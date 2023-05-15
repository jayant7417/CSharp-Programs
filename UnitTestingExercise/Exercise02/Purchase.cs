using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public class Purchase 
    {
        public string purchaseId;
        public int quantityOrdered;
        public string shippingAddress;
        public DateTime dateOfPurchase;
        public string paymentType;

        public Purchase(string purchaseId,int quantityOrdered,string shippingAddress,DateTime dateOfPurchase,string paymentType)
        {
            this.purchaseId = purchaseId;
            this.quantityOrdered = quantityOrdered;
            this.shippingAddress = shippingAddress;
            this.dateOfPurchase = dateOfPurchase;
            this.paymentType = paymentType;

        }
        public double CalculateBillAmount(double price)
        {
            return price * quantityOrdered;
        }
        public double CalculateBillAmount(double price, double discountPercentage, int quantityOrdered)
        {
            double amount = 0;
            //amount = price * quantityOrdered;
            amount = CalculateBillAmount(price);
            amount = amount - (amount * (discountPercentage / 100));
            return amount;
        }

    }
}
