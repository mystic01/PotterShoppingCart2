using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.Tests
{
    public class PotterShoppingCart
    {
        public static int CalculateTotalPrice(Dictionary<string, int> books)
        {
            const int bookPrice = 100;
            var discount = 0.0;

            if (books.Count == 2)
                discount = 0.05;
            else if (books.Count == 3)
                discount = 0.1;
            else if (books.Count >= 4)
                discount = 0.2;

            return (int) (bookPrice * books.Count * (1-discount));
        }
    }
}
