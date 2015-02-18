using System.Collections.Generic;

namespace KeyPassInfoObjects
{
	public class Document
	{

		private List<Group> _groups = new List<Group>();

		public List<Group> Groups
		{
			get { return _groups; }
			set { _groups = value; }
		}

	}
}
