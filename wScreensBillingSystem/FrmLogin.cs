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

        if (user.Equals("admin") && pass.Equals("admin"))
        {
            this.DialogResult = DialogResult.OK;
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.Show();
        }
        else
        {
            MessageBox.Show("Usuario y clave no encontrado");
            txtUser.Focus();
        }
    }

}