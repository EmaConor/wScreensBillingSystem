using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;
using System.Data;
using wScreensBillingSystem.Data;
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
    BillingDB db = new();

    private void LoadData(string filter = "")
    {
        dgvCustomers.Rows.Clear();

        string cmd = $"SELECT IdCliente, StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail FROM TBLCLIENTES";
        if (!string.IsNullOrWhiteSpace(filter))
        {
            cmd += $" WHERE StrNombre like '%{filter}%'";
        }

        dt = db.RunCommandData(cmd);
        foreach (DataRow row in dt.Rows)
        {
            dgvCustomers.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
        }
    }

    private void ToggleButtons(bool isEdit)
    {
        btnNew.Visible = !isEdit;
        btnNew.DrawShadows = !isEdit;
        btnUpdate.Visible = isEdit;
        btnUpdate.DrawShadows = isEdit;
    }

    public void Clear()
    {
        txtId.Clear();
        txtName.Clear();
        txtDoc.Clear();
        txtAddress.Clear();
        txtPhone.Clear();
        txtEmail.Clear();
        txtSearch.Clear();

        LoadData();

        ToggleButtons(false);

        txtName.Focus();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        string search = txtSearch.Text;
        LoadData(search);
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar un cliente de la tabla para actualizar");
                return;
            }

            int id = Convert.ToInt32(txtId.Text);
            string name = txtName.Text;
            string document = txtDoc.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;


            if (Validate(name, document, address, phone, email))
            {
                try
                {
                    string sentencia = $"Exec [actualizar_Cliente] {id},'{name}',{document} ,'{address}','{phone}', '{email}', 'Javier','{DateTime.Now:d}'";
                    MessageBox.Show(db.RunCommand(sentencia));
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar en la base de datos");
                }
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al actualizar el cliente" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        try
        {
            string name = txtName.Text;
            string document = txtDoc.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;

            if (Validate(name, document, address, phone, email))
            {
                try
                {
                    string sentencia = $@"INSERT INTO TBLCLIENTES (StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail, DtmFechaModifica, StrUsuarioModifica) VALUES  ('{name}', {document}, '{address}', '{phone}', '{email}', GETDATE(), 'Javier')";
                    MessageBox.Show(db.RunCommand(sentencia));
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar en la base de datos");
                }
            }
        }
        catch (Exception ex) 
        {
            MessageBox.Show("Error al crear el cliente: " + ex.Message, "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnOut_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var row = dgvCustomers.Rows[e.RowIndex];
        txtId.Text = row.Cells["id"].Value?.ToString();
        txtName.Text = row.Cells["nameCustomer"].Value?.ToString();
        txtDoc.Text = row.Cells["document"].Value?.ToString();
        txtAddress.Text = row.Cells["address"].Value?.ToString();
        txtPhone.Text = row.Cells["phone"].Value?.ToString();
        txtEmail.Text = row.Cells["email"].Value?.ToString();

        ToggleButtons(true);
    }

    private void dgvCustomers_MouseDown(object sender, MouseEventArgs e)
    {
        // Si le da fuera de la tabla limpia
        var hit = dgvCustomers.HitTest(e.X, e.Y);
        if (hit.Type == DataGridViewHitTestType.None)
        {
            Clear();
        }
    }

    private Boolean Validate(string name, string document, string address, string phone, string email)
    {
        Boolean fieldError = true;
        if (string.IsNullOrWhiteSpace(name))
        {
            MessageBox.Show("El nombre es obligatorio");
            txtName.Focus();
            fieldError = false;
        }
        if (string.IsNullOrWhiteSpace(document))
        {
            MessageBox.Show("El documento es obligatorio");
            txtDoc.Focus();
            fieldError = false;
        }
        if (!isNumeric(document))
        {
            MessageBox.Show("El Documento debe ser numerico");
            txtDoc.Focus();
            return false;
        }
        if (string.IsNullOrWhiteSpace(address))
        {
            MessageBox.Show("La direccion es obligatoria");
            txtAddress.Focus();
            fieldError = false;
        }
        if (string.IsNullOrWhiteSpace(phone))
        {
            MessageBox.Show("El telefono es obligatorio");
            txtPhone.Focus();
            fieldError = false;
        }
        if (string.IsNullOrWhiteSpace(email))
        {
            MessageBox.Show("El email es obligatorio");
            txtEmail.Focus();
            fieldError = false;
        }
        return fieldError;
    }

    private bool isNumeric(string num)
    {
        try
        {
            double x = Convert.ToDouble(num);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}