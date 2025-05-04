using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputAndStringOperations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.Write("Введите Ваше имя: ");
			string first_name = "Alina"; // Console.ReadLine();

			//Console.Write("Введите Вашу фамилию: ");
			string last_name = "Krestina"; // Console.ReadLine();

			//Console.Write("Ваш возраст: ");
			int age = 38; // Convert.ToInt32(Console.ReadLine());


			//Console.Write(first_name);
			//Console.Write(last_name);
			//Console.Write(age);

			Console.WriteLine(first_name + " " + last_name + " " + age);							//конкатенация строк

			Console.WriteLine(string.Format("{0} {1} {2}", first_name, last_name, age));			//форматирование строк

			Console.WriteLine($"{first_name} {last_name} {age}");									//интерполяция строк



			Console.WriteLine();					//аналог cout << endl;
		}
	}
}
