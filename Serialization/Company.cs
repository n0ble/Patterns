using System;

namespace Serialization
{
	[Serializable]
	class Company
	{
		public string Name { get; set; }

		public Company(string name)
		{
			Name = name;
		}
	}
}
