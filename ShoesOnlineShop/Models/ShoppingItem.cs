namespace ShoesOnlineShop.Models
{
    public class ShoppingItem
    {
        public int Id { get; set; }
        
        public Product Product { get; set; }

        public int Quantity { get; set; } = 1;

        public decimal PurachasePrice { get; set; } = 0;
    }
}
