using System.ComponentModel.DataAnnotations;

namespace ShoesOnlineShop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; } = 0;

        [StringLength(60)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [StringLength(255)]
        public string? Description { get; set; } = null;

        [StringLength(200)]
        public string ImageURL {get; set;} = string.Empty;

        [Range(1.00, 100.00)]
        public decimal Price { get; set; } = 0;

        public int Category { get; set; } = 0;
    }
}
