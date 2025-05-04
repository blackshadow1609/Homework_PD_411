using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine("Привет Мир!!");
			Console.Title = "Introduction to .NET";								//вывод имени в заголовке окна
			Console.Title = "Введение в платформу .NET";                        //вывод имени заголовка окна на русском

			//Console.WindowWidth = 80;											//ширина окна консоли
			//Console.WindowHeight = 16;										//высота окна консоли

			Console.SetWindowSize(80, 16);										//второй вариант задать размер окна консоли

			//Console.CursorTop = 8;											//строка
			//Console.CursorLeft = 16;											//позиция по центру

			Console.SetCursorPosition(16, 8);									//второй вариант указания позиции курсора

			Console.BackgroundColor = ConsoleColor.Blue;						//окрашивание строки и цвет
			Console.ForegroundColor = ConsoleColor.DarkGreen;                   //окрашивание символов и цвет

			Console.WriteLine("Position");										//просто слово Позиция

			Console.ResetColor();												//сброс цвета после слова Позиция
			//Console.Clear();													//очистка консоли (цвет не сбрасывает)


			


		}
	}
}
