using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Point A = new Point();


			A.Print();
			A.X = 2;//A.SetX(2);
			A.Y = 3;//A.SetY(3);
			A.Print();


			Point B = new Point(50);
			//B.X = 7000;
			//B.Y = 8000;
			B.Print();

			Point C = new Point(7, 8);
			C.Print();

			int a = 2;
			int b = 3;
			int c = a + b;
			Console.WriteLine("\n------------------------------------\n");
			Point D = A + B;
			D.Print();
		}
	}
}
