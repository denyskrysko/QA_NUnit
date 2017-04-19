using System;
using NUnit.Framework;
using QA_Assignment4;

namespace QA_Assignment4.Main
{
		[TestFixture()]
	public class TestCases
	{
		[Test()]
		public void TestCase1()
		{
			string expResult = "Triangle does not exist.";
			string actualResult = TriangleSolver.Analyze(1, 2, 8);
			Assert.AreEqual(expResult, actualResult);
		}

		[Test()]
		public void TestCase2()
		{
			string expResult = "equilateral";
			string actualResult = TriangleSolver.Analyze(5, 5, 5);
			Assert.AreEqual(expResult, actualResult);
		}

		[Test()]
		public void TestCase3()
		{
			string expResult = "isosceles";
			string actualResult = TriangleSolver.Analyze(10, 10, 8);
			Assert.AreEqual(expResult, actualResult);
		}

		[Test()]
		public void TestCase4()
		{
			string expResult = "scalene";
			string actualResult = TriangleSolver.Analyze(4, 5, 6);
			Assert.AreEqual(expResult, actualResult);
		}

		[Test()]
		public void TestCase5()
		{
			string expResult = "Triangle does not exist.";
			string actualResult = TriangleSolver.Analyze(2, 3, 10);
			Assert.AreEqual(expResult, actualResult);
		}

		[Test()]
		public void TestCase6()
		{
			string expResult = "equilateral";
			string actualResult = TriangleSolver.Analyze(3, 3, 3);
			Assert.AreEqual(expResult, actualResult);
		}

		[Test()]
		public void TestCase7()
		{
			string expResult = "isosceles";
			string actualResult = TriangleSolver.Analyze(5, 5, 2);
			Assert.AreEqual(expResult, actualResult);
		}

		[Test()]
		public void TestCase8()
		{
			string expResult = "scalene";
			string actualResult = TriangleSolver.Analyze(9, 6, 8);
			Assert.AreEqual(expResult, actualResult);
		}
	}
}
