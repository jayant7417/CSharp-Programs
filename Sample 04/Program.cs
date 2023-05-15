using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample04
{
    using System;

	class Calculator
	{
		private static int num = 10;

		public static void Reset()
		{
			num = 0;
		}
		public static void Add()
		{
			num += 10;
		}
		public static void Sub(int num)
		{
			num -= 5;
		}
		public static void Show()
		{
			Console.Write(num + " ");
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			int num = 55;
			Calculator.Sub(num);
			Console.Write(num + " ");
			Calculator.Add();
			Console.Write(num + " ");
			Calculator.Show();

			Console.ReadKey();
		}
	}
}

