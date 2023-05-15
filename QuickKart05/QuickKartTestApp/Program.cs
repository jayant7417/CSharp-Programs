using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickKartBL;

namespace QuickKartTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customerObj = new Customer("1001", "Nitin");
            customerObj.AddContactDetails("aaryanjess@gmail.com", 8700182338, 8788787877, 9876546758);

            Console.WriteLine("Customer contact details are:\n");
            Console.WriteLine("Email ID = " + customerObj.EmailID);
            foreach (long customerno in customerObj.CustomerContact)
            {
                Console.WriteLine("Contact Number = " + customerno);
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
