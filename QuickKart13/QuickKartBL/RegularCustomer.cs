using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    //derived class
    public class RegularCustomer: Customer //is-A or inheritance relationship
    {       
        public double DiscountPercentage { get; set; }        

        public double CalculateDiscount()
        {
            //this.PhoneNumber= "9987675849";
            this.CustomerId = 101;
            this.CustomerName = "Ted";
            this.Address= "Mount Royal,Canada";
            this.PhoneNumber = "8700182338";
            return DiscountPercentage / 100;
        }

    }
}
