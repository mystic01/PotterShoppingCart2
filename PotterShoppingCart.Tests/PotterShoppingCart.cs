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
            if (books.Count <= 1)
                return bookPrice * books.Count;
            else
                return (int) (bookPrice * books.Count * 0.95);
        }
    }
}
