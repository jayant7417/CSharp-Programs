using System;

namespace Sample10
{
    class Player
    {
        public int age;
        public double runRate;
        public void SetData(double runRate)
        {
            this.age = 0;
            this.runRate = runRate;
        }
        public void SetData(int age)
        {
            this.age = age;
            this.runRate = 0.0;
        }
        public void Display()
        {
            Console.WriteLine(age + " " + runRate);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Player player = new Player();
            player.SetData(5);
            player.Display();
        }
    }
}
