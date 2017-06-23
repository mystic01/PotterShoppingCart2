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

        [TestMethod()]
        public void CalculateTotalPriceTest_第一集1本_第二集1本_預計回傳190()
        {
            //Arrange
            var books = new Dictionary<string, int>()
            {
                { "哈利波特_1", 1},
                { "哈利波特_2", 1}
            };
            var expected = 190;

            //Act
            var actual = PotterShoppingCart.CalculateTotalPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalPriceTest_第一集1本_第二集1本_第三集1本_預計回傳270()
        {
            //Arrange
            var books = new Dictionary<string, int>()
            {
                { "哈利波特_1", 1},
                { "哈利波特_2", 1},
                { "哈利波特_3", 1}
            };
            var expected = 270;

            //Act
            var actual = PotterShoppingCart.CalculateTotalPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalPriceTest_第一集1本_第二集1本_第三集1本_第四集1本_預計回傳320()
        {
            //Arrange
            var books = new Dictionary<string, int>()
            {
                { "哈利波特_1", 1},
                { "哈利波特_2", 1},
                { "哈利波特_3", 1},
                { "哈利波特_4", 1},
            };
            var expected = 320;

            //Act
            var actual = PotterShoppingCart.CalculateTotalPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalPriceTest_第一集1本_第二集1本_第三集1本_第四集1本_第五集1本_預計回傳375()
        {
            //Arrange
            var books = new Dictionary<string, int>()
            {
                { "哈利波特_1", 1},
                { "哈利波特_2", 1},
                { "哈利波特_3", 1},
                { "哈利波特_4", 1},
                { "哈利波特_5", 1},
            };
            var expected = 375;

            //Act
            var actual = PotterShoppingCart.CalculateTotalPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalPriceTest_第一集1本_第二集1本_第三集2本_預計回傳370()
        {
            //Arrange
            var books = new Dictionary<string, int>()
            {
                { "哈利波特_1", 1},
                { "哈利波特_2", 1},
                { "哈利波特_3", 2},
            };
            var expected = 370;

            //Act
            var actual = PotterShoppingCart.CalculateTotalPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalPriceTest_第一集1本_第二集2本_第三集2本_預計回傳460()
        {
            //Arrange
            var books = new Dictionary<string, int>()
            {
                { "哈利波特_1", 1},
                { "哈利波特_2", 2},
                { "哈利波特_3", 2},
            };
            var expected = 460;

            //Act
            var actual = PotterShoppingCart.CalculateTotalPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
