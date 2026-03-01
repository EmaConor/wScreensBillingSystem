using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wScreensBillingSystem.Models
{
    internal abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Relations 
        public int? WhoModifiedId { get; set; }

        [ForeignKey("WhoModifiedId")]
        public virtual Employee? WhoModified { get; set; } = null!;
    }
}
