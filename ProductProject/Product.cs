using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Product
    {
        public int ProductID {  get; set; }

        public string ProductName { get; set; }

        public double Price { get; set; }

        public int Stock {  get; set; }

        // empty parameter constructor 
        public Product() { }

        // full parameter constructor 
        public Product(int productID, string productName, double price, int stock)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }



        // Increase the stock
        public void IncreaseStock(int stockIn)
        {
            Stock += stockIn;
        }

        // decrease the stock
        public void DecreaseStock(int stockOut) {
            if (stockOut <= Stock)
            {
                Stock -= stockOut;
            }
            else
            {
                throw new ArgumentException("Not enough stock.");
            }
        }
    }
}
