using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
	
	internal class Point
	{
		//double x;
		//double y;

		//public double X
		//{
		//	get 
		//	{ 
		//		return x; 
		//	}
		//	set 
		//	{
		//		if(value > 1000) value = 800;
		//		this.x = value;
		//	}
		//}
		//public double Y
		//{
		//	get
		//	{
		//		return y;
		//	}
		//	set 
		//	{
		//		if (value > 1000) value = 600;
		//		this.y = value;
		//	}
		//}
		
		//public double GetX()
		//{
		//	return x;
		//}
		//public double GetY()
		//{
		//	return y;
		//}
		//public void SetX(double x)
		//{
		//	this.x = x;
		//}
		//public void SetY(double y)
		//{
		//	this.y = y;
		//}
		public double X { get; set; }
		public double Y { get; set; }

		// Constructors:
		public Point(double x = 0, double y = 0)
		{
			X = x;
			Y = y;
			Console.WriteLine($"Constructors:\t{this.GetHashCode()}");
		}
		~Point()
		{
			Console.WriteLine($"Destructor:\t{this.GetHashCode()}");
		}

		//Operators
		public static Point operator + (Point left, Point right)
		{
			Point result = new Point();
			result.X = left.X + right.X;
			result.Y = left.Y + right.Y;
			return result;

		}

		public void Print()
		{
			Console.WriteLine($"X = {X}, Y = {Y}");
		}

		void Metod()
		{
			
		}
	}
}
