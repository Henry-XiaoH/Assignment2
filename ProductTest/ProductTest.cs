using Assignment2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProject
{
    internal class ProductTest
    {
        // ProductID Tests
        [Test]
        public void ProductID_ValidValue_Inrange()
        {
            var product = new Product(5000, "TestProduct", 100.0, 10);
            Assert.That(product.ProductID, Is.InRange(1, 10000));
        }

        [Test]
        public void ProductID_MinBoundaryValue_Pass()
        {
            var product = new Product(1, "TestProduct", 100.0, 10);
            Assert.That(product.ProductID, Is.EqualTo(1));
        }

        [Test]
        public void ProductID_MaxBoundaryValue_Pass()
        {
            var product = new Product(10000, "TestProduct", 100.0, 10);
            Assert.That(product.ProductID, Is.EqualTo(10000));
        }

        // ProductName Tests
        [Test]
        public void ProductName_ValidValue_Pass()
        {
            var product = new Product(1, "TestProduct", 100.0, 10);
            Assert.That(product.ProductName, Is.EqualTo("TestProduct"));
        }

        [Test]
        public void ProductName_EmptyValue_Pass()
        {
            var product = new Product(1, "", 100.0, 10);
            Assert.That(product.ProductName, Is.Empty);
        }

        [Test]
        public void ProductName_NullValue_Pass()
        {
            var product = new Product(1, null, 100.0, 10);
            Assert.That(product.ProductName, Is.Null);
        }

        // Price Tests
        [Test]
        public void Price_ValidValue_Inrange()
        {
            var product = new Product(1, "TestProduct", 2500.0, 10);
            Assert.That(product.Price, Is.InRange(1.0, 5000.0));
        }

        [Test]
        public void Price_MinBoundaryValue_Pass()
        {
            var product = new Product(1, "TestProduct", 1.0, 10);
            Assert.That(product.Price, Is.EqualTo(1.0));
        }

        [Test]
        public void Price_MaxBoundaryValue_Pass()
        {
            var product = new Product(1, "TestProduct", 5000.0, 10);
            Assert.That(product.Price, Is.EqualTo(5000.0));
        }

        // Stock Tests
        [Test]
        public void Stock_ValidValue_Inrange()
        {
            var product = new Product(1, "TestProduct", 100.0, 50000);
            Assert.That(product.Stock, Is.InRange(1, 100000));
        }

        [Test]
        public void Stock_MinBoundaryValue_Pass()
        {
            var product = new Product(1, "TestProduct", 100.0, 1);
            Assert.That(product.Stock, Is.EqualTo(1));
        }

        [Test]
        public void Stock_MaxBoundaryValue_Pass()
        {
            var product = new Product(1, "TestProduct", 100.0, 100000);
            Assert.That(product.Stock, Is.EqualTo(100000));
        }

        // IncreaseStock Tests
        [Test]
        public void IncreaseStock_ValidAmount_Pass()
        {
            var product = new Product(1, "TestProduct", 100.0, 10);
            product.Increase(5);
            Assert.That(product.Stock, Is.EqualTo(15));
        }

        [Test]
        public void IncreaseStock_ZeroAmount_Pass()
        {
            var product = new Product(1, "TestProduct", 100.0, 10);
            product.Increase(0);
            Assert.That(product.Stock, Is.EqualTo(10));
        }

        [Test]
        public void IncreaseStock_LargeValidAmount_Pass()
        {
            var product = new Product(1, "TestProduct", 100.0, 10);
            product.Increase(99990);
            Assert.That(product.Stock, Is.EqualTo(100000));
        }

        // DecreaseStock Tests
        [Test]
        public void DecreaseStock_ValidAmount_Pass()
        {
            var product = new Product(1, "TestProduct", 100.0, 10);
            product.Decrease(5);
            Assert.That(product.Stock, Is.EqualTo(5));
        }

        [Test]
        public void DecreaseStock_All_Pass()
        {
            var product = new Product(1, "TestProduct", 100.0, 10);
            product.Decrease(10);
            Assert.That(product.Stock, Is.EqualTo(0));
        }

        [Test]
        public void DecreaseStock_GreaterThanStock_ThrowException()
        {
            var product = new Product(1, "TestProduct", 100.0, 10);
            Assert.Throws<ArgumentException>(() => product.Decrease(15));
        }
    }
}
