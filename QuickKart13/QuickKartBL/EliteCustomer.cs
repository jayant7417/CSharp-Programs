using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    //derived class
    public class EliteCustomer : Customer //is-A or inheritance relationship
    {        
        public int CouponsOwned { get; set; }

        public double CalculateDiscount()
        {
            double discount = CouponsOwned * 0.01;
            this.CouponsOwned = 0;
            return discount;
        }
    }
}
