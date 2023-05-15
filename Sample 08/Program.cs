using System;

namespace Sample_08
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCourseDetails("MVC", "SharePoint", "Azure");
        }
        public static void PrintCourseDetails(string mainSubj = "C#", params string[] electives)
        {
            Console.WriteLine("Main sub : {0}", mainSubj);
            Console.WriteLine("No. of electives :{0} ", electives.Count());
        }
    }
}
