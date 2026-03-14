using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace wBusinessLogicLayer
{
    public class Security
    {
        public string User { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int EmployeeId { get; set; }
        public string WhoModified { get; set; }

        private readonly DataAccess Access = new DataAccess();

        public DataTable LoadEmployee()
        {
            try
            {
                string sql = "Select * from TBLEMPLEADO";
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

        public DataTable GetEmployeeById(int employeeId)
        {
            try
            {
                string sql = $"SELECT StrUsuario, StrClave FROM TBLSEGURIDAD WHERE IdEmpleado = {employeeId}";
                return Access.RunCommandData(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CONSULTAR USUARIO: " + ex.Message);
                return null;
            }
        }

        public string Update()
        {
            string output;
            try
            {
                List<Parameters> lst = new List<Parameters>
                {
                    new Parameters("@IdEmpleado", EmployeeId),
                    new Parameters("@StrUsuario", User),
                    new Parameters("@StrClave", Password),
                    new Parameters("@DtmFechaModifica", DateTime.Now),
                    new Parameters("@StrUsuarioModifico", WhoModified)
                };
                output = Access.RunProcedure("actualizar_Seguridad", lst);
            }
            catch (Exception ex)
            {
                output = "ERROR: falló la actualizacion del usuario: " + ex;
            }
            return output;
        }

        public string Delete()
        {
            string output;
            try
            {
                List<Parameters> lst = new List<Parameters>
                {
                    new Parameters("@IdEmpleado", EmployeeId)
                };
                output = Access.RunProcedure("Eliminar_Seguridad", lst);
            }
            catch (Exception ex)
            {
                output = "ERROR: falló el borrado del usuario: " + ex;
            }
            return output;
        }
    }
}
