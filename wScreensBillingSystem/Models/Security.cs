using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wScreensBillingSystem.Models
{
    internal class Security : BaseEntity
    {
        [Required]
        public string User {  get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        // Relations 
        [Required]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; } = null!;
    }
}
