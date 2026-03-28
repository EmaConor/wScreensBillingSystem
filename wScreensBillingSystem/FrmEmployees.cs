using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wScreensBillingSystem;
using wBusinessLogicLayer;

namespace wScreensBillingSystem
{
    public partial class FrmEmployees : Form
    {
        public FrmEmployees()
        {
            InitializeComponent();

            LoadComboBox();
            LoadData();
        }

        DataTable dt = new();
        private readonly Employee employee = new();

        private void LoadComboBox()
        {
            cmbRol.DataSource = employee.LoadRol();
            cmbRol.DisplayMember = "StrDescripcion";
            cmbRol.ValueMember = "IdRolEmpleado";
            cmbRol.SelectedValue = -1;
        }

        private void LoadData(string filter = "")
        {
            dgvEmployees.Rows.Clear();
            dt = employee.LoadTable(filter);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgvEmployees.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10]);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron empleados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                txtSearch.Clear();
            }
        }

        private void ToggleButtons(bool isEdit)
        {
            btnNew.Visible = !isEdit;
            btnNew.DrawShadows = !isEdit;
            btnUpdate.Visible = isEdit;
            btnUpdate.DrawShadows = isEdit;
        }

        public void Clear()
        {
            txtId.Clear();
            txtName.Clear();
            txtDoc.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtSearch.Clear();
            txtInfo.Clear();
            cmbRol.SelectedValue = -1;
            dtpOnboarding.Value = DateTime.Now;
            dtpOffboarding.Value = DateTime.Now;

            LoadData();
            ToggleButtons(false);
            txtName.Focus();
        }

        private Boolean Validate(string name, string document, string address, string phone, string email, object idRol)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("El nombre es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(document))
            {
                MessageBox.Show("El documento es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDoc.Focus();
                return false;
            }
            if (!isNumeric(document))
            {
                MessageBox.Show("El Documento debe ser numerico");
                txtDoc.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("La dirección es obligatoria", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("El teléfono es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("El email es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (idRol == null || Convert.ToInt32(idRol) <= 0)
            {
                MessageBox.Show("Debe seleccionar un rol", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRol.Focus();
                return false;
            }
            return true;
        }

        private bool isNumeric(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvEmployees.Rows[e.RowIndex];

            this.SuspendLayout();
            txtId.Text = row.Cells["id"].Value?.ToString();
            txtName.Text = row.Cells["nameEmployee"].Value?.ToString();
            txtDoc.Text = row.Cells["document"].Value?.ToString();
            txtAddress.Text = row.Cells["address"].Value?.ToString();
            txtPhone.Text = row.Cells["phone"].Value?.ToString();
            txtEmail.Text = row.Cells["email"].Value?.ToString();
            if (row.Cells["idRol"].Value != null)
            {
                int idRol = Convert.ToInt32(row.Cells["idRol"].Value);
                cmbRol.SelectedValue = idRol;
            }
            if (row.Cells["dateOnboarding"].Value != null && row.Cells["dateOnboarding"].Value != DBNull.Value)
                dtpOnboarding.Value = Convert.ToDateTime(row.Cells["dateOnboarding"].Value);
            if (row.Cells["dateOffboarding"].Value != null && row.Cells["dateOffboarding"].Value != DBNull.Value)
                dtpOffboarding.Value = Convert.ToDateTime(row.Cells["dateOffboarding"].Value);
            txtInfo.Text = row.Cells["datos"].Value?.ToString();


            ToggleButtons(true);
            this.ResumeLayout();
        }

        private void dgvEmployees_MouseDown(object sender, MouseEventArgs e)
        {
            // Si hace clic fuera de la tabla, limpia el formulario
            var hit = dgvEmployees.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                Clear();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate(txtName.Text, txtDoc.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text, cmbRol.SelectedValue))
                {
                    Employee newEmployee = new()
                    {
                        Name = txtName.Text,
                        Document = double.Parse(txtDoc.Text),
                        Address = txtAddress.Text,
                        Phone = txtPhone.Text,
                        Email = txtEmail.Text,
                        IdRol = (int)cmbRol.SelectedValue,
                        Onboarding = dtpOnboarding.Value,
                        Offboarding = dtpOffboarding.Value,
                        Info = txtInfo.Text,
                        WhoModified = "Ema"
                    };

                    string message = newEmployee.Insert();
                    MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!message.Contains("ERROR"))
                    {
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Debe seleccionar un empleado de la tabla para actualizar", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Validate(txtName.Text, txtDoc.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text, cmbRol.SelectedValue))
                {
                    employee.Id = int.Parse(txtId.Text);
                    employee.Name = txtName.Text;
                    employee.Document = double.Parse(txtDoc.Text);
                    employee.Address = txtAddress.Text;
                    employee.Phone = txtPhone.Text;
                    employee.Email = txtEmail.Text;
                    employee.IdRol = (int)cmbRol.SelectedValue;
                    employee.Onboarding = dtpOnboarding.Value;
                    employee.Offboarding = dtpOffboarding.Value;
                    employee.Info = txtInfo.Text;
                    employee.WhoModified = "Ema";

                    string message = employee.Update();
                    MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el empleado: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            LoadData(search);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
