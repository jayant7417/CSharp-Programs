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
        public int QuantityAvailabe { get; set; }
        public double Price { get; set; }

        public Product(string productId, string productName, int quantityAvailable, double price)
        {
            ProductId = productId;
            ProductName = productName;
            QuantityAvailabe = quantityAvailable;
            Price = price;
        }
    }
}
