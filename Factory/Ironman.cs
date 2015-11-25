using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	class Ironman : ISuperhero
	{
		public string SaveTheWorld()
		{
			return "World is saved! Thanks to Ironman";
		}
	}
}
