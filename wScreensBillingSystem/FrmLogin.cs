using wBusinessLogicLayer;
using wScreensBillingSystem;

namespace wScreensBillingSystem;

public partial class FrmLogin : Form
{
    public FrmLogin()
    {
        InitializeComponent();
    }
    
    private void btnCancel_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnVerify_Click(object sender, EventArgs e)
    {
        ValidateUser ObjValidate = new();

        string user = txtUser.Text.Trim();
        string pass = txtPassword.Text.Trim();
        if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
        {
            MessageBox.Show("Ingrese el nombre de usuario y clave");
            if (string.IsNullOrEmpty(user))
            {
                txtUser.Focus();
            }
            else
            {
                txtPassword.Focus();
            }
            return;
        }

        ObjValidate.Username = user;
        ObjValidate.Password = pass;

        ObjValidate.Validate();

        if (ObjValidate.Id != 0)
        {
            MessageBox.Show("Datos Validos");
            FrmMain frm = new();
            frm.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Usuario y/o clave no encontrado");
            txtUser.Focus();
        }
    }

}