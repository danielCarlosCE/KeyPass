using System;
using System.Linq;

namespace KeyPassBusiness
{
	public static class Util
	{
		static Random random = new Random();


		public static string generateRandomText()
		{
			var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			var result = new string(
				Enumerable.Repeat(chars, random.Next(1,20))
						  .Select(s => s[random.Next(s.Length)])
						  .ToArray());
			return result;
		}
	}
}
