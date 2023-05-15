using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Customer
    {       
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContact { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }

        public Customer()
        {
            this.CustomerID = 1001;
        }

        public Customer(int customerId, string customerName, string emailId)
        {
            this.CustomerID = customerId;
            this.CustomerName = customerName;
            this.EmailId = emailId;
        }

        public Customer(string customerName, string customerContact, string emailId, string address) : this()
        {
            this.CustomerName = customerName;
            this.CustomerContact = customerContact;
            this.EmailId = emailId;
            this.Address = address;
        }

    }
}
