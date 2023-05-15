using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentsMVC.Models
{
    [Table ("tblCourse")]
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
}