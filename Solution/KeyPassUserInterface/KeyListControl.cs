using KeyPassBusiness;
using KeyPassInfoObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KeyPassUserInterface
{
	public partial class KeyListControl : UserControl
	{
		public KeyListControl()
		{
			InitializeComponent();
		}

		private void OnLoad(object sender, EventArgs e)
		{
			UIContextManager.GroupSelectedEvent += OnGroupSelected;

		}

		void OnGroupSelected(Group groupSelected)
		{

			ClearUpdateKeys(groupSelected);

		}

		private void ClearUpdateKeys(Group groupSelected)
		{
			UIContextManager.KeysSelected.Clear();
			listViewKeys.Items.Clear();
			if (groupSelected != null)
			{


				foreach (Key key in groupSelected.Keys)
				{
					ListViewItem listViewItem = new ListViewItem(key.Title);
					listViewItem.SubItems.Add(key.UserName);
					listViewItem.SubItems.Add(key.Password);

					listViewItem.SubItems.Add(key.URL);

					listViewItem.Tag = key;

					listViewKeys.Items.Add(listViewItem);
				}

			}

		}

		private void OnAddKey(object sender, EventArgs e)
		{
			AddKeyDialog();

		}


		private void OnEditKey(object sender, EventArgs e)
		{
			EditKeyDialog();

		}
		public void AddKeyDialog()
		{
			if (UIContextManager.GroupSelected == null)
			{
				MessageBox.Show("Please select a group");
				return;
			}

			AddEditKeyForm addEditKeyForm = new AddEditKeyForm();

			if (addEditKeyForm.ShowDialog() != DialogResult.OK)
				return;

			Key key = parseFormToKey(addEditKeyForm);


			Group group = (Group)addEditKeyForm.comboBoxGroups.SelectedItem;

			//get from "database" using name
			group = DataManager.GetGroupByName(group.Name);
			DataManager.AddkeyToGroup(key, group);


			ClearUpdateKeys(UIContextManager.GroupSelected);
		}

		public void EditKeyDialog()
		{

			AddEditKeyForm addEditKeyForm = new AddEditKeyForm();
			Key oldKey = (Key)listViewKeys.SelectedItems[0].Tag;

			addEditKeyForm.comboBoxGroups.Enabled = false;
			parseKeyToForm(addEditKeyForm, oldKey);


			if (addEditKeyForm.ShowDialog() != DialogResult.OK)
				return;

			Key key = parseFormToKey(addEditKeyForm);



			//get from "database" using name
			Group group = DataManager.GetGroupByName(UIContextManager.GroupSelected.Name);
			if (DataManager.EditKeyFromGroup(oldKey, key, group) != null)
			{
				ClearUpdateKeys(UIContextManager.GroupSelected);

			}

		}

		private static void parseKeyToForm(AddEditKeyForm addEditKeyForm, Key oldKey)
		{
			addEditKeyForm.textBoxTitle.Text = oldKey.Title;
			addEditKeyForm.textBoxUserName.Text = oldKey.UserName;
			addEditKeyForm.textBoxPassword.Text = oldKey.Password;
			addEditKeyForm.textBoxConfirmPass.Text = oldKey.Password;
			addEditKeyForm.textBoxURL.Text = oldKey.URL;
			addEditKeyForm.textBoxNotes.Text = oldKey.Notes;
		}

		private static Key parseFormToKey(AddEditKeyForm addEditKeyForm)
		{
			Key key = new Key();
			key.Title = addEditKeyForm.textBoxTitle.Text;
			key.UserName = addEditKeyForm.textBoxUserName.Text;
			key.Password = addEditKeyForm.textBoxPassword.Text;
			key.URL = addEditKeyForm.textBoxURL.Text;
			key.Notes = addEditKeyForm.textBoxNotes.Text;
			return key;
		}

		private void listViewKeys_SelectedIndexChanged(object sender, EventArgs e)
		{
			List<Key> keysSelected = new List<Key>();
			foreach (ListViewItem listViewItem in listViewKeys.SelectedItems)
			{
				keysSelected.Add((Key)listViewItem.Tag);

			}
			UIContextManager.KeysSelected = keysSelected;
		}



		internal void enableDisableStripItems(bool keyEnableEdit, bool keyEnableDelete)
		{
			toolStripButtonEditKey.Enabled = editEntryToolStripMenuItem.Enabled = keyEnableEdit;
			toolStripButtonDeleteKey.Enabled = deleteEntryToolStripMenuItem.Enabled = keyEnableDelete;
		}

		private void OnDeleteKeys(object sender, EventArgs e)
		{
			deleteKeys();
		}

		public void deleteKeys()
		{
			foreach (ListViewItem listViewItem in listViewKeys.SelectedItems)
			{
				if (DataManager.DeleteKeyFromGroup((Key)listViewItem.Tag, UIContextManager.GroupSelected))
				{
					listViewKeys.Items.Remove(listViewItem);

				}

			}
		}
	}
}
