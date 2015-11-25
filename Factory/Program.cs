using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	class Program
	{
		static void Main(string[] args)
		{
			var factory = new SuperheroesFactory();
			for (int i = 0; i <= 2; i++)
			{
				ISuperhero hero = factory.OnlyGodCanHelpUs(i);
				Console.WriteLine(hero.SaveTheWorld());
			}
			Console.ReadKey();
		}
	}
}
