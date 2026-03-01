using System.ComponentModel;

namespace wScreensBillingSystem;

partial class FrmProducts
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        pnlProduct = new Panel();
        txtInfo = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
        cmbCategory = new MaterialSkin.Controls.MaterialComboBox();
        txtId = new TextBox();
        txtStock = new MaterialSkin.Controls.MaterialTextBox();
        txtSalePrice = new MaterialSkin.Controls.MaterialTextBox();
        txtSupplierPrice = new MaterialSkin.Controls.MaterialTextBox();
        txtCode = new MaterialSkin.Controls.MaterialTextBox();
        txtName = new MaterialSkin.Controls.MaterialTextBox();
        pnlSearch = new Panel();
        dataGridView1 = new DataGridView();
        btnSearch = new MaterialSkin.Controls.MaterialButton();
        txtSearch = new MaterialSkin.Controls.MaterialTextBox();
        btnNew = new MaterialSkin.Controls.MaterialButton();
        btnUpdate = new MaterialSkin.Controls.MaterialButton();
        btnDelete = new MaterialSkin.Controls.MaterialButton();
        btnOut = new MaterialSkin.Controls.MaterialButton();
        pnlProduct.SuspendLayout();
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
        lblTitle.Text = "Admintración de Productos";
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
        pnlProduct.Location = new Point(16, 35);
        pnlProduct.Name = "pnlProduct";
        pnlProduct.Size = new Size(656, 213);
        pnlProduct.TabIndex = 1;
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
        // pnlSearch
        // 
        pnlSearch.Controls.Add(dataGridView1);
        pnlSearch.Controls.Add(btnSearch);
        pnlSearch.Controls.Add(txtSearch);
        pnlSearch.Location = new Point(-8, 254);
        pnlSearch.Name = "pnlSearch";
        pnlSearch.Size = new Size(735, 263);
        pnlSearch.TabIndex = 2;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(13, 67);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(706, 184);
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
        btnSearch.Location = new Point(635, 22);
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
        txtSearch.Hint = "Buscar Producto";
        txtSearch.LeadingIcon = null;
        txtSearch.Location = new Point(24, 14);
        txtSearch.MaxLength = 32767;
        txtSearch.MouseState = MaterialSkin.MouseState.OUT;
        txtSearch.Multiline = false;
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(604, 50);
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
        btnNew.Location = new Point(679, 74);
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
        // 
        // btnUpdate
        // 
        btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnUpdate.Depth = 0;
        btnUpdate.HighEmphasis = true;
        btnUpdate.Icon = null;
        btnUpdate.Location = new Point(679, 116);
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
        btnDelete.Location = new Point(679, 158);
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
        // FrmProducts
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(811, 517);
        ControlBox = false;
        Controls.Add(btnOut);
        Controls.Add(btnDelete);
        Controls.Add(btnUpdate);
        Controls.Add(btnNew);
        Controls.Add(pnlSearch);
        Controls.Add(lblTitle);
        Controls.Add(pnlProduct);
        Name = "FrmProducts";
        ShowInTaskbar = false;
        pnlProduct.ResumeLayout(false);
        pnlProduct.PerformLayout();
        pnlSearch.ResumeLayout(false);
        pnlSearch.PerformLayout();
        ((ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private MaterialSkin.Controls.MaterialButton btnOut;

    private System.Windows.Forms.DataGridView dataGridView1;

    private MaterialSkin.Controls.MaterialButton btnSearch;

    private MaterialSkin.Controls.MaterialButton btnDelete;

    private MaterialSkin.Controls.MaterialButton btnNew;
    private MaterialSkin.Controls.MaterialButton btnUpdate;

    private System.Windows.Forms.Panel pnlSearch;
    private MaterialSkin.Controls.MaterialTextBox txtSearch;

    private MaterialSkin.Controls.MaterialTextBox txtName;
    private MaterialSkin.Controls.MaterialTextBox txtCode;
    private MaterialSkin.Controls.MaterialTextBox txtSupplierPrice;
    private MaterialSkin.Controls.MaterialTextBox txtSalePrice;
    private MaterialSkin.Controls.MaterialTextBox txtStock;

    private System.Windows.Forms.Panel pnlProduct;

    private MaterialSkin.Controls.MaterialLabel lblTitle;

    #endregion

    private TextBox txtId;
    private MaterialSkin.Controls.MaterialComboBox cmbCategory;
    private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtInfo;
}