using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class InternationalSeller:Seller
    {
        public double ExportCharge { get; set; }

        public InternationalSeller(string sellerId, string sellerName,
                                   string[] sellerLocations, double exportCharge) 
                                   : base(sellerId, sellerName, sellerLocations)
        {
            ExportCharge = exportCharge;
        }
       
    }
}
