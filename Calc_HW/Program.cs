using System;
using System.Collections.Generic;
using System.Linq;

namespace Calc
{
	internal class Program
	{
		static char[] operations = new char[] { '+', '-', '*', '/' };
		static char[] digits = "0123456789.".ToCharArray();
		static char[] brackets = new char[] { '(', ')' };

		static void Main(string[] args)
		{
			string expression = "(1+(22+33)/5-44/(2+6)*8)*3"; //Console.ReadLine();

			try
			{
				
				expression = new string(expression.Where(c => !char.IsWhiteSpace(c)).ToArray());

				
				double result = CalculateWithBrackets(expression);
				Console.WriteLine($"Результат: {result}");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Ошибка: {ex.Message}");
			}
		}

		static double CalculateWithBrackets(string expression)
		{
			
			while (expression.Contains('('))
			{
				int lastOpenBracket = expression.LastIndexOf('(');
				int closeBracket = expression.IndexOf(')', lastOpenBracket);

				if (closeBracket == -1)
					throw new ArgumentException("Несовпадающие круглые скобки");

				string subExpression = expression.Substring(lastOpenBracket + 1, closeBracket - lastOpenBracket - 1);
				double subResult = CalculateWithBrackets(subExpression);

				
				expression = expression.Substring(0, lastOpenBracket)
						  + subResult.ToString()
						  + expression.Substring(closeBracket + 1);
			}

			
			return CalculateSimpleExpression(expression);
		}

		static double CalculateSimpleExpression(string expression)
		{
			List<double> values = new List<double>();
			List<string> ops = new List<string>();

			int i = 0;
			while (i < expression.Length)
			{
				if (expression[i] == '-' && (i == 0 || operations.Contains(expression[i - 1])))
				{
					
					int start = i;
					i++;
					while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
						i++;
					values.Add(double.Parse(expression.Substring(start, i - start)));
				}
				else if (char.IsDigit(expression[i]) || expression[i] == '.')
				{
					int start = i;
					while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
						i++;
					values.Add(double.Parse(expression.Substring(start, i - start)));
				}
				else if (operations.Contains(expression[i]))
				{
					ops.Add(expression[i].ToString());
					i++;
				}
				else
				{
					throw new ArgumentException($"Недопустимый символ: {expression[i]}");
				}
			}

			if (values.Count != ops.Count + 1)
				throw new ArgumentException("Несовпадающие номера и операторы");

			for (int j = 0; j < ops.Count;)
			{
				if (ops[j] == "*" || ops[j] == "/")
				{
					double a = values[j];
					double b = values[j + 1];
					double result = ops[j] == "*" ? a * b : a / b;

					values[j] = result;
					values.RemoveAt(j + 1);
					ops.RemoveAt(j);
				}
				else
				{
					j++;
				}
			}

			double finalResult = values[0];
			for (int j = 0; j < ops.Count; j++)
			{
				if (ops[j] == "+")
					finalResult += values[j + 1];
				else if (ops[j] == "-")
					finalResult -= values[j + 1];
			}

			return finalResult;
		}
	}
}