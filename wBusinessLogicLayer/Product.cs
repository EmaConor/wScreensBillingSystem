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
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal SupplierPrice { get; set; }
        public decimal SalePrice { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string WhoModified { get; set; }

        private readonly DataAccess Access = new DataAccess();

        public DataTable LoadTable(string filter = "")
        {
            try
            {
                string sql = $"SELECT p.[IdProducto], p.[StrNombre], p.[StrCodigo], p.[NumPrecioCompra], p.[NumPrecioVenta],  p.[NumStock], p.[IdCategoria], c.StrDescripcion, p.[StrDetalle] FROM [TBLPRODUCTO] p INNER JOIN TBLCATEGORIA_PROD c ON p.[IdCategoria] = c.IdCategoria";
                if (!string.IsNullOrWhiteSpace(filter))
                {
                    sql += $" WHERE p.[StrNombre] like '%{filter}%'";
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

        public DataTable LoadCategory()
        {
            try
            {
                string sql = "Select * from TBLCATEGORIA_PROD";
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
                    new Parameters("@IdProducto", Id)
                };
                output = Access.RunProcedure("Eliminar_Producto", lst);
            }
            catch (Exception ex)
            {
                output = "ERROR: falló el borrado del producto: " + ex;
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
                    new Parameters("@IdProducto", Id),
                    new Parameters("@StrNombre", Name),
                    new Parameters("@StrCodigo", Code),
                    new Parameters("@NumPrecioCompra", SupplierPrice),
                    new Parameters("@NumPrecioVenta", SalePrice),
                    new Parameters("@IdCategoria", CategoryId),
                    new Parameters("@StrDetalle", Description),
                    new Parameters("@NumStock", Stock),
                    new Parameters("@strFoto", ""),
                    new Parameters("@DtmFechaModifica", DateTime.Now),
                    new Parameters("@StrUsuarioModifica", WhoModified)
                };
                output = Access.RunProcedure("actualizar_Producto", lst);
            }
            catch (Exception ex)
            {
                output = "ERROR: falló la actualizacion del producto: " + ex;
            }
            return output;
        }
    }
}
