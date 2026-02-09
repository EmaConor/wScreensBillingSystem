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
        string res = "";
        if (txtUser.Text != "" && txtPassword.Text != string.Empty)
        {
            if (txtUser.Text == "admin" && txtPassword.Text == "123456")
                res = "Admin";

            if (res != "")
            {
                MessageBox.Show("Login correcto: " + res);
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

}