using KeyPassInfoObjects;
using System.Collections.Generic;


namespace KeyPassBusiness
{
	public delegate void GroupSelectedEventHandler(Group groupSelected);

	public class UIContextManager
	{
		private static Group groupSelected;
		public static event GroupSelectedEventHandler GroupSelectedEvent;
		private static List<Key> _keysSelected = new List<Key>();

		public static List<Key> KeysSelected
		{
			get { return _keysSelected; }
			set { _keysSelected = value; }
		}

		public static Group GroupSelected
		{
			get { return groupSelected; }
			set
			{

				groupSelected = value;
				//null when have no subscribers
				if (GroupSelectedEvent != null)
				{
					GroupSelectedEvent(value);
				}

			}
		}


	}
}
