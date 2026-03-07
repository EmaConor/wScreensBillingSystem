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

        BillingDB db = new();

        private void LoadComboBox()
        {
            DataTable dt = new();
            dt = db.LoadTable("TBLEMPLEADO", "");

            cmbEmployee.DataSource = dt;
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

            cmbEmployee.SelectedValue = 0;
            txtUser.Clear();
            txtKeyword.Clear();

            ToggleButtons(false);
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbEmployee.SelectedValue.ToString()))
            {
                MessageBox.Show("Debe seleccionar un empleado de la lista para consultar");
                return;
            }
            string id = cmbEmployee.SelectedValue.ToString();

            DataTable dt = new();
            string sentence = "select StrUsuario,StrClave from TBLSEGURIDAD where IdEmpleado=" + id;
            dt = db.RunCommandData(sentence);
            if (dt.Rows.Count > 0)
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
            string id = cmbEmployee.SelectedValue.ToString();
            string user = txtUser.Text;
            string keyword = txtKeyword.Text;


            if (Validate(user, keyword))
            {
                try
                {
                    string sentencia = $"Exec actualizar_Seguridad '{Convert.ToInt32(id)}','{user}','{keyword}','{DateTime.Now}','Javier'";
                    MessageBox.Show(db.RunCommand(sentencia));
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
                string sentencia = $"Exec Eliminar_Seguridad '{Convert.ToInt32(cmbEmployee.SelectedValue)}'";
                MessageBox.Show(db.RunCommand(sentencia));
                txtUser.Text = "";
                txtKeyword.Text = "";
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

    }
}
