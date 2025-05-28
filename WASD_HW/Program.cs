using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASD_HW
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x = 0, y = 0; // Начальная позиция курсора
			Console.CursorVisible = false;
			
			while (true)
			{
				Console.SetCursorPosition(x, y);
				Console.Write("#"); // Курсор

				var key = Console.ReadKey(true).Key;

				// Удаление предыидущей позиции курсора
				Console.SetCursorPosition(x, y);
				Console.Write(" ");

				// Движение курсора
				switch (key)
				{
					case ConsoleKey.W:
					case ConsoleKey.UpArrow:
						if (y > 0) y--;
						break;
					case ConsoleKey.S:
					case ConsoleKey.DownArrow:
						if (y < Console.WindowHeight - 1) y++;
						break;
					case ConsoleKey.A:
					case ConsoleKey.LeftArrow:
						if (x > 0) x--;
						break;
					case ConsoleKey.D:
					case ConsoleKey.RightArrow:
						if (x < Console.WindowWidth - 1) x++;
						break;
					case ConsoleKey.Escape:
						return; // Выход 
				}
			}
		}
	}
}
