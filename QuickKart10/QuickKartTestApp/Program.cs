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
            Product productTwo = new Product("P132", "Basket Ball", 8, 1000.00);
            Product productThree = new Product("P133", "Carrom Board", 11, 800.00);

            Product[] cartProducts = new Product[] { productOne, productTwo, productThree };
            Cart cartObj = new Cart(cartProducts);
            Console.WriteLine("Total bill for all products: " + cartObj.CalculateBill());

            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
    }
}
