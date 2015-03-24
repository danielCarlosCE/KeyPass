
using System;
using System.Collections.Generic;
namespace KeyPassInfoObjects
{
	[Serializable]
	public class Group
	{

		private string _name;

		private List<Key> _keys = new List<Key>();

		public Group() : base() { }

		public Group(string name)
		{
			Name = name;
		}



		public List<Key> Keys
		{
			get { return _keys; }
			set { _keys = value; }
		}


		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}


		public override string ToString()
		{
			return Name;
		}
	}
}
