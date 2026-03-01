using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wScreensBillingSystem.Models
{
    internal class Employee : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Document { get; set; } = string.Empty;

        [Required]
        public string Address { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;

        [Required]
        [MaxLength]
        public string Info { get; set; } = string.Empty;

        public DateTime Onboarding { get; set; }

        public DateTime? Offboarding { get; set; }

        // Relations 
        [Required]
        public int RolId { get; set; }

        [ForeignKey("RolId")]
        public virtual Rol Rol { get; set; } = null!;

    }
}
