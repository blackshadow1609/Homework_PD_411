using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Fraction a = new Fraction(1, 2);
			Fraction b = new Fraction(3, 4);

			Console.WriteLine($"a = {a}");
			Console.WriteLine($"b = {b}");
			Console.WriteLine($"a + b = {a + b}");
			Console.WriteLine($"a - b = {a - b}");
			Console.WriteLine($"a * b = {a * b}");
			Console.WriteLine($"a / b = {a / b}");
		}
	}
}
