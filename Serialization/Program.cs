using System;


namespace Serialization
{
	class Program
	{
		static void Main(string[] args)
		{
			Contact cont = new Contact();
			cont.Id = 1;
			cont.FirstName = "Ben";
			cont.LastName = "Dover";
			cont.IsPrivate = true;
			cont.ParentCompany = new Company("Google");



			BinarySerialization bs = new BinarySerialization();
			bs.Serialize(cont);
			bs.Deserialize();

			JsonSerialization js = new JsonSerialization();
			js.Serialize(cont);
			js.Deserialize();


			Console.ReadKey();
				
		}
	}
}
