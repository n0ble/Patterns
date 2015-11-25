using System;
using System.Threading;
using System.Windows.Forms;

namespace MultiThreading
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("ID of the primary tread is {0}", Thread.CurrentThread.GetHashCode());

			Worker w = new Worker();
			Thread t1 = new Thread(new ThreadStart(w.Work2));
			Thread t2 = new Thread(new ThreadStart(w.Work2));
			Thread t3 = new Thread(new ThreadStart(w.Work2));

			t1.Start();
			t2.Start();
			t3.Start();


			//MessageBox.Show("Main thread is busy");


		}
	}
}
