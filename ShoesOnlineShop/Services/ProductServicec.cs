using ShoesOnlineShop.Models;
using System.Collections.Immutable;

namespace ShoesOnlineShop.Services
{
    public class ProductServicec
    {
        public static readonly List<Product> Products = new List<Product>()
        {
            new ()
            {
                Id = 1,
                Name = "Nike Air Max SC Men's Shoe",
                Description = "With its easy-going lines, heritage athletics look and, of course, visible Air cushioning.",
                Price = 57
            },
            new ()
            {
                Id = 1,
                Name = "Nike Air Max 270 Mens Trainers",
                Description = "The Air Max 270 from Nike delivers unrivalled all-day comfort. ",
                Price = 70
            },
            new()
            {
                Id = 1,
                Name = "Air Max Invigor Trainers Mens",
                Description = "The Invigor trainers have been engineered with a breathe tech upper which is light, .",
                Price = 80
            },
        };
    }
}
