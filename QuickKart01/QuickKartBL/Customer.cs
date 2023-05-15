using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        private static int counter;

        static Customer()
        {
            counter = 1000;
        }

        public Customer()
        {
            CustomerId = ++counter;
        }
    }
}
