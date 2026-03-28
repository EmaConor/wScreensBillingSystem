using MaterialSkin.Controls;
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
    public partial class FrmCustomerModal : MaterialForm
    {
        public FrmCustomerModal()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CustomerId { get; set; }

        private readonly Customer customer = new();


        private void FrmCustomerModal_Load(object sender, EventArgs e)
        {
            if (CustomerId == 0)
            {
                Clear();
                
            }
            else
            {
                LoadCustomerData();
            }
        }

        public void Clear()
        {
            txtId.Clear();
            txtName.Clear();
            txtDoc.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();

            ToggleButtons(false);
            txtName.Focus();
        }

        private void ToggleButtons(bool isEdit)
        {
            btnNew.Visible = !isEdit;
            btnNew.DrawShadows = !isEdit;
            btnUpdate.Visible = isEdit;
            btnUpdate.DrawShadows = isEdit;
        }

        private void LoadCustomerData()
        {
            try
            {
                DataTable dt = customer.LoadCustomerById(CustomerId);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    lblTitle.Text = $"Modificar cliente {row["StrNombre"].ToString()}";
                    txtId.Text = row["IdCliente"].ToString();
                    txtName.Text = row["StrNombre"].ToString();
                    txtDoc.Text = row["NumDocumento"].ToString();
                    txtAddress.Text = row["StrDireccion"].ToString();
                    txtPhone.Text = row["StrTelefono"].ToString();
                    txtEmail.Text = row["StrEmail"].ToString();

                    ToggleButtons(true);
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean Validate(string name, string document, string address, string phone, string email)
        {
            Boolean fieldError = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("El nombre es obligatorio");
                txtName.Focus();
                fieldError = false;
            }
            if (string.IsNullOrWhiteSpace(document))
            {
                MessageBox.Show("El documento es obligatorio");
                txtDoc.Focus();
                fieldError = false;
            }
            if (!isNumeric(document))
            {
                MessageBox.Show("El Documento debe ser numerico");
                txtDoc.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("La direccion es obligatoria");
                txtAddress.Focus();
                fieldError = false;
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("El telefono es obligatorio");
                txtPhone.Focus();
                fieldError = false;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("El email es obligatorio");
                txtEmail.Focus();
                fieldError = false;
            }
            return fieldError;
        }
        private bool isNumeric(string num)
        {
            return double.TryParse(num, out _);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string document = txtDoc.Text;
                string address = txtAddress.Text;
                string phone = txtPhone.Text;
                string email = txtEmail.Text;

                if (Validate(name, document, address, phone, email))
                {
                    Customer newCustomer = new()
                    {
                        Name = name,
                        Document = double.Parse(document),
                        Address = address,
                        Phone = phone,
                        Email = email,
                        WhoModified = "Ema"
                    };

                    string message = newCustomer.Update();
                    MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!message.Contains("ERROR"))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al crear el cliente: " + ex.Message, "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    this.Close();
                }

                int id = Convert.ToInt32(txtId.Text);
                string name = txtName.Text;
                string document = txtDoc.Text;
                string address = txtAddress.Text;
                string phone = txtPhone.Text;
                string email = txtEmail.Text;


                if (Validate(name, document, address, phone, email))
                {
                    customer.Id = id;
                    customer.Name = name;
                    customer.Document = double.Parse(document);
                    customer.Address = address;
                    customer.Phone = phone;
                    customer.Email = email;
                    customer.WhoModified = "Ema";

                    string message = customer.Update();
                    MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                Clear();
            }
            else
            {
                LoadCustomerData();
            }
        }
    }
}
