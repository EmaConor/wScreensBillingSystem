using wScreensBillingSystem.Data;

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
        string user = txtUser.Text.Trim();
        string pass = txtPassword.Text.Trim();
        if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
        {
            MessageBox.Show("Ingrese el nombre de usuario y clave");
            return;
        }

        BillingDB db = new();
        string res = db.ValidateUser(user, pass);
        if (res != "")
        {
            MessageBox.Show("Bienvenid@: " +  res);
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