using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wBusinessLogicLayer
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Document { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string WhoModified { get; set; }

        private readonly DataAccess Access = new DataAccess();

        public DataTable LoadTable(string filter = "")
        {
            try
            {
                string sql = $"SELECT IdCliente, StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail FROM TBLCLIENTES";
                if (!string.IsNullOrWhiteSpace(filter))
                {
                    sql += $" WHERE StrNombre like '%{filter}%'";
                }

                DataTable dt = new DataTable();
                dt = Access.RunCommandData(sql);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN LA CONSULTA: " + ex.ToString());
                return null;
            }
        }

        public string Delete()
        {
            string output;
            try
            {
                List<Parameters> lst = new List<Parameters>
                {
                    new Parameters("@IdCliente", Id)
                };
                output = Access.RunProcedure("Eliminar_Cliente", lst);
            }
            catch (Exception ex)
            {
                output = "ERROR: falló el borrado del empleado: " + ex;
            }
            return output;
        }

        public string Update()
        {
            string output;
            try
            {
                List<Parameters> lst = new List<Parameters>
                {
                    new Parameters("@IdCliente", Id),
                    new Parameters("@StrNombre", Name),
                    new Parameters("@NumDocumento", Document),
                    new Parameters("@StrDireccion", Address),
                    new Parameters("@StrTelefono", Phone),
                    new Parameters("@StrEmail", Email),
                    new Parameters("@DtmFechaModifica", DateTime.Now),
                    new Parameters("@StrUsuarioModifica", WhoModified)
                };
                output = Access.RunProcedure("actualizar_Cliente", lst);
            }
            catch (Exception ex)
            {
                output = "ERROR: falló la actualizacion del cliente: " + ex;
            }
            return output;
        }

        public string Insert()
        {
            string output;
            try
            {
                string name = Name.Replace("'", "''");
                string address = Address.Replace("'", "''");
                string email = Email.Replace("'", "''");
                string phone = Phone.Replace("'", "''");
                string whoModified = WhoModified.Replace("'", "''");

                string sql = $@"INSERT INTO TBLCLIENTES 
                        (StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail, DtmFechaModifica, StrUsuarioModifica) 
                        VALUES 
                        ('{name}', {Document}, '{address}', '{phone}', '{email}', GETDATE(), '{whoModified}')";

                output = Access.RunCommand(sql);
            }
            catch (Exception ex)
            {
                output = "ERROR: falló la creacion del cliente: " + ex.Message;
            }
            return output;
        }
    }
}
