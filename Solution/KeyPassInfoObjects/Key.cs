
using System;
namespace KeyPassInfoObjects
{
	[Serializable]
	public class Key
	{
		private string _title;
		private string _username;
		private string _password;
		private string _url;
		private string _notes;

		public string URL
		{
			get { return _url; }
			set { _url = value; }
		}

		public string Notes
		{
			get { return _notes; }
			set { _notes = value; }
		}


		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}
		
		public string UserName
		{
			get { return _username; }
			set { _username = value; }
		}
		

		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}


	}
}
