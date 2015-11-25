using Newtonsoft.Json;
using System;

namespace Serialization
{
	class JsonSerialization
	{
		private string output { get; set; }

		public void Serialize(Contact c)
		{
			Console.WriteLine("\r\n JSON Seserialization");
			output = JsonConvert.SerializeObject(c);
            Console.WriteLine(output);
		}


		public void Deserialize()
		{
			Console.WriteLine("\r\n JSON Deserialization");
			Console.WriteLine(JsonConvert.DeserializeObject(output));
		}
	}
}
