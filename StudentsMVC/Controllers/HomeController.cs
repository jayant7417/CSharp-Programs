using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentsMVC.Models;
using StudentsMVC.Business;

namespace StudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public StudentManager studentManager = new StudentManager();

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetCourseData()
        {
            List<Course> courses = studentManager.CourseData();
            return Json(courses, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetStudentData(int courseId)
        {
            List<Student> students = studentManager.StudentData(courseId);
            return Json(students, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Update(Student stuObj)
        {
           return Json(studentManager.UpdateStudent(stuObj), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int id)
        {
            return Json(studentManager.DeleteStudent(id), JsonRequestBehavior.AllowGet);
        }
    }
}