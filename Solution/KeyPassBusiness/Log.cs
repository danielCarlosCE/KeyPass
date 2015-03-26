using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPassBusiness
{

	public delegate void LogEventHandler(String message);

	public class Log
	{
		public static event LogEventHandler LogEvent;

		public static void log(string message)
		{
			string date = DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss");
			Console.WriteLine(date + " " + message);
			if (LogEvent != null)
				LogEvent(date + " " + message);
		}

	}
}
