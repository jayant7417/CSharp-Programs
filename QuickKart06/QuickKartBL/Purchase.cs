using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Purchase
    {
        public void PrintPurchaseDetails(string purchaseId, string productName, int quantityOrdered, string shippingAddress = "NA")
        {
            Console.WriteLine("Purchase Details are :");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Purchase Id={0}", purchaseId);
            Console.WriteLine("Product Name={0}", productName);
            Console.WriteLine("Quantity Ordered={0}", quantityOrdered);
            Console.WriteLine("Shipping Address={0}", shippingAddress);
            Console.WriteLine("----------------------------------------------");
        }
    }
}
