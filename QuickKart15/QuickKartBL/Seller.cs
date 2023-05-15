using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Seller
    {        
        public string SellerId { get; set; }
        public string SellerName { get; set; }
        public string[] SellerLocations { get; set; }

        public Seller(string sellerId, string sellerName, string[] sellerLocations)
        {
            SellerId = sellerId;
            SellerName = sellerName;
            SellerLocations = sellerLocations;
        }
      
    }
}
