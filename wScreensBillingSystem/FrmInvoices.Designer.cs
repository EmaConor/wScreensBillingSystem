using System.ComponentModel;

namespace wScreensBillingSystem
{
    partial class FrmInvoices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new MaterialSkin.Controls.MaterialLabel();
            pnlSearch = new Panel();
            dataGridView1 = new DataGridView();
            btnSearch = new MaterialSkin.Controls.MaterialButton();
            txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            btnNew = new MaterialSkin.Controls.MaterialButton();
            btnOut = new MaterialSkin.Controls.MaterialButton();
            pnlSearch.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Depth = 0;
            lblTitle.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblTitle.Location = new Point(53, 9);
            lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(700, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Facturaciones";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(dataGridView1);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(btnNew);
            pnlSearch.Location = new Point(-8, 35);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(735, 482);
            pnlSearch.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(706, 400);
            dataGridView1.TabIndex = 5;
            dataGridView1.Text = "dataGridView1";
            // 
            // btnSearch
            // 
            btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSearch.Depth = 0;
            btnSearch.HighEmphasis = true;
            btnSearch.Icon = null;
            btnSearch.Location = new Point(460, 22);
            btnSearch.Margin = new Padding(4, 6, 4, 6);
            btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnSearch.Name = "btnSearch";
            btnSearch.NoAccentTextColor = Color.Empty;
            btnSearch.Size = new Size(77, 36);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Buscar";
            btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSearch.UseAccentColor = false;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.AnimateReadOnly = false;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Depth = 0;
            txtSearch.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearch.Hint = "Buscar Factura";
            txtSearch.LeadingIcon = null;
            txtSearch.Location = new Point(24, 14);
            txtSearch.MaxLength = 32767;
            txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(429, 50);
            txtSearch.TabIndex = 8;
            txtSearch.Text = "";
            txtSearch.TrailingIcon = null;
            // 
            // btnNew
            // 
            btnNew.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNew.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNew.Depth = 0;
            btnNew.HighEmphasis = true;
            btnNew.Icon = null;
            btnNew.Location = new Point(649, 22);
            btnNew.Margin = new Padding(4, 6, 4, 6);
            btnNew.MouseState = MaterialSkin.MouseState.HOVER;
            btnNew.Name = "btnNew";
            btnNew.NoAccentTextColor = Color.Empty;
            btnNew.Size = new Size(70, 36);
            btnNew.TabIndex = 5;
            btnNew.Text = "Nuevo";
            btnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNew.UseAccentColor = false;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnOut
            // 
            btnOut.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnOut.Depth = 0;
            btnOut.HighEmphasis = true;
            btnOut.Icon = null;
            btnOut.Location = new Point(734, 466);
            btnOut.Margin = new Padding(4, 6, 4, 6);
            btnOut.MouseState = MaterialSkin.MouseState.HOVER;
            btnOut.Name = "btnOut";
            btnOut.NoAccentTextColor = Color.Empty;
            btnOut.Size = new Size(64, 36);
            btnOut.TabIndex = 10;
            btnOut.Text = "Salir";
            btnOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnOut.UseAccentColor = false;
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // FrmInvoices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 517);
            ControlBox = false;
            Controls.Add(btnOut);
            Controls.Add(pnlSearch);
            Controls.Add(lblTitle);
            Name = "FrmInvoices";
            ShowInTaskbar = false;
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private MaterialSkin.Controls.MaterialButton btnOut;

        private System.Windows.Forms.DataGridView dataGridView1;

        private MaterialSkin.Controls.MaterialButton btnSearch;

        private MaterialSkin.Controls.MaterialButton btnNew;

        private System.Windows.Forms.Panel pnlSearch;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;

        private MaterialSkin.Controls.MaterialTextBox txtCustomer;
        private MaterialSkin.Controls.MaterialTextBox txtDoc;
        private MaterialSkin.Controls.MaterialTextBox txtAddress;
        private MaterialSkin.Controls.MaterialTextBox txtPhone;

        private MaterialSkin.Controls.MaterialLabel lblTitle;

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cmbRol;
        private DateTimePicker dtpOffboarding;
        private Label lblOffboarding;
    }
}