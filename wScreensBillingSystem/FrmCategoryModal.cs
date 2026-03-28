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
using System.Xml.Linq;
using wBusinessLogicLayer;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace wScreensBillingSystem
{
    public partial class FrmCategoryModal : MaterialForm
    {
        public FrmCategoryModal()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CategoryId { get; set; }
        private readonly Category category = new();

        private void FrmCategoryModal_Load(object sender, EventArgs e)
        {
            if (CategoryId == 0)
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
            txtDescription.Clear();

            ToggleButtons(false);
            txtDescription.Focus();
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
                DataTable dt = category.LoadCategoryById(CategoryId);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    lblTitle.Text = $"Modificar Categoria {row["StrDescripcion"].ToString()}";
                    txtId.Text = row["IdCategoria"].ToString();
                    txtDescription.Text = row["StrDescripcion"].ToString();

                    ToggleButtons(true);
                }
                else
                {
                    MessageBox.Show("Categoria no encontrada", "Error",
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
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("El nombre es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescription.Focus();
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
                    Category newCategory = new()
                    {
                        Description = txtDescription.Text.Trim(),
                        WhoModified = "Ema"
                    };

                    string message = newCategory.Update();
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
                MessageBox.Show("Error al crear la Categoria: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Debe seleccionar una categoria para actualizar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Validate())
                {
                    category.Id = Convert.ToInt32(txtId.Text);
                    category.Description = txtDescription.Text.Trim();
                    category.WhoModified = "Ema";

                    string message = category.Update();
                    MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la Categoria: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
