using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	public class Fraction
	{
		public int Numerator { get; private set; }
		public int Denominator { get; private set; }

		public Fraction(int numerator, int denominator)
		{
			if (denominator == 0)
				throw new ArgumentException("Denominator cannot be zero.");

			Numerator = numerator;
			Denominator = denominator;
			Simplify();
		}

		private void Simplify()
		{
			int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
			Numerator /= gcd;
			Denominator /= gcd;

			if (Denominator < 0)
			{
				Numerator *= -1;
				Denominator *= -1;
			}
		}

		private static int GCD(int a, int b)
		{
			while (b != 0)
			{
				int temp = b;
				b = a % b;
				a = temp;
			}
			return a;
		}

		public static Fraction operator +(Fraction a, Fraction b)
		{
			int numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
			int denominator = a.Denominator * b.Denominator;
			return new Fraction(numerator, denominator);
		}

		public static Fraction operator -(Fraction a, Fraction b)
		{
			int numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
			int denominator = a.Denominator * b.Denominator;
			return new Fraction(numerator, denominator);
		}

		public static Fraction operator *(Fraction a, Fraction b)
		{
			return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
		}

		public static Fraction operator /(Fraction a, Fraction b)
		{
			if (b.Numerator == 0)
				throw new DivideByZeroException("Cannot divide by zero fraction.");
			return new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
		}

		public override string ToString()
		{
			return Denominator == 1 ? Numerator.ToString() : $"{Numerator}/{Denominator}";
		}

		public static bool operator ==(Fraction a, Fraction b)
		{
			return a.Numerator == b.Numerator && a.Denominator == b.Denominator;
		}

		public static bool operator !=(Fraction a, Fraction b)
		{
			return !(a == b);
		}

		public override bool Equals(object obj)
		{
			if (obj is Fraction other)
			{
				return this == other;
			}
			return false;
		}

		/*public override int GetHashCode()
		{
			return HashCode.Combine(Numerator, Denominator);
		}*/
	}
}
