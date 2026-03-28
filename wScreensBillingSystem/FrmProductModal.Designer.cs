namespace wScreensBillingSystem
{
    partial class FrmProductModal
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
            btnClear = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnNew = new MaterialSkin.Controls.MaterialButton();
            lblTitle = new MaterialSkin.Controls.MaterialLabel();
            pnlProduct = new Panel();
            txtInfo = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            cmbCategory = new MaterialSkin.Controls.MaterialComboBox();
            txtId = new TextBox();
            txtStock = new MaterialSkin.Controls.MaterialTextBox();
            txtSalePrice = new MaterialSkin.Controls.MaterialTextBox();
            txtSupplierPrice = new MaterialSkin.Controls.MaterialTextBox();
            txtCode = new MaterialSkin.Controls.MaterialTextBox();
            txtName = new MaterialSkin.Controls.MaterialTextBox();
            pnlProduct.SuspendLayout();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.Location = new Point(714, 70);
            btnClear.Margin = new Padding(4, 6, 4, 6);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(79, 36);
            btnClear.TabIndex = 16;
            btnClear.Text = "Limpiar";
            btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = false;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.DrawShadows = false;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(671, 225);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(109, 36);
            btnUpdate.TabIndex = 14;
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
            btnNew.Location = new Point(671, 243);
            btnNew.Margin = new Padding(4, 6, 4, 6);
            btnNew.MouseState = MaterialSkin.MouseState.HOVER;
            btnNew.Name = "btnNew";
            btnNew.NoAccentTextColor = Color.Empty;
            btnNew.Size = new Size(70, 36);
            btnNew.TabIndex = 13;
            btnNew.Text = "Nuevo";
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
            lblTitle.Location = new Point(45, 136);
            lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(700, 23);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Nuevo Producto";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlProduct
            // 
            pnlProduct.Controls.Add(txtInfo);
            pnlProduct.Controls.Add(cmbCategory);
            pnlProduct.Controls.Add(txtId);
            pnlProduct.Controls.Add(txtStock);
            pnlProduct.Controls.Add(txtSalePrice);
            pnlProduct.Controls.Add(txtSupplierPrice);
            pnlProduct.Controls.Add(txtCode);
            pnlProduct.Controls.Add(txtName);
            pnlProduct.Location = new Point(8, 162);
            pnlProduct.Name = "pnlProduct";
            pnlProduct.Size = new Size(656, 213);
            pnlProduct.TabIndex = 12;
            // 
            // txtInfo
            // 
            txtInfo.AnimateReadOnly = false;
            txtInfo.BackgroundImageLayout = ImageLayout.None;
            txtInfo.CharacterCasing = CharacterCasing.Normal;
            txtInfo.Depth = 0;
            txtInfo.HideSelection = true;
            txtInfo.Hint = "Detalles del Producto";
            txtInfo.Location = new Point(382, 50);
            txtInfo.MaxLength = 32767;
            txtInfo.MouseState = MaterialSkin.MouseState.OUT;
            txtInfo.Name = "txtInfo";
            txtInfo.PasswordChar = '\0';
            txtInfo.ReadOnly = false;
            txtInfo.ScrollBars = ScrollBars.None;
            txtInfo.SelectedText = "";
            txtInfo.SelectionLength = 0;
            txtInfo.SelectionStart = 0;
            txtInfo.ShortcutsEnabled = true;
            txtInfo.Size = new Size(256, 159);
            txtInfo.TabIndex = 11;
            txtInfo.TabStop = false;
            txtInfo.TextAlign = HorizontalAlignment.Left;
            txtInfo.UseSystemPasswordChar = false;
            // 
            // cmbCategory
            // 
            cmbCategory.AutoResize = false;
            cmbCategory.BackColor = Color.FromArgb(255, 255, 255);
            cmbCategory.Depth = 0;
            cmbCategory.DrawMode = DrawMode.OwnerDrawVariable;
            cmbCategory.DropDownHeight = 118;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.DropDownWidth = 121;
            cmbCategory.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbCategory.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Hint = "Categoria";
            cmbCategory.IntegralHeight = false;
            cmbCategory.ItemHeight = 29;
            cmbCategory.Location = new Point(381, 9);
            cmbCategory.MaxDropDownItems = 4;
            cmbCategory.MouseState = MaterialSkin.MouseState.OUT;
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(256, 35);
            cmbCategory.StartIndex = 0;
            cmbCategory.TabIndex = 6;
            cmbCategory.UseTallSize = false;
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
            // txtStock
            // 
            txtStock.AnimateReadOnly = false;
            txtStock.BorderStyle = BorderStyle.None;
            txtStock.Depth = 0;
            txtStock.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStock.Hint = "Cantidad";
            txtStock.LeadingIcon = null;
            txtStock.Location = new Point(35, 173);
            txtStock.MaxLength = 32767;
            txtStock.MouseState = MaterialSkin.MouseState.OUT;
            txtStock.Multiline = false;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(329, 36);
            txtStock.TabIndex = 4;
            txtStock.Text = "";
            txtStock.TrailingIcon = null;
            txtStock.UseTallSize = false;
            // 
            // txtSalePrice
            // 
            txtSalePrice.AnimateReadOnly = false;
            txtSalePrice.BorderStyle = BorderStyle.None;
            txtSalePrice.Depth = 0;
            txtSalePrice.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSalePrice.Hint = "Precio Venta";
            txtSalePrice.LeadingIcon = null;
            txtSalePrice.Location = new Point(35, 131);
            txtSalePrice.MaxLength = 32767;
            txtSalePrice.MouseState = MaterialSkin.MouseState.OUT;
            txtSalePrice.Multiline = false;
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(329, 36);
            txtSalePrice.TabIndex = 3;
            txtSalePrice.Text = "";
            txtSalePrice.TrailingIcon = null;
            txtSalePrice.UseTallSize = false;
            // 
            // txtSupplierPrice
            // 
            txtSupplierPrice.AnimateReadOnly = false;
            txtSupplierPrice.BorderStyle = BorderStyle.None;
            txtSupplierPrice.Depth = 0;
            txtSupplierPrice.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSupplierPrice.Hint = "Precio Compra";
            txtSupplierPrice.LeadingIcon = null;
            txtSupplierPrice.Location = new Point(35, 89);
            txtSupplierPrice.MaxLength = 32767;
            txtSupplierPrice.MouseState = MaterialSkin.MouseState.OUT;
            txtSupplierPrice.Multiline = false;
            txtSupplierPrice.Name = "txtSupplierPrice";
            txtSupplierPrice.Size = new Size(329, 36);
            txtSupplierPrice.TabIndex = 2;
            txtSupplierPrice.Text = "";
            txtSupplierPrice.TrailingIcon = null;
            txtSupplierPrice.UseTallSize = false;
            // 
            // txtCode
            // 
            txtCode.AnimateReadOnly = false;
            txtCode.BorderStyle = BorderStyle.None;
            txtCode.Depth = 0;
            txtCode.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCode.Hint = "Codigo";
            txtCode.LeadingIcon = null;
            txtCode.Location = new Point(35, 47);
            txtCode.MaxLength = 32767;
            txtCode.MouseState = MaterialSkin.MouseState.OUT;
            txtCode.Multiline = false;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(329, 36);
            txtCode.TabIndex = 1;
            txtCode.Text = "";
            txtCode.TrailingIcon = null;
            txtCode.UseTallSize = false;
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Depth = 0;
            txtName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.Hint = "Nombre Producto";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(35, 9);
            txtName.MaxLength = 32767;
            txtName.MouseState = MaterialSkin.MouseState.OUT;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Size = new Size(329, 36);
            txtName.TabIndex = 0;
            txtName.Text = "";
            txtName.TrailingIcon = null;
            txtName.UseTallSize = false;
            // 
            // FrmProductModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(lblTitle);
            Controls.Add(pnlProduct);
            Name = "FrmProductModal";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Producto";
            Load += FrmProductModal_Load;
            pnlProduct.ResumeLayout(false);
            pnlProduct.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnNew;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private Panel pnlProduct;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtInfo;
        private MaterialSkin.Controls.MaterialComboBox cmbCategory;
        private TextBox txtId;
        private MaterialSkin.Controls.MaterialTextBox txtStock;
        private MaterialSkin.Controls.MaterialTextBox txtSalePrice;
        private MaterialSkin.Controls.MaterialTextBox txtSupplierPrice;
        private MaterialSkin.Controls.MaterialTextBox txtCode;
        private MaterialSkin.Controls.MaterialTextBox txtName;
    }
}