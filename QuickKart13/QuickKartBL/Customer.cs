using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    //base class
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        protected string Address { get; set; }
        private string PhoneNumber { get; set; }

        public string GetInfo()
        {
            this.PhoneNumber = "9987675849";
            this.CustomerId = 101;
            this.CustomerName = "Ted";
            this.Address= "Mount Royal,Canada";
            return "Quickkart Customer";
        }

    }

}
