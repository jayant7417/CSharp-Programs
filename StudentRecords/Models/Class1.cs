using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentRecords.Models
{
    public class Class1
    {
        public String Id { get; set; }
        public String StudentName { get; set; }
        public String StudentCourse { get; set; }
        public String Status { get; set; }

        public IEnumerable<Class1> GenerateRecord()
        {
            IEnumerable<Class1> list1 = new List<Class1>()
            {
                new Class1{Id = "101", StudentName = "Nitin", StudentCourse="MCA", Status="active"},
                new Class1{Id = "102", StudentName = "Gaurav", StudentCourse="BCA", Status="active"},
                new Class1{Id = "103", StudentName = "Sidhu", StudentCourse="LLB", Status="active"},
                new Class1{Id = "104", StudentName = "Aaryan", StudentCourse="MTech", Status="active"},
                new Class1{Id = "104", StudentName = "Aaryan", StudentCourse="MTech", Status="active"}
            };

            return list1;
        }

        public List<SelectListItem> GetCourses()
        {
            var course = new List<SelectListItem>();
            var courseList = GenerateRecord().Select(x => x.StudentCourse).Distinct().ToArray();
            foreach (var item in courseList)
            {
                course.Add(new SelectListItem { Text = item, Value = item });
            }
            return course;
        }

        public void Delete(string id, string course,  IEnumerable<Class1> list2)
        {
            if (id != null && course == null)
            {
                foreach (var item in list2)
                {
                    if (item.Id.Equals(id))
                    {
                        item.Status = "inactive";
                    }
                }
            }
        }

        public void Edit(string id, string name, string course, IEnumerable<Class1> list2)
        {
            if (id != null && name != null && course != null)
            {
                foreach (var item in list2)
                {
                    if (item.Id.Equals(id))
                    {
                        item.StudentName = name;
                        item.StudentCourse = course;
                    }
                }
            }
        }
    }

    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}