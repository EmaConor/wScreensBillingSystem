using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wBusinessLogicLayer;

namespace wScreensBillingSystem
{
    public partial class FrmRols : Form
    {
        public FrmRols()
        {
            InitializeComponent();
            LoadData();


        }

        DataTable dt = new();
        private readonly Rol rol = new();

        private void LoadData(string filter = "")
        {
            dgvRols.Rows.Clear();
            dt = rol.LoadTable(filter);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgvRols.Rows.Add(row[0], row[1]);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron empleados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Usar BeginInvoke evita que la selección por defecto de .NET gane
            BeginInvoke(new Action(() => dgvRols.ClearSelection()));
        }

        private void ToggleButtons(bool isEdit)
        {
            btnNew.Visible = !isEdit;
            btnNew.DrawShadows = !isEdit;
            btnUpdate.Visible = isEdit;
            btnUpdate.DrawShadows = isEdit;
            btnDelete.Visible = isEdit;
            btnDelete.DrawShadows = isEdit;
        }

        public void Clear()
        {
            txtId.Clear();
            txtDescription.Clear();
            txtSearch.Clear();

            LoadData();

            ToggleButtons(false);
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            LoadData(search);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                string description = txtDescription.Text;


                if (string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("La descripción del rol es obligatorio.");
                    return;
                }


                rol.Description = description;

                string message = rol.Insert();
                MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar el dato", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Debe seleccionar un rol de la tabla para actualizar");
                    return;
                }

                int id = Convert.ToInt32(txtId.Text);
                string description = txtDescription.Text;

                if (string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("La descripción del rol es obligatorio");
                    return;
                }

                rol.Id = id;
                rol.Description = description;

                string message = rol.Update();
                MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el rol " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Debe seleccionar un rol de la tabla para actualizar");
                    return;
                }

                int id = Convert.ToInt32(txtId.Text);

                var confirm = MessageBox.Show("¿Seguro que desea eliminar?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    rol.Id = id;

                    string message = rol.Delete();

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
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el rol " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRols_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvRols.Rows[e.RowIndex];
            txtId.Text = row.Cells["id"].Value?.ToString();
            txtDescription.Text = row.Cells["description"].Value?.ToString();

            ToggleButtons(true);
        }

        private void dgvRols_MouseDown(object sender, MouseEventArgs e)
        {
            // Si le da fuera de la tabla limpia
            var hit = dgvRols.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}