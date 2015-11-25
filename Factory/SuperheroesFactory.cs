using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	internal class SuperheroesFactory
	{
		public ISuperhero OnlyGodCanHelpUs(int id)
		{
			switch (id) {
				case 0:
					return new Batman();
				case 1:
					return new Superman();
				case 2:
				default:
					return new Ironman();
				
				

			}
		}
	}
}
