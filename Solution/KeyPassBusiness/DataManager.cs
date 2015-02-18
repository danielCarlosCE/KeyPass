using KeyPassInfoObjects;
using System;
using System.Collections.Generic;

namespace KeyPassBusiness
{
	public static class DataManager
	{
		private static Document _document = new Document();

		public static List<Group> ListGroups()
		{
			return _document.Groups;
		}

		public static Group AddGroup(String name)
		{
			Group g = new Group();
			g.Name = name;
			_document.Groups.Add(g);
			return g;
		}

		public static Group EditGroup(string oldName, string newName)
		{
			Group group = GetGroupByName(oldName);
			if (group != null)
			{
				group.Name = newName;
			}
			return group;
		}

		public static Group GetGroupByName(string groupName)
		{
			foreach (Group group in _document.Groups)
			{
				if (groupName.Equals(group.Name))
				{
					return group;
				}
			}
			return null;
		}

		public static bool DeleteGroup(String groupName)
		{
			Group group = GetGroupByName(groupName);
			_document.Groups.Remove(group);
			return true;
		}


		public static Group AddkeyToGroup(Key key, Group group)
		{
			group.Keys.Add(key);
			return group;
		}

		public static bool DeleteKeyFromGroup(Key key, Group group)
		{
			group.Keys.Remove(key);
			return true;
		}

		public static Key EditKeyFromGroup(Key oldKey, Key newkey, Group group)
		{
			foreach (Key key in group.Keys)
			{
				if (key == oldKey)
				{
					int index = group.Keys.IndexOf(key);
					group.Keys[index] = newkey;
					return newkey;
					
				}
			}

			return null;
		}
	}
}
