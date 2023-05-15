using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Purchase
    {
        public double CalculateBillAmount(Cart cart)
        {
            double totalPrice = 0;
            foreach (Product prod in cart.CartProducts)
            {
                totalPrice = prod.Price + totalPrice;
            }
            return totalPrice;
        }
    }
}
