using System.ComponentModel;

namespace wScreensBillingSystem
{
    partial class FrmCategories
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
            txtId = new TextBox();
            txtName = new MaterialSkin.Controls.MaterialTextBox();
            pnlSearch = new Panel();
            dataGridView1 = new DataGridView();
            btnSearch = new MaterialSkin.Controls.MaterialButton();
            txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            btnNew = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnOut = new MaterialSkin.Controls.MaterialButton();
            txtDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            pnlCustomer.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
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
            lblTitle.Text = "Admintración de Categorias";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlCustomer
            // 
            pnlCustomer.Controls.Add(txtDescription);
            pnlCustomer.Controls.Add(txtId);
            pnlCustomer.Controls.Add(txtName);
            pnlCustomer.Location = new Point(129, 35);
            pnlCustomer.Name = "pnlCustomer";
            pnlCustomer.Size = new Size(425, 183);
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
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Depth = 0;
            txtName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.Hint = "Nombre Categoria";
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
            pnlSearch.Controls.Add(dataGridView1);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Location = new Point(-8, 224);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(735, 293);
            pnlSearch.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(706, 214);
            dataGridView1.TabIndex = 5;
            dataGridView1.Text = "dataGridView1";
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
            // 
            // txtSearch
            // 
            txtSearch.AnimateReadOnly = false;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Depth = 0;
            txtSearch.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearch.Hint = "Buscar Categoria";
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
            btnNew.Location = new Point(573, 74);
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
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(573, 116);
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
            btnDelete.Location = new Point(573, 158);
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
            // txtDescription
            // 
            txtDescription.AnimateReadOnly = false;
            txtDescription.BackgroundImageLayout = ImageLayout.None;
            txtDescription.CharacterCasing = CharacterCasing.Normal;
            txtDescription.Depth = 0;
            txtDescription.HideSelection = true;
            txtDescription.Hint = "Descripción";
            txtDescription.Location = new Point(37, 62);
            txtDescription.MaxLength = 32767;
            txtDescription.MouseState = MaterialSkin.MouseState.OUT;
            txtDescription.Name = "txtDescription";
            txtDescription.PasswordChar = '\0';
            txtDescription.ReadOnly = false;
            txtDescription.ScrollBars = ScrollBars.None;
            txtDescription.SelectedText = "";
            txtDescription.SelectionLength = 0;
            txtDescription.SelectionStart = 0;
            txtDescription.ShortcutsEnabled = true;
            txtDescription.Size = new Size(355, 108);
            txtDescription.TabIndex = 6;
            txtDescription.TabStop = false;
            txtDescription.TextAlign = HorizontalAlignment.Left;
            txtDescription.UseSystemPasswordChar = false;
            // 
            // FrmCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 517);
            ControlBox = false;
            Controls.Add(btnOut);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(pnlSearch);
            Controls.Add(lblTitle);
            Controls.Add(pnlCustomer);
            Name = "FrmCategories";
            ShowInTaskbar = false;
            pnlCustomer.ResumeLayout(false);
            pnlCustomer.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private MaterialSkin.Controls.MaterialButton btnOut;

        private System.Windows.Forms.DataGridView dataGridView1;

        private MaterialSkin.Controls.MaterialButton btnSearch;

        private MaterialSkin.Controls.MaterialButton btnDelete;

        private MaterialSkin.Controls.MaterialButton btnNew;
        private MaterialSkin.Controls.MaterialButton btnUpdate;

        private System.Windows.Forms.Panel pnlSearch;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;

        private MaterialSkin.Controls.MaterialTextBox txtName;

        private System.Windows.Forms.Panel pnlCustomer;

        private MaterialSkin.Controls.MaterialLabel lblTitle;

        #endregion

        private TextBox txtId;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescription;
    }
}