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
        lblTitle = new MaterialSkin.Controls.MaterialLabel();
        pnlCustomer = new Panel();
        txtId = new TextBox();
        txtEmail = new MaterialSkin.Controls.MaterialTextBox();
        txtPhone = new MaterialSkin.Controls.MaterialTextBox();
        txtAddress = new MaterialSkin.Controls.MaterialTextBox();
        txtDoc = new MaterialSkin.Controls.MaterialTextBox();
        txtName = new MaterialSkin.Controls.MaterialTextBox();
        pnlSearch = new Panel();
        dgvCustomers = new DataGridView();
        id = new DataGridViewTextBoxColumn();
        nameCustomer = new DataGridViewTextBoxColumn();
        document = new DataGridViewTextBoxColumn();
        address = new DataGridViewTextBoxColumn();
        phone = new DataGridViewTextBoxColumn();
        email = new DataGridViewTextBoxColumn();
        btnSearch = new MaterialSkin.Controls.MaterialButton();
        txtSearch = new MaterialSkin.Controls.MaterialTextBox();
        btnNew = new MaterialSkin.Controls.MaterialButton();
        btnUpdate = new MaterialSkin.Controls.MaterialButton();
        btnOut = new MaterialSkin.Controls.MaterialButton();
        btnClear = new MaterialSkin.Controls.MaterialButton();
        pnlCustomer.SuspendLayout();
        pnlSearch.SuspendLayout();
        ((ISupportInitialize)dgvCustomers).BeginInit();
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
        lblTitle.Text = "Admintración de Clientes";
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
        pnlCustomer.Location = new Point(129, 35);
        pnlCustomer.Name = "pnlCustomer";
        pnlCustomer.Size = new Size(425, 213);
        pnlCustomer.TabIndex = 1;
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
        // pnlSearch
        // 
        pnlSearch.Controls.Add(dgvCustomers);
        pnlSearch.Controls.Add(btnSearch);
        pnlSearch.Controls.Add(txtSearch);
        pnlSearch.Location = new Point(-8, 254);
        pnlSearch.Name = "pnlSearch";
        pnlSearch.Size = new Size(735, 263);
        pnlSearch.TabIndex = 2;
        // 
        // dgvCustomers
        // 
        dgvCustomers.AllowUserToAddRows = false;
        dgvCustomers.AllowUserToDeleteRows = false;
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { id, nameCustomer, document, address, phone, email });
        dgvCustomers.Location = new Point(13, 67);
        dgvCustomers.Name = "dgvCustomers";
        dgvCustomers.ReadOnly = true;
        dgvCustomers.Size = new Size(706, 184);
        dgvCustomers.TabIndex = 5;
        dgvCustomers.Text = "dataGridView1";
        dgvCustomers.CellClick += dgvCustomers_CellClick;
        dgvCustomers.MouseDown += dgvCustomers_MouseDown;
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
        btnSearch.Click += btnSearch_Click;
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
        btnNew.Location = new Point(573, 116);
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
        // btnUpdate
        // 
        btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnUpdate.Depth = 0;
        btnUpdate.DrawShadows = false;
        btnUpdate.HighEmphasis = true;
        btnUpdate.Icon = null;
        btnUpdate.Location = new Point(573, 104);
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
        btnUpdate.Visible = false;
        btnUpdate.Click += btnUpdate_Click;
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
        // FrmCustomers
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(811, 517);
        ControlBox = false;
        Controls.Add(btnClear);
        Controls.Add(btnOut);
        Controls.Add(btnUpdate);
        Controls.Add(btnNew);
        Controls.Add(pnlSearch);
        Controls.Add(lblTitle);
        Controls.Add(pnlCustomer);
        Name = "FrmCustomers";
        ShowInTaskbar = false;
        pnlCustomer.ResumeLayout(false);
        pnlCustomer.PerformLayout();
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
    private MaterialSkin.Controls.MaterialButton btnUpdate;

    private System.Windows.Forms.Panel pnlSearch;
    private MaterialSkin.Controls.MaterialTextBox txtSearch;

    private MaterialSkin.Controls.MaterialTextBox txtName;
    private MaterialSkin.Controls.MaterialTextBox txtDoc;
    private MaterialSkin.Controls.MaterialTextBox txtAddress;
    private MaterialSkin.Controls.MaterialTextBox txtPhone;
    private MaterialSkin.Controls.MaterialTextBox txtEmail;

    private System.Windows.Forms.Panel pnlCustomer;

    private MaterialSkin.Controls.MaterialLabel lblTitle;

    #endregion

    private TextBox txtId;
    private DataGridViewTextBoxColumn id;
    private DataGridViewTextBoxColumn nameCustomer;
    private DataGridViewTextBoxColumn document;
    private DataGridViewTextBoxColumn address;
    private DataGridViewTextBoxColumn phone;
    private DataGridViewTextBoxColumn email;
    private MaterialSkin.Controls.MaterialButton btnClear;
}