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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmMain));
        pnlMain = new Panel();
        pnlContainer = new Panel();
        pnlAside = new Panel();
        tbpMenu = new MaterialSkin.Controls.MaterialTabControl();
        tabMain = new TabPage();
        btnOut = new Button();
        pictureBox1 = new PictureBox();
        tabTables = new TabPage();
        btnCategories = new Button();
        btnProducts = new Button();
        btnCustomers = new Button();
        pictureBox2 = new PictureBox();
        tabBilling = new TabPage();
        btnReports = new Button();
        btnInvoices = new Button();
        pictureBox3 = new PictureBox();
        tabSecurity = new TabPage();
        btnSecurity = new Button();
        btnRols = new Button();
        btnEmployees = new Button();
        pictureBox4 = new PictureBox();
        tabAbout = new TabPage();
        btnAbout = new Button();
        btnHelp = new Button();
        pictureBox5 = new PictureBox();
        tabMenuOptions = new MaterialSkin.Controls.MaterialTabSelector();
        pnlMain.SuspendLayout();
        pnlAside.SuspendLayout();
        tbpMenu.SuspendLayout();
        tabMain.SuspendLayout();
        ((ISupportInitialize)pictureBox1).BeginInit();
        tabTables.SuspendLayout();
        ((ISupportInitialize)pictureBox2).BeginInit();
        tabBilling.SuspendLayout();
        ((ISupportInitialize)pictureBox3).BeginInit();
        tabSecurity.SuspendLayout();
        ((ISupportInitialize)pictureBox4).BeginInit();
        tabAbout.SuspendLayout();
        ((ISupportInitialize)pictureBox5).BeginInit();
        SuspendLayout();
        // 
        // pnlMain
        // 
        pnlMain.Controls.Add(pnlContainer);
        pnlMain.Controls.Add(pnlAside);
        pnlMain.Location = new Point(0, 63);
        pnlMain.Name = "pnlMain";
        pnlMain.Size = new Size(1200, 586);
        pnlMain.TabIndex = 0;
        // 
        // pnlContainer
        // 
        pnlContainer.Dock = DockStyle.Fill;
        pnlContainer.Location = new Point(261, 0);
        pnlContainer.Name = "pnlContainer";
        pnlContainer.Size = new Size(939, 586);
        pnlContainer.TabIndex = 1;
        // 
        // pnlAside
        // 
        pnlAside.Controls.Add(tbpMenu);
        pnlAside.Dock = DockStyle.Left;
        pnlAside.Location = new Point(0, 0);
        pnlAside.Name = "pnlAside";
        pnlAside.Size = new Size(261, 586);
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
        tbpMenu.Dock = DockStyle.Fill;
        tbpMenu.Location = new Point(0, 0);
        tbpMenu.MouseState = MaterialSkin.MouseState.HOVER;
        tbpMenu.Multiline = true;
        tbpMenu.Name = "tbpMenu";
        tbpMenu.SelectedIndex = 0;
        tbpMenu.Size = new Size(261, 586);
        tbpMenu.SizeMode = TabSizeMode.FillToRight;
        tbpMenu.TabIndex = 0;
        // 
        // tabMain
        // 
        tabMain.BackColor = Color.Silver;
        tabMain.Controls.Add(btnOut);
        tabMain.Controls.Add(pictureBox1);
        tabMain.Location = new Point(4, 44);
        tabMain.Name = "tabMain";
        tabMain.Padding = new Padding(3);
        tabMain.Size = new Size(253, 538);
        tabMain.TabIndex = 0;
        tabMain.Text = "Pricipal";
        // 
        // btnOut
        // 
        btnOut.FlatAppearance.BorderSize = 0;
        btnOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
        btnOut.FlatStyle = FlatStyle.Flat;
        btnOut.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnOut.ForeColor = SystemColors.ControlText;
        btnOut.Image = (Image)resources.GetObject("btnOut.Image");
        btnOut.ImageAlign = ContentAlignment.MiddleRight;
        btnOut.Location = new Point(1, 212);
        btnOut.Name = "btnOut";
        btnOut.Size = new Size(251, 49);
        btnOut.TabIndex = 1;
        btnOut.Text = "Salir";
        btnOut.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnOut.UseVisualStyleBackColor = true;
        btnOut.Click += btnOut_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(39, 6);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(180, 180);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // tabTables
        // 
        tabTables.BackColor = Color.Silver;
        tabTables.Controls.Add(btnCategories);
        tabTables.Controls.Add(btnProducts);
        tabTables.Controls.Add(btnCustomers);
        tabTables.Controls.Add(pictureBox2);
        tabTables.Location = new Point(4, 44);
        tabTables.Name = "tabTables";
        tabTables.Padding = new Padding(3);
        tabTables.Size = new Size(253, 538);
        tabTables.TabIndex = 1;
        tabTables.Text = "Admin Tablas";
        // 
        // btnCategories
        // 
        btnCategories.FlatAppearance.BorderSize = 0;
        btnCategories.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
        btnCategories.FlatStyle = FlatStyle.Flat;
        btnCategories.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnCategories.ForeColor = SystemColors.ControlText;
        btnCategories.Image = (Image)resources.GetObject("btnCategories.Image");
        btnCategories.ImageAlign = ContentAlignment.MiddleRight;
        btnCategories.Location = new Point(1, 372);
        btnCategories.Name = "btnCategories";
        btnCategories.Size = new Size(251, 49);
        btnCategories.TabIndex = 4;
        btnCategories.Text = "Categorias";
        btnCategories.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnCategories.UseVisualStyleBackColor = true;
        btnCategories.Click += btnCategories_Click;
        // 
        // btnProducts
        // 
        btnProducts.FlatAppearance.BorderSize = 0;
        btnProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
        btnProducts.FlatStyle = FlatStyle.Flat;
        btnProducts.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnProducts.ForeColor = SystemColors.ControlText;
        btnProducts.Image = (Image)resources.GetObject("btnProducts.Image");
        btnProducts.ImageAlign = ContentAlignment.MiddleRight;
        btnProducts.Location = new Point(1, 292);
        btnProducts.Name = "btnProducts";
        btnProducts.Size = new Size(251, 49);
        btnProducts.TabIndex = 3;
        btnProducts.Text = "Productos";
        btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnProducts.UseVisualStyleBackColor = true;
        btnProducts.Click += btnProducts_Click;
        // 
        // btnCustomers
        // 
        btnCustomers.FlatAppearance.BorderSize = 0;
        btnCustomers.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
        btnCustomers.FlatStyle = FlatStyle.Flat;
        btnCustomers.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnCustomers.ForeColor = SystemColors.ControlText;
        btnCustomers.Image = (Image)resources.GetObject("btnCustomers.Image");
        btnCustomers.ImageAlign = ContentAlignment.MiddleRight;
        btnCustomers.Location = new Point(1, 212);
        btnCustomers.Name = "btnCustomers";
        btnCustomers.Size = new Size(251, 49);
        btnCustomers.TabIndex = 2;
        btnCustomers.Text = "Clientes";
        btnCustomers.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnCustomers.UseVisualStyleBackColor = true;
        btnCustomers.Click += btnCustomers_Click;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
        pictureBox2.Location = new Point(39, 6);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(180, 180);
        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox2.TabIndex = 1;
        pictureBox2.TabStop = false;
        // 
        // tabBilling
        // 
        tabBilling.BackColor = Color.Silver;
        tabBilling.Controls.Add(btnReports);
        tabBilling.Controls.Add(btnInvoices);
        tabBilling.Controls.Add(pictureBox3);
        tabBilling.Location = new Point(4, 44);
        tabBilling.Name = "tabBilling";
        tabBilling.Size = new Size(253, 538);
        tabBilling.TabIndex = 2;
        tabBilling.Text = "Facturación";
        // 
        // btnReports
        // 
        btnReports.FlatAppearance.BorderSize = 0;
        btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
        btnReports.FlatStyle = FlatStyle.Flat;
        btnReports.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnReports.ForeColor = SystemColors.ControlText;
        btnReports.Image = (Image)resources.GetObject("btnReports.Image");
        btnReports.ImageAlign = ContentAlignment.MiddleRight;
        btnReports.Location = new Point(1, 292);
        btnReports.Name = "btnReports";
        btnReports.Size = new Size(251, 49);
        btnReports.TabIndex = 4;
        btnReports.Text = "Informes";
        btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnReports.UseVisualStyleBackColor = true;
        btnReports.Click += btnReports_Click;
        // 
        // btnInvoices
        // 
        btnInvoices.FlatAppearance.BorderSize = 0;
        btnInvoices.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
        btnInvoices.FlatStyle = FlatStyle.Flat;
        btnInvoices.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnInvoices.ForeColor = SystemColors.ControlText;
        btnInvoices.Image = (Image)resources.GetObject("btnInvoices.Image");
        btnInvoices.ImageAlign = ContentAlignment.MiddleRight;
        btnInvoices.Location = new Point(1, 212);
        btnInvoices.Name = "btnInvoices";
        btnInvoices.Size = new Size(251, 49);
        btnInvoices.TabIndex = 3;
        btnInvoices.Text = "Facturas";
        btnInvoices.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnInvoices.UseVisualStyleBackColor = true;
        btnInvoices.Click += btnInvoices_Click;
        // 
        // pictureBox3
        // 
        pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
        pictureBox3.Location = new Point(39, 6);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(180, 180);
        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox3.TabIndex = 1;
        pictureBox3.TabStop = false;
        // 
        // tabSecurity
        // 
        tabSecurity.BackColor = Color.Silver;
        tabSecurity.Controls.Add(btnSecurity);
        tabSecurity.Controls.Add(btnRols);
        tabSecurity.Controls.Add(btnEmployees);
        tabSecurity.Controls.Add(pictureBox4);
        tabSecurity.Location = new Point(4, 44);
        tabSecurity.Name = "tabSecurity";
        tabSecurity.Size = new Size(253, 538);
        tabSecurity.TabIndex = 3;
        tabSecurity.Text = "Seguridad";
        // 
        // btnSecurity
        // 
        btnSecurity.FlatAppearance.BorderSize = 0;
        btnSecurity.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
        btnSecurity.FlatStyle = FlatStyle.Flat;
        btnSecurity.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSecurity.ForeColor = SystemColors.ControlText;
        btnSecurity.Image = (Image)resources.GetObject("btnSecurity.Image");
        btnSecurity.ImageAlign = ContentAlignment.MiddleRight;
        btnSecurity.Location = new Point(1, 372);
        btnSecurity.Name = "btnSecurity";
        btnSecurity.Size = new Size(251, 49);
        btnSecurity.TabIndex = 7;
        btnSecurity.Text = "Seguridad";
        btnSecurity.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnSecurity.UseVisualStyleBackColor = true;
        btnSecurity.Click += btnSecurity_Click;
        // 
        // btnRols
        // 
        btnRols.FlatAppearance.BorderSize = 0;
        btnRols.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
        btnRols.FlatStyle = FlatStyle.Flat;
        btnRols.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnRols.ForeColor = SystemColors.ControlText;
        btnRols.Image = (Image)resources.GetObject("btnRols.Image");
        btnRols.ImageAlign = ContentAlignment.MiddleRight;
        btnRols.Location = new Point(1, 292);
        btnRols.Name = "btnRols";
        btnRols.Size = new Size(251, 49);
        btnRols.TabIndex = 6;
        btnRols.Text = "Roles";
        btnRols.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnRols.UseVisualStyleBackColor = true;
        btnRols.Click += btnRols_Click;
        // 
        // btnEmployees
        // 
        btnEmployees.FlatAppearance.BorderSize = 0;
        btnEmployees.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
        btnEmployees.FlatStyle = FlatStyle.Flat;
        btnEmployees.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnEmployees.ForeColor = SystemColors.ControlText;
        btnEmployees.Image = (Image)resources.GetObject("btnEmployees.Image");
        btnEmployees.ImageAlign = ContentAlignment.MiddleRight;
        btnEmployees.Location = new Point(1, 212);
        btnEmployees.Name = "btnEmployees";
        btnEmployees.Size = new Size(251, 49);
        btnEmployees.TabIndex = 5;
        btnEmployees.Text = "Empleados";
        btnEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnEmployees.UseVisualStyleBackColor = true;
        btnEmployees.Click += btnEmployees_Click;
        // 
        // pictureBox4
        // 
        pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
        pictureBox4.Location = new Point(39, 6);
        pictureBox4.Name = "pictureBox4";
        pictureBox4.Size = new Size(180, 180);
        pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox4.TabIndex = 1;
        pictureBox4.TabStop = false;
        // 
        // tabAbout
        // 
        tabAbout.BackColor = Color.Silver;
        tabAbout.Controls.Add(btnAbout);
        tabAbout.Controls.Add(btnHelp);
        tabAbout.Controls.Add(pictureBox5);
        tabAbout.Location = new Point(4, 44);
        tabAbout.Name = "tabAbout";
        tabAbout.Size = new Size(253, 538);
        tabAbout.TabIndex = 4;
        tabAbout.Text = "Acerca";
        // 
        // btnAbout
        // 
        btnAbout.FlatAppearance.BorderSize = 0;
        btnAbout.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
        btnAbout.FlatStyle = FlatStyle.Flat;
        btnAbout.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnAbout.ForeColor = SystemColors.ControlText;
        btnAbout.Image = (Image)resources.GetObject("btnAbout.Image");
        btnAbout.ImageAlign = ContentAlignment.MiddleRight;
        btnAbout.Location = new Point(1, 292);
        btnAbout.Name = "btnAbout";
        btnAbout.Size = new Size(251, 49);
        btnAbout.TabIndex = 6;
        btnAbout.Text = "Acerca de";
        btnAbout.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnAbout.UseVisualStyleBackColor = true;
        btnAbout.Click += btnAbout_Click;
        // 
        // btnHelp
        // 
        btnHelp.FlatAppearance.BorderSize = 0;
        btnHelp.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
        btnHelp.FlatStyle = FlatStyle.Flat;
        btnHelp.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnHelp.ForeColor = SystemColors.ControlText;
        btnHelp.Image = (Image)resources.GetObject("btnHelp.Image");
        btnHelp.ImageAlign = ContentAlignment.MiddleRight;
        btnHelp.Location = new Point(1, 212);
        btnHelp.Name = "btnHelp";
        btnHelp.Size = new Size(251, 49);
        btnHelp.TabIndex = 5;
        btnHelp.Text = "Ayuda";
        btnHelp.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnHelp.UseVisualStyleBackColor = true;
        btnHelp.Click += btnHelp_Click;
        // 
        // pictureBox5
        // 
        pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
        pictureBox5.Location = new Point(39, 6);
        pictureBox5.Name = "pictureBox5";
        pictureBox5.Size = new Size(180, 180);
        pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox5.TabIndex = 1;
        pictureBox5.TabStop = false;
        // 
        // tabMenuOptions
        // 
        tabMenuOptions.BaseTabControl = tbpMenu;
        tabMenuOptions.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
        tabMenuOptions.Depth = 0;
        tabMenuOptions.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        tabMenuOptions.Location = new Point(302, 30);
        tabMenuOptions.MouseState = MaterialSkin.MouseState.HOVER;
        tabMenuOptions.Name = "tabMenuOptions";
        tabMenuOptions.Size = new Size(855, 27);
        tabMenuOptions.TabIndex = 1;
        // 
        // FrmMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1200, 650);
        Controls.Add(tabMenuOptions);
        Controls.Add(pnlMain);
        Name = "FrmMain";
        Sizable = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Sistema de Facturación";
        pnlMain.ResumeLayout(false);
        pnlAside.ResumeLayout(false);
        tbpMenu.ResumeLayout(false);
        tabMain.ResumeLayout(false);
        ((ISupportInitialize)pictureBox1).EndInit();
        tabTables.ResumeLayout(false);
        ((ISupportInitialize)pictureBox2).EndInit();
        tabBilling.ResumeLayout(false);
        ((ISupportInitialize)pictureBox3).EndInit();
        tabSecurity.ResumeLayout(false);
        ((ISupportInitialize)pictureBox4).EndInit();
        tabAbout.ResumeLayout(false);
        ((ISupportInitialize)pictureBox5).EndInit();
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