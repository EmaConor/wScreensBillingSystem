using System.ComponentModel.DataAnnotations;

namespace wScreensBillingSystem.Models
{
    internal class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;
    }
}
