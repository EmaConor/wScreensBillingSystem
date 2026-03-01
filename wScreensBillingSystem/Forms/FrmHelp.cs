using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace wScreensBillingSystem
{
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
            InitializeComponent();
            btnOut.BringToFront();
            InitializeAsync();
        }

        async void InitializeAsync()
        {
            // Espera a que el motor Chromium esté listo
            await webView21.EnsureCoreWebView2Async(null);
            // Una vez listo, navegamos a la URL
            webView21.CoreWebView2.Navigate("https://www.emaconor.site/");
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
