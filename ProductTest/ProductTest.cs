using ECommerceApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp
{
    public class ProductTests
    {
        [SetUp]
        public void Setup()
        {

        }

        // Tests for ProductId 
        [TestCase(1)]
        [TestCase(5000)]
        [TestCase(10000)]
        public void ProductId_Test(int productId)
        {
            // Assign 
            var product = new Product(productId, "ProductA", 10.00, 100);

            // Act 
            var actual = product.ProductID;

            // Assert 
            Assert.That(actual, Is.EqualTo(productId));
        }

        // Tests for ProductName 
        [TestCase("Product A")]
        [TestCase("Product B")]
        [TestCase("Product C")]
        public void ProductName_Test(string productName)
        {
            // Assign 
            var product = new Product(1, productName, 10.00, 100);

            // Act 
            var actual = product.ProductName;

            // Assert 
            Assert.That(actual, Is.EqualTo(productName));
        }

        // Tests for Price 
        [TestCase(1.00)]
        [TestCase(2500.00)]
        [TestCase(5000.00)]
        public void Price_Test(double price)
        {
            // Assign 
            var product = new Product(1, "ProductA", price, 100);

            // Act 
            var actual = product.Price;

            // Assert 
            Assert.That(actual, Is.EqualTo(price));
        }

        // Tests for Stock 
        [TestCase(1)]
        [TestCase(50000)]
        [TestCase(100000)]
        public void Stock_Test(int stock)
        {
            // Assign 
            var product = new Product(1, "ProductA", 10.00, stock);

            // Act 
            var actual = product.Stock;

            // Assert 
            Assert.That(actual, Is.EqualTo(stock));
        }

        // Tests for IncreaseStock 
        [TestCase(10, 10, 20)]
        [TestCase(5, 15, 20)]
        [TestCase(100, 100, 200)]
        public void IncreaseStock_Test(int initialStock, int amountToAdd, int expected)
        {
            // Assign 
            var product = new Product(1, "ProductA", 10.00, initialStock);

            // Act 
            product.IncreaseStock(amountToAdd);
            var actual = product.Stock;

            // Assert 
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Tests for DecreaseStock 
        [TestCase(20, 10, 10)]
        [TestCase(200, 100, 100)]
        public void DecreaseStock_Test(int initialStock, int amountToSubtract, int expected)
        {
            // Assign 
            var product = new Product(1, "ProductA", 10.00, initialStock);

            // Act 
            product.DecreaseStock(amountToSubtract);
            var actual = product.Stock;

            // Assert 
            Assert.That(actual, Is.EqualTo(expected));

        }

        // Tests for DecreaseStock Exception 
        [Test]
        public void DecreaseStock_Exception_Test()
        {
            // Assign 
            var product = new Product(1, "TestProduct", 100.0, 10);

            // Assert 
            Assert.Throws<ArgumentException>(() => product.DecreaseStock(15));
        }

    }
}
