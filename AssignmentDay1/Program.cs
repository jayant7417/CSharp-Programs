using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] instructorSkill = { "C", "C++", "Java", "CSharp" };
            Instructor I1 = new Instructor("Nitin", 2.5f, 2, instructorSkill);

            I1.CheckSkill("Java");
            I1.ValidateEligibility();

            Console.WriteLine("\nPress Any Key to Continue.....");
            Console.ReadKey();

        }
    }
}
