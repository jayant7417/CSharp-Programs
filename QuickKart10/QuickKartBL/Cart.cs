using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Cart
    {
        public Product[] CartProducts { get; set; }

        public Cart(Product[] Products)
        {
            this.CartProducts = Products;
        }

        public double CalculateBill()
        {
            double totalBill = 0;
            int noOfItems = this.CartProducts.Length;

            for(int i = 0; i < noOfItems; i++)
            {
                totalBill += CartProducts[i].Price;
            }
            return totalBill;
        }

        //public string[] items;

        //public Cart()
        //{
        //    this.items = new string[4];
        //    items[0] = "Apple iPhone 6s Plus";
        //    items[1] = "Microsoft Lumia 950";
        //    items[2] = "HTC One M9";
        //    items[3] = "Samsung Galaxy S6";
        //}

        //public void DisplayItems()
        //{
        //    int index = 0;
        //    int numberOfItems = this.items.Length;
        //    while (index < numberOfItems)
        //    {
        //        Console.WriteLine(this.items[index]);
        //        index += 1;
        //    }
        //}
    }
}
