using MaterialSkin;
using MaterialSkin.Controls;

namespace wScreensBillingSystem;

public partial class FrmMain : MaterialForm
{
    public FrmMain()
    {
        InitializeComponent();
        
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // O DARK

        // Aquí definimos el color Rosa
        materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Pink200,    // Color del Header (Barra de título)
            Primary.Pink300,    // Color del Header oscuro (Barra de estado superior)
            Primary.Pink100,    // Color de acento claro
            Accent.Pink200,     // Color de acento (botones, etc.)
            TextShade.WHITE     // Color del texto sobre el rosa (blanco queda mejor)
        );
    }
    
    
    private void OpenForm(Form frmChild)
    {
        if (this.pnlContainer.Controls.Count > 0)
            this.pnlContainer.Controls.RemoveAt(0);
        
        frmChild.TopLevel = false;
        frmChild.FormBorderStyle = FormBorderStyle.None;
        frmChild.Dock = DockStyle.Fill;
        this.pnlContainer.Controls.Add(frmChild);
        frmChild.Show();
    }

    private void btnOut_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnCustomers_Click(object sender, EventArgs e)
    {
        FrmCustomers frmCustomer = new FrmCustomers();
        OpenForm(frmCustomer);
    }
}