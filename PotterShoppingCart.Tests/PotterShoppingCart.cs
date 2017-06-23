using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.Tests
{
    public class PotterShoppingCart
    {
        private const int BOOK_PRICE = 100;
        private static readonly Dictionary<int, double> SUITE_DISCOUNT = new Dictionary<int, double>
        {
            {1, 0},
            {2, 0.05},
            {3, 0.1},
            {4, 0.2},
            {5, 0.25}
        };

        public static int CalculateTotalPrice(Dictionary<string, int> books)
        {
            var totalPrice = 0;
            
            while (books.Count > 0)
            {
                var suiteSize = books.Count;
                var suiteAmout = books.Min(x => x.Value);

                var discount = SUITE_DISCOUNT[suiteSize];                
                var oneSuitePrice = (int)(BOOK_PRICE * suiteSize * (1 - discount));

                totalPrice += oneSuitePrice * suiteAmout;

                //算過的從 books 中移掉
                books = books.ToDictionary(x => x.Key, x => x.Value - suiteAmout)
                    .Where(x => x.Value > 0)
                    .ToDictionary(x => x.Key, x => x.Value);
            }

            return totalPrice;
        }
    }
}
