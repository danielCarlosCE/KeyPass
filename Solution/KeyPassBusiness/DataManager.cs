using KeyPassInfoObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace KeyPassBusiness
{
	public delegate void DataModifiedEventHandler();


	public static class DataManager
	{
		private static Document _document = new Document();
		public static event DataModifiedEventHandler DataModifiedEvent;

		private static void CallEvent()
		{
			if(DataModifiedEvent!=null){
				DataModifiedEvent();
			}
		}

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
				Console.Write(e.Message);
				return false;
			}
		}

		public static List<Group> OpenDocument(Stream stream)
		{
			try { 			byte[] cipherText;
			using (MemoryStream ms = new MemoryStream())
			{
				stream.CopyTo(ms);
				cipherText = ms.ToArray();
			}
			
			string xml = System.Text.Encoding.ASCII.GetString(CryptoHelper.Decrypt(cipherText));

			XElement root = XElement.Parse(xml);
			
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
			}catch(Exception ex){
				Console.WriteLine(ex.Message);
				return null;
			}


		}

		private static void SaveAsXML(Stream stream)
		{
			
				StreamWriter streamWriter = new StreamWriter(stream);
				XmlDocument xmlDoc = new XmlDocument();

				#region XmlParse
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
				#endregion

				stream.Close();
				
				byte[] buffer = Encoding.ASCII.GetBytes(xmlDoc.InnerXml);
				string filePath = ((FileStream)(streamWriter.BaseStream)).Name;
				File.WriteAllBytes(filePath, CryptoHelper.Encrypt(buffer));
	
		}

		public static Group AddGroup(String name)
		{
			Group group = new Group();
			group.Name = name;

			return AddGroupDocument(group);
		}

		public static Group AddGroup(Group group)
		{
			return AddGroupDocument(group);
		}

		private static Group AddGroupDocument(Group group)
		{
			_document.Groups.Add(group);
			CallEvent();
			Log.log("Add Group: " + group.Name);
			return group;
		}

		public static Group EditGroup(Group group, string newName)
		{
			
			group.Name = newName;
			
			CallEvent();

			Log.log("Edit Group: "+group.Name);

			return group;
		}

		public static bool DeleteGroup(Group group)
		{
			_document.Groups.Remove(group);
			CallEvent();

			Log.log("Delete Group: " + group.Name);

			return true;
		}

		public static Group AddkeyToGroup(Key key, Group group)
		{
			group.Keys.Add(key);
			CallEvent();

			Log.log("Add Key to Group: " + group.Name + " - title: " + key.Title);
			return group;
		}

		public static bool DeleteKeyFromGroup(Key key, Group group)
		{
			group.Keys.Remove(key);
			CallEvent();

			Log.log("Delete key from Group: " + group.Name + " - title: " + key.Title);

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
					CallEvent();
					Log.log("Edit key in Group: " + group.Name +" - title: "+key.Title);

					return newkey;

				}
			}

			return null;
		}



	}
}
