using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArithmeticOperators
{
	public class ArithmeticOperators
	{
		public static double CalcCircleArea(double radius)
		{
			return Math.PI * Math.Pow(radius, 2); // User Math.Pow to raise a number to a power
		}

		public static void Division()
		{
			int numA = 10;
			int numB = 3;

			// Dividing integers A
			// Integer division or DIV in C Sharp is just division where both numbers are integral types 
			double numC = numA / numB;
			Console.WriteLine($"When both numbers are integers: {numA} / {numB} is {numC}.");

			// Dividing integers B
			numC = numA / (double)numB;
			Console.WriteLine($"When one number is converted to a double: {numA} / {(double)numB} is {numC}.");

			Console.WriteLine();
		}

		
		// Constants are used for values that will not change whilst the program is running.
		private const decimal VatRate = 0.2m;

		public static decimal CalculateEatInCost(decimal foodCost)
		{
			return foodCost * (1 + VatRate);
		}

		public static void Remainders()
		{
			int numA = 10;
			int numB = 3;

			int remainder = numA % numB;
			Console.WriteLine($"The remainder of {numA} / {numB} (integers) is {remainder}.");

			double numC = 10.0;
			double numD = 4.4;

			double remainder2 = numC % numD;
			Console.WriteLine($"The remainder of {numC} / {numD} (doubles) is {remainder2}.");

			decimal numE = 10.0m;
			decimal numF = 4.4m;

			// We can avoid rounding errors by using the decimal data type
			// This is one of the reasons it is well suited to financial calculations
			decimal remainder3 = numE % numF;
			Console.WriteLine($"The remainder of {numE} / {numF} (decimals) is {remainder3}.");

			Console.WriteLine();
		}

		// At a midpoint Math.Round rounds to the nearest even number
		public static void Rounding()
		{
			double num1 = 12.5;
			Console.WriteLine($"{num1} rounded is {Math.Round(num1)}");

			double num2 = 13.5;
			Console.WriteLine($"{num2} rounded is {Math.Round(num2)}");

			Console.WriteLine();
		}

		// There are different options to round in c#
		public static void DifferentRoundingOptions(double number)
		{
			double roundedNumber = Math.Round(number);
			Console.WriteLine($"{number} rounded is {roundedNumber}");

			// Floor gives the nearest integral number that is lower
			double flooredNumber = Math.Floor(number);
			Console.WriteLine($"{number} floored is {flooredNumber}");

			// Ceiling gives the nearest integral number that is higher
			double ceilingNumber = Math.Ceiling(number);
			Console.WriteLine($"{number} ceiling is {ceilingNumber}");

			// Truncate gives the nearest integral number that is closer to zero
			double truncatedNumber = Math.Truncate(number);
			Console.WriteLine($"{number} truncated is {truncatedNumber}");

			Console.WriteLine();
		}
	}
}
