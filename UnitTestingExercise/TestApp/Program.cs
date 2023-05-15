using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise02;

namespace TestApp
{
    class Program
    {
        public double CalculateBillAmount(double price, double discountPercentage, int quantityOrdered)
        {
            double totalAmount = quantityOrdered*price;
            double Bill = totalAmount - (totalAmount * discountPercentage) / 100;
            return Bill;
        }
        static void Main(string[] args)
        {
            Purchase purObj = new Purchase("1001", 3, "dcfdev", new DateTime(2016, 04, 01), "Card");
            Console.WriteLine("Bill = Rs" + purObj.CalculateBillAmount(2690.0, 3.0, purObj.quantityOrdered));
            Console.ReadKey();
        }
    }
}
