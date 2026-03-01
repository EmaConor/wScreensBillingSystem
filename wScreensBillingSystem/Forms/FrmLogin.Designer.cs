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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
        panel1 = new Panel();
        pictureBox1 = new PictureBox();
        lblTitle = new MaterialSkin.Controls.MaterialLabel();
        txtUser = new MaterialSkin.Controls.MaterialTextBox();
        txtPassword = new MaterialSkin.Controls.MaterialTextBox();
        btnVerify = new MaterialSkin.Controls.MaterialButton();
        btnCancel = new MaterialSkin.Controls.MaterialButton();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.Pink;
        panel1.Controls.Add(pictureBox1);
        panel1.Dock = DockStyle.Left;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(190, 354);
        panel1.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(43, 48);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(98, 92);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // lblTitle
        // 
        lblTitle.Depth = 0;
        lblTitle.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        lblTitle.ForeColor = Color.FromArgb(222, 0, 0, 0);
        lblTitle.Location = new Point(366, 48);
        lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(115, 24);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Validar Usuario";
        // 
        // txtUser
        // 
        txtUser.AnimateReadOnly = false;
        txtUser.BorderStyle = BorderStyle.None;
        txtUser.Depth = 0;
        txtUser.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        txtUser.Hint = "Usuario";
        txtUser.LeadingIcon = null;
        txtUser.Location = new Point(260, 119);
        txtUser.MaxLength = 32767;
        txtUser.MouseState = MaterialSkin.MouseState.OUT;
        txtUser.Multiline = false;
        txtUser.Name = "txtUser";
        txtUser.Size = new Size(325, 50);
        txtUser.TabIndex = 2;
        txtUser.Text = "";
        txtUser.TrailingIcon = null;
        // 
        // txtPassword
        // 
        txtPassword.AnimateReadOnly = false;
        txtPassword.BorderStyle = BorderStyle.None;
        txtPassword.Depth = 0;
        txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        txtPassword.Hint = "Contraseña";
        txtPassword.LeadingIcon = null;
        txtPassword.Location = new Point(260, 179);
        txtPassword.MaxLength = 32767;
        txtPassword.MouseState = MaterialSkin.MouseState.OUT;
        txtPassword.Multiline = false;
        txtPassword.Name = "txtPassword";
        txtPassword.Password = true;
        txtPassword.Size = new Size(325, 50);
        txtPassword.TabIndex = 3;
        txtPassword.Text = "";
        txtPassword.TrailingIcon = null;
        // 
        // btnVerify
        // 
        btnVerify.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnVerify.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnVerify.Depth = 0;
        btnVerify.ForeColor = SystemColors.ControlText;
        btnVerify.HighEmphasis = true;
        btnVerify.Icon = null;
        btnVerify.Location = new Point(299, 246);
        btnVerify.Margin = new Padding(4, 6, 4, 6);
        btnVerify.MouseState = MaterialSkin.MouseState.HOVER;
        btnVerify.Name = "btnVerify";
        btnVerify.NoAccentTextColor = Color.Empty;
        btnVerify.Size = new Size(81, 36);
        btnVerify.TabIndex = 4;
        btnVerify.Text = "Validar";
        btnVerify.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        btnVerify.UseAccentColor = false;
        btnVerify.UseVisualStyleBackColor = true;
        btnVerify.Click += btnVerify_Click;
        // 
        // btnCancel
        // 
        btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnCancel.Depth = 0;
        btnCancel.HighEmphasis = true;
        btnCancel.Icon = null;
        btnCancel.Location = new Point(448, 246);
        btnCancel.Margin = new Padding(4, 6, 4, 6);
        btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
        btnCancel.Name = "btnCancel";
        btnCancel.NoAccentTextColor = Color.Empty;
        btnCancel.Size = new Size(96, 36);
        btnCancel.TabIndex = 5;
        btnCancel.Text = "Cancelar";
        btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
        btnCancel.UseAccentColor = false;
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // FrmLogin
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Gainsboro;
        ClientSize = new Size(674, 354);
        Controls.Add(btnCancel);
        Controls.Add(btnVerify);
        Controls.Add(txtPassword);
        Controls.Add(txtUser);
        Controls.Add(lblTitle);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FrmLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private MaterialSkin.Controls.MaterialButton btnVerify;
    private MaterialSkin.Controls.MaterialButton btnCancel;

    private MaterialSkin.Controls.MaterialTextBox txtUser;
    private MaterialSkin.Controls.MaterialTextBox txtPassword;

    private MaterialSkin.Controls.MaterialLabel lblTitle;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}