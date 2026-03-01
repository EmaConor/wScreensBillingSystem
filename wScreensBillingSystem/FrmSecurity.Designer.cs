using System.ComponentModel;

namespace wScreensBillingSystem
{
    partial class FrmSecurity
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
            lblTitle = new MaterialSkin.Controls.MaterialLabel();
            pnlCustomer = new Panel();
            txtKeyword = new MaterialSkin.Controls.MaterialTextBox();
            txtUser = new MaterialSkin.Controls.MaterialTextBox();
            cmbEmployee = new MaterialSkin.Controls.MaterialComboBox();
            btnConsult = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnOut = new MaterialSkin.Controls.MaterialButton();
            pnlCustomer.SuspendLayout();
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
            lblTitle.Text = "Admintración de Seguridad";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlCustomer
            // 
            pnlCustomer.Controls.Add(txtKeyword);
            pnlCustomer.Controls.Add(txtUser);
            pnlCustomer.Controls.Add(cmbEmployee);
            pnlCustomer.Location = new Point(101, 147);
            pnlCustomer.Name = "pnlCustomer";
            pnlCustomer.Size = new Size(495, 225);
            pnlCustomer.TabIndex = 1;
            // 
            // txtKeyword
            // 
            txtKeyword.AnimateReadOnly = false;
            txtKeyword.BorderStyle = BorderStyle.None;
            txtKeyword.Depth = 0;
            txtKeyword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtKeyword.Hint = "Clave";
            txtKeyword.LeadingIcon = null;
            txtKeyword.Location = new Point(41, 148);
            txtKeyword.MaxLength = 50;
            txtKeyword.MouseState = MaterialSkin.MouseState.OUT;
            txtKeyword.Multiline = false;
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(317, 36);
            txtKeyword.TabIndex = 2;
            txtKeyword.Text = "";
            txtKeyword.TrailingIcon = null;
            txtKeyword.UseTallSize = false;
            // 
            // txtUser
            // 
            txtUser.AnimateReadOnly = false;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Depth = 0;
            txtUser.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUser.Hint = "Usuario";
            txtUser.LeadingIcon = null;
            txtUser.Location = new Point(41, 106);
            txtUser.MaxLength = 50;
            txtUser.MouseState = MaterialSkin.MouseState.OUT;
            txtUser.Multiline = false;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(317, 36);
            txtUser.TabIndex = 1;
            txtUser.Text = "";
            txtUser.TrailingIcon = null;
            txtUser.UseTallSize = false;
            // 
            // cmbEmployee
            // 
            cmbEmployee.AutoResize = false;
            cmbEmployee.BackColor = Color.FromArgb(255, 255, 255);
            cmbEmployee.Depth = 0;
            cmbEmployee.DrawMode = DrawMode.OwnerDrawVariable;
            cmbEmployee.DropDownHeight = 118;
            cmbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmployee.DropDownWidth = 121;
            cmbEmployee.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbEmployee.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Hint = "Empleado";
            cmbEmployee.IntegralHeight = false;
            cmbEmployee.ItemHeight = 29;
            cmbEmployee.Location = new Point(41, 37);
            cmbEmployee.MaxDropDownItems = 4;
            cmbEmployee.MouseState = MaterialSkin.MouseState.OUT;
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(422, 35);
            cmbEmployee.StartIndex = 0;
            cmbEmployee.TabIndex = 0;
            cmbEmployee.UseTallSize = false;
            // 
            // btnConsult
            // 
            btnConsult.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConsult.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConsult.Depth = 0;
            btnConsult.HighEmphasis = true;
            btnConsult.Icon = null;
            btnConsult.Location = new Point(615, 199);
            btnConsult.Margin = new Padding(4, 6, 4, 6);
            btnConsult.MouseState = MaterialSkin.MouseState.HOVER;
            btnConsult.Name = "btnConsult";
            btnConsult.NoAccentTextColor = Color.Empty;
            btnConsult.Size = new Size(106, 36);
            btnConsult.TabIndex = 5;
            btnConsult.Text = "Consultar";
            btnConsult.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConsult.UseAccentColor = false;
            btnConsult.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(615, 241);
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
            btnDelete.Location = new Point(615, 283);
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
            // FrmSecurity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 517);
            ControlBox = false;
            Controls.Add(btnOut);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnConsult);
            Controls.Add(lblTitle);
            Controls.Add(pnlCustomer);
            Name = "FrmSecurity";
            ShowInTaskbar = false;
            pnlCustomer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private MaterialSkin.Controls.MaterialButton btnOut;

        private MaterialSkin.Controls.MaterialButton btnDelete;

        private MaterialSkin.Controls.MaterialButton btnConsult;
        private MaterialSkin.Controls.MaterialButton btnUpdate;

        private System.Windows.Forms.Panel pnlCustomer;

        private MaterialSkin.Controls.MaterialLabel lblTitle;

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtKeyword;
        private MaterialSkin.Controls.MaterialTextBox txtUser;
        private MaterialSkin.Controls.MaterialComboBox cmbEmployee;
    }
}