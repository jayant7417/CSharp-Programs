using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_02
{
    public class Customer
    {
        public string customerName;
        public string customerAddress;
        public string customerContact;
        public void MyProfile()
        {
            Console.WriteLine("Print Customer Details");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer custObj1 = new Customer();
            Customer custObj2 = new Customer();
            Customer custObj3 = custObj1;
            custObj1 = null;
            custObj1.MyProfile();

            Console.ReadKey();
        }
    }
}
