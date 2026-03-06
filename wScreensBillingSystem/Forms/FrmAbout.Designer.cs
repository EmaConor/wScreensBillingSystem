using System.ComponentModel;

namespace wScreensBillingSystem
{
    partial class FrmAbout
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmAbout));
            lblTitle = new MaterialSkin.Controls.MaterialLabel();
            lblInfo = new MaterialSkin.Controls.MaterialLabel();
            divider = new MaterialSkin.Controls.MaterialDivider();
            btnOut = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Depth = 0;
            lblTitle.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitle.Location = new Point(200, 80);
            lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SISTEMA DE FACTURACIÓN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            lblInfo.Depth = 0;
            lblInfo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblInfo.Location = new Point(150, 140);
            lblInfo.MouseState = MaterialSkin.MouseState.HOVER;
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(500, 243);
            lblInfo.TabIndex = 2;
            lblInfo.Text = resources.GetString("lblInfo.Text");
            lblInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // divider
            // 
            divider.BackColor = Color.FromArgb(30, 0, 0, 0);
            divider.Depth = 0;
            divider.Location = new Point(150, 120);
            divider.MouseState = MaterialSkin.MouseState.HOVER;
            divider.Name = "divider";
            divider.Size = new Size(500, 1);
            divider.TabIndex = 1;
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
            // FrmAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 517);
            ControlBox = false;
            Controls.Add(btnOut);
            Controls.Add(lblInfo);
            Controls.Add(divider);
            Controls.Add(lblTitle);
            Name = "FrmAbout";
            ShowInTaskbar = false;
            Text = "Acerca de...";
            ResumeLayout(false);
            PerformLayout();
        }

        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialLabel lblInfo;
        private MaterialSkin.Controls.MaterialDivider divider;
        private MaterialSkin.Controls.MaterialButton btnOut;

        #endregion
    }
}