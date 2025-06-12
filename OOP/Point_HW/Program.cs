using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_HW
{
	internal class Program
	{
		static void Main()
		{
			Point p1 = new Point(1, 2);
			Point p2 = new Point(4, 6);

			double distance = p1 - p2; //  '-'

			Console.WriteLine($"Точка 1: {p1}");
			Console.WriteLine($"Точка 2: {p2}");
			Console.WriteLine($"Расстояние между точками: {distance:F2}");
		}
	}
}
