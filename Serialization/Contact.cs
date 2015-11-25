using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
	[Serializable]
	class Contact
	{

		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public bool IsPrivate { get; set; }
		public Company ParentCompany { get; set; }

		[NonSerialized]
		private const double MinSalary = 100;

		public override string ToString()
		{
			return String.Format("Contact record \r\n ID = {0} \r\n Name = {1} {2} \r\n Company = {3}", Id, FirstName, LastName, ParentCompany.Name);
		}



	}
}
