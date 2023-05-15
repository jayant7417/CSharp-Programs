using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class DomesticSeller:Seller
    {
        public bool ExpressDelivery { get; set; }

        public DomesticSeller(string sellerId, string sellerName, 
                              string[] sellerLocations, bool expressDelivery)
                              : base(sellerId,sellerName,sellerLocations)
        {
            this.ExpressDelivery = expressDelivery;
        }
       
    }
}
