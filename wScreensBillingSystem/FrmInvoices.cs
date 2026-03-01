
namespace wScreensBillingSystem
{
    public partial class FrmInvoices : Form
    {
        public FrmInvoices()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmInvoiceModal  frmInvoice = new FrmInvoiceModal();
            frmInvoice.ShowDialog();
        }
    }
}
