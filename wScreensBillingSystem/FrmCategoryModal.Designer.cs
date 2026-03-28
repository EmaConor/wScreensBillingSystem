namespace wScreensBillingSystem
{
    partial class FrmCategoryModal
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
            btnClear = new MaterialSkin.Controls.MaterialButton();
            lblTitle = new MaterialSkin.Controls.MaterialLabel();
            pnlCustomer = new Panel();
            txtDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            txtId = new TextBox();
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
            // 
            // lblTitle
            // 
            lblTitle.Depth = 0;
            lblTitle.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblTitle.Location = new Point(59, 149);
            lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(700, 23);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Nueva Categoria";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlCustomer
            // 
            pnlCustomer.Controls.Add(txtDescription);
            pnlCustomer.Controls.Add(txtId);
            pnlCustomer.Location = new Point(135, 175);
            pnlCustomer.Name = "pnlCustomer";
            pnlCustomer.Size = new Size(425, 183);
            pnlCustomer.TabIndex = 14;
            // 
            // txtDescription
            // 
            txtDescription.AnimateReadOnly = false;
            txtDescription.BackgroundImageLayout = ImageLayout.None;
            txtDescription.CharacterCasing = CharacterCasing.Normal;
            txtDescription.Depth = 0;
            txtDescription.HideSelection = true;
            txtDescription.Hint = "Descripción";
            txtDescription.Location = new Point(37, 22);
            txtDescription.MaxLength = 32767;
            txtDescription.MouseState = MaterialSkin.MouseState.OUT;
            txtDescription.Name = "txtDescription";
            txtDescription.PasswordChar = '\0';
            txtDescription.ReadOnly = false;
            txtDescription.ScrollBars = ScrollBars.None;
            txtDescription.SelectedText = "";
            txtDescription.SelectionLength = 0;
            txtDescription.SelectionStart = 0;
            txtDescription.ShortcutsEnabled = true;
            txtDescription.Size = new Size(355, 148);
            txtDescription.TabIndex = 6;
            txtDescription.TabStop = false;
            txtDescription.TextAlign = HorizontalAlignment.Left;
            txtDescription.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(7, 22);
            txtId.Name = "txtId";
            txtId.Size = new Size(22, 23);
            txtId.TabIndex = 5;
            txtId.Visible = false;
            // 
            // FrmCategoryModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(pnlCustomer);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Name = "FrmCategoryModal";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categoria";
            Load += FrmCategoryModal_Load;
            pnlCustomer.ResumeLayout(false);
            pnlCustomer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnNew;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private Panel pnlCustomer;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescription;
        private TextBox txtId;
    }
}