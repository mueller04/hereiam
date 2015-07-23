using System;
using Nancy;

namespace HereIAm
{
	public class MainModule : NancyModule
	{
		public MainModule ()
		{
			Get["/"] = parameters => { return "Hello World"; };
		}
	}
}

