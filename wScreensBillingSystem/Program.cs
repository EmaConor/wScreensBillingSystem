using Microsoft.EntityFrameworkCore;
using wScreensBillingSystem.Data;

namespace wScreensBillingSystem;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        using (var db = new BillingDbContext())
        {
            db.Database.Migrate(); // Crea la BD si no existe
            if (!db.Rols.Any())
            {
                db.Rols.Add(new Models.Rol { Name = "Administrador", Description = "Acceso total al sistema, gestión de usuarios, configuración y supervisión de registros." });
                db.Rols.Add(new Models.Rol { Name = "Vendedor", Description = "Gestión de ventas, registro de pedidos y consulta de catálogo de productos." });
                db.SaveChanges();
            }
        }
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new FrmMain());
    }
}