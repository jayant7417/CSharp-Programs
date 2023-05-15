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
            Purchase obj = new Purchase();
            obj.PrintPurchaseDetails("1001", quantityOrdered : 10, productName : "Coke");

            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
          
        }
    }

}
