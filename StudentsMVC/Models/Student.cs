using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentsMVC.Models
{
    [Table ("tblStudents")]
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Student Name is required")]
        public string Name { get; set; }
        public string City { get; set; }
        public string CourseId { get; set; }
    }
}