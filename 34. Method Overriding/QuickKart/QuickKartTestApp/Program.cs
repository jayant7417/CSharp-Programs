using QuickKartBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrivilegedCustomer privilegedCustomer = 
                new PrivilegedCustomer("Albert","9999999999","Albert@gmail.com","Churchgate road, Mumbai", Gender.Male, "Silver");
            Console.WriteLine("Privileged customer details are : " 
                + privilegedCustomer.GetCustomerDetails());

            RegularCustomer regularCustomer = 
                new RegularCustomer("Frank", "8888888888", "Franken@gmail.com", "Central Park, Manhattan", Gender.Female,  0.1);
            Console.WriteLine("Regular customer details are : "
                + regularCustomer.GetCustomerDetails());
            Console.WriteLine("Regular customer discount percentage is : " 
                + regularCustomer.GetDiscount());

            Console.WriteLine("Press Any key to continue....");
            Console.ReadKey();
        }
    }
}
