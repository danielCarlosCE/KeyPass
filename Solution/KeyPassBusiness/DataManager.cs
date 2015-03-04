using KeyPassInfoObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace KeyPassBusiness
{
	public static class DataManager
	{
		private static Document _document = new Document();

		public static List<Group> ListGroups()
		{
			return _document.Groups;
		}


		public static bool NewDocument()
		{
			_document = new Document();
			return true;
		}

		public static bool SaveDocument(Stream stream)
		{
			try
			{
				SaveAsXML(stream);
				return true;

			}
			catch (Exception e)
			{
				return false;
			}
		}

		public static List<Group> OpenDocument(Stream stream)
		{
			XElement root = XElement.Load(stream);
			_document = new Document();
			foreach (XElement element in root.Elements())
			{
				Group group = new Group();
				group.Name = (String)element.Attribute("name");
				XElement keyRoot = element.Element("keys");
				foreach (XElement keyElement in keyRoot.Elements())
				{
					Key key = new Key();
					foreach (var prop in key.GetType().GetProperties())
					{
						prop.SetValue(key, (String)keyElement.Attribute(prop.Name), null);
					}
					group.Keys.Add(key);
				}
				_document.Groups.Add(group);
			}

			return _document.Groups;


		}

		private static void SaveAsXML(Stream stream)
		{
			using (stream)
			{
				StreamWriter streamWriter = new StreamWriter(stream);
				XmlDocument xmlDoc = new XmlDocument();

				XmlNode rootNode = xmlDoc.CreateElement("groups");
				xmlDoc.AppendChild(rootNode);

				foreach (Group g in _document.Groups)
				{
					XmlNode groupNode = xmlDoc.CreateElement("group");
					XmlAttribute attribute = xmlDoc.CreateAttribute("name");
					attribute.Value = g.Name;
					rootNode.AppendChild(groupNode);
					groupNode.Attributes.Append(attribute);

					XmlNode keysRootNode = xmlDoc.CreateElement("keys");
					groupNode.AppendChild(keysRootNode);


					foreach (Key k in g.Keys)
					{
						XmlNode keyNode = xmlDoc.CreateElement("key");
						XmlAttribute keyattribute;

						foreach (var prop in k.GetType().GetProperties())
						{
							keyattribute = xmlDoc.CreateAttribute(prop.Name);
							keyattribute.Value = (string)prop.GetValue(k, null);
							keyNode.Attributes.Append(keyattribute);
						}

						keysRootNode.AppendChild(keyNode);
					}

				}



				xmlDoc.Save(streamWriter);
			}
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
