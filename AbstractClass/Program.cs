using System;

namespace AbstractClass
{
    abstract class Main
    {
        public abstract void Add(int x, int y);         //Abstract Method
        public void Display()                           //Non Abstract Method
        {
            Console.WriteLine("This is an Abtract Class Method!!");
        }
            /*A method without any method body is known as an abstract method, what the method contains is only the 
             declaration of the method.*/

            /*This Abstract method should me declared inside an Abstract Class.*/

            /*If a method is declared as abstract under any class then the child class of that class is responsible 
             for implementing the method.*/
    }

    class Program : Main
    {
        //Child Class of Abstract Class must implement each and every abstract method of Parent Class.
        public static void Main(String[] args)
        {
            Program obj = new Program();
            obj.Add(10,20);
            obj.Display();
            Console.ReadKey();
        }

        public override void Add(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("Sum : " + sum);
        }
    }
}
