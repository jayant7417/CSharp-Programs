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
            Customer obj = new RegularCustomer(1001, "Nitin", 10);
            RegularCustomer rcobj = (RegularCustomer)obj;
            Console.WriteLine(rcobj.DiscountPercentage);

            Console.ReadKey();

        }
    }
}
