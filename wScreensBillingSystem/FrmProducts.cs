using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System.Collections;
using System.Data;
using System.Globalization;
using wBusinessLogicLayer;
using wScreensBillingSystem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace wScreensBillingSystem;

public partial class FrmProducts : Form
{
    public FrmProducts()
    {
        InitializeComponent();

        LoadComboBox();
        LoadData();
    }

    DataTable dt = new();
    private readonly Product product = new();

    private void LoadComboBox()
    {
        cmbCategory.DataSource = product.LoadCategory();
        cmbCategory.DisplayMember = "StrDescripcion";
        cmbCategory.ValueMember = "IdCategoria";
        cmbCategory.SelectedValue = -1;
    }

    private void LoadData(string filter = "")
    {
        dgvProducts.Rows.Clear();
        dt = product.LoadTable(filter);

        if (dt.Rows.Count > 0)
        {
            foreach (DataRow row in dt.Rows)
            {
                dgvProducts.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
            }
        }
        else
        {
            MessageBox.Show("No se encontraron productos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtSearch.Clear(); 
            LoadData();
        }
    }

    private void ToggleButtons(bool isEdit)
    {
        btnNew.Visible = !isEdit;
        btnNew.DrawShadows = !isEdit;
        btnUpdate.Visible = isEdit;
        btnUpdate.DrawShadows = isEdit;
        btnDelete.Visible = isEdit;
        btnDelete.DrawShadows = isEdit;
    }

    public void Clear()
    {
        txtId.Clear();
        txtName.Clear();
        txtCode.Clear();
        txtSupplierPrice.Clear();
        txtSalePrice.Clear();
        txtStock.Clear();
        cmbCategory.SelectedValue = -1;
        txtInfo.Clear();
        txtSearch.Clear();

        LoadData();
        ToggleButtons(false);
        txtName.Focus();
    }

    private void btnOut_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var row = dgvProducts.Rows[e.RowIndex];

        txtId.Text = row.Cells["id"].Value?.ToString();
        txtName.Text = row.Cells["nameProduct"].Value?.ToString();
        txtCode.Text = row.Cells["code"].Value?.ToString();
        txtSupplierPrice.Text = row.Cells["supplierPrice"].Value?.ToString();
        txtSalePrice.Text = row.Cells["salePrice"].Value?.ToString();
        txtStock.Text = row.Cells["stock"].Value?.ToString();
        if (row.Cells["idCategory"].Value != null)
        {
            int idCategory = Convert.ToInt32(row.Cells["idCategory"].Value);
            cmbCategory.SelectedValue = idCategory;
        }
        txtInfo.Text = row.Cells["info"].Value?.ToString();

        ToggleButtons(true);
    }

    private void dgvProducts_MouseDown(object sender, MouseEventArgs e)
    {
        // Si hace clic fuera de la tabla, limpia el formulario
        var hit = dgvProducts.HitTest(e.X, e.Y);
        if (hit.Type == DataGridViewHitTestType.None)
        {
            Clear();
        }
    }

    private Boolean Validate()
    {
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            MessageBox.Show("El nombre es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtName.Focus();
            return false;
        }
        if (string.IsNullOrWhiteSpace(txtCode.Text))
        {
            MessageBox.Show("El codigo es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCode.Focus();
            return false;
        }
        if (!decimal.TryParse(txtSupplierPrice.Text, out _))
        {
            MessageBox.Show("El precio de compra debe ser un número válido");
            txtSupplierPrice.Focus();
            return false;
        }
        if (!decimal.TryParse(txtSalePrice.Text, out _))
        {
            MessageBox.Show("El precio de venta debe ser un número válido");
            txtSalePrice.Focus();
            return false;
        }
        if (!int.TryParse(txtStock.Text, out _))
        {
            MessageBox.Show("El stock debe ser un número entero");
            txtStock.Focus();
            return false;
        }
        if (cmbCategory.SelectedValue == null || Convert.ToInt32(cmbCategory.SelectedValue) <= 0)
        {
            MessageBox.Show("Debe seleccionar una categoria", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cmbCategory.Focus();
            return false;
        }
        return true;
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        try
        {
            if (Validate())
            {
                Product newProduct = new()
                {
                    Name = txtName.Text.Trim(),
                    Code = txtCode.Text.Trim(),
                    SupplierPrice = Convert.ToDecimal(txtSupplierPrice.Text.Replace(",", ".")),
                    SalePrice = Convert.ToDecimal(txtSalePrice.Text.Replace(",", ".")),
                    Stock = Convert.ToInt32(txtStock.Text),
                    CategoryId = Convert.ToInt32(cmbCategory.SelectedValue),
                    Description = txtInfo.Text.Trim(),
                    WhoModified = "Ema"
                };

                string message = newProduct.Update();
                MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (!message.Contains("ERROR"))
                {
                    Clear();
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al crear el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar un producto para actualizar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Validate())
            {
                product.Id = Convert.ToInt32(txtId.Text);
                product.Name = txtName.Text.Trim();
                product.Code = txtCode.Text.Trim();
                product.SupplierPrice = Convert.ToDecimal(txtSupplierPrice.Text.Replace(",", "."));
                product.SalePrice = Convert.ToDecimal(txtSalePrice.Text.Replace(",", "."));
                product.Stock = Convert.ToInt32(txtStock.Text);
                product.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                product.Description = txtInfo.Text.Trim();
                product.WhoModified = "Ema";

                string message = product.Update();
                MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        string search = txtSearch.Text;
        LoadData(search);
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        Clear();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar un producto para eliminar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                product.Id = Convert.ToInt32(txtId.Text);

                string message = product.Delete();
                MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}