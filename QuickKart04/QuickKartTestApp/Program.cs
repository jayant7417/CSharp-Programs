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
            Product productOne = new Product("P131", "Marble chess board", 10, 2000.00);
            int discount = 0;
            int min, max;

            string result = productOne.UpdateDiscount(ref discount, out min, out max);
            Console.WriteLine(result);
            Console.WriteLine("Discount for the product = {0}", discount);
            Console.WriteLine("Min price range ={0}\nMax price range ={1}", min, max);

            Console.WriteLine("\nPress Any Key to Continue....");
            Console.ReadKey();

        }
    }
}
