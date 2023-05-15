using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ContactUsController : Controller
    {
        List<Class1> list1 = new List<Class1>()
            {
                new Class1{Id = 101, name = "Nitin", course="MCA"},
                new Class1{Id = 102, name = "Gaurav", course="BCA"},
                new Class1{Id = 103, name = "Sidhu", course="LLB"},
                new Class1{Id = 104, name = "Aaryan", course="MTech"}
            };

        // GET: ContactUs
        public ActionResult Index()
        {
            //ViewModel

            IEnumerable<Class1> list2 = new List<Class1>();
            list2 = list1.Where(x => x.Id == 101);
            return View(list2);
        }

        public ActionResult checkTemp(string id)
        {

            TempData["data"] = "This is Temporary data and it will be cleared out after completion of a subsequent request";
            return RedirectToAction("Index");
        }
    }
}