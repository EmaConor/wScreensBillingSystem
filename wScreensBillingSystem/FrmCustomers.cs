using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;
using System.Data;
using System.Xml.Linq;
using wBusinessLogicLayer;
using wScreensBillingSystem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace wScreensBillingSystem;

public partial class FrmCustomers : Form
{
    public FrmCustomers()
    {
        InitializeComponent();

        LoadData();
    }

    DataTable dt = new();
    private readonly Customer customer = new();

    private void LoadData(string filter = "")
    {
        dgvCustomers.Rows.Clear();
        try
        {
            dt = customer.LoadTable(filter);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgvCustomers.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
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
        FrmCustomerModal frm = new()
        {
            CustomerId = 0
        };
        if (frm.ShowDialog() == DialogResult.OK)
        {
            LoadData();
        }
    }

    private void btnOut_Click(object sender, EventArgs e)
    {
        this.Close();
    }


    private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        int row = e.RowIndex;
        string columnName = dgvCustomers.Columns[e.ColumnIndex].Name;

        if (columnName == "delete")
        {
            var result = MessageBox.Show("¿Está seguro de eliminar este Cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    customer.Id = Convert.ToInt32(dgvCustomers[0, row].Value.ToString());
                    string message = customer.Delete();
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
            int customerId = Convert.ToInt32(dgvCustomers[0, row].Value);

            using FrmCustomerModal frm = new();
            frm.CustomerId = customerId;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}