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

        LoadData();
    }

    DataTable dt = new();
    private readonly Product product = new();

    private void LoadData(string filter = "")
    {
        dgvProducts.Rows.Clear();
        try
        {
            dt = product.LoadTable(filter);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgvProducts.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
                }
            }
            else if (string.IsNullOrEmpty(filter))
            {
                MessageBox.Show("No hay clientes registrados", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    private void btnSearch_Click(object sender, EventArgs e)
    {
        string search = txtSearch.Text;
        LoadData(search);
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        Clear();
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        FrmProductModal frm = new()
        {
            ProductId = 0
        };
        if (frm.ShowDialog() == DialogResult.OK)
        {
            LoadData();
        }
    }

    private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        int row = e.RowIndex;
        string columnName = dgvProducts.Columns[e.ColumnIndex].Name;

        if (columnName == "delete")
        {
            var result = MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    product.Id = Convert.ToInt32(dgvProducts[0, row].Value);
                    string message = product.Delete();
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
            int productId = Convert.ToInt32(dgvProducts[0, row].Value);

            using FrmProductModal frm = new();
            frm.ProductId = productId;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}