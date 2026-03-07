using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;
using System.Data;
using wScreensBillingSystem.Data;
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

    BillingDB db = new();

    private void LoadComboBox()
    {
        DataTable dt = new();
        dt = db.LoadTable("TBLCATEGORIA_PROD", "");

        cmbCategory.DataSource = dt;
        cmbCategory.DisplayMember = "StrDescripcion";
        cmbCategory.ValueMember = "IdCategoria";
        cmbCategory.SelectedValue = -1;
    }

    private void LoadData(string filter = "")
    {
        dgvProducts.Rows.Clear();

        string cmd = $"SELECT p.[IdProducto], p.[StrNombre], p.[StrCodigo], p.[NumPrecioCompra], p.[NumPrecioVenta],  p.[NumStock], p.[IdCategoria], c.StrDescripcion, p.[StrDetalle] FROM [TBLPRODUCTO] p INNER JOIN TBLCATEGORIA_PROD c ON p.[IdCategoria] = c.IdCategoria";
        if (!string.IsNullOrWhiteSpace(filter))
        {
            cmd += $" WHERE p.[StrNombre] like '%{filter}%'";
        }

        DataTable dt = db.RunCommandData(cmd);
        foreach (DataRow row in dt.Rows)
        {
            dgvProducts.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
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

    private Boolean Validate(string name, string code, string supplierPrice, string salePrice, string stock, object idCategory)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            MessageBox.Show("El nombre es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtName.Focus();
            return false;
        }
        if (string.IsNullOrWhiteSpace(code))
        {
            MessageBox.Show("El codigo es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCode.Focus();
            return false;
        }
        if (string.IsNullOrWhiteSpace(supplierPrice))
        {
            MessageBox.Show("El precio compra es obligatoria", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSupplierPrice.Focus();
            return false;
        }
        if (!isNumeric(supplierPrice))
        {
            MessageBox.Show("El precio compra debe ser numerico");
            txtSupplierPrice.Focus();
            return false;
        }
        if (string.IsNullOrWhiteSpace(salePrice))
        {
            MessageBox.Show("El precio venta es obligatoria", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSalePrice.Focus();
            return false;
        }
        if (!isNumeric(salePrice))
        {
            MessageBox.Show("El precio venta debe ser numerico");
            txtSalePrice.Focus();
            return false;
        }
        if (string.IsNullOrWhiteSpace(stock))
        {
            MessageBox.Show("La cantidad es obligatoria", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtStock.Focus();
            return false;
        }
        if (!isNumeric(stock))
        {
            MessageBox.Show("La cantidad debe ser numerico");
            txtStock.Focus();
            return false;
        }
        if (idCategory == null || Convert.ToInt32(idCategory) <= 0)
        {
            MessageBox.Show("Debe seleccionar una categoria", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cmbCategory.Focus();
            return false;
        }
        return true;
    }

    private bool isNumeric(string num)
    {
        return double.TryParse(num, out _);
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        try
        {
            if (Validate(txtName.Text, txtCode.Text, txtSupplierPrice.Text, txtSalePrice.Text, txtStock.Text, cmbCategory.SelectedValue))
            {
                string name = txtName.Text.Replace("'", "''");
                string code = txtCode.Text.Replace("'", "''");
                string supplierPrice = txtSupplierPrice.Text.Replace("'", "''");
                string salePrice = txtSalePrice.Text.Replace("'", "''");
                string stock = txtStock.Text.Replace("'", "''");
                string additionalData = txtInfo.Text.Replace("'", "''");

                string sentencia = $@"INSERT INTO TBLPRODUCTO 
                        (StrNombre, StrCodigo, NumPrecioCompra, NumPrecioVenta, NumStock, IdCategoria, StrDetalle, [DtmFechaModifica], [StrUsuarioModifica]) 
                        VALUES 
                        ('{name}', '{code}', {supplierPrice}, {salePrice}, {stock}, 
                         {cmbCategory.SelectedValue}, '{additionalData}', GETDATE(), 'Javier')";

                string resultado = db.RunCommand(sentencia);
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
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

            if (Validate(txtName.Text, txtCode.Text, txtSupplierPrice.Text, txtSalePrice.Text, txtStock.Text, cmbCategory.SelectedValue))
            {
                string name = txtName.Text.Replace("'", "''");
                string code = txtCode.Text.Replace("'", "''");
                decimal supplierPrice = Convert.ToDecimal(txtSupplierPrice.Text);
                decimal salePrice = Convert.ToDecimal(txtSalePrice.Text);
                int stock = Convert.ToInt32(txtStock.Text);
                int idCategory = Convert.ToInt32(cmbCategory.SelectedValue);
                string additionalData = txtInfo.Text.Replace("'", "''");

                string sentencia = $@"UPDATE TBLPRODUCTO SET 
                        StrNombre = '{name}',
                        StrCodigo = '{code}',
                        NumPrecioCompra = {supplierPrice},
                        NumPrecioVenta = {salePrice},
                        NumStock = {stock},
                        IdCategoria = {idCategory},
                        StrDetalle = '{additionalData}',
                        DtmFechaModifica = GETDATE(),
                        StrUsuarioModifica = 'Javier'
                        WHERE IdProducto = {txtId.Text}";

                string resultado = db.RunCommand(sentencia);
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string sentencia = $"DELETE FROM TBLPRODUCTO WHERE IdProducto = {txtId.Text}";
                string resultado = db.RunCommand(sentencia);
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}