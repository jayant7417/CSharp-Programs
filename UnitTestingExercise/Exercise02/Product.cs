using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public class Product
    {
        public string productId;
        public string productName;
        public string description;
        public double price;

        public Product(string productId,string productName,string description,double price)
        {
            this.productId = productId;
            this.productName = productName;
            this.description = description;
            this.price = price;
        }
    }
}
