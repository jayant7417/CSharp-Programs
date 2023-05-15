using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Business_Layer
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Upload Profile Picture")]
        public HttpPostedFileBase ProfilePic { get; set; }

    }
}
