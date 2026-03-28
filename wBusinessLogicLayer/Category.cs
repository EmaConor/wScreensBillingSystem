using Data_Access_Layer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wBusinessLogicLayer
{
    public class Category
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string WhoModified { get; set; }

        private readonly DataAccess Access = new DataAccess();

        public DataTable LoadTable(string filter = "")
        {
            try
            {
                string sql = $"SELECT [IdCategoria], [StrDescripcion] FROM TBLCATEGORIA_PROD";
                if (!string.IsNullOrWhiteSpace(filter))
                {
                    sql += $" WHERE [StrDescripcion] like '%{filter}%'";
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
                    new Parameters("@IdCategoria", Id)
                };
                output = Access.RunProcedure("Eliminar_CategoriaProducto", lst);
            }
            catch (Exception ex)
            {
                output = "ERROR: falló el borrado de la Categoria: " + ex;
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
                    new Parameters("@IdCategoria", Id),
                    new Parameters("@StrDescripcion", Description),
                    new Parameters("@DtmFechaModifica", DateTime.Now),
                    new Parameters("@StrUsuarioModifico", WhoModified)
                };
                output = Access.RunProcedure("actualizar_CategoriaProd", lst);
            }
            catch (Exception ex)
            {
                output = "ERROR: falló la actualizacion de la Categoria: " + ex;
            }
            return output;
        }
    }
}
