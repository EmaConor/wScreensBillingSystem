using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wBusinessLogicLayer
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Document { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int IdRol { get; set; }
        public DateTime Onboarding { get; set; }
        public DateTime Offboarding { get; set; }
        public string Info { get; set; } = string.Empty;
        public string WhoModified { get; set; }

        private readonly DataAccess Access = new DataAccess();

        public DataTable LoadTable(string filter = "")
        {
            try
            {
                string sql;
                if (!string.IsNullOrWhiteSpace(filter))
                {
                    sql = $"SELECT e.IdEmpleado, e.StrNombre, e.NumDocumento, e.StrDireccion, e.StrTelefono, e.StrEmail, e.IdRolEmpleado, r.StrDescripcion AS RolDescripcion, e.DtmIngreso, e.DtmRetiro, e.StrDatosAdicionales FROM TBLEMPLEADO e INNER JOIN TBLROLES r ON e.IdRolEmpleado = r.IdRolEmpleado WHERE e.StrNombre LIKE '%{filter}%'";
                }
                else
                {
                    sql = $"SELECT e.IdEmpleado, e.StrNombre, e.NumDocumento, e.StrDireccion, e.StrTelefono, e.StrEmail, e.IdRolEmpleado, r.StrDescripcion AS RolDescripcion, e.DtmIngreso, e.DtmRetiro, e.StrDatosAdicionales FROM TBLEMPLEADO e INNER JOIN TBLROLES r ON e.IdRolEmpleado = r.IdRolEmpleado";
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

        public DataTable LoadRol()
        {
            try
            {
                string sql = "Select * from TBLROLES";
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
                    new Parameters("@IdEmpleado", Id)
                };
                output = Access.RunProcedure("eliminar_Empleado", lst);
            }
            catch (Exception ex)
            {
                output = "ERROR: falló el borrado del empleado: " + ex;
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
                string additionalData = Info.Replace("'", "''");
                string whoModified = WhoModified.Replace("'", "''");

                string sql = $@"INSERT INTO TBLEMPLEADO 
                        (StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail, IdRolEmpleado, DtmIngreso, DtmRetiro, StrDatosAdicionales, DtmFechaModifica, StrUsuarioModifico) 
                        VALUES 
                        ('{name}', {Document}, '{address}', '{phone}', '{email}', {IdRol}, 
                         '{Onboarding:yyyy-MM-dd HH:mm:ss}', '{Offboarding:yyyy-MM-dd HH:mm:ss}', 
                         '{additionalData}', GETDATE(), '{whoModified}')";

                output = Access.RunCommand(sql);
            }
            catch (Exception ex)
            {
                output = "ERROR: falló la creacion del empleado: " + ex.Message;
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
                    new Parameters("@IdEmpleado", Id),
                    new Parameters("@StrNombre", Name),
                    new Parameters("@NumDocumento", Document),
                    new Parameters("@StrDireccion", Address),
                    new Parameters("@StrTelefono", Phone),
                    new Parameters("@StrEmail", Email),
                    new Parameters("@IdRolEmpleado", IdRol),
                    new Parameters("@DtmIngreso", Onboarding),
                    new Parameters("@DtmRetiro", Offboarding),
                    new Parameters("@strDatosAdicionales", Info),
                    new Parameters("@DtmFechaModifica", DateTime.Now),
                    new Parameters("@StrUsuarioModifico", WhoModified)
                };
                output = Access.RunProcedure("actualizar_Empleado", lst);
            }
            catch (Exception ex)
            {
                output = "ERROR: falló la actualizacion del empleado: " + ex;
            }
            return output;
        }
    }
}
