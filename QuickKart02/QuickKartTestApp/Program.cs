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
            Customer customerOne = new Customer();
            Customer customerTwo = new Customer();
            Customer customerThree = new Customer();
            int n;

            Console.WriteLine("Customer ID = " + customerOne.CustomerId);
            Console.WriteLine("Customer ID = " + customerTwo.CustomerId);
            Console.WriteLine("Customer ID = " + customerThree.CustomerId);

            n = Customer.GetNumberOfCustomers();

            Console.WriteLine("Number of Customer = " + n);

            Console.WriteLine("\n\nPress any key to continue.....");
            Console.ReadKey();
        }
    }
}
