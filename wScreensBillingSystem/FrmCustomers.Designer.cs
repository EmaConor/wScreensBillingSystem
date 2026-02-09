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
        pnlCustomer = new System.Windows.Forms.Panel();
        txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
        txtPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
        txtAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
        txtDoc = new MaterialSkin.Controls.MaterialSingleLineTextField();
        txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
        panel1 = new System.Windows.Forms.Panel();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        btnSearch = new MaterialSkin.Controls.MaterialRaisedButton();
        txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
        btnNew = new MaterialSkin.Controls.MaterialRaisedButton();
        btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
        btnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
        btnOut = new MaterialSkin.Controls.MaterialRaisedButton();
        pnlCustomer.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Depth = 0;
        lblTitle.Font = new System.Drawing.Font("Roboto", 11F);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)222)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
        lblTitle.Location = new System.Drawing.Point(1, 21);
        lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(921, 35);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Admintración de Clientes";
        lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // pnlCustomer
        // 
        pnlCustomer.Controls.Add(txtEmail);
        pnlCustomer.Controls.Add(txtPhone);
        pnlCustomer.Controls.Add(txtAddress);
        pnlCustomer.Controls.Add(txtDoc);
        pnlCustomer.Controls.Add(txtName);
        pnlCustomer.Location = new System.Drawing.Point(193, 50);
        pnlCustomer.Name = "pnlCustomer";
        pnlCustomer.Size = new System.Drawing.Size(423, 195);
        pnlCustomer.TabIndex = 1;
        // 
        // txtEmail
        // 
        txtEmail.Depth = 0;
        txtEmail.Hint = "Email";
        txtEmail.Location = new System.Drawing.Point(35, 150);
        txtEmail.MaxLength = 32767;
        txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
        txtEmail.Name = "txtEmail";
        txtEmail.PasswordChar = '\0';
        txtEmail.SelectedText = "";
        txtEmail.SelectionLength = 0;
        txtEmail.SelectionStart = 0;
        txtEmail.Size = new System.Drawing.Size(357, 23);
        txtEmail.TabIndex = 4;
        txtEmail.TabStop = false;
        txtEmail.UseSystemPasswordChar = false;
        // 
        // txtPhone
        // 
        txtPhone.Depth = 0;
        txtPhone.Hint = "Teléfono";
        txtPhone.Location = new System.Drawing.Point(35, 121);
        txtPhone.MaxLength = 32767;
        txtPhone.MouseState = MaterialSkin.MouseState.HOVER;
        txtPhone.Name = "txtPhone";
        txtPhone.PasswordChar = '\0';
        txtPhone.SelectedText = "";
        txtPhone.SelectionLength = 0;
        txtPhone.SelectionStart = 0;
        txtPhone.Size = new System.Drawing.Size(357, 23);
        txtPhone.TabIndex = 3;
        txtPhone.TabStop = false;
        txtPhone.UseSystemPasswordChar = false;
        // 
        // txtAddress
        // 
        txtAddress.Depth = 0;
        txtAddress.Hint = "Dirección";
        txtAddress.Location = new System.Drawing.Point(35, 92);
        txtAddress.MaxLength = 32767;
        txtAddress.MouseState = MaterialSkin.MouseState.HOVER;
        txtAddress.Name = "txtAddress";
        txtAddress.PasswordChar = '\0';
        txtAddress.SelectedText = "";
        txtAddress.SelectionLength = 0;
        txtAddress.SelectionStart = 0;
        txtAddress.Size = new System.Drawing.Size(357, 23);
        txtAddress.TabIndex = 2;
        txtAddress.TabStop = false;
        txtAddress.UseSystemPasswordChar = false;
        // 
        // txtDoc
        // 
        txtDoc.Depth = 0;
        txtDoc.Hint = "Documento";
        txtDoc.Location = new System.Drawing.Point(35, 54);
        txtDoc.MaxLength = 32767;
        txtDoc.MouseState = MaterialSkin.MouseState.HOVER;
        txtDoc.Name = "txtDoc";
        txtDoc.PasswordChar = '\0';
        txtDoc.SelectedText = "";
        txtDoc.SelectionLength = 0;
        txtDoc.SelectionStart = 0;
        txtDoc.Size = new System.Drawing.Size(357, 23);
        txtDoc.TabIndex = 1;
        txtDoc.TabStop = false;
        txtDoc.UseSystemPasswordChar = false;
        // 
        // txtName
        // 
        txtName.Depth = 0;
        txtName.Hint = "Nombre Cliente";
        txtName.Location = new System.Drawing.Point(35, 25);
        txtName.MaxLength = 32767;
        txtName.MouseState = MaterialSkin.MouseState.HOVER;
        txtName.Name = "txtName";
        txtName.PasswordChar = '\0';
        txtName.SelectedText = "";
        txtName.SelectionLength = 0;
        txtName.SelectionStart = 0;
        txtName.Size = new System.Drawing.Size(357, 23);
        txtName.TabIndex = 0;
        txtName.TabStop = false;
        txtName.UseSystemPasswordChar = false;
        // 
        // panel1
        // 
        panel1.Controls.Add(dataGridView1);
        panel1.Controls.Add(btnSearch);
        panel1.Controls.Add(txtSearch);
        panel1.Location = new System.Drawing.Point(21, 269);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(752, 246);
        panel1.TabIndex = 2;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new System.Drawing.Point(35, 67);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new System.Drawing.Size(684, 162);
        dataGridView1.TabIndex = 5;
        dataGridView1.Text = "dataGridView1";
        // 
        // btnSearch
        // 
        btnSearch.AutoSize = true;
        btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        btnSearch.Depth = 0;
        btnSearch.Icon = null;
        btnSearch.Location = new System.Drawing.Point(645, 14);
        btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
        btnSearch.Name = "btnSearch";
        btnSearch.Primary = true;
        btnSearch.Size = new System.Drawing.Size(74, 36);
        btnSearch.TabIndex = 4;
        btnSearch.Text = "Buscar";
        btnSearch.UseVisualStyleBackColor = true;
        // 
        // txtSearch
        // 
        txtSearch.Depth = 0;
        txtSearch.Hint = "Buscar Cliente";
        txtSearch.Location = new System.Drawing.Point(35, 27);
        txtSearch.MaxLength = 32767;
        txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
        txtSearch.Name = "txtSearch";
        txtSearch.PasswordChar = '\0';
        txtSearch.SelectedText = "";
        txtSearch.SelectionLength = 0;
        txtSearch.SelectionStart = 0;
        txtSearch.Size = new System.Drawing.Size(604, 23);
        txtSearch.TabIndex = 1;
        txtSearch.TabStop = false;
        txtSearch.UseSystemPasswordChar = false;
        // 
        // btnNew
        // 
        btnNew.AutoSize = true;
        btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        btnNew.Depth = 0;
        btnNew.Icon = null;
        btnNew.Location = new System.Drawing.Point(635, 89);
        btnNew.MouseState = MaterialSkin.MouseState.HOVER;
        btnNew.Name = "btnNew";
        btnNew.Primary = true;
        btnNew.Size = new System.Drawing.Size(66, 36);
        btnNew.TabIndex = 3;
        btnNew.Text = "Nuevo";
        btnNew.UseVisualStyleBackColor = true;
        // 
        // btnUpdate
        // 
        btnUpdate.AutoSize = true;
        btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        btnUpdate.Depth = 0;
        btnUpdate.Icon = null;
        btnUpdate.Location = new System.Drawing.Point(635, 131);
        btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Primary = true;
        btnUpdate.Size = new System.Drawing.Size(103, 36);
        btnUpdate.TabIndex = 4;
        btnUpdate.Text = "Actualizar";
        btnUpdate.UseVisualStyleBackColor = true;
        // 
        // btnDelete
        // 
        btnDelete.AutoSize = true;
        btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        btnDelete.Depth = 0;
        btnDelete.Icon = null;
        btnDelete.Location = new System.Drawing.Point(635, 173);
        btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
        btnDelete.Name = "btnDelete";
        btnDelete.Primary = true;
        btnDelete.Size = new System.Drawing.Size(83, 36);
        btnDelete.TabIndex = 5;
        btnDelete.Text = "Eliminar";
        btnDelete.UseVisualStyleBackColor = true;
        // 
        // btnOut
        // 
        btnOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        btnOut.Depth = 0;
        btnOut.Icon = null;
        btnOut.Location = new System.Drawing.Point(795, 462);
        btnOut.MouseState = MaterialSkin.MouseState.HOVER;
        btnOut.Name = "btnOut";
        btnOut.Primary = true;
        btnOut.Size = new System.Drawing.Size(90, 36);
        btnOut.TabIndex = 6;
        btnOut.Text = "Salir";
        btnOut.UseVisualStyleBackColor = true;
        // 
        // FrmCustomers
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(923, 547);
        Controls.Add(btnOut);
        Controls.Add(btnDelete);
        Controls.Add(btnUpdate);
        Controls.Add(btnNew);
        Controls.Add(panel1);
        Controls.Add(pnlCustomer);
        Controls.Add(lblTitle);
        Text = "FrmCustomers";
        pnlCustomer.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private MaterialSkin.Controls.MaterialRaisedButton btnOut;

    private System.Windows.Forms.DataGridView dataGridView1;

    private MaterialSkin.Controls.MaterialRaisedButton btnSearch;

    private MaterialSkin.Controls.MaterialRaisedButton btnDelete;

    private MaterialSkin.Controls.MaterialRaisedButton btnNew;
    private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;

    private System.Windows.Forms.Panel panel1;
    private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;

    private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
    private MaterialSkin.Controls.MaterialSingleLineTextField txtDoc;
    private MaterialSkin.Controls.MaterialSingleLineTextField txtAddress;
    private MaterialSkin.Controls.MaterialSingleLineTextField txtPhone;
    private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;

    private System.Windows.Forms.Panel pnlCustomer;

    private MaterialSkin.Controls.MaterialLabel lblTitle;

    #endregion
}