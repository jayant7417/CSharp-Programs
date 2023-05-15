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
            //Customer custObj = new Customer();
            //Customer custObjOne = new Customer("Ted");

            Customer custObjTwo = new Customer("ted@gmail.com", "Sweden", "Ted");
            //Customer custObjThree = new Customer("Ted", "ted@gmail.com", "Sweden");

            Console.WriteLine("Customer Id is      : " + custObjTwo.customerId);
            Console.WriteLine("Customer Name is    : " + custObjTwo.customerName);
            Console.WriteLine("Customer EmailId is : " + custObjTwo.emailId);
            Console.WriteLine("Customer Address is : " + custObjTwo.address);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
