using ShoesOnlineShop.Models;
using System.Collections.Immutable;

namespace ShoesOnlineShop.Services
{
    public class ProductService
    {
        public static readonly List<Product> Products = new List<Product>()
        {
            new Product ()
            {
                Id = 1,
                Name = "Nike Air Max SC Men's Shoe",
                ImageURL = "image.jpg",
                Description = "With its easy-going lines, heritage athletics look and, of course, visible Air cushioning.",
                Category = 2,
                Price = 57
            },
            new Product ()
            {
                Id = 1,
                Name = "Nike Air Max 270 Mens Trainers",
                ImageURL = "image.jpg",
                Description = "The Air Max 270 from Nike delivers unrivalled all-day comfort. ",
                Category = 2,
                Price = 70
            },
            new Product ()
            {
                Id = 1,
                Name = "Air Max Invigor Trainers Mens",
                ImageURL = "image.jpg",
                Description = "The Invigor trainers have been engineered with a breathe tech upper which is light, .",
                Category = 2,
                Price = 80
            },
        };
    }
}
