using Microsoft.EntityFrameworkCore;
using wScreensBillingSystem.Models;

namespace wScreensBillingSystem.Data
{
    internal class BillingDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoicesDetail { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Security> Securities { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 1. Definimos la ruta en AppData/Local (ideal para que no se borre al actualizar)
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string path = Path.Combine(folder, "BillingSystem");

            // 2. Creamos la carpeta si no existe
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            // 3. Unimos la carpeta con el nombre del archivo
            string dbPath = Path.Combine(path, "Billing.db");

            // 4. Le decimos a SQLite que use esa ruta exacta
            optionsBuilder.UseSqlite($"Data Source={dbPath}");

            // Presiona Win + R, escribe %localappdata% y busca la carpeta "BillingSystem". ¡Ahí estará tu archivo real!
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración para el Enum de Estado de Factura
            // Si InvoiceStatus es un enum, se guardará como entero en la BD
            modelBuilder.Entity<Invoice>()
                .Property(i => i.Status)
                .HasConversion<int>();
        }

        public override int SaveChanges()
        {
            // Actualizar UpdatedAt automáticamente
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                ((BaseEntity)entry.Entity).UpdatedAt = DateTime.Now;
            }

            return base.SaveChanges();
        }

        // Usar la Consola del Administrador de Paquetes (Herramientas > Administrador de Paquetes NuGet)
        // Add-Migration InitialCreate (crea la migracion del codigo necesario para crear la base de datos)
        // Update-Database (crea el archivo .db fisicamente con toda la estructura de la base de datos)
    }
}
