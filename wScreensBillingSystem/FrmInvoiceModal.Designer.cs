using System.ComponentModel;

namespace wScreensBillingSystem;

partial class FrmInvoiceModal
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
        pnlEmployee = new Panel();
        txtIVA = new MaterialSkin.Controls.MaterialTextBox();
        txtDiscount = new MaterialSkin.Controls.MaterialTextBox();
        cmbStatus = new MaterialSkin.Controls.MaterialComboBox();
        cmbEmployee = new MaterialSkin.Controls.MaterialComboBox();
        cmbCustomer = new MaterialSkin.Controls.MaterialComboBox();
        txtInfo = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
        lblDate = new Label();
        dtpOnboarding = new DateTimePicker();
        txtId = new TextBox();
        txtTotal = new MaterialSkin.Controls.MaterialTextBox();
        pnlSearch = new Panel();
        dataGridView1 = new DataGridView();
        btnSearch = new MaterialSkin.Controls.MaterialButton();
        txtSearch = new MaterialSkin.Controls.MaterialTextBox();
        btnNew = new MaterialSkin.Controls.MaterialButton();
        btnUpdate = new MaterialSkin.Controls.MaterialButton();
        btnDelete = new MaterialSkin.Controls.MaterialButton();
        btnOut = new MaterialSkin.Controls.MaterialButton();
        materialButton1 = new MaterialSkin.Controls.MaterialButton();
        pnlEmployee.SuspendLayout();
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
        lblTitle.Text = "Titulo";
        lblTitle.TextAlign = ContentAlignment.TopCenter;
        // 
        // pnlEmployee
        // 
        pnlEmployee.Controls.Add(txtIVA);
        pnlEmployee.Controls.Add(txtDiscount);
        pnlEmployee.Controls.Add(cmbStatus);
        pnlEmployee.Controls.Add(cmbEmployee);
        pnlEmployee.Controls.Add(cmbCustomer);
        pnlEmployee.Controls.Add(txtInfo);
        pnlEmployee.Controls.Add(lblDate);
        pnlEmployee.Controls.Add(dtpOnboarding);
        pnlEmployee.Controls.Add(txtId);
        pnlEmployee.Controls.Add(txtTotal);
        pnlEmployee.Location = new Point(16, 35);
        pnlEmployee.Name = "pnlEmployee";
        pnlEmployee.Size = new Size(656, 213);
        pnlEmployee.TabIndex = 1;
        // 
        // txtIVA
        // 
        txtIVA.AnimateReadOnly = false;
        txtIVA.BorderStyle = BorderStyle.None;
        txtIVA.Depth = 0;
        txtIVA.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        txtIVA.Hint = "Total IVA";
        txtIVA.LeadingIcon = null;
        txtIVA.Location = new Point(35, 131);
        txtIVA.MaxLength = 32767;
        txtIVA.MouseState = MaterialSkin.MouseState.OUT;
        txtIVA.Multiline = false;
        txtIVA.Name = "txtIVA";
        txtIVA.Size = new Size(329, 36);
        txtIVA.TabIndex = 4;
        txtIVA.Text = "";
        txtIVA.TrailingIcon = null;
        txtIVA.UseTallSize = false;
        // 
        // txtDiscount
        // 
        txtDiscount.AnimateReadOnly = false;
        txtDiscount.BorderStyle = BorderStyle.None;
        txtDiscount.Depth = 0;
        txtDiscount.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        txtDiscount.Hint = "Descuento";
        txtDiscount.LeadingIcon = null;
        txtDiscount.Location = new Point(35, 89);
        txtDiscount.MaxLength = 32767;
        txtDiscount.MouseState = MaterialSkin.MouseState.OUT;
        txtDiscount.Multiline = false;
        txtDiscount.Name = "txtDiscount";
        txtDiscount.Size = new Size(329, 36);
        txtDiscount.TabIndex = 3;
        txtDiscount.Text = "";
        txtDiscount.TrailingIcon = null;
        txtDiscount.UseTallSize = false;
        // 
        // cmbStatus
        // 
        cmbStatus.AutoResize = false;
        cmbStatus.BackColor = Color.FromArgb(255, 255, 255);
        cmbStatus.Depth = 0;
        cmbStatus.DrawMode = DrawMode.OwnerDrawVariable;
        cmbStatus.DropDownHeight = 118;
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbStatus.DropDownWidth = 121;
        cmbStatus.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        cmbStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
        cmbStatus.FormattingEnabled = true;
        cmbStatus.Hint = "Estado";
        cmbStatus.IntegralHeight = false;
        cmbStatus.ItemHeight = 29;
        cmbStatus.Location = new Point(381, 62);
        cmbStatus.MaxDropDownItems = 4;
        cmbStatus.MouseState = MaterialSkin.MouseState.OUT;
        cmbStatus.Name = "cmbStatus";
        cmbStatus.Size = new Size(256, 35);
        cmbStatus.StartIndex = 0;
        cmbStatus.TabIndex = 7;
        cmbStatus.UseTallSize = false;
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
        cmbEmployee.Location = new Point(35, 48);
        cmbEmployee.MaxDropDownItems = 4;
        cmbEmployee.MouseState = MaterialSkin.MouseState.OUT;
        cmbEmployee.Name = "cmbEmployee";
        cmbEmployee.Size = new Size(329, 35);
        cmbEmployee.StartIndex = 0;
        cmbEmployee.TabIndex = 2;
        cmbEmployee.UseTallSize = false;
        // 
        // cmbCustomer
        // 
        cmbCustomer.AutoResize = false;
        cmbCustomer.BackColor = Color.FromArgb(255, 255, 255);
        cmbCustomer.Depth = 0;
        cmbCustomer.DrawMode = DrawMode.OwnerDrawVariable;
        cmbCustomer.DropDownHeight = 118;
        cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCustomer.DropDownWidth = 121;
        cmbCustomer.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        cmbCustomer.ForeColor = Color.FromArgb(222, 0, 0, 0);
        cmbCustomer.FormattingEnabled = true;
        cmbCustomer.Hint = "Cliente";
        cmbCustomer.IntegralHeight = false;
        cmbCustomer.ItemHeight = 29;
        cmbCustomer.Location = new Point(35, 9);
        cmbCustomer.MaxDropDownItems = 4;
        cmbCustomer.MouseState = MaterialSkin.MouseState.OUT;
        cmbCustomer.Name = "cmbCustomer";
        cmbCustomer.Size = new Size(329, 35);
        cmbCustomer.StartIndex = 0;
        cmbCustomer.TabIndex = 1;
        cmbCustomer.UseTallSize = false;
        // 
        // txtInfo
        // 
        txtInfo.AnimateReadOnly = false;
        txtInfo.BackgroundImageLayout = ImageLayout.None;
        txtInfo.CharacterCasing = CharacterCasing.Normal;
        txtInfo.Cursor = Cursors.IBeam;
        txtInfo.Depth = 0;
        txtInfo.HideSelection = true;
        txtInfo.Hint = "Datos Adicionales";
        txtInfo.Location = new Point(382, 103);
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
        txtInfo.Size = new Size(256, 106);
        txtInfo.TabIndex = 8;
        txtInfo.TabStop = false;
        txtInfo.TextAlign = HorizontalAlignment.Left;
        txtInfo.UseSystemPasswordChar = false;
        // 
        // lblDate
        // 
        lblDate.AutoSize = true;
        lblDate.Location = new Point(381, 15);
        lblDate.Name = "lblDate";
        lblDate.Size = new Size(38, 15);
        lblDate.TabIndex = 9;
        lblDate.Text = "Fecha";
        // 
        // dtpOnboarding
        // 
        dtpOnboarding.Location = new Point(381, 33);
        dtpOnboarding.Name = "dtpOnboarding";
        dtpOnboarding.Size = new Size(256, 23);
        dtpOnboarding.TabIndex = 6;
        // 
        // txtId
        // 
        txtId.Enabled = false;
        txtId.Location = new Point(7, 22);
        txtId.Name = "txtId";
        txtId.ReadOnly = true;
        txtId.Size = new Size(22, 23);
        txtId.TabIndex = 5;
        txtId.Visible = false;
        // 
        // txtTotal
        // 
        txtTotal.AnimateReadOnly = false;
        txtTotal.BorderStyle = BorderStyle.None;
        txtTotal.Depth = 0;
        txtTotal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        txtTotal.Hint = "Total";
        txtTotal.LeadingIcon = null;
        txtTotal.Location = new Point(35, 173);
        txtTotal.MaxLength = 32767;
        txtTotal.MouseState = MaterialSkin.MouseState.OUT;
        txtTotal.Multiline = false;
        txtTotal.Name = "txtTotal";
        txtTotal.Size = new Size(329, 36);
        txtTotal.TabIndex = 5;
        txtTotal.Text = "";
        txtTotal.TrailingIcon = null;
        txtTotal.UseTallSize = false;
        // 
        // pnlSearch
        // 
        pnlSearch.Controls.Add(materialButton1);
        pnlSearch.Controls.Add(dataGridView1);
        pnlSearch.Controls.Add(btnSearch);
        pnlSearch.Controls.Add(txtSearch);
        pnlSearch.Location = new Point(-8, 254);
        pnlSearch.Name = "pnlSearch";
        pnlSearch.Size = new Size(735, 263);
        pnlSearch.TabIndex = 2;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(13, 67);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(706, 181);
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
        btnSearch.Location = new Point(457, 22);
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
        txtSearch.Hint = "Buscar Factura";
        txtSearch.LeadingIcon = null;
        txtSearch.Location = new Point(24, 14);
        txtSearch.MaxLength = 32767;
        txtSearch.MouseState = MaterialSkin.MouseState.OUT;
        txtSearch.Multiline = false;
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(426, 50);
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
        btnNew.Location = new Point(679, 74);
        btnNew.Margin = new Padding(4, 6, 4, 6);
        btnNew.MouseState = MaterialSkin.MouseState.HOVER;
        btnNew.Name = "btnNew";
        btnNew.NoAccentTextColor = Color.Empty;
        btnNew.Size = new Size(88, 36);
        btnNew.TabIndex = 5;
        btnNew.Text = "Agregar";
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
        // 
        // btnDelete
        // 
        btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        btnDelete.Depth = 0;
        btnDelete.HighEmphasis = true;
        btnDelete.Icon = null;
        btnDelete.Location = new Point(679, 158);
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
        // materialButton1
        // 
        materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        materialButton1.Depth = 0;
        materialButton1.HighEmphasis = true;
        materialButton1.Icon = null;
        materialButton1.Location = new Point(649, 22);
        materialButton1.Margin = new Padding(4, 6, 4, 6);
        materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
        materialButton1.Name = "materialButton1";
        materialButton1.NoAccentTextColor = Color.Empty;
        materialButton1.Size = new Size(70, 36);
        materialButton1.TabIndex = 10;
        materialButton1.Text = "Nuevo";
        materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        materialButton1.UseAccentColor = false;
        materialButton1.UseVisualStyleBackColor = true;
        // 
        // FrmInvoiceModal
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
        Controls.Add(pnlEmployee);
        Name = "FrmInvoiceModal";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        pnlEmployee.ResumeLayout(false);
        pnlEmployee.PerformLayout();
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

        private MaterialSkin.Controls.MaterialTextBox txtSearch;

        private MaterialSkin.Controls.MaterialTextBox txtCustomer;
        private MaterialSkin.Controls.MaterialTextBox txtDoc;
        private MaterialSkin.Controls.MaterialTextBox txtAddress;
        private MaterialSkin.Controls.MaterialTextBox txtPhone;
        private MaterialSkin.Controls.MaterialTextBox txtTotal;

        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Panel pnlSearch;

        private MaterialSkin.Controls.MaterialLabel lblTitle;

        #endregion

        private TextBox txtId;
        private MaterialSkin.Controls.MaterialComboBox cmbRol;
        private System.Windows.Forms.DateTimePicker dtpOnboarding;
        private DateTimePicker dtpOffboarding;
        private Label lblOffboarding;
        private Label lblDate;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtInfo;
        private MaterialSkin.Controls.MaterialComboBox cmbEmployee;
        private MaterialSkin.Controls.MaterialComboBox cmbCustomer;
        private MaterialSkin.Controls.MaterialComboBox cmbStatus;
        private MaterialSkin.Controls.MaterialTextBox txtIVA;
        private MaterialSkin.Controls.MaterialTextBox txtDiscount;
    private MaterialSkin.Controls.MaterialButton materialButton1;
}