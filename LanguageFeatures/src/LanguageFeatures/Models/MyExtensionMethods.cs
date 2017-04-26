using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> products)
        {
            decimal total = 0;

            foreach (Product item in products)
            {
                total += item?.Price ?? 0;
            }

            return total;
        }

        /// <summary>
        /// returns products with price greater than minPrice
        /// </summary>
        /// <param name="products"></param>
        /// <param name="minPrice"></param>
        /// <returns></returns>
        public static IEnumerable<Product> FilterByPrice(this IEnumerable<Product> products, decimal minPrice)
        {
            foreach (Product item in products)
            {
                if ((item?.Price ?? 0) >= minPrice)
                {
                    yield return item;
                }
            }
        }
    }
}
