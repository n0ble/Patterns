using System;
using System.Threading;

namespace MultiThreading
{
	class Worker
	{

		public void Work()
		{
			lock (this)
			{
				Console.WriteLine("Worker started its work...");
				Console.WriteLine("ID of the worker tread is {0}", Thread.CurrentThread.GetHashCode());
				for (int i = 0; i < 10; i++)
				{
					Console.WriteLine(i);
				}
				Console.WriteLine();

			}
		}


		public void Work2()
		{
			Monitor.Enter(this);
			try
			{
				Console.WriteLine("Worker started its work...");
				Console.WriteLine("ID of the worker tread is {0}", Thread.CurrentThread.GetHashCode());
				for (int i = 0; i < 10; i++)
				{
					Console.WriteLine(i);
				}
				Console.WriteLine();

			}
			finally {
				Monitor.Exit(this);
			}
		}
	}
}
