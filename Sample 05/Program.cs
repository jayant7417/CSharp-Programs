using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_05
{
    class Category
    {
        public int CategoryId { get; set; }     //Line 1
        public string CategoryName { get; set; }    //Line 2
        public Category(int categoryId, string categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Category c1 = new Category(1001, "Sports");
            Console.WriteLine("Category ID : " + c1.CategoryId);
            Console.WriteLine("Category Name : " + c1.CategoryName);

            Console.ReadKey();
        }
    }
}

