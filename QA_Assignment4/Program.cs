using System;

namespace QA_Assignment4.Main
{
	public class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("1. Enter triagle dementions.");
			Console.WriteLine("2. Exit.");

			TriangleSolver.checkTriangle(Console.ReadLine());

			if(Console.ReadLine() == "Invalid value. Try again."){
				Main(args);	
			}
		}
	}
}
