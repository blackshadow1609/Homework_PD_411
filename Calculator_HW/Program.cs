using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_HW
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double a;
			double b;
			double resultat = 0;
			char operation;

			Console.Write("Введите первое число: ");
			a = Convert.ToDouble(Console.ReadLine());

			Console.Write("Введите оператор: ");
			operation = Convert.ToChar(Console.ReadLine());

			Console.Write("Введите второе число: ");
			b = Convert.ToDouble(Console.ReadLine());

			if (operation == '+')
			{
				resultat = a + b;
			}

			else if (operation == '-')
			{
				resultat = a - b;
			}

			else if (operation == '*')
			{
				resultat = a * b;
			}

			else if (operation == '/')
			{
				if (b != 0)
					resultat = a / b;
				else Console.WriteLine("На 0 делить нельзя!");
			}
			else
			{
				Console.WriteLine("Неизвестный оператор.");
			}

			Console.WriteLine("Результат: {0}", resultat);
			Console.ReadLine();
		}
	}
}
