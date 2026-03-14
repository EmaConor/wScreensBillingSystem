using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using wBusinessLogicLayer;
using wScreensBillingSystem.Data;

namespace wScreensBillingSystem
{
    public partial class FrmSecurity : Form
    {
        public FrmSecurity()
        {
            InitializeComponent();

            LoadComboBox();
        }

        DataTable dt = new();
        Security security = new();

        private void LoadComboBox()
        {
            cmbEmployee.DataSource = security.LoadEmployee();
            cmbEmployee.DisplayMember = "strNombre";
            cmbEmployee.ValueMember = "IdEmpleado";
            cmbEmployee.SelectedValue = 0;
        }

        private void ToggleButtons(bool isEdit)
        {
            btnConsult.Visible = !isEdit;
            btnConsult.DrawShadows = !isEdit;
            btnUpdate.Visible = isEdit;
            btnUpdate.DrawShadows = isEdit;
            btnDelete.Visible = isEdit;
            btnDelete.DrawShadows = isEdit;
        }

        public void Clear()
        {
            LoadComboBox();

            cmbEmployee.SelectedValue = -1;
            txtUser.Clear();
            txtKeyword.Clear();

            ToggleButtons(false);
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cmbEmployee.SelectedValue.ToString()))
                {
                    MessageBox.Show("Debe seleccionar un empleado de la lista para consultar");
                    return;
                }
                int employeeId = Convert.ToInt32(cmbEmployee.SelectedValue);

                dt = security.GetEmployeeById(employeeId);
                if (dt != null && dt.Rows.Count > 0)
                {
                    txtUser.Text = dt.Rows[0]["StrUsuario"].ToString();
                    txtKeyword.Text = dt.Rows[0]["StrClave"].ToString();
                }
                else
                {
                    MessageBox.Show("El usuario no dispone de datos de ingreso");
                    txtUser.Text = "";
                    txtKeyword.Text = "";
                }
                ToggleButtons(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del usuario: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean Validate(string user, string keyword)
        {
            Boolean fieldError = true;
            if (string.IsNullOrWhiteSpace(user))
            {
                MessageBox.Show("El usuario es obligatorio");
                txtUser.Focus();
                fieldError = false;
            }
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("La contraseña es obligatoria");
                txtKeyword.Focus();
                fieldError = false;
            }
            return fieldError;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbEmployee.SelectedValue.ToString()))
            {
                MessageBox.Show("Debe seleccionar un empleado de la lista para consultar");
                return;
            }
            int id = Convert.ToInt32(cmbEmployee.SelectedValue);
            string user = txtUser.Text.Trim();
            string keyword = txtKeyword.Text.Trim();

            var result = MessageBox.Show("¿Está seguro de actualizar este usuario?", "Confirmar",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes && Validate(user, keyword))
            {
                try
                {
                    security.EmployeeId = id;
                    security.User = user;
                    security.Password = keyword;
                    security.WhoModified = "Ema";

                    string message = security.Update();
                    MessageBox.Show(message, "Información", MessageBoxButtons.OK,
                       message.Contains("ERROR") ? MessageBoxIcon.Error : MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbEmployee.SelectedValue.ToString()))
            {
                MessageBox.Show("Debe seleccionar un empleado de la lista para eliminar");
                return;
            }

            var result = MessageBox.Show("¿Está seguro de eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                security.EmployeeId = Convert.ToInt32(cmbEmployee.SelectedValue);

                string message = security.Delete();
                if (message.Contains("ERROR"))
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult Rta;
            Rta = MessageBox.Show("Desea salir de la edición ?", "MENSAJE DE ADVERTENCIA",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void cmbEmployee_SelectedValueChanged(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtKeyword.Clear();

            ToggleButtons(false);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
