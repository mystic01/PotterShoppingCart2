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
            var totalPrice = 0;
            
            while (books.Count > 0)
            {
                var discount = GetDiscountBySuiteSize(books.Count);
                totalPrice += (int) (bookPrice * books.Count * (1 - discount));

                //算過的從 books 中移掉
                books = books.ToDictionary(x => x.Key, x => x.Value - 1)
                    .Where(x => x.Value > 0)
                    .ToDictionary(x => x.Key, x => x.Value);
            }

            return totalPrice;
        }

        private static double GetDiscountBySuiteSize(int suiteSize)
        {
            var discount = 0.0;
            if (suiteSize == 1)
                discount = 0.0;
            else if (suiteSize == 2)
                discount = 0.05;
            else if (suiteSize == 3)
                discount = 0.1;
            else if (suiteSize == 4)
                discount = 0.2;
            else if (suiteSize >= 5)
                discount = 0.25;
            return discount;
        }
    }
}
