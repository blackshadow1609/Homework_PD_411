using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard_HW
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int squareSize = 5; // размер квадрата (5x5)
			int squaresPerLine = 8; // количество квадратов в строке
			int lines = 8; // количество строк узора

			for (int line = 0; line < lines; line++)
			{
				for (int row = 0; row < squareSize; row++)
				{
					for (int square = 0; square < squaresPerLine; square++)
					{
						
						if ((line % 2 == 1 && square % 2 == 0) ||
							(line % 2 == 0 && square % 2 == 1))
						{
							Console.Write(new string(' ', squareSize * 2));
						}
						else
						{
							Console.Write(new string('*', squareSize * 2));
						}

					}

					Console.WriteLine();
				}
			}
		}
	}
}
