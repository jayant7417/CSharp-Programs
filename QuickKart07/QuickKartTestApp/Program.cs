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
            Product productObj = new Product("P116", "Samsung Galaxy S4", 10, 38000.00);
            Console.WriteLine("Product Price = " + productObj.Price);
            Console.WriteLine("Quantity Available = " + productObj.QuantityAvailable);

            productObj.updateProductDetails(40000.0);
            Console.WriteLine("\nProduct Price = " + productObj.Price);

            productObj.updateProductDetails(8);

            Console.WriteLine("Quantity Available = " + productObj.QuantityAvailable);

            productObj.UpdateProductDetails(35000.00, 7);

            Console.WriteLine("\nProduct Price = " + productObj.Price);
            Console.WriteLine("Quantity Available = " + productObj.QuantityAvailable);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }   
}
