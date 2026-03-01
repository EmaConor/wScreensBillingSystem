using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wScreensBillingSystem.Models
{
    internal class Invoice : BaseEntity
    {
        public DateTime Date { get; set;  } = DateTime.Now;

        [Required]
        [Range(0, int.MaxValue)]
        public int Discont { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal IVA { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SubTotal { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        public InvoiceStatus Status { get; set; } = InvoiceStatus.Pendiente;


        // Relations 
        [Required]
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; } = null!;

        [Required]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; } = null!;
    }
}
