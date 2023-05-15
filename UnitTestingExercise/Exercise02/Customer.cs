using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public class Customer
    {
        public int customerId;
        public string customerName;
        public string address;
        public DateTime dateOfBirth;
        public string emailId;
        public string gender;
        public string password;
        public string customerType;

        public Customer(int customerId,string customerName,string address,DateTime dateOfBirth,string emailId,string gender,string password,string customerType)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.address = address;
            this.dateOfBirth = dateOfBirth;
            this.emailId = emailId;
            this.gender = gender;
            this.password = password;
            this.customerType = customerType;

        }
     

        public double GetDiscount()
        {
            double discount = 0.0;
            if (customerType.Equals("Privileged"))
            {
                discount = 2.0;
            }
            else if (customerType.Equals("Regular"))
            {
                discount = 5.0;
            }
            else if (customerType.Equals("Elite"))
            {
                discount = 7.0;
            }
            else
            {
                discount = 0;
            }
            return discount;
        }
    }
}
