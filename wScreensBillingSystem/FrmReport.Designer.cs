namespace wScreensBillingSystem
{
    partial class FrmReport
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
            pnlCustomer = new Panel();
            cmbInvoice = new MaterialSkin.Controls.MaterialComboBox();
            btnConsult = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnOut = new MaterialSkin.Controls.MaterialButton();
            rdoScreen = new MaterialSkin.Controls.MaterialRadioButton();
            rdoPdf = new MaterialSkin.Controls.MaterialRadioButton();
            rdoExcel = new MaterialSkin.Controls.MaterialRadioButton();
            pnlCustomer.SuspendLayout();
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
            lblTitle.Text = "Generador de Informes Facturas";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlCustomer
            // 
            pnlCustomer.Controls.Add(rdoExcel);
            pnlCustomer.Controls.Add(rdoPdf);
            pnlCustomer.Controls.Add(rdoScreen);
            pnlCustomer.Controls.Add(cmbInvoice);
            pnlCustomer.Location = new Point(101, 147);
            pnlCustomer.Name = "pnlCustomer";
            pnlCustomer.Size = new Size(495, 225);
            pnlCustomer.TabIndex = 1;
            // 
            // cmbInvoice
            // 
            cmbInvoice.AutoResize = false;
            cmbInvoice.BackColor = Color.FromArgb(255, 255, 255);
            cmbInvoice.Depth = 0;
            cmbInvoice.DrawMode = DrawMode.OwnerDrawVariable;
            cmbInvoice.DropDownHeight = 118;
            cmbInvoice.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInvoice.DropDownWidth = 121;
            cmbInvoice.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbInvoice.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbInvoice.FormattingEnabled = true;
            cmbInvoice.Hint = "Factura";
            cmbInvoice.IntegralHeight = false;
            cmbInvoice.ItemHeight = 29;
            cmbInvoice.Location = new Point(41, 37);
            cmbInvoice.MaxDropDownItems = 4;
            cmbInvoice.MouseState = MaterialSkin.MouseState.OUT;
            cmbInvoice.Name = "cmbInvoice";
            cmbInvoice.Size = new Size(422, 35);
            cmbInvoice.StartIndex = 0;
            cmbInvoice.TabIndex = 0;
            cmbInvoice.UseTallSize = false;
            // 
            // btnConsult
            // 
            btnConsult.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConsult.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConsult.Depth = 0;
            btnConsult.HighEmphasis = true;
            btnConsult.Icon = null;
            btnConsult.Location = new Point(615, 199);
            btnConsult.Margin = new Padding(4, 6, 4, 6);
            btnConsult.MouseState = MaterialSkin.MouseState.HOVER;
            btnConsult.Name = "btnConsult";
            btnConsult.NoAccentTextColor = Color.Empty;
            btnConsult.Size = new Size(106, 36);
            btnConsult.TabIndex = 5;
            btnConsult.Text = "Consultar";
            btnConsult.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConsult.UseAccentColor = false;
            btnConsult.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(615, 241);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(109, 36);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Actualizar";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(615, 283);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(88, 36);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Eliminar";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
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
            // rdoScreen
            // 
            rdoScreen.AutoSize = true;
            rdoScreen.Depth = 0;
            rdoScreen.Location = new Point(74, 146);
            rdoScreen.Margin = new Padding(0);
            rdoScreen.MouseLocation = new Point(-1, -1);
            rdoScreen.MouseState = MaterialSkin.MouseState.HOVER;
            rdoScreen.Name = "rdoScreen";
            rdoScreen.Ripple = true;
            rdoScreen.Size = new Size(116, 37);
            rdoScreen.TabIndex = 1;
            rdoScreen.TabStop = true;
            rdoScreen.Text = "En Pantalla";
            rdoScreen.UseVisualStyleBackColor = true;
            // 
            // rdoPdf
            // 
            rdoPdf.AutoSize = true;
            rdoPdf.Depth = 0;
            rdoPdf.Location = new Point(220, 146);
            rdoPdf.Margin = new Padding(0);
            rdoPdf.MouseLocation = new Point(-1, -1);
            rdoPdf.MouseState = MaterialSkin.MouseState.HOVER;
            rdoPdf.Name = "rdoPdf";
            rdoPdf.Ripple = true;
            rdoPdf.Size = new Size(60, 37);
            rdoPdf.TabIndex = 2;
            rdoPdf.TabStop = true;
            rdoPdf.Text = "Pdf";
            rdoPdf.UseVisualStyleBackColor = true;
            // 
            // rdoExcel
            // 
            rdoExcel.AutoSize = true;
            rdoExcel.Depth = 0;
            rdoExcel.Location = new Point(333, 146);
            rdoExcel.Margin = new Padding(0);
            rdoExcel.MouseLocation = new Point(-1, -1);
            rdoExcel.MouseState = MaterialSkin.MouseState.HOVER;
            rdoExcel.Name = "rdoExcel";
            rdoExcel.Ripple = true;
            rdoExcel.Size = new Size(72, 37);
            rdoExcel.TabIndex = 3;
            rdoExcel.TabStop = true;
            rdoExcel.Text = "Excel";
            rdoExcel.UseVisualStyleBackColor = true;
            // 
            // FrmReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 517);
            ControlBox = false;
            Controls.Add(btnOut);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnConsult);
            Controls.Add(lblTitle);
            Controls.Add(pnlCustomer);
            Name = "FrmReport";
            ShowInTaskbar = false;
            pnlCustomer.ResumeLayout(false);
            pnlCustomer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MaterialSkin.Controls.MaterialButton btnOut;

        private MaterialSkin.Controls.MaterialButton btnDelete;

        private MaterialSkin.Controls.MaterialButton btnConsult;
        private MaterialSkin.Controls.MaterialButton btnUpdate;

        private System.Windows.Forms.Panel pnlCustomer;

        private MaterialSkin.Controls.MaterialLabel lblTitle;

        #endregion
        private MaterialSkin.Controls.MaterialComboBox cmbInvoice;
        private MaterialSkin.Controls.MaterialRadioButton rdoExcel;
        private MaterialSkin.Controls.MaterialRadioButton rdoPdf;
        private MaterialSkin.Controls.MaterialRadioButton rdoScreen;
    }
}