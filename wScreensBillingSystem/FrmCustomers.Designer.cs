using System.ComponentModel;

namespace wScreensBillingSystem;

partial class FrmCustomers
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
        pnlSearch = new Panel();
        dgvCustomers = new DataGridView();
        id = new DataGridViewTextBoxColumn();
        nameCustomer = new DataGridViewTextBoxColumn();
        document = new DataGridViewTextBoxColumn();
        address = new DataGridViewTextBoxColumn();
        phone = new DataGridViewTextBoxColumn();
        email = new DataGridViewTextBoxColumn();
        edit = new DataGridViewButtonColumn();
        delete = new DataGridViewButtonColumn();
        btnSearch = new MaterialSkin.Controls.MaterialButton();
        btnNew = new MaterialSkin.Controls.MaterialButton();
        txtSearch = new MaterialSkin.Controls.MaterialTextBox();
        btnOut = new MaterialSkin.Controls.MaterialButton();
        btnClear = new MaterialSkin.Controls.MaterialButton();
        lblTitle = new MaterialSkin.Controls.MaterialLabel();
        pnlSearch.SuspendLayout();
        ((ISupportInitialize)dgvCustomers).BeginInit();
        SuspendLayout();
        // 
        // pnlSearch
        // 
        pnlSearch.Controls.Add(dgvCustomers);
        pnlSearch.Controls.Add(btnSearch);
        pnlSearch.Controls.Add(btnNew);
        pnlSearch.Controls.Add(txtSearch);
        pnlSearch.Location = new Point(-8, 44);
        pnlSearch.Name = "pnlSearch";
        pnlSearch.Size = new Size(735, 473);
        pnlSearch.TabIndex = 2;
        // 
        // dgvCustomers
        // 
        dgvCustomers.AllowUserToAddRows = false;
        dgvCustomers.AllowUserToDeleteRows = false;
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { id, nameCustomer, document, address, phone, email, edit, delete });
        dgvCustomers.Location = new Point(13, 67);
        dgvCustomers.Name = "dgvCustomers";
        dgvCustomers.ReadOnly = true;
        dgvCustomers.Size = new Size(706, 391);
        dgvCustomers.TabIndex = 5;
        dgvCustomers.Text = "dataGridView1";
        dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
        // 
        // id
        // 
        id.HeaderText = "ID";
        id.Name = "id";
        id.ReadOnly = true;
        id.Resizable = DataGridViewTriState.False;
        // 
        // nameCustomer
        // 
        nameCustomer.HeaderText = "Nombre";
        nameCustomer.Name = "nameCustomer";
        nameCustomer.ReadOnly = true;
        // 
        // document
        // 
        document.HeaderText = "Documento";
        document.Name = "document";
        document.ReadOnly = true;
        // 
        // address
        // 
        address.HeaderText = "Direccion";
        address.Name = "address";
        address.ReadOnly = true;
        // 
        // phone
        // 
        phone.HeaderText = "Telefono";
        phone.Name = "phone";
        phone.ReadOnly = true;
        // 
        // email
        // 
        email.HeaderText = "Email";
        email.Name = "email";
        email.ReadOnly = true;
        // 
        // edit
        // 
        edit.HeaderText = "Editar";
        edit.Name = "edit";
        edit.ReadOnly = true;
        edit.Text = "Editar";
        edit.UseColumnTextForButtonValue = true;
        edit.Width = 80;
        // 
        // delete
        // 
        delete.HeaderText = "Eliminar";
        delete.Name = "delete";
        delete.ReadOnly = true;
        delete.Text = "Eliminar";
        delete.UseColumnTextForButtonValue = true;
        delete.Width = 80;
        // 
        // btnSearch
        // 
        btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnSearch.Depth = 0;
        btnSearch.HighEmphasis = true;
        btnSearch.Icon = null;
        btnSearch.Location = new Point(480, 22);
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
        // txtSearch
        // 
        txtSearch.AnimateReadOnly = false;
        txtSearch.BorderStyle = BorderStyle.None;
        txtSearch.Depth = 0;
        txtSearch.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        txtSearch.Hint = "Buscar Cliente";
        txtSearch.LeadingIcon = null;
        txtSearch.Location = new Point(24, 14);
        txtSearch.MaxLength = 32767;
        txtSearch.MouseState = MaterialSkin.MouseState.OUT;
        txtSearch.Multiline = false;
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(449, 50);
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
        btnClear.Location = new Point(719, 9);
        btnClear.Margin = new Padding(4, 6, 4, 6);
        btnClear.MouseState = MaterialSkin.MouseState.HOVER;
        btnClear.Name = "btnClear";
        btnClear.NoAccentTextColor = Color.Empty;
        btnClear.Size = new Size(79, 36);
        btnClear.TabIndex = 11;
        btnClear.Text = "Limpiar";
        btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        btnClear.UseAccentColor = false;
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;
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
        lblTitle.Text = "Admintración de Clientes";
        lblTitle.TextAlign = ContentAlignment.TopCenter;
        // 
        // FrmCustomers
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(811, 517);
        ControlBox = false;
        Controls.Add(btnClear);
        Controls.Add(btnOut);
        Controls.Add(pnlSearch);
        Controls.Add(lblTitle);
        Name = "FrmCustomers";
        ShowInTaskbar = false;
        pnlSearch.ResumeLayout(false);
        pnlSearch.PerformLayout();
        ((ISupportInitialize)dgvCustomers).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private MaterialSkin.Controls.MaterialButton btnOut;

    private System.Windows.Forms.DataGridView dgvCustomers;

    private MaterialSkin.Controls.MaterialButton btnSearch;

    private MaterialSkin.Controls.MaterialButton btnNew;

    private System.Windows.Forms.Panel pnlSearch;
    private MaterialSkin.Controls.MaterialTextBox txtSearch;

    #endregion
    private MaterialSkin.Controls.MaterialButton btnClear;
    private MaterialSkin.Controls.MaterialLabel lblTitle;
    private DataGridViewTextBoxColumn id;
    private DataGridViewTextBoxColumn nameCustomer;
    private DataGridViewTextBoxColumn document;
    private DataGridViewTextBoxColumn address;
    private DataGridViewTextBoxColumn phone;
    private DataGridViewTextBoxColumn email;
    private DataGridViewButtonColumn edit;
    private DataGridViewButtonColumn delete;
}