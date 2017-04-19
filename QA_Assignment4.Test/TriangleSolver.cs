using System;

namespace QA_Assignment4.Test
{
	public class TriangleSolver
	{
		public static string Analyze(int a, int b, int c)
		{
			string triangleType = "";
			if (a == b && b == c)
			{
				triangleType = "Equilateral";
				Console.Write("This is an equilateral triangle.\n");
			}
			else if (a == b || b == c || c == a)
			{
				triangleType = "Isosceles";
				Console.Write("This is an isosceles triangle.\n");
			}
			else
			{
				triangleType = "Scalene";
				Console.Write("This is a scalene triangle.\n");
			}

			return triangleType;
		}

		public static string checkTriangle(string userInput, int a, int b, int c)
		{
			string triangleType = "";
			if (userInput == "1")
			{
				if ((a + b) > c && (b + c) > a && (c + a) > b)
				{
					triangleType = TriangleSolver.Analyze(a, b, c);
				}
				else
				{
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

			return triangleType;
		}
	}
}
