using System.ComponentModel;

namespace wScreensBillingSystem
{
    partial class FrmEmployees
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
            pnlEmployee = new Panel();
            txtInfo = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            lblOffboarding = new Label();
            lblOnboarding = new Label();
            dtpOffboarding = new DateTimePicker();
            dtpOnboarding = new DateTimePicker();
            cmbRol = new MaterialSkin.Controls.MaterialComboBox();
            txtId = new TextBox();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            txtPhone = new MaterialSkin.Controls.MaterialTextBox();
            txtAddress = new MaterialSkin.Controls.MaterialTextBox();
            txtDoc = new MaterialSkin.Controls.MaterialTextBox();
            txtName = new MaterialSkin.Controls.MaterialTextBox();
            pnlSearch = new Panel();
            dgvEmployees = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nameEmployee = new DataGridViewTextBoxColumn();
            document = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            idRol = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            dateOnboarding = new DataGridViewTextBoxColumn();
            dateOffboarding = new DataGridViewTextBoxColumn();
            datos = new DataGridViewTextBoxColumn();
            btnSearch = new MaterialSkin.Controls.MaterialButton();
            txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            btnNew = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnOut = new MaterialSkin.Controls.MaterialButton();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            pnlEmployee.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((ISupportInitialize)dgvEmployees).BeginInit();
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
            lblTitle.Text = "Admintración de Empleados";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlEmployee
            // 
            pnlEmployee.Controls.Add(txtInfo);
            pnlEmployee.Controls.Add(lblOffboarding);
            pnlEmployee.Controls.Add(lblOnboarding);
            pnlEmployee.Controls.Add(dtpOffboarding);
            pnlEmployee.Controls.Add(dtpOnboarding);
            pnlEmployee.Controls.Add(cmbRol);
            pnlEmployee.Controls.Add(txtId);
            pnlEmployee.Controls.Add(txtEmail);
            pnlEmployee.Controls.Add(txtPhone);
            pnlEmployee.Controls.Add(txtAddress);
            pnlEmployee.Controls.Add(txtDoc);
            pnlEmployee.Controls.Add(txtName);
            pnlEmployee.Location = new Point(16, 35);
            pnlEmployee.Name = "pnlEmployee";
            pnlEmployee.Size = new Size(656, 213);
            pnlEmployee.TabIndex = 1;
            // 
            // txtInfo
            // 
            txtInfo.AnimateReadOnly = false;
            txtInfo.BackgroundImageLayout = ImageLayout.None;
            txtInfo.CharacterCasing = CharacterCasing.Normal;
            txtInfo.Depth = 0;
            txtInfo.HideSelection = true;
            txtInfo.Hint = "Datos Adicionales";
            txtInfo.Location = new Point(382, 150);
            txtInfo.MaxLength = 32767;
            txtInfo.MouseState = MaterialSkin.MouseState.OUT;
            txtInfo.Name = "txtInfo";
            txtInfo.PasswordChar = '\0';
            txtInfo.ReadOnly = false;
            txtInfo.ScrollBars = ScrollBars.None;
            txtInfo.SelectedText = "";
            txtInfo.SelectionLength = 0;
            txtInfo.SelectionStart = 0;
            txtInfo.ShortcutsEnabled = true;
            txtInfo.Size = new Size(256, 59);
            txtInfo.TabIndex = 11;
            txtInfo.TabStop = false;
            txtInfo.TextAlign = HorizontalAlignment.Left;
            txtInfo.UseSystemPasswordChar = false;
            // 
            // lblOffboarding
            // 
            lblOffboarding.AutoSize = true;
            lblOffboarding.Location = new Point(381, 99);
            lblOffboarding.Name = "lblOffboarding";
            lblOffboarding.Size = new Size(38, 15);
            lblOffboarding.TabIndex = 10;
            lblOffboarding.Text = "Retiro";
            // 
            // lblOnboarding
            // 
            lblOnboarding.AutoSize = true;
            lblOnboarding.Location = new Point(381, 51);
            lblOnboarding.Name = "lblOnboarding";
            lblOnboarding.Size = new Size(46, 15);
            lblOnboarding.TabIndex = 9;
            lblOnboarding.Text = "Ingreso";
            // 
            // dtpOffboarding
            // 
            dtpOffboarding.Location = new Point(381, 117);
            dtpOffboarding.Name = "dtpOffboarding";
            dtpOffboarding.Size = new Size(256, 23);
            dtpOffboarding.TabIndex = 8;
            // 
            // dtpOnboarding
            // 
            dtpOnboarding.Location = new Point(381, 69);
            dtpOnboarding.Name = "dtpOnboarding";
            dtpOnboarding.Size = new Size(256, 23);
            dtpOnboarding.TabIndex = 7;
            // 
            // cmbRol
            // 
            cmbRol.AutoResize = false;
            cmbRol.BackColor = Color.FromArgb(255, 255, 255);
            cmbRol.Depth = 0;
            cmbRol.DrawMode = DrawMode.OwnerDrawVariable;
            cmbRol.DropDownHeight = 118;
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.DropDownWidth = 121;
            cmbRol.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbRol.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbRol.FormattingEnabled = true;
            cmbRol.Hint = "Rol Empleado";
            cmbRol.IntegralHeight = false;
            cmbRol.ItemHeight = 29;
            cmbRol.Location = new Point(381, 9);
            cmbRol.MaxDropDownItems = 4;
            cmbRol.MouseState = MaterialSkin.MouseState.OUT;
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(256, 35);
            cmbRol.StartIndex = 0;
            cmbRol.TabIndex = 6;
            cmbRol.UseTallSize = false;
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
            txtEmail.Size = new Size(329, 36);
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
            txtPhone.Size = new Size(329, 36);
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
            txtAddress.Size = new Size(329, 36);
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
            txtDoc.Size = new Size(329, 36);
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
            txtName.Hint = "Nombre Empleado";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(35, 9);
            txtName.MaxLength = 32767;
            txtName.MouseState = MaterialSkin.MouseState.OUT;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Size = new Size(329, 36);
            txtName.TabIndex = 0;
            txtName.Text = "";
            txtName.TrailingIcon = null;
            txtName.UseTallSize = false;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(dgvEmployees);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Location = new Point(-8, 254);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(735, 263);
            pnlSearch.TabIndex = 2;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Columns.AddRange(new DataGridViewColumn[] { id, nameEmployee, document, address, phone, email, idRol, rol, dateOnboarding, dateOffboarding, datos });
            dgvEmployees.Location = new Point(13, 67);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.Size = new Size(706, 184);
            dgvEmployees.TabIndex = 5;
            dgvEmployees.Text = "dataGridView1";
            dgvEmployees.CellClick += dgvEmployees_CellClick;
            dgvEmployees.MouseDown += dgvEmployees_MouseDown;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // nameEmployee
            // 
            nameEmployee.HeaderText = "Nombre";
            nameEmployee.Name = "nameEmployee";
            nameEmployee.ReadOnly = true;
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
            // idRol
            // 
            idRol.HeaderText = "ID Rol";
            idRol.Name = "idRol";
            idRol.ReadOnly = true;
            idRol.Visible = false;
            // 
            // rol
            // 
            rol.HeaderText = "Rol";
            rol.Name = "rol";
            rol.ReadOnly = true;
            // 
            // dateOnboarding
            // 
            dateOnboarding.HeaderText = "Ingreso";
            dateOnboarding.Name = "dateOnboarding";
            dateOnboarding.ReadOnly = true;
            // 
            // dateOffboarding
            // 
            dateOffboarding.HeaderText = "Retiro";
            dateOffboarding.Name = "dateOffboarding";
            dateOffboarding.ReadOnly = true;
            // 
            // datos
            // 
            datos.HeaderText = "Datos Adi";
            datos.Name = "datos";
            datos.ReadOnly = true;
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
            txtSearch.Hint = "Buscar Empleado";
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
            btnNew.Location = new Point(679, 116);
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
            btnUpdate.Location = new Point(679, 116);
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
            // FrmEmployees
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
            Controls.Add(pnlEmployee);
            Name = "FrmEmployees";
            ShowInTaskbar = false;
            pnlEmployee.ResumeLayout(false);
            pnlEmployee.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private MaterialSkin.Controls.MaterialButton btnOut;

        private System.Windows.Forms.DataGridView dataGridView1;

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

        private System.Windows.Forms.Panel pnlEmployee;

        private MaterialSkin.Controls.MaterialLabel lblTitle;

        #endregion

        private TextBox txtId;
        private MaterialSkin.Controls.MaterialComboBox cmbRol;
        private DateTimePicker dtpOnboarding;
        private DateTimePicker dtpOffboarding;
        private Label lblOffboarding;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtInfo;
        private DataGridView dgvEmployees;
        private Label lblOnboarding;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nameEmployee;
        private DataGridViewTextBoxColumn document;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn idRol;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewTextBoxColumn dateOnboarding;
        private DataGridViewTextBoxColumn dateOffboarding;
        private DataGridViewTextBoxColumn datos;
        private MaterialSkin.Controls.MaterialButton btnClear;
    }
}