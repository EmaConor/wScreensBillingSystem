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
            pnlSearch = new Panel();
            dgvCategories = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            btnSearch = new MaterialSkin.Controls.MaterialButton();
            txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            btnNew = new MaterialSkin.Controls.MaterialButton();
            btnOut = new MaterialSkin.Controls.MaterialButton();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            pnlSearch.SuspendLayout();
            ((ISupportInitialize)dgvCategories).BeginInit();
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
            // pnlSearch
            // 
            pnlSearch.Controls.Add(dgvCategories);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(btnNew);
            pnlSearch.Location = new Point(-8, 49);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(735, 468);
            pnlSearch.TabIndex = 2;
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Columns.AddRange(new DataGridViewColumn[] { id, description, edit, delete });
            dgvCategories.Location = new Point(13, 67);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.Size = new Size(706, 386);
            dgvCategories.TabIndex = 5;
            dgvCategories.Text = "dataGridView1";
            dgvCategories.CellContentClick += dgvCategories_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // description
            // 
            description.HeaderText = "Descripcion";
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // edit
            // 
            edit.HeaderText = "Editar";
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Text = "Editar";
            edit.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            delete.HeaderText = "Eliminar";
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Text = "Eliminar";
            delete.UseColumnTextForButtonValue = true;
            // 
            // btnSearch
            // 
            btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSearch.Depth = 0;
            btnSearch.HighEmphasis = true;
            btnSearch.Icon = null;
            btnSearch.Location = new Point(452, 22);
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
            txtSearch.Hint = "Buscar Categoria";
            txtSearch.LeadingIcon = null;
            txtSearch.Location = new Point(24, 14);
            txtSearch.MaxLength = 32767;
            txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(419, 50);
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
            // FrmCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 517);
            ControlBox = false;
            Controls.Add(btnClear);
            Controls.Add(btnOut);
            Controls.Add(pnlSearch);
            Controls.Add(lblTitle);
            Name = "FrmCategories";
            ShowInTaskbar = false;
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private MaterialSkin.Controls.MaterialButton btnOut;

        private System.Windows.Forms.DataGridView dgvCategories;

        private MaterialSkin.Controls.MaterialButton btnSearch;

        private MaterialSkin.Controls.MaterialButton btnNew;

        private System.Windows.Forms.Panel pnlSearch;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;

        private MaterialSkin.Controls.MaterialLabel lblTitle;

        #endregion
        private MaterialSkin.Controls.MaterialButton btnClear;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn description;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
    }
}