using System.ComponentModel.DataAnnotations;

namespace ShoesOnlineShop.Models
{
    public class ShoppingItem
    {
        public int Id { get; set; }
        
        public Product Product { get; set; }

        [Range(0, 9)]
        public int Quantity { get; set; } = 1;

        [Range(0, 100.00)]
        public decimal PurachasePrice { get; set; } = 0;
    }
}
