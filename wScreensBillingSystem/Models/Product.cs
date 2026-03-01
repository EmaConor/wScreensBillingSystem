using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wScreensBillingSystem.Models
{
    internal class Product : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string Code { get; set; } = string.Empty;

        [Required]
        [Range(0, int.MaxValue)]
        public int Stock { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SupplierPrice { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SalePrice { get; set; }

        [Required]
        public string Info { get; set; } = string.Empty;

        // Relations 
        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; } = null!;

    }
}
