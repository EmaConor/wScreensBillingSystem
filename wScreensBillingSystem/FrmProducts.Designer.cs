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
        pnlSearch = new Panel();
        btnNew = new MaterialSkin.Controls.MaterialButton();
        dgvProducts = new DataGridView();
        id = new DataGridViewTextBoxColumn();
        nameProduct = new DataGridViewTextBoxColumn();
        code = new DataGridViewTextBoxColumn();
        supplierPrice = new DataGridViewTextBoxColumn();
        salePrice = new DataGridViewTextBoxColumn();
        stock = new DataGridViewTextBoxColumn();
        idCategory = new DataGridViewTextBoxColumn();
        category = new DataGridViewTextBoxColumn();
        info = new DataGridViewTextBoxColumn();
        edit = new DataGridViewButtonColumn();
        delete = new DataGridViewButtonColumn();
        btnSearch = new MaterialSkin.Controls.MaterialButton();
        txtSearch = new MaterialSkin.Controls.MaterialTextBox();
        btnOut = new MaterialSkin.Controls.MaterialButton();
        btnClear = new MaterialSkin.Controls.MaterialButton();
        pnlSearch.SuspendLayout();
        ((ISupportInitialize)dgvProducts).BeginInit();
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
        // pnlSearch
        // 
        pnlSearch.Controls.Add(btnNew);
        pnlSearch.Controls.Add(dgvProducts);
        pnlSearch.Controls.Add(btnSearch);
        pnlSearch.Controls.Add(txtSearch);
        pnlSearch.Location = new Point(-8, 54);
        pnlSearch.Name = "pnlSearch";
        pnlSearch.Size = new Size(735, 463);
        pnlSearch.TabIndex = 2;
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
        btnNew.TabIndex = 10;
        btnNew.Text = "Nuevo";
        btnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        btnNew.UseAccentColor = false;
        btnNew.UseVisualStyleBackColor = true;
        btnNew.Click += btnNew_Click;
        // 
        // dgvProducts
        // 
        dgvProducts.AllowUserToAddRows = false;
        dgvProducts.AllowUserToDeleteRows = false;
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProducts.Columns.AddRange(new DataGridViewColumn[] { id, nameProduct, code, supplierPrice, salePrice, stock, idCategory, category, info, edit, delete });
        dgvProducts.Location = new Point(13, 67);
        dgvProducts.Name = "dgvProducts";
        dgvProducts.ReadOnly = true;
        dgvProducts.Size = new Size(706, 381);
        dgvProducts.TabIndex = 5;
        dgvProducts.Text = "dataGridView1";
        dgvProducts.CellContentClick += dgvProducts_CellContentClick;
        // 
        // id
        // 
        id.HeaderText = "ID";
        id.Name = "id";
        id.ReadOnly = true;
        // 
        // nameProduct
        // 
        nameProduct.HeaderText = "Nombre";
        nameProduct.Name = "nameProduct";
        nameProduct.ReadOnly = true;
        // 
        // code
        // 
        code.HeaderText = "Codigo";
        code.Name = "code";
        code.ReadOnly = true;
        // 
        // supplierPrice
        // 
        supplierPrice.HeaderText = "Precio Compra";
        supplierPrice.Name = "supplierPrice";
        supplierPrice.ReadOnly = true;
        // 
        // salePrice
        // 
        salePrice.HeaderText = "Precio Venta";
        salePrice.Name = "salePrice";
        salePrice.ReadOnly = true;
        // 
        // stock
        // 
        stock.HeaderText = "Cantidad";
        stock.Name = "stock";
        stock.ReadOnly = true;
        // 
        // idCategory
        // 
        idCategory.HeaderText = "ID Categoria";
        idCategory.Name = "idCategory";
        idCategory.ReadOnly = true;
        idCategory.Visible = false;
        // 
        // category
        // 
        category.HeaderText = "Categoria";
        category.Name = "category";
        category.ReadOnly = true;
        // 
        // info
        // 
        info.HeaderText = "Detalle";
        info.Name = "info";
        info.ReadOnly = true;
        // 
        // edit
        // 
        edit.HeaderText = "Editar";
        edit.Name = "edit";
        edit.ReadOnly = true;
        edit.Resizable = DataGridViewTriState.True;
        edit.SortMode = DataGridViewColumnSortMode.Automatic;
        edit.Text = "Editar";
        edit.UseColumnTextForButtonValue = true;
        // 
        // delete
        // 
        delete.HeaderText = "Eliminar";
        delete.Name = "delete";
        delete.ReadOnly = true;
        delete.Resizable = DataGridViewTriState.True;
        delete.SortMode = DataGridViewColumnSortMode.Automatic;
        delete.Text = "Eliminar";
        delete.UseColumnTextForButtonValue = true;
        // 
        // btnSearch
        // 
        btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnSearch.Depth = 0;
        btnSearch.HighEmphasis = true;
        btnSearch.Icon = null;
        btnSearch.Location = new Point(490, 22);
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
        btnSearch.Click += btnSearch_Click;
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
        txtSearch.Size = new Size(459, 50);
        txtSearch.TabIndex = 8;
        txtSearch.Text = "";
        txtSearch.TrailingIcon = null;
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
        // btnClear
        // 
        btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnClear.Depth = 0;
        btnClear.HighEmphasis = true;
        btnClear.Icon = null;
        btnClear.Location = new Point(721, 9);
        btnClear.Margin = new Padding(4, 6, 4, 6);
        btnClear.MouseState = MaterialSkin.MouseState.HOVER;
        btnClear.Name = "btnClear";
        btnClear.NoAccentTextColor = Color.Empty;
        btnClear.Size = new Size(79, 36);
        btnClear.TabIndex = 10;
        btnClear.Text = "Limpiar";
        btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        btnClear.UseAccentColor = false;
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;
        // 
        // FrmProducts
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(811, 517);
        ControlBox = false;
        Controls.Add(btnClear);
        Controls.Add(btnOut);
        Controls.Add(pnlSearch);
        Controls.Add(lblTitle);
        Name = "FrmProducts";
        ShowInTaskbar = false;
        pnlSearch.ResumeLayout(false);
        pnlSearch.PerformLayout();
        ((ISupportInitialize)dgvProducts).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private MaterialSkin.Controls.MaterialButton btnOut;

    private System.Windows.Forms.DataGridView dgvProducts;

    private MaterialSkin.Controls.MaterialButton btnSearch;

    private System.Windows.Forms.Panel pnlSearch;
    private MaterialSkin.Controls.MaterialTextBox txtSearch;

    private MaterialSkin.Controls.MaterialLabel lblTitle;

    #endregion
    private MaterialSkin.Controls.MaterialButton btnClear;
    private MaterialSkin.Controls.MaterialButton btnNew;
    private DataGridViewTextBoxColumn id;
    private DataGridViewTextBoxColumn nameProduct;
    private DataGridViewTextBoxColumn code;
    private DataGridViewTextBoxColumn supplierPrice;
    private DataGridViewTextBoxColumn salePrice;
    private DataGridViewTextBoxColumn stock;
    private DataGridViewTextBoxColumn idCategory;
    private DataGridViewTextBoxColumn category;
    private DataGridViewTextBoxColumn info;
    private DataGridViewButtonColumn edit;
    private DataGridViewButtonColumn delete;
}