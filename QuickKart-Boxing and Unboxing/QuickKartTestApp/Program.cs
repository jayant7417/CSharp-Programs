using QuickKartBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuickKartTestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string productName = "Samsung Galaxy J7";
            double mobilePrice = 15000.00;
            short quantity = 100;
            object obj = quantity;
            short newQuantity = (short)obj;
            double discount = .05;
            //array of objects
            object[] productDetails = { productName,mobilePrice,quantity,discount, obj, newQuantity };
            Purchase purchase1 = new Purchase();
            purchase1.PrintPurchaseDetails(productDetails);

            Console.ReadKey();
        }
    }
}
