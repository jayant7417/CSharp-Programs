using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            //EmployeeContext employeeContext = new EmployeeContext();
            //Employee employee = employeeContext.Employees.Single(emp => emp.EmployeeId == id);

            //Employee employee = new Employee()
            //{
            //    EmployeeId = 101,
            //    Name = "Nitin", 
            //    Gender = "Male",
            //    City = "Delhi"
            //};

            return View();
        }

        public JsonResult Index(string departmentId)
        {
            //int deptId = Int32.Parse(departmentId);
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employee = employeeContext.Employees.ToList();
            return Json(employee, JsonRequestBehavior.AllowGet);
        }
    }
}