using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business_Layer;

namespace Web_Business_Object.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<Employee> employees = employeeBusinessLayer.Employees.ToList();

            return View(employees);
        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(FormCollection formCollection)
        //{
        //    Employee employee = new Employee();
        //    employee.Name = formCollection["Name"];
        //    employee.Gender = formCollection["Gender"];
        //    employee.City = formCollection["City"];
        //    employee.DateOfBirth = Convert.ToDateTime(formCollection["DateOfBirth"]);

        //    EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
        //    employeeBusinessLayer.AddEmployee(employee);
        //    return RedirectToAction("Index", "Employee");
        //}

        //[HttpPost]
        //public ActionResult Create(string Name, string Gender, string City, DateTime DateOfBirth)
        //{
        //    Employee employee = new Employee();
        //    employee.Name = Name;
        //    employee.Gender = Gender;
        //    employee.City = City;
        //    employee.DateOfBirth = DateOfBirth;

        //    EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
        //    employeeBusinessLayer.AddEmployee(employee);
        //    return RedirectToAction("Index", "Employee");
        //}

        //[HttpPost]
        //public ActionResult Create(Employee employee)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
        //        employeeBusinessLayer.AddEmployee(employee);
        //        return RedirectToAction("Index", "Employee");
        //    }

        //    return View();
        //}

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {

            Employee employee = new Employee();
            TryUpdateModel(employee);
            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                employeeBusinessLayer.EditEmployee(employee);
                return RedirectToAction("Index", "Employee");
            }

            return View();
        }
        public ActionResult Delete(string id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            employeeBusinessLayer.DeleteEmployee(Convert.ToInt32(id));
            return RedirectToAction("Index", "Employee");
        }

        public ActionResult Details(string id)
        {
            Employee employee = new Employee();
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            employee = employeeBusinessLayer.EmployeeDetails(Convert.ToInt32(id));
            return View(employee);
        }

        //[HttpGet]
        [ActionName("Edit")]
        public ActionResult Edit(string id)
        {
            Employee employee = new Employee();
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            employee = employeeBusinessLayer.EmployeeDetails(Convert.ToInt32(id));
            return View(employee);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post()
        {
            Employee employee = new Employee();
            TryUpdateModel(employee, null, null, new string[] { "ProfilePic" });

            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                employeeBusinessLayer.EditEmployee(employee);

                return RedirectToAction("Index", "Employee");
            }

            return View(new Employee());
        }

        public ActionResult UploadFiles(FormCollection formCollection)
        {
            int id = int.Parse(formCollection["ID"]);

            HttpPostedFileBase file = Request.Files[0];
            EmployeeBusinessLayer employeeBusiness = new EmployeeBusinessLayer();
            Employee employee = employeeBusiness.EmployeeDetails(id);
            if (file != null)
            {
                employee.ProfilePic = file;
                string fileName = Path.GetFileNameWithoutExtension(employee.ProfilePic.FileName);
                string extension = Path.GetExtension(employee.ProfilePic.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                employee.ImagePath = "~/UploadedFiles/" + fileName;

                fileName = Path.Combine(Server.MapPath("~/UploadedFiles/"), fileName);
                employee.ProfilePic.SaveAs(fileName);

                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                employeeBusinessLayer.UploadImage(employee);

                return Json(employee.ImagePath, JsonRequestBehavior.AllowGet);
            }

            return Json(null, JsonRequestBehavior.AllowGet);
        }

    }
}