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
            Console.WriteLine("Customer Id: " + customerOne.CustomerID);
            Console.WriteLine();
            Customer customerThree = new Customer(1002, "Nitin", "nitin@gmail.com");
            Console.WriteLine("Customer Id: " + customerThree.CustomerID);
            Console.WriteLine();

            Customer customerFour = new Customer("Violet", "12345678", "Violet@gmail.com", "Arizona");
            Console.WriteLine("Customer Id: " + customerFour.CustomerID);
            Console.WriteLine("Customer Name: " + customerFour.CustomerName);
            Console.WriteLine("Contact Number: " + customerFour.CustomerContact);
            Console.WriteLine("EmailId: " + customerFour.EmailId);
            Console.WriteLine("Address: " + customerFour.Address);
            Console.WriteLine();

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
