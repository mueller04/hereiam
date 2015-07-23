using System;
using Nancy.Hosting.Self;

namespace HereIAm
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			using (var host = new NancyHost (new Uri ("http://localhost:8080/"))) {
				host.Start ();
				Console.ReadKey ();
			}
		}
	}
}
