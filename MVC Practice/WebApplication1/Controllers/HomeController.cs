using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        Demo obj = new Demo();
        // GET: Home
        public ActionResult Index()
        {
           
            return RedirectToAction("Record");

        }

        public ActionResult Page1()
        {
            return View("~/Views/Home1/Page1.cshtml");
        }

        public ActionResult Record()
        {
            var record = new Record();
            //ViewBag
            ViewBag.m1 = "This is Controller to View Data Passing";
            ViewBag.Id = obj.Id;
            ViewBag.name = obj.name;
            ViewBag.course = obj.course;
            ViewBag.Students = record.GetRecords();

            //ViewData
            ViewData["Students"] = record.GetRecords();
            TempData["Students"] = record.GetRecords();

            return View("~/Views/Home/Index.cshtml");
        }
    }
}