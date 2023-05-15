using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class PrivilegedCustomer:Customer
    {
        public string MembershipCardType { get; set; }

        public PrivilegedCustomer()
        {

        }

        public PrivilegedCustomer(string name, string contactNumber, string emailId, string address, string cardType):base(name,contactNumber,emailId,address)
        {
            MembershipCardType = cardType;
        }

        public override string GetCustomerDetails()
        {
            string details = base.GetCustomerDetails();
            details += " " + MembershipCardType;
            return details;
        }
    }
}
