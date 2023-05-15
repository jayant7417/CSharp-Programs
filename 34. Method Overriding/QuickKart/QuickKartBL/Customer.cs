using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Customer
    {
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string EMailId { get; set; }
        public string Address { get; set; }

        public Gender gender;

        public Customer()
        {

        }

        public Customer(string name, string contactNumber, string emailId, string address, Gender gender)
        {
            Name = name;
            ContactNumber = contactNumber;
            EMailId = emailId;
            Address = address;
            this.gender = gender;
        }

        public string GetCustomerDetails()
        {
            return Name + " " + ContactNumber + " " + EMailId + " " + Address + " " + gender;
        }

        public double GetDiscount()
        {
            return 0.2;
        }
    }
}
