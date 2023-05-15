using System;

namespace Sample_09
{
    using System;

    class Calculation
    {
        // First Square method
        public void Square(int x)
        {
            Console.WriteLine("Square of int " + x * x);
        }
        // Second Square method
        public void Square(double x)
        {
            Console.WriteLine("Square of double " + x * x);
        }

        // First Add method
        public void Add(int x, int y)
        {
            Console.WriteLine("Sum of int and int " + (x + y));
        }

        // Second Add method
        public void Add(double x, int y)
        {
            Console.WriteLine("Sum of double and int " + (x + y));
        }

        // Third Add method
        public void Add(int x, double y)
        {
            Console.WriteLine("Sum of int and double " + (x + y));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculation obj = new Calculation();
            obj.Square(5);
            /* 1. Comment out the first Square method and execute again */
            /* Here since we are passing an integer value both methods are applicable 
             * but the best out of the two is chosen */

            /* 2. Now comment the second Square method and uncomment the first Square method 
             * Uncomment and execute the following statement */
            //obj.Square(2.5);
            /* In this case, only the second Square method is available which accepts a 
             * parameter of type double. Hence a compilation error is thrown as implicit conversion 
             * of a double value to integer value cannot be done. */

            /* The following method call executes the first Add method as 
             * both the actual parameters are of int type */
            obj.Add(10, 20);

            // 3. Comment out the first Add method and execute.
            /* A compilation error is thrown as now there is an ambiguity between the second and third Add methods.
             * Both the remaining methods have one integer and one double parameter. 
             * Both these methods are equally applicable as the int values 10 and 20 can be assigned to the double type. */
        }
    }

}
