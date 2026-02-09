namespace wScreensBillingSystem;

partial class FrmLogin
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
        panel1 = new System.Windows.Forms.Panel();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        lblTitle = new MaterialSkin.Controls.MaterialLabel();
        txtUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
        txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
        btnVerify = new MaterialSkin.Controls.MaterialRaisedButton();
        btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.Pink;
        panel1.Controls.Add(pictureBox1);
        panel1.Dock = System.Windows.Forms.DockStyle.Left;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(190, 354);
        panel1.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(43, 48);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(98, 92);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // lblTitle
        // 
        lblTitle.Depth = 0;
        lblTitle.Font = new System.Drawing.Font("Roboto", 11F);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)222)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
        lblTitle.Location = new System.Drawing.Point(366, 48);
        lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(115, 24);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Validar Usuario";
        // 
        // txtUser
        // 
        txtUser.Depth = 0;
        txtUser.Hint = "Usuario";
        txtUser.Location = new System.Drawing.Point(260, 130);
        txtUser.MaxLength = 32767;
        txtUser.MouseState = MaterialSkin.MouseState.HOVER;
        txtUser.Name = "txtUser";
        txtUser.PasswordChar = '\0';
        txtUser.SelectedText = "";
        txtUser.SelectionLength = 0;
        txtUser.SelectionStart = 0;
        txtUser.Size = new System.Drawing.Size(325, 23);
        txtUser.TabIndex = 2;
        txtUser.TabStop = false;
        txtUser.UseSystemPasswordChar = false;
        // 
        // txtPassword
        // 
        txtPassword.Depth = 0;
        txtPassword.Hint = "Contraseña";
        txtPassword.Location = new System.Drawing.Point(260, 179);
        txtPassword.MaxLength = 32767;
        txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '•';
        txtPassword.SelectedText = "";
        txtPassword.SelectionLength = 0;
        txtPassword.SelectionStart = 0;
        txtPassword.Size = new System.Drawing.Size(325, 23);
        txtPassword.TabIndex = 3;
        txtPassword.TabStop = false;
        txtPassword.UseSystemPasswordChar = false;
        // 
        // btnVerify
        // 
        btnVerify.AutoSize = true;
        btnVerify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        btnVerify.Depth = 0;
        btnVerify.ForeColor = System.Drawing.SystemColors.ControlText;
        btnVerify.Icon = null;
        btnVerify.Location = new System.Drawing.Point(299, 246);
        btnVerify.MouseState = MaterialSkin.MouseState.HOVER;
        btnVerify.Name = "btnVerify";
        btnVerify.Primary = true;
        btnVerify.Size = new System.Drawing.Size(77, 36);
        btnVerify.TabIndex = 4;
        btnVerify.Text = "Validar";
        btnVerify.UseVisualStyleBackColor = true;
        btnVerify.Click += btnVerify_Click;
        // 
        // btnCancel
        // 
        btnCancel.AutoSize = true;
        btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        btnCancel.Depth = 0;
        btnCancel.Icon = null;
        btnCancel.Location = new System.Drawing.Point(448, 246);
        btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
        btnCancel.Name = "btnCancel";
        btnCancel.Primary = true;
        btnCancel.Size = new System.Drawing.Size(91, 36);
        btnCancel.TabIndex = 5;
        btnCancel.Text = "Cancelar";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // FrmLogin
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Gainsboro;
        ClientSize = new System.Drawing.Size(674, 354);
        Controls.Add(btnCancel);
        Controls.Add(btnVerify);
        Controls.Add(txtPassword);
        Controls.Add(txtUser);
        Controls.Add(lblTitle);
        Controls.Add(panel1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Form1";
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private MaterialSkin.Controls.MaterialRaisedButton btnVerify;
    private MaterialSkin.Controls.MaterialRaisedButton btnCancel;

    private MaterialSkin.Controls.MaterialSingleLineTextField txtUser;
    private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;

    private MaterialSkin.Controls.MaterialLabel lblTitle;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Panel panel1;
    
    #endregion
}