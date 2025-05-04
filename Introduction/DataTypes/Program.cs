using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("DataTypes");
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(typeof(byte));
			Console.WriteLine(sizeof(byte));

			Console.WriteLine($"Byte:	{byte.MinValue} ... {byte.MaxValue}");
			Console.WriteLine($"SByte:{sbyte.MinValue} ... {sbyte.MaxValue}");
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(typeof(short));
			Console.WriteLine(sizeof(short));

			Console.WriteLine($"Short:	{short.MinValue} ... {short.MaxValue}");
			Console.WriteLine($"UShort:{ushort.MinValue} ... {ushort.MaxValue}");
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(typeof(int));
			Console.WriteLine(sizeof(int));

			Console.WriteLine($"Int:	{int.MinValue} ... {int.MaxValue}");
			Console.WriteLine($"UInt:{uint.MinValue} ... {uint.MaxValue}");
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine(typeof(long));
			Console.WriteLine(sizeof(long));

			Console.WriteLine($"Long:	{long.MinValue} ... {long.MaxValue}");
			Console.WriteLine($"ULong:{ulong.MinValue} ... {ulong.MaxValue}");
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine(typeof(float));
			Console.WriteLine(sizeof(float));

			Console.WriteLine($"Float:  {float.MinValue} ... {float.MaxValue}");
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine(typeof(double));
			Console.WriteLine(sizeof(double));

			Console.WriteLine($"Double: {double.MinValue} ... {double.MaxValue}");
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine(typeof(decimal));
			Console.WriteLine(sizeof(decimal));

			Console.WriteLine($"Decimal: {decimal.MinValue} ... {decimal.MaxValue}");
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine(typeof(bool));
			Console.WriteLine(sizeof(bool));

			Console.WriteLine($"Bool: {bool.TrueString} ... {bool.FalseString}");
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine(typeof(char));
			Console.WriteLine(sizeof(char));
			Console.WriteLine();

			Console.ResetColor();
		}
	}
}
