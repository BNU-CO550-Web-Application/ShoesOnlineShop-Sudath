using ShoesOnlineShop.Models;

namespace ShoesOnlineShop.Services
{
    public class CartService
    {
        public static List<ShoppingItem> SelectedItms { get; set; } = new List<ShoppingItem>();

        public void AddProductToCart(int productId)
        {
            if(ProductInCart(productId) is false)
            {
                var product = ProductService.Products.First(p => p.Id == productId);

                ShoppingItem item = new ShoppingItem();

                item.Product = product;
                item.PurachasePrice = product.Price;
              //  item.Quantity = 1;
                SelectedItms.Add(item);
            }
           
        }

        private bool ProductInCart(int productId)
        {
            foreach(ShoppingItem item in SelectedItms)
            {
                if (item.Product.Id == productId)
                {
                    item.Quantity++;
                    return true;
                }
            }
            return false;
        }

    }
}
