using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public Product(bool stock = true)
        {
            InStock = stock;
        }

        public string Name { get; set; }
        public string Category { get; set; } = "Watersports";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; } = true;

        public static Product[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Category = "Watercraft",
                Price = 275m
            };

            Product lifejacket = new Product(false)
            {
                Name = "Lifejacket",
                Price = 48.95m
            };

            Product nullProduct = new Product
            {
                Name = null,
                Price = null
            };

            kayak.Related = lifejacket;
            nullProduct.Related = null;

            return new Product[] { kayak, lifejacket, nullProduct, null};
        }
    }
}
