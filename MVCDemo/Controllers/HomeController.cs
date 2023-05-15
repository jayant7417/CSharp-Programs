using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public string Index(string id, string name)
        //{
        //    //return "Hello and Welcome to Asp.Net MVC";
        //    //return "id = " + id + "Name = " + Request.QueryString["name"];

        //    return "id = " + id + "Name = "+name;
        //}

        public ViewResult Index()
        {
            //ViewBag uses the dynamic features introduced in C# 4. It allows an object to have properties
            //dynamically added to it.

            ViewData["Countries"] = new List<string>()
            {
                "India", "US", "UK",
                "Canada"
            };

            ViewBag.CountriesList = new List<string>()
            {
                "India",
                "US", "UK", "Canada"
            };

            return View();
        }			

        public string GetDetails()
        {
            return "Get Details invoked";
        }

        public JsonResult GetEmployeeData(string departmentId)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employee = employeeContext.Employees.Where(emp => emp.DepartmentId == departmentId).ToList();
            return Json(employee, JsonRequestBehavior.AllowGet);
        }
    }
}