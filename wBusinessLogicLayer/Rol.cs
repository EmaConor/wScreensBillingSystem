using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    public class Rol
    {
        public int Id { get; set; }
        public string Description { get; set; }

        private readonly DataAccess Access = new DataAccess();

        public DataTable LoadTable(string filter = "")
        {
            try
            {
                string sql;
                if (!string.IsNullOrWhiteSpace(filter))
                {
                    sql = $"SELECT IdRolEmpleado, StrDescripcion FROM TBLROLES WHERE StrDescripcion LIKE '%{filter}%'";
                }
                else
                {
                    sql = $"SELECT IdRolEmpleado, StrDescripcion FROM TBLROLES";
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

        public string Insert()
        {
            try
            {
                string sql = $"INSERT INTO TBLROLES (StrDescripcion) " +
                            $"VALUES ('{Description}')";

                return Access.RunCommand(sql);
            }
            catch (Exception ex)
            {
                return "ERROR: falló la inserción del rol: " + ex.Message;
            }
        }

        public string Update()
        {
            try
            {
                string sql = $"UPDATE TBLROLES SET StrDescripcion = '{Description}'" +
                            $"WHERE IdRolEmpleado = {Id}";
                return Access.RunCommand(sql);
            }
            catch (Exception ex)
            {
                return "ERROR: falló la actualizacion del rol: " + ex;
            }
        }

        public string Delete()
        {

            string output;
            try
            {
                string sql = $"DELETE FROM TBLROLES WHERE IdRolEmpleado = {Id}";
                return Access.RunCommand(sql);
            }
            catch (Exception ex)
            {
                return "ERROR: falló la eliminación del rol: " + ex.Message;
            }
        }
    }
}