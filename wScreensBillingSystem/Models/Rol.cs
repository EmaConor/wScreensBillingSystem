using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using wScreensBillingSystem.Data;

namespace wScreensBillingSystem.Models
{
    internal class Rol : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        public Rol() { }
        public Rol(int id, string name, string description)
        {   
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
        public Rol(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
        public Rol(int id) 
        { 
            this.Id= id;
        }

        public bool Set()
        {
            try
            {
                using var db = new BillingDbContext();
                db.Rols.Add(this);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                using var db = new BillingDbContext();
                db.Rols.Update(this);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                using var db = new BillingDbContext();
                db.Rols.Remove(this);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
