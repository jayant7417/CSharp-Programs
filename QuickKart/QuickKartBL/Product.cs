using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuickKartBL
{
    public class Product
    {
        public string productId;
        public string productName;
        public double price;
        public int quantityAvailable;
        public Product(string productId, string productName, double price, int quantityAvailable)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.quantityAvailable = quantityAvailable;
        }
        public bool CheckAvailability(int quantityPurchased)
        {
            return (quantityPurchased <= this.quantityAvailable);
        }
    }
}