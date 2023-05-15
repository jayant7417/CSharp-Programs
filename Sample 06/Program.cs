using System;

namespace Sample_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2;
            CalculateSquare(num1);
            CalculateSquareAtAddress(ref num1);
            CalculateSquare(out num2);
            Console.WriteLine(num1 + "," + num2);
        }
        static void CalculateSquare(int num)
        {
            num = 5;
            num = num * num;
        }
        static void CalculateSquare(out int num)
        {
            num = 10;
            num = num * num;
        }
        static void CalculateSquareAtAddress(ref int num)
        {
            num = 5;
            num = num * num;
        }
    }
}
