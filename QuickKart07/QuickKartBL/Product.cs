using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int QuantityAvailable { get; set; }
        public double Price { get; set; }
        public Product(string productId, string productName, int quantityAvailable, double price)
        {
            ProductId = productId;
            ProductName = productName;
            QuantityAvailable = quantityAvailable;
            Price = price;
        }

        public void updateProductDetails(double price)
        {
            this.Price = price;
        }

        public void updateProductDetails(int quantityAvailable)
        {
            this.QuantityAvailable = quantityAvailable;
        }

        public void UpdateProductDetails(double price, int quantityAvailable)
        {
            this.Price = price;
            this.QuantityAvailable = quantityAvailable;
        }

    }
}