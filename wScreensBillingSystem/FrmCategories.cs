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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();

            LoadData();
        }

        DataTable dt = new();
        Category category = new();

        private void LoadData(string filter = "")
        {
            dgvCategories.Rows.Clear();
            dt = category.LoadTable(filter);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgvCategories.Rows.Add(row[0], row[1]);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron categorias", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtDescription.Clear();
            txtSearch.Clear();

            LoadData();
            ToggleButtons(false);
            txtDescription.Focus();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvCategories.Rows[e.RowIndex];

            txtId.Text = row.Cells["id"].Value?.ToString();
            txtDescription.Text = row.Cells["description"].Value?.ToString();

            ToggleButtons(true);
        }

        private void dgvCategories_MouseDown(object sender, MouseEventArgs e)
        {
            // Si hace clic fuera de la tabla, limpia el formulario
            var hit = dgvCategories.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                Clear();
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
                        Clear();
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
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la Categoria: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            LoadData(search);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Debe seleccionar una categoria para eliminar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("¿Está seguro de eliminar esta categoria?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    category.Id = Convert.ToInt32(txtId.Text);

                    string message = category.Delete();
                    MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la categoria: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
