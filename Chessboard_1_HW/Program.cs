using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard_1_HW
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int squareSize = 5; // размер квадрата (5x5)
			int squaresPerLine = 8; // количество квадратов в строке
			int lines = 8; // количество строк 

			for (int line = 0; line < lines * squareSize; line++)
			{
				int currentLineGroup = line / squareSize;

				for (int square = 0; square < squaresPerLine; square++)
				{
					bool isBlackSquare = (currentLineGroup % 2 == 0 && square % 2 == 0) ||
										(currentLineGroup % 2 == 1 && square % 2 == 1);

					Console.Write(isBlackSquare ? new string('*', squareSize * 2)
											  : new string(' ', squareSize * 2));
				}
				Console.WriteLine();
			}
		}
	}
}
