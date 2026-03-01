using System.Data;
using Microsoft.EntityFrameworkCore;
using wScreensBillingSystem.Data;
using wScreensBillingSystem.Models;

namespace wScreensBillingSystem
{
    public partial class FrmRols : Form
    {
        public FrmRols()
        {
            InitializeComponent();
            ConfigureGrid();
            LoadData();


        }

        private void LoadData(string filter = "")
        {
            using var db = new BillingDbContext();
            var query = db.Rols.AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter))
            {
                filter = filter.Trim().ToLower();
                query = query.Where(r => r.Name.ToLower().Contains(filter) 
                                        || r.Description.ToLower().Contains(filter));
            }

            dgvRols.DataSource = query.ToList();

            // Usar BeginInvoke evita que la selección por defecto de .NET gane
            BeginInvoke(new Action(() => dgvRols.ClearSelection()));
        }

        private void ConfigureGrid()
        {
            dgvRols.AutoGenerateColumns = false;
            dgvRols.Columns["colID"].DataPropertyName = "Id";
            dgvRols.Columns["colName"].DataPropertyName = "Name";
            dgvRols.Columns["colDescription"].DataPropertyName = "Description";
            dgvRols.MultiSelect = false;

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
            txtName.Clear();
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
                string name = txtName.Text;
                string description = txtDescription.Text;

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("El nombre del rol es obligatorio.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("La descripción del rol es obligatorio.");
                    return;
                }

                Rol rol = new(name, description);
                if (rol.Set())
                {
                    MessageBox.Show("Rol Creado Correctamente");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Error al guardar en la base de datos");
                }
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
                string name = txtName.Text;
                string description = txtDescription.Text;


                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("El nombre del rol es obligatorio");
                    return;
                }

                if (string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("La descripción del rol es obligatorio");
                    return;
                }

                Rol rol = new(id, name, description);

                if (rol.Update())
                {
                    MessageBox.Show("Rol Actualizado Correctamente");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Error al actualizar en la base de datos");
                }

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
                    Rol rol = new(id);
                    if (rol.Delete())
                    {
                        MessageBox.Show("Rol Eliminado Correctamente");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar en la base de datos");
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
            txtId.Text = row.Cells["colID"].Value?.ToString();
            txtName.Text = row.Cells["colName"].Value?.ToString();
            txtDescription.Text = row.Cells["colDescription"].Value?.ToString();

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

    }
}
