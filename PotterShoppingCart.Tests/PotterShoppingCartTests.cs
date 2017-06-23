using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class PotterShoppingCartTests
    {
        [TestMethod()]
        public void CalculateTotalPriceTest_第一集1本_預計回傳100()
        {
            //Arrange
            var books = new Dictionary<string, int>()
            {
                { "哈利波特_1", 1}
            };
            var expected = 100;

            //Act
            var actual = PotterShoppingCart.CalculateTotalPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
