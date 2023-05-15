using StudentRecords.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentRecords.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private Class1 list1 = new Class1();
        public ActionResult Index(string id, string name, string course)
        {
            IEnumerable<Class1> list2 = new List<Class1>();
            list2 = list1.GenerateRecord();

            ViewBag.CourseList = list1.GetCourses();
            ViewBag.SelectCourse = "";

            //Delete
            list1.Delete(id, course, list2);

            //Edit
            list1.Edit(id, name, course, list2);


            list2 = list2.Where(x => x.Status == "active")
                .Select(x => x);

            return View(list2);
        }

        public ActionResult Edit(String Id) // Model class object  
        {
            var list1 = new Class1();

            IEnumerable<Class1> list3 = new List<Class1>();
            list3 = (list1.GenerateRecord()).Where(x => x.Id == Id);

            return View("~/Views/Home/Edit.cshtml", list3);
        }

        public ActionResult Delete(String Id) // Model class object  
        {
            return RedirectToAction("Index", Id);
        }

        public ActionResult Filter(string course)
        {
            var list3 = new List<Class1>();
            if (!string.IsNullOrEmpty(course))
            {
                var list2 = list1.GenerateRecord();
                list3 = list2.Where(x => x.StudentCourse == course && x.Status == "active").ToList();
            }
            ViewBag.CourseList = list1.GetCourses();
            ViewBag.SelectCourse = course;
            return View("~/Views/Home/Index.cshtml", list3);
        }
    }
}