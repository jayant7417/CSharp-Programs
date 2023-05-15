using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Purchase
    {
        public string purchaseId;
        public string quantityOrdered;
        public string shippingAddress;
        public string productName;

        public Purchase(string purchaseId, string productName, string quantityOrdered, string shippingAddress)
        {
            this.purchaseId = purchaseId;
            this.productName = productName;
            this.quantityOrdered = quantityOrdered;
            this.shippingAddress = shippingAddress;
        }
        
        public Purchase()
        {
        }

        public void PrintPurchaseDetails(object[] purchaseDetails)
        {
            Console.WriteLine("Purchase Details are :");
            Console.WriteLine("----------------------------------------------");
            foreach (object item in purchaseDetails)
                Console.WriteLine(item);
            Console.WriteLine("----------------------------------------------");

        }


    }
}
