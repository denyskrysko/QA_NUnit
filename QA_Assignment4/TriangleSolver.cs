using System;

namespace QA_Assignment4.Main
{
	public static class TriangleSolver
	{
		public static string Analyze(int a, int b, int c)
		{
			string triangleType = "";

			if ((a + b) > c && (b + c) > a && (c + a) > b)
			{
				if (a == b && b == c)
				{
					triangleType = "equilateral";
					Console.Write("This is an equilateral triangle.\n");
				}
				else if (a == b || b == c || c == a)
				{
					triangleType = "isosceles";
					Console.Write("This is an isosceles triangle.\n");
				}
				else
				{
					triangleType = "scalene";
					Console.Write("This is a scalene triangle.\n");
				}

			}
			else
			{
				triangleType = "Triangle does not exist.";
			}

			return triangleType;
		}

		public static String checkTriangle(string userInput, int a = 0, int b = 0, int c = 0)
		{
			string result = "";

			if (userInput == "1")
			{
				Console.WriteLine("Enter side a");
				a = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter side b");
				b = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter side c");
				c = Convert.ToInt32(Console.ReadLine());

				if ((a + b) > c && (b + c) > a && (c + a) > b)
				{
					result = TriangleSolver.Analyze(a, b, c);

				}
				else
				{
					result = "Test failed.";
					Console.WriteLine("Triangle does not exist.");
				}

			}
			else if (userInput == "2")
			{
				Environment.Exit(0);
			}
			else
			{
				Console.WriteLine("Invalid value. Try again.");
				MainClass.Main(null);
			}

			return result;
		}
	}
}
