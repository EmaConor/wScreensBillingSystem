using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wScreensBillingSystem.Data
{
    internal class BillingDB
    {
        SqlConnection connection; 
        SqlCommand cmd; // se defie la variable para realizar comandos en la BD
        SqlDataReader dataReader = null;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        public void OpenDB()
        {
            try
            {
                connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog = [DBFACTURAS]; Integrated Security = True;TrustServerCertificate = True;");
                connection.Open();
            }
            catch (Exception e)
            {   
                MessageBox.Show("Fallo Conexion" + e);
            }
        }

        public void CloseDB() 
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Fallo Cerrar Conexion" + e);
            }
        }


        public string ValidateUser(string username, string password)
        {
            try
            {
                string strEmpleado = "";
                string sentencia = $"select e.strNombre, e.IdRolEmpleado from TBLSEGURIDAD s JOIN TBLEMPLEADO e ON s.IdEmpleado = e.IdEmpleado where StrUsuario = '{username}' and StrClave = '{password}'";
                OpenDB();
                cmd = new SqlCommand
                {
                    // utilizamos las propiedades de SqlCommand esta es una forma extendidas con mas parámetros de control
                    Connection = connection,
                    CommandText = sentencia,
                    CommandType = CommandType.Text, // otros tipos son: CommandType.StoredProcedure CommandType.TableDirect
                    CommandTimeout = 10
                };
                dataReader = cmd.ExecuteReader(); // ejecuta y retorna un conjunto de datos no actualizable
                while (dataReader.Read()) // recorremos los datos consultados
                {
                    strEmpleado = Convert.ToString(dataReader.GetValue(0));
                }
                dataReader?.Close();
                return strEmpleado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALLA LECTURA: " + ex.Message);
                return "";
            }
        }

        public DataTable LoadTable(string tableName, string condition)
        {
            try
            {
                OpenDB();
                string Sql = "Select * from " + tableName + " " + condition;
                da = new SqlDataAdapter(Sql, connection);
                ds = new DataSet();
                da.Fill(ds, tableName);
                DataTable dt = new();
                dt = ds.Tables[tableName];
                CloseDB();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN LA CONSULTA: " + ex.ToString());
                return null;
            }
        }

        public string RunCommand(string command)
        {
            string salida;
            try
            {
                int retornado;
                OpenDB();
                cmd = new SqlCommand(command, connection);
                retornado = cmd.ExecuteNonQuery();
                CloseDB();
                if (retornado > 0)
                {
                    salida = "Los datos fueron Actualizados";
                }
                else
                {
                    salida = "Los datos no fueron Actualizados";
                }
            }
            catch (Exception ex)
            {
                salida = "falló inserción: " + ex;
            }
            return salida;
        }

        public DataTable RunCommandData(string command)
        {
            try
            {
                OpenDB();
                da = new SqlDataAdapter(command,connection);
                dt = new DataTable();
                da.Fill(dt);
                CloseDB();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALLÓ OPERACIÓN: " + ex);
                return null;

            }
        }
    }
}
