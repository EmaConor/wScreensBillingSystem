namespace wScreensBillingSystem
{
    partial class FrmCustomerModal
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
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnNew = new MaterialSkin.Controls.MaterialButton();
            lblTitle = new MaterialSkin.Controls.MaterialLabel();
            pnlCustomer = new Panel();
            txtId = new TextBox();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            txtPhone = new MaterialSkin.Controls.MaterialTextBox();
            txtAddress = new MaterialSkin.Controls.MaterialTextBox();
            txtDoc = new MaterialSkin.Controls.MaterialTextBox();
            txtName = new MaterialSkin.Controls.MaterialTextBox();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            pnlCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.DrawShadows = false;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(570, 239);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(109, 36);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Actualizar";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Visible = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNew.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNew.Depth = 0;
            btnNew.HighEmphasis = true;
            btnNew.Icon = null;
            btnNew.Location = new Point(570, 240);
            btnNew.Margin = new Padding(4, 6, 4, 6);
            btnNew.MouseState = MaterialSkin.MouseState.HOVER;
            btnNew.Name = "btnNew";
            btnNew.NoAccentTextColor = Color.Empty;
            btnNew.Size = new Size(88, 36);
            btnNew.TabIndex = 9;
            btnNew.Text = "Guardar";
            btnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNew.UseAccentColor = false;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // lblTitle
            // 
            lblTitle.Depth = 0;
            lblTitle.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblTitle.Location = new Point(50, 132);
            lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(700, 23);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Nuevo Cliente";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlCustomer
            // 
            pnlCustomer.Controls.Add(txtId);
            pnlCustomer.Controls.Add(txtEmail);
            pnlCustomer.Controls.Add(txtPhone);
            pnlCustomer.Controls.Add(txtAddress);
            pnlCustomer.Controls.Add(txtDoc);
            pnlCustomer.Controls.Add(txtName);
            pnlCustomer.Location = new Point(126, 158);
            pnlCustomer.Name = "pnlCustomer";
            pnlCustomer.Size = new Size(425, 213);
            pnlCustomer.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(7, 22);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(22, 23);
            txtId.TabIndex = 5;
            txtId.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(35, 173);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(357, 36);
            txtEmail.TabIndex = 4;
            txtEmail.Text = "";
            txtEmail.TrailingIcon = null;
            txtEmail.UseTallSize = false;
            // 
            // txtPhone
            // 
            txtPhone.AnimateReadOnly = false;
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Depth = 0;
            txtPhone.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPhone.Hint = "Teléfono";
            txtPhone.LeadingIcon = null;
            txtPhone.Location = new Point(35, 131);
            txtPhone.MaxLength = 32767;
            txtPhone.MouseState = MaterialSkin.MouseState.OUT;
            txtPhone.Multiline = false;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(357, 36);
            txtPhone.TabIndex = 3;
            txtPhone.Text = "";
            txtPhone.TrailingIcon = null;
            txtPhone.UseTallSize = false;
            // 
            // txtAddress
            // 
            txtAddress.AnimateReadOnly = false;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Depth = 0;
            txtAddress.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddress.Hint = "Dirección";
            txtAddress.LeadingIcon = null;
            txtAddress.Location = new Point(35, 89);
            txtAddress.MaxLength = 32767;
            txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtAddress.Multiline = false;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(357, 36);
            txtAddress.TabIndex = 2;
            txtAddress.Text = "";
            txtAddress.TrailingIcon = null;
            txtAddress.UseTallSize = false;
            // 
            // txtDoc
            // 
            txtDoc.AnimateReadOnly = false;
            txtDoc.BorderStyle = BorderStyle.None;
            txtDoc.Depth = 0;
            txtDoc.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDoc.Hint = "Documento";
            txtDoc.LeadingIcon = null;
            txtDoc.Location = new Point(35, 47);
            txtDoc.MaxLength = 32767;
            txtDoc.MouseState = MaterialSkin.MouseState.OUT;
            txtDoc.Multiline = false;
            txtDoc.Name = "txtDoc";
            txtDoc.Size = new Size(357, 36);
            txtDoc.TabIndex = 1;
            txtDoc.Text = "";
            txtDoc.TrailingIcon = null;
            txtDoc.UseTallSize = false;
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Depth = 0;
            txtName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.Hint = "Nombre Cliente";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(35, 9);
            txtName.MaxLength = 32767;
            txtName.MouseState = MaterialSkin.MouseState.OUT;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Size = new Size(357, 36);
            txtName.TabIndex = 0;
            txtName.Text = "";
            txtName.TrailingIcon = null;
            txtName.UseTallSize = false;
            // 
            // btnClear
            // 
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.Location = new Point(708, 81);
            btnClear.Margin = new Padding(4, 6, 4, 6);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(79, 36);
            btnClear.TabIndex = 12;
            btnClear.Text = "Limpiar";
            btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = false;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // FrmCustomerModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(lblTitle);
            Controls.Add(pnlCustomer);
            Name = "FrmCustomerModal";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
            Load += FrmCustomerModal_Load;
            pnlCustomer.ResumeLayout(false);
            pnlCustomer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnNew;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private Panel pnlCustomer;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtPhone;
        private MaterialSkin.Controls.MaterialTextBox txtAddress;
        private MaterialSkin.Controls.MaterialTextBox txtDoc;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private MaterialSkin.Controls.MaterialButton btnClear;
        public TextBox txtId;
    }
}