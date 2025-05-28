using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_HW
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите размер фигуры: ");
			int size = int.Parse(Console.ReadLine());

			Console.WriteLine("Прямоугольник:");
			DrawRectangle(size);

			Console.WriteLine("Прямоугольный треугольник (возрастающий):");
			DrawIncreasingTriangle(size);

			Console.WriteLine("Прямоугольный треугольник (убывающий):");
			DrawDecreasingTriangle(size);

			Console.WriteLine("Треугольник с отступом (убывающий):");
			DrawIndentedDecreasingTriangle(size);

			Console.WriteLine("Треугольник с отступом (возрастающий):");
			DrawIndentedIncreasingTriangle(size);

		}

		static void DrawRectangle(int size)
		{
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
		}

		static void DrawIncreasingTriangle(int size)
		{
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
		}

		static void DrawDecreasingTriangle(int size)
		{
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size - i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
		}

		static void DrawIndentedDecreasingTriangle(int size)
		{
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write("  ");
				}
				for (int j = 0; j < size - i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
		}

		static void DrawIndentedIncreasingTriangle(int size)
		{
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size - i - 1; j++)
				{
					Console.Write("  ");
				}
				for (int j = 0; j < i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			
		}
	}
}
