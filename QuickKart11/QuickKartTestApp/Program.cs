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
            Purchase purchaseObj = new Purchase();
            Console.WriteLine("Total bill amount of all the products " +
                   "purchased is : " + purchaseObj.CalculateBillAmount(cartObj));

            Console.WriteLine("Press Any Key to Continue....");
            Console.ReadKey();
            
        }
    }
}
