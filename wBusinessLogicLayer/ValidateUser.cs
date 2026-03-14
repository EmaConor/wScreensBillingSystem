using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wBusinessLogicLayer
{
    public class ValidateUser
    {
        public Int32 Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public void Validate()
        {
            try
            {
                string sentencia = $"select IdEmpleado from TBLSEGURIDAD WHERE StrUsuario = '{Username}' AND StrClave = '{Password}'";
                DataTable dt = new DataTable();
                DataAccess Access = new DataAccess();

                dt = Access.RunCommandData(sentencia);
                
                foreach (DataRow dr in dt.Rows)
                {
                    Id = Convert.ToInt32(dr["IdEmpleado".ToString()]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la consulta: " + ex);
            }
        }
    }
}
