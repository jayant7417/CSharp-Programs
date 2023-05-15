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
            EliteCustomer eliteCustomer = new EliteCustomer();
            Console.WriteLine(eliteCustomer.CustomerName);

            RegularCustomer regularCustomer = new RegularCustomer();
            Console.WriteLine(regularCustomer.CustomerId);

            Console.WriteLine( eliteCustomer.GetInfo());

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
