using System;

namespace Sample07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Sum(j: 5));
        }
        public static double Sum(int i = 4, int j = 7)
        {
            int sum = i + j;
            return sum;
        }
        public static double Sum(int i = 10, int j = 6, int k = 8)
        {
            int sum = i + j + k;
            return sum;
        }

    }
}
