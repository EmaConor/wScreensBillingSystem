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
        private readonly Category category = new();

        private void LoadData(string filter = "")
        {
            dgvCategories.Rows.Clear();
            try
            {
                dt = category.LoadTable(filter);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvCategories.Rows.Add(row[0], row[1]);
                    }
                }
                else if (string.IsNullOrEmpty(filter))
                {
                    MessageBox.Show("No se encontraron categorias", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSearch.Clear();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void Clear()
        {
            txtSearch.Clear();
            LoadData();
            txtSearch.Focus();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            LoadData(search);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmCategoryModal frm = new()
            {
                CategoryId = 0
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int row = e.RowIndex;
            string columnName = dgvCategories.Columns[e.ColumnIndex].Name;

            if (columnName == "delete")
            {
                var result = MessageBox.Show("¿Está seguro de eliminar esta categoria?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        category.Id = Convert.ToInt32(dgvCategories[0, row].Value);
                        string message = category.Delete();
                        MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (columnName == "edit")
            {
                int categoryId = Convert.ToInt32(dgvCategories[0, row].Value);

                using FrmCategoryModal frm = new();
                frm.CategoryId = categoryId;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
    }
}
