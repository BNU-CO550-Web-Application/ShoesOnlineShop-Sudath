using ShoesOnlineShop.Models;

namespace ShoesOnlineShop.Services
{
    public class CartService
    {
        public List<Product> SelectedItms { get; set; } = new List<Product>();

        public void AddProductToCart(int productId)
        {
            var product = ProductServicec.Products.First(p => p.Id == productId);

            if(SelectedItms.Contains(product) is false)
            {
                SelectedItms.Add(product);
            }
        }
    }
}
