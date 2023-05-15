using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Cart
    {
        public Product[] CartProducts { get; set; }

        public Cart(Product[] products)
        {
            this.CartProducts = products;
            
        }

        public double CalculateBill()
        {
            double totalBill = 0;
            int numberOfItems = this.CartProducts.Length;
            for (int i = 0; i < numberOfItems; i++)
            {
                totalBill += CartProducts[i].Price;
            }
            return totalBill;
        }

    }
}
   