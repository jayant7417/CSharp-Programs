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
            Customer custObj = new Customer();
            //custObj.Address = "Mount Royal,Canada"; 
            custObj.CustomerId = 101;
            custObj.CustomerName = "Ted";
            custObj.Address = "Mount Royal,Canada";
            custObj.PhoneNumber= "9987675849";
            
        }
    }
}
