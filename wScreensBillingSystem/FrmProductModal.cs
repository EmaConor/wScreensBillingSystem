using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wBusinessLogicLayer;

namespace wScreensBillingSystem
{
    public partial class FrmProductModal : MaterialForm
    {
        public FrmProductModal()
        {
            InitializeComponent();

            LoadComboBox();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ProductId { get; set; }
        private readonly Product product = new();

        private void LoadComboBox()
        {
            cmbCategory.DataSource = product.LoadCategory();
            cmbCategory.DisplayMember = "StrDescripcion";
            cmbCategory.ValueMember = "IdCategoria";
            cmbCategory.SelectedValue = -1;
        }

        private void FrmProductModal_Load(object sender, EventArgs e)
        {
            if (ProductId == 0)
            {
                Clear();
            }
            else
            {
                LoadCustomerData();
            }
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

            ToggleButtons(false);
            txtName.Focus();
        }

        private void ToggleButtons(bool isEdit)
        {
            btnNew.Visible = !isEdit;
            btnNew.DrawShadows = !isEdit;
            btnUpdate.Visible = isEdit;
            btnUpdate.DrawShadows = isEdit;
        }

        private void LoadCustomerData()
        {
            try
            {
                DataTable dt = product.LoadProductById(ProductId);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    lblTitle.Text = $"Modificar producto {row["StrNombre"].ToString()}";
                    txtId.Text = row["IdProducto"].ToString();
                    txtName.Text = row["StrNombre"].ToString();
                    txtCode.Text = row["StrCodigo"].ToString();
                    txtSupplierPrice.Text = row["NumPrecioCompra"].ToString();
                    txtSalePrice.Text = row["NumPrecioVenta"].ToString();
                    txtStock.Text = row["NumStock"].ToString();
                    cmbCategory.SelectedValue = row["IdCategoria"];
                    txtInfo.Text = row["StrDetalle"].ToString();

                    ToggleButtons(true);
                }
                else
                {
                    MessageBox.Show("Producto no encontrado", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        this.DialogResult = DialogResult.OK;
                        this.Close();
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

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                Clear();
            }
            else
            {
                LoadCustomerData();
            }
        }
    }
}
