using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Demo
    {
        public int Id { get; set; }
        public String name { get; set; }
        public String course { get; set; }

    }

    public class Record
    {
        public List<Demo> GetRecords()
        {
            var obj = new List<Demo>();
            for (int i = 0; i < 20; i++)
            {
                obj.Add(new Demo { Id = i, name = "name" + i, course = "course " + i });
            }
            return obj;

        }
    }
}