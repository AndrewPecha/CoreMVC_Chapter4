using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this ShoppingCart cart)
        {
            decimal total = 0;

            foreach (Product item in cart.Products)
            {
                total += item?.Price ?? 0;
            }

            return total;
        }
    }
}
