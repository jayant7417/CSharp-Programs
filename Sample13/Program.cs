using System;

namespace Sample13
{
    class Parent
    {
        private string name;
        public Parent(string name)
        {
            Console.WriteLine(name + " is in Parent Parameterized constructor");
        }
    }
    class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Child Parameterless constructor");
        }
        public Child(string name)
            : base(name)
        {
            Console.WriteLine(name + " is in Child Parameterized constructor");
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Child obj = new Child("jack");
        }
    }
}
