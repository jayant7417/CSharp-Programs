using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Customer
    {
        public int customerId;
        public string customerName;
        public string emailId;
        public string address;

        public Customer()
        {
            customerId = 1001;
        }

        // To create a customer object name
        public Customer(string customerName) : this()
        {
            this.customerName = customerName;              
        }

        //To create a customer object with email id and address
        public Customer(string emailId, string address, string CustomerName) : this(CustomerName)
        {

            this.emailId = emailId;
            this.address = address;
        }


    }
}
