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
        frmChild.Location = Point.Empty;
        this.pnlContainer.Controls.Add(frmChild);
        frmChild.Show();
        frmChild.BringToFront();
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

    private void btnProducts_Click(object sender, EventArgs e)
    {
        FrmProducts frmProducts = new FrmProducts();
        OpenForm(frmProducts);
    }

    private void btnEmployees_Click(object sender, EventArgs e)
    {
        FrmEmployees frmEmployees = new FrmEmployees();
        OpenForm(frmEmployees);
    }

    private void btnSecurity_Click(object sender, EventArgs e)
    {
        FrmSecurity frmSecurity = new FrmSecurity();
        OpenForm(frmSecurity);
    }

    private void btnCategories_Click(object sender, EventArgs e)
    {
        FrmCategories frmCategories = new FrmCategories();
        OpenForm(frmCategories);
    }

    private void btnInvoices_Click(object sender, EventArgs e)
    {
        FrmInvoices frmInvoices = new FrmInvoices();
        OpenForm(frmInvoices);
    }

    private void btnReports_Click(object sender, EventArgs e)
    {
        FrmReport frmReport = new FrmReport();
        OpenForm(frmReport);
    }

    private void btnRols_Click(object sender, EventArgs e)
    {
        FrmRols frmRols = new FrmRols();
        OpenForm(frmRols);
    }

    private void btnHelp_Click(object sender, EventArgs e)
    {
        FrmHelp frmHelp = new FrmHelp();
        OpenForm(frmHelp);
    }

    private void btnAbout_Click(object sender, EventArgs e)
    {
        FrmAbout frmAbout = new FrmAbout();
        OpenForm(frmAbout);
    }
}