using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Graduate: Human
	{
		public string Speciality { get; set; }
		public string Group { get; set; }
		public string Graduate_work { get; set; }
		public Graduate
			(
			string lastName, string firstName, int age,
			string speciality, string group, string graduate_work
			) : base(lastName, firstName, age)
		{
			Speciality = speciality;
			Group = group;
			Graduate_work = graduate_work;
			Console.WriteLine($"TConstructor:\t {this.GetHashCode()}");
		}

		~Graduate()
		{
			Console.WriteLine($"TDestructor:\t {this.GetHashCode()}");
		}

		public void Info()
		{
			base.Info();
			Console.WriteLine($"{Speciality} {Group} {Graduate_work}");
		}
	}
}
