using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class RegularCustomer : Customer  //is-A or inheritance relationship
    {
        public int DiscountPercentage { get; set; }

        public double CalculateDiscount()
        {
            return DiscountPercentage / 100;
        }

    }
}
