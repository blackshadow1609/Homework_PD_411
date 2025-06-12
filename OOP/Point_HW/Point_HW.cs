using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_HW
{
	public class Point
	{
		public double X { get; }
		public double Y { get; }

		public Point(double x, double y)
		{
			X = x;
			Y = y;
		}

		
		public static double operator -(Point a, Point b)
		{
			double dx = a.X - b.X;
			double dy = a.Y - b.Y;
			return Math.Sqrt(dx * dx + dy * dy);
		}

		
		public override string ToString()
		{
			return $"({X}, {Y})";
		}
	}
}
