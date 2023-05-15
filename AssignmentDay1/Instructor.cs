using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay1
{
    class Instructor
    {
        public float avgFeedback;
        public int experience;
        public string instructorName;
        public string[] instructorSkill;

        public Instructor()
        {
        }

        public Instructor(string instructorName, float avgFeedback, int experience, string[] instructorSkill)
        {
            this.instructorName = instructorName;
            this.avgFeedback = avgFeedback;
            this.experience = experience;
            this.instructorSkill = instructorSkill;

        }

        public bool CheckSkill(string technology)
        {
            bool flag = false;
            foreach(string item in instructorSkill)
            {
                if (item.Equals(technology))
                {
                    flag = true;
                    Console.WriteLine("Skill Matched.....");
                }
            }
            return flag;
        }

        public bool ValidateEligibility()
        {
            if (experience > 3 && avgFeedback >= 4.5)
            {
                Console.WriteLine("Eligible....");
                return true;
            }
            else if (experience <= 3 && avgFeedback >= 4)
            {
                Console.WriteLine("Eligible....");
                return true;
            }
            else
            {
                Console.WriteLine("Not Eligible!!!!");
                return false;
            }
        }
    }
}
