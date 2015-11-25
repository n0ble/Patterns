using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
	class BinarySerialization
	{
		public FileStream fs { get; set; }
		public BinaryFormatter bf { get; set; }

		public BinarySerialization()
		{
			fs = File.Create("Contact.dat");
			bf = new BinaryFormatter();

		}

		public void Serialize(Contact cont)
		{
			//Before Serialization - original object
			Console.WriteLine("Before Serialization");
			Console.WriteLine(cont.ToString());
	
			bf.Serialize(fs, cont);
			fs.Close();

		}

		public void Deserialize()
		{
			//Deserialization
			fs = File.OpenRead("Contact.dat");
			Contact deserializedCont = (Contact)bf.Deserialize(fs);

			//After Deserialization - original object
			Console.WriteLine("\r\n After Deserialization");
			Console.WriteLine(deserializedCont.ToString());
		}
	}
}
