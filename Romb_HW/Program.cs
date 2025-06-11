using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romb_HW
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите размер фигуры: ");
			int n = Convert.ToInt32(Console.ReadLine());

			int totalLines = 2 * n;

			for (int line = 0; line < totalLines; line++)
			{
				if (line < n)
				{
					// Верхняя половина ромба
					for (int j = line; j < n; j++) Console.Write(" ");
					Console.Write("/");
					for (int j = 0; j < line * 2; j++) Console.Write(" ");
					Console.Write("\\");
				}
				else
				{
					// Нижняя половина ромба
					int i = line - n;
					for (int j = 0; j <= i; j++) Console.Write(" ");
					Console.Write("\\");
					for (int j = 0; j < (n - i - 1) * 2; j++) Console.Write(" ");
					Console.Write("/");
				}
				Console.WriteLine();
			}
		}
	}
}
