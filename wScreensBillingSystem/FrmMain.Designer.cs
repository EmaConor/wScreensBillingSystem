using System.ComponentModel;

namespace wScreensBillingSystem;

partial class FrmMain
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
        pnlMain = new System.Windows.Forms.Panel();
        pnlContainer = new System.Windows.Forms.Panel();
        pnlAside = new System.Windows.Forms.Panel();
        tbpMenu = new MaterialSkin.Controls.MaterialTabControl();
        tabMain = new System.Windows.Forms.TabPage();
        btnOut = new System.Windows.Forms.Button();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        tabTables = new System.Windows.Forms.TabPage();
        btnCategories = new System.Windows.Forms.Button();
        btnProducts = new System.Windows.Forms.Button();
        btnCustomers = new System.Windows.Forms.Button();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        tabBilling = new System.Windows.Forms.TabPage();
        btnReports = new System.Windows.Forms.Button();
        btnInvoices = new System.Windows.Forms.Button();
        pictureBox3 = new System.Windows.Forms.PictureBox();
        tabSecurity = new System.Windows.Forms.TabPage();
        btnSecurity = new System.Windows.Forms.Button();
        btnRols = new System.Windows.Forms.Button();
        btnEmployees = new System.Windows.Forms.Button();
        pictureBox4 = new System.Windows.Forms.PictureBox();
        tabAbout = new System.Windows.Forms.TabPage();
        btnAbout = new System.Windows.Forms.Button();
        btnHelp = new System.Windows.Forms.Button();
        pictureBox5 = new System.Windows.Forms.PictureBox();
        tabMenuOptions = new MaterialSkin.Controls.MaterialTabSelector();
        pnlMain.SuspendLayout();
        pnlAside.SuspendLayout();
        tbpMenu.SuspendLayout();
        tabMain.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        tabTables.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        tabBilling.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        tabSecurity.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
        tabAbout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
        SuspendLayout();
        // 
        // pnlMain
        // 
        pnlMain.Controls.Add(pnlContainer);
        pnlMain.Controls.Add(pnlAside);
        pnlMain.Location = new System.Drawing.Point(0, 63);
        pnlMain.Name = "pnlMain";
        pnlMain.Size = new System.Drawing.Size(1200, 586);
        pnlMain.TabIndex = 0;
        // 
        // pnlContainer
        // 
        pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlContainer.Location = new System.Drawing.Point(261, 0);
        pnlContainer.Name = "pnlContainer";
        pnlContainer.Size = new System.Drawing.Size(939, 586);
        pnlContainer.TabIndex = 1;
        // 
        // pnlAside
        // 
        pnlAside.Controls.Add(tbpMenu);
        pnlAside.Dock = System.Windows.Forms.DockStyle.Left;
        pnlAside.Location = new System.Drawing.Point(0, 0);
        pnlAside.Name = "pnlAside";
        pnlAside.Size = new System.Drawing.Size(261, 586);
        pnlAside.TabIndex = 0;
        // 
        // tbpMenu
        // 
        tbpMenu.Controls.Add(tabMain);
        tbpMenu.Controls.Add(tabTables);
        tbpMenu.Controls.Add(tabBilling);
        tbpMenu.Controls.Add(tabSecurity);
        tbpMenu.Controls.Add(tabAbout);
        tbpMenu.Depth = 0;
        tbpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
        tbpMenu.Location = new System.Drawing.Point(0, 0);
        tbpMenu.MouseState = MaterialSkin.MouseState.HOVER;
        tbpMenu.Name = "tbpMenu";
        tbpMenu.SelectedIndex = 0;
        tbpMenu.Size = new System.Drawing.Size(261, 586);
        tbpMenu.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
        tbpMenu.TabIndex = 0;
        // 
        // tabMain
        // 
        tabMain.BackColor = System.Drawing.Color.Silver;
        tabMain.Controls.Add(btnOut);
        tabMain.Controls.Add(pictureBox1);
        tabMain.Location = new System.Drawing.Point(4, 24);
        tabMain.Name = "tabMain";
        tabMain.Padding = new System.Windows.Forms.Padding(3);
        tabMain.Size = new System.Drawing.Size(253, 558);
        tabMain.TabIndex = 0;
        tabMain.Text = "Pricipal";
        // 
        // btnOut
        // 
        btnOut.FlatAppearance.BorderSize = 0;
        btnOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)45)), ((int)((byte)45)), ((int)((byte)45)));
        btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnOut.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnOut.ForeColor = System.Drawing.SystemColors.ControlText;
        btnOut.Image = ((System.Drawing.Image)resources.GetObject("btnOut.Image"));
        btnOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnOut.Location = new System.Drawing.Point(1, 212);
        btnOut.Name = "btnOut";
        btnOut.Size = new System.Drawing.Size(251, 49);
        btnOut.TabIndex = 1;
        btnOut.Text = "Salir";
        btnOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        btnOut.UseVisualStyleBackColor = true;
        btnOut.Click += btnOut_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(39, 6);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(180, 180);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // tabTables
        // 
        tabTables.BackColor = System.Drawing.Color.Silver;
        tabTables.Controls.Add(btnCategories);
        tabTables.Controls.Add(btnProducts);
        tabTables.Controls.Add(btnCustomers);
        tabTables.Controls.Add(pictureBox2);
        tabTables.Location = new System.Drawing.Point(4, 24);
        tabTables.Name = "tabTables";
        tabTables.Padding = new System.Windows.Forms.Padding(3);
        tabTables.Size = new System.Drawing.Size(253, 558);
        tabTables.TabIndex = 1;
        tabTables.Text = "Admin Tablas";
        // 
        // btnCategories
        // 
        btnCategories.FlatAppearance.BorderSize = 0;
        btnCategories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)45)), ((int)((byte)45)), ((int)((byte)45)));
        btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCategories.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnCategories.ForeColor = System.Drawing.SystemColors.ControlText;
        btnCategories.Image = ((System.Drawing.Image)resources.GetObject("btnCategories.Image"));
        btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnCategories.Location = new System.Drawing.Point(1, 372);
        btnCategories.Name = "btnCategories";
        btnCategories.Size = new System.Drawing.Size(251, 49);
        btnCategories.TabIndex = 4;
        btnCategories.Text = "Categorias";
        btnCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        btnCategories.UseVisualStyleBackColor = true;
        // 
        // btnProducts
        // 
        btnProducts.FlatAppearance.BorderSize = 0;
        btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)45)), ((int)((byte)45)), ((int)((byte)45)));
        btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnProducts.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnProducts.ForeColor = System.Drawing.SystemColors.ControlText;
        btnProducts.Image = ((System.Drawing.Image)resources.GetObject("btnProducts.Image"));
        btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnProducts.Location = new System.Drawing.Point(1, 292);
        btnProducts.Name = "btnProducts";
        btnProducts.Size = new System.Drawing.Size(251, 49);
        btnProducts.TabIndex = 3;
        btnProducts.Text = "Productos";
        btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        btnProducts.UseVisualStyleBackColor = true;
        // 
        // btnCustomers
        // 
        btnCustomers.FlatAppearance.BorderSize = 0;
        btnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)45)), ((int)((byte)45)), ((int)((byte)45)));
        btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCustomers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnCustomers.ForeColor = System.Drawing.SystemColors.ControlText;
        btnCustomers.Image = ((System.Drawing.Image)resources.GetObject("btnCustomers.Image"));
        btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnCustomers.Location = new System.Drawing.Point(1, 212);
        btnCustomers.Name = "btnCustomers";
        btnCustomers.Size = new System.Drawing.Size(251, 49);
        btnCustomers.TabIndex = 2;
        btnCustomers.Text = "Clientes";
        btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        btnCustomers.UseVisualStyleBackColor = true;
        btnCustomers.Click += btnCustomers_Click;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = ((System.Drawing.Image)resources.GetObject("pictureBox2.Image"));
        pictureBox2.Location = new System.Drawing.Point(39, 6);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new System.Drawing.Size(180, 180);
        pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox2.TabIndex = 1;
        pictureBox2.TabStop = false;
        // 
        // tabBilling
        // 
        tabBilling.BackColor = System.Drawing.Color.Silver;
        tabBilling.Controls.Add(btnReports);
        tabBilling.Controls.Add(btnInvoices);
        tabBilling.Controls.Add(pictureBox3);
        tabBilling.Location = new System.Drawing.Point(4, 24);
        tabBilling.Name = "tabBilling";
        tabBilling.Size = new System.Drawing.Size(253, 558);
        tabBilling.TabIndex = 2;
        tabBilling.Text = "Facturación";
        // 
        // btnReports
        // 
        btnReports.FlatAppearance.BorderSize = 0;
        btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)45)), ((int)((byte)45)), ((int)((byte)45)));
        btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnReports.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnReports.ForeColor = System.Drawing.SystemColors.ControlText;
        btnReports.Image = ((System.Drawing.Image)resources.GetObject("btnReports.Image"));
        btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnReports.Location = new System.Drawing.Point(1, 292);
        btnReports.Name = "btnReports";
        btnReports.Size = new System.Drawing.Size(251, 49);
        btnReports.TabIndex = 4;
        btnReports.Text = "Informes";
        btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        btnReports.UseVisualStyleBackColor = true;
        // 
        // btnInvoices
        // 
        btnInvoices.FlatAppearance.BorderSize = 0;
        btnInvoices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)45)), ((int)((byte)45)), ((int)((byte)45)));
        btnInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnInvoices.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnInvoices.ForeColor = System.Drawing.SystemColors.ControlText;
        btnInvoices.Image = ((System.Drawing.Image)resources.GetObject("btnInvoices.Image"));
        btnInvoices.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnInvoices.Location = new System.Drawing.Point(1, 212);
        btnInvoices.Name = "btnInvoices";
        btnInvoices.Size = new System.Drawing.Size(251, 49);
        btnInvoices.TabIndex = 3;
        btnInvoices.Text = "Facturas";
        btnInvoices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        btnInvoices.UseVisualStyleBackColor = true;
        // 
        // pictureBox3
        // 
        pictureBox3.Image = ((System.Drawing.Image)resources.GetObject("pictureBox3.Image"));
        pictureBox3.Location = new System.Drawing.Point(39, 6);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new System.Drawing.Size(180, 180);
        pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox3.TabIndex = 1;
        pictureBox3.TabStop = false;
        // 
        // tabSecurity
        // 
        tabSecurity.BackColor = System.Drawing.Color.Silver;
        tabSecurity.Controls.Add(btnSecurity);
        tabSecurity.Controls.Add(btnRols);
        tabSecurity.Controls.Add(btnEmployees);
        tabSecurity.Controls.Add(pictureBox4);
        tabSecurity.Location = new System.Drawing.Point(4, 24);
        tabSecurity.Name = "tabSecurity";
        tabSecurity.Size = new System.Drawing.Size(253, 558);
        tabSecurity.TabIndex = 3;
        tabSecurity.Text = "Seguridad";
        // 
        // btnSecurity
        // 
        btnSecurity.FlatAppearance.BorderSize = 0;
        btnSecurity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)45)), ((int)((byte)45)), ((int)((byte)45)));
        btnSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSecurity.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnSecurity.ForeColor = System.Drawing.SystemColors.ControlText;
        btnSecurity.Image = ((System.Drawing.Image)resources.GetObject("btnSecurity.Image"));
        btnSecurity.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnSecurity.Location = new System.Drawing.Point(1, 372);
        btnSecurity.Name = "btnSecurity";
        btnSecurity.Size = new System.Drawing.Size(251, 49);
        btnSecurity.TabIndex = 7;
        btnSecurity.Text = "Seguridad";
        btnSecurity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        btnSecurity.UseVisualStyleBackColor = true;
        // 
        // btnRols
        // 
        btnRols.FlatAppearance.BorderSize = 0;
        btnRols.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)45)), ((int)((byte)45)), ((int)((byte)45)));
        btnRols.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnRols.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnRols.ForeColor = System.Drawing.SystemColors.ControlText;
        btnRols.Image = ((System.Drawing.Image)resources.GetObject("btnRols.Image"));
        btnRols.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnRols.Location = new System.Drawing.Point(1, 292);
        btnRols.Name = "btnRols";
        btnRols.Size = new System.Drawing.Size(251, 49);
        btnRols.TabIndex = 6;
        btnRols.Text = "Roles";
        btnRols.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        btnRols.UseVisualStyleBackColor = true;
        // 
        // btnEmployees
        // 
        btnEmployees.FlatAppearance.BorderSize = 0;
        btnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)45)), ((int)((byte)45)), ((int)((byte)45)));
        btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnEmployees.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnEmployees.ForeColor = System.Drawing.SystemColors.ControlText;
        btnEmployees.Image = ((System.Drawing.Image)resources.GetObject("btnEmployees.Image"));
        btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnEmployees.Location = new System.Drawing.Point(1, 212);
        btnEmployees.Name = "btnEmployees";
        btnEmployees.Size = new System.Drawing.Size(251, 49);
        btnEmployees.TabIndex = 5;
        btnEmployees.Text = "Empleados";
        btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        btnEmployees.UseVisualStyleBackColor = true;
        // 
        // pictureBox4
        // 
        pictureBox4.Image = ((System.Drawing.Image)resources.GetObject("pictureBox4.Image"));
        pictureBox4.Location = new System.Drawing.Point(39, 6);
        pictureBox4.Name = "pictureBox4";
        pictureBox4.Size = new System.Drawing.Size(180, 180);
        pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox4.TabIndex = 1;
        pictureBox4.TabStop = false;
        // 
        // tabAbout
        // 
        tabAbout.BackColor = System.Drawing.Color.Silver;
        tabAbout.Controls.Add(btnAbout);
        tabAbout.Controls.Add(btnHelp);
        tabAbout.Controls.Add(pictureBox5);
        tabAbout.Location = new System.Drawing.Point(4, 24);
        tabAbout.Name = "tabAbout";
        tabAbout.Size = new System.Drawing.Size(253, 558);
        tabAbout.TabIndex = 4;
        tabAbout.Text = "Acerca";
        // 
        // btnAbout
        // 
        btnAbout.FlatAppearance.BorderSize = 0;
        btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)45)), ((int)((byte)45)), ((int)((byte)45)));
        btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAbout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnAbout.ForeColor = System.Drawing.SystemColors.ControlText;
        btnAbout.Image = ((System.Drawing.Image)resources.GetObject("btnAbout.Image"));
        btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnAbout.Location = new System.Drawing.Point(1, 292);
        btnAbout.Name = "btnAbout";
        btnAbout.Size = new System.Drawing.Size(251, 49);
        btnAbout.TabIndex = 6;
        btnAbout.Text = "Acerca de";
        btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        btnAbout.UseVisualStyleBackColor = true;
        // 
        // btnHelp
        // 
        btnHelp.FlatAppearance.BorderSize = 0;
        btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)45)), ((int)((byte)45)), ((int)((byte)45)));
        btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnHelp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnHelp.ForeColor = System.Drawing.SystemColors.ControlText;
        btnHelp.Image = ((System.Drawing.Image)resources.GetObject("btnHelp.Image"));
        btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnHelp.Location = new System.Drawing.Point(1, 212);
        btnHelp.Name = "btnHelp";
        btnHelp.Size = new System.Drawing.Size(251, 49);
        btnHelp.TabIndex = 5;
        btnHelp.Text = "Ayuda";
        btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        btnHelp.UseVisualStyleBackColor = true;
        // 
        // pictureBox5
        // 
        pictureBox5.Image = ((System.Drawing.Image)resources.GetObject("pictureBox5.Image"));
        pictureBox5.Location = new System.Drawing.Point(39, 6);
        pictureBox5.Name = "pictureBox5";
        pictureBox5.Size = new System.Drawing.Size(180, 180);
        pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox5.TabIndex = 1;
        pictureBox5.TabStop = false;
        // 
        // tabMenuOptions
        // 
        tabMenuOptions.BaseTabControl = tbpMenu;
        tabMenuOptions.Depth = 0;
        tabMenuOptions.Location = new System.Drawing.Point(338, 30);
        tabMenuOptions.MouseState = MaterialSkin.MouseState.HOVER;
        tabMenuOptions.Name = "tabMenuOptions";
        tabMenuOptions.Size = new System.Drawing.Size(727, 27);
        tabMenuOptions.TabIndex = 1;
        // 
        // FrmMain
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1200, 650);
        Controls.Add(tabMenuOptions);
        Controls.Add(pnlMain);
        Text = "Sistema de Facturación";
        pnlMain.ResumeLayout(false);
        pnlAside.ResumeLayout(false);
        tbpMenu.ResumeLayout(false);
        tabMain.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        tabTables.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        tabBilling.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        tabSecurity.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
        tabAbout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlContainer;

    private System.Windows.Forms.Button btnAbout;
    private System.Windows.Forms.Button btnHelp;

    private System.Windows.Forms.Button btnSecurity;
    private System.Windows.Forms.Button btnRols;
    private System.Windows.Forms.Button btnEmployees;

    private System.Windows.Forms.Button btnReports;

    private System.Windows.Forms.Button btnInvoices;

    private System.Windows.Forms.Button btnProducts;
    private System.Windows.Forms.Button btnCategories;

    private System.Windows.Forms.Button btnCustomers;

    private System.Windows.Forms.Button btnOut;

    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox pictureBox4;
    private System.Windows.Forms.PictureBox pictureBox5;

    private System.Windows.Forms.PictureBox pictureBox2;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.TabPage tabMain;
    private System.Windows.Forms.TabPage tabTables;

    private System.Windows.Forms.TabPage tabAbout;
    private MaterialSkin.Controls.MaterialTabSelector tabMenuOptions;

    private System.Windows.Forms.TabPage tabSecurity;

    private MaterialSkin.Controls.MaterialTabControl tbpMenu;
    private System.Windows.Forms.TabPage tabBilling;

    private System.Windows.Forms.Panel pnlAside;

    private System.Windows.Forms.Panel pnlMain;

    #endregion
}