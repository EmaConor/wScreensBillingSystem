using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class DataAccess
    {
        SqlConnection connection;
        SqlCommand cmd; // se defie la variable para realizar comandos en la BD
        SqlDataAdapter da;
        DataTable dt;

        public void OpenDB()
        {
            try
            {
                connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog = [DBFACTURAS]; Integrated Security = True;TrustServerCertificate = True;");
                connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Fallo Conexion" + e);
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
                Console.WriteLine("Fallo Cerrar Conexion" + e);
            }
        }

        public string RunProcedure(string procedure, List<Parameters> lst)
        {
            string output;
            try
            {
                int returned;

                OpenDB();
                cmd = new SqlCommand(procedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;

                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Direction == ParameterDirection.Input)
                        {
                            cmd.Parameters.AddWithValue(lst[i].Name, lst[i].Value);
                        }
                        else
                        {
                            cmd.Parameters.Add(lst[i].Name, lst[i].Type, lst[i].Size).Direction = ParameterDirection.Output;
                        }
                    }
                }

                returned = cmd.ExecuteNonQuery();
                CloseDB();

                if (returned > 0)
                {
                    output = "Los datos fueron Actualizados";
                }
                else
                {
                    output = "Los datos no fueron Actualizados";
                }
            }
            catch (Exception ex)
            {
                output = "ERROR: falló la operacion: " + ex;
            }
            return output;
        }

        public string RunCommand(string command)
        {
            string output;
            try
            {
                int returned;
                OpenDB();
                cmd = new SqlCommand(command, connection);
                returned = cmd.ExecuteNonQuery();
                CloseDB();
                if (returned > 0)
                {
                    output = "Los datos fueron Actualizados";
                }
                else
                {
                    output = "Los datos no fueron Actualizados";
                }
            }
            catch (Exception ex)
            {
                output = "ERROR: falló la operacion: " + ex;
            }
            return output;
        }

        public DataTable RunCommandData(string command)
        {
            try
            {
                OpenDB();
                da = new SqlDataAdapter(command, connection);
                dt = new DataTable();
                da.Fill(dt);
                CloseDB();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("FALLÓ OPERACIÓN: " + ex);
                return null;

            }
        }
    }

    public class Parameters
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public SqlDbType Type { get; set; }
        public Int32 Size { get; set; }
        public ParameterDirection Direction { get; set; }

        public Parameters(string name, object value)
        {
            this.Name = name;
            this.Value = value;
            this.Direction = System.Data.ParameterDirection.Input;
        }

        public Parameters(string name, SqlDbType type, Int32 size)
        {
            this.Name = name;
            this.Type = type;
            this.Size = size;
            this.Direction = ParameterDirection.Output;
        }
    }
}
