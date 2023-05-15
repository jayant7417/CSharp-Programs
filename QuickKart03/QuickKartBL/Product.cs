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

        public Product(string ProductId, string ProductName, int QuantityAvailable, double Price)
        {
            this.ProductId = ProductId;
            this.ProductId = ProductName;
            this.QuantityAvailable = QuantityAvailable;
            this.Price = Price;
        }

        public string UpdateDiscount(ref int discount)
        {
            string result = "Eligible for discount";
            if (this.Price <= 500)
            {
                result = "Not eligible for discount";
            }
            else if (this.Price > 500 && this.Price <= 1000)
            {
                discount = 5;
            }
            else if (this.Price > 1000 && this.Price <= 5000)
            {
                discount = 10;
            }
            else if (this.Price > 5000 && this.Price <= 10000)
            {
                discount = 15;
            }
            else
            {
                discount = 20;
            }
            return result;
        }

    }
}
