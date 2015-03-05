using KeyPassBusiness;
using KeyPassInfoObjects;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace KeyPassUserInterface
{
	public partial class MainForm : Form
	{


		public MainForm()
		{
			InitializeComponent();
		}


		private void MainForm_Load(object sender, EventArgs e)
		{
			Application.Idle += OnIdle;
			DataManager.DataModifiedEvent += OnDataModified;

		}

		void OnDataModified()
		{
			saveToolStripButton.Enabled = true;
			saveToolStripMenuItem.Enabled = true;
			saveAsToolStripMenuItem.Enabled = true;
		}


		private void OnStateChanged(object sender, EventArgs e)
		{
			if (sender == toolBarToolStripMenuItem)
			{
				toolStripMenu.Visible = toolBarToolStripMenuItem.Checked;
			}
			if (sender == statusBarToolStripMenuItem)
			{
				statusBar.Visible = statusBarToolStripMenuItem.Checked;

			}
		}

		private void OnClickAbout(object sender, EventArgs e)
		{
			AboutForm about = new AboutForm();
			about.ShowDialog();
		}


		#region GroupTree public methods
		private void OnGroupAdd(object sender, EventArgs e)
		{
			groupTreeControl.addGroupDialog();
		}

		private void OnGroupEdit(object sender, EventArgs e)
		{
			groupTreeControl.editGroupDialog();

		}

		private void OnGroupDelete(object sender, EventArgs e)
		{
			groupTreeControl.deleteGroup();

		}
		#endregion


		private void OnIdle(object sender, EventArgs e)
		{


			bool groupEnable = UIContextManager.GroupSelected != null;
			bool keyEnableDelete = UIContextManager.GroupSelected != null
								  && UIContextManager.GroupSelected.Keys.Count > 0
								  && UIContextManager.KeysSelected.Count > 0;
			bool keyEnableEdit = UIContextManager.GroupSelected != null
								 && UIContextManager.GroupSelected.Keys.Count > 0
								&& UIContextManager.KeysSelected.Count == 1;

			editGroupToolStripMenuItem.Enabled = deleteGroupToolStripMenuItem.Enabled = groupEnable;
			groupTreeControl.enableDisableStripItems(groupEnable);

			editEntryToolStripMenuItem.Enabled = keyEnableEdit;
			deleteEntryToolStripMenuItem.Enabled = keyEnableDelete;
			keyListControl.enableDisableStripItems(keyEnableEdit, keyEnableDelete);

			this.Text = (UIContextManager.FileName != null) ? UIContextManager.FileName : "KeyPass";


			if (keyEnableEdit)
			{
				updateRichText();
			}
			else
			{
				richText.Text = "";
			}

			int totalGroups = DataManager.ListGroups().Count;
			int toalKeysSelected = UIContextManager.KeysSelected.Count;
			int totalKeys = UIContextManager.GroupSelected == null ? 0 : UIContextManager.GroupSelected.Keys.Count;

			statusBar.updateStatus(totalGroups, toalKeysSelected, totalKeys);


		}

		private void updateRichText()
		{
			Key key = UIContextManager.KeysSelected[0];
			String text = "";
			text += "Title = " + key.Title;
			text += "\nUserName  = " + key.UserName;
			text += "\nPassword  = " + key.Password;
			text += "\nURL  = " + key.URL;
			text += "\n\nNotes\n - - - - - - - - - - - - - - - - - - - - - -\n " + key.Notes;
			if (richText.Text != text)
			{
				richText.Text = text;
			}

		}

		private void OnAddEntry(object sender, EventArgs e)
		{
			keyListControl.AddKeyDialog();
		}

		private void OnEditEntry(object sender, EventArgs e)
		{
			keyListControl.EditKeyDialog();
		}

		private void OnDeleteEntry(object sender, EventArgs e)
		{
			keyListControl.deleteKeys();
		}

		private void OnSaveDocument(object sender, EventArgs e)
		{
			SaveDocument();

		}

		private void SaveDocument()
		{
			Stream stream = null;
			if (UIContextManager.FileName != null)
			{
				stream = new FileStream(UIContextManager.FileName, FileMode.Create);
			}
			else
			{
				stream = StreamSaveFile();
			}
			if (stream != null && DataManager.SaveDocument(stream))
			{
				saveToolStripButton.Enabled = false;
				saveToolStripMenuItem.Enabled = false;
			}
		}

		private void OnSaveAsDocument(object sender, EventArgs e)
		{
			Stream stream = StreamSaveFile();
			if (stream != null && DataManager.SaveDocument(stream))
			{
				saveToolStripButton.Enabled = false;
				saveToolStripMenuItem.Enabled = false;
			}
		}

		private static Stream StreamSaveFile()
		{
			Stream stream = null;
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();

			saveFileDialog1.Filter = "Key Pass Files|*.xml";
			saveFileDialog1.FilterIndex = 2;
			saveFileDialog1.RestoreDirectory = true;

			using (saveFileDialog1)
			{
				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					UIContextManager.FileName = saveFileDialog1.FileName;
					stream = saveFileDialog1.OpenFile();
				}

			}
			return stream;
		}

		private void OnOpenDocument(object sender, EventArgs e)
		{

			if (!CheckIfWantSaveChanges())
				return;

			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.Filter = "Key Pass Files|*.xml";
			openFileDialog.FilterIndex = 2;
			openFileDialog.RestoreDirectory = true;

			Stream stream;
			using (openFileDialog)
			{

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					if ((stream = openFileDialog.OpenFile()) != null)
					{

						if (DataManager.OpenDocument(stream) != null)
						{
							UIContextManager.FileName = openFileDialog.FileName;
							groupTreeControl.getGroups();
							saveAsToolStripMenuItem.Enabled = true;
							saveToolStripButton.Enabled = false;
							saveToolStripMenuItem.Enabled = false;
						}

					}
				}

			}
		}

		private void OnNewDocument(object sender, EventArgs e)
		{
			if (!CheckIfWantSaveChanges())
				return;

			if (DataManager.NewDocument())
			{
				UIContextManager.FileName = null;
				groupTreeControl.getGroups();
				saveAsToolStripMenuItem.Enabled = false;
				saveToolStripButton.Enabled = false;
				saveToolStripMenuItem.Enabled = false;
			}
		}

		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			if(CheckIfWantSaveChanges())
				e.Cancel = false;
            else 
				e.Cancel = true;
		}
		
		/** Return false when user clicks Cancel button*/
		private bool CheckIfWantSaveChanges()
		{
			if (!saveToolStripButton.Enabled)
				return true;

			SaveFileOptionForm saveform = new SaveFileOptionForm();
			using (saveform)
			{

				DialogResult dialogResult = saveform.ShowDialog();

				if (dialogResult == DialogResult.Yes)
				{
					SaveDocument();
					return true;
				}
				else if (dialogResult == DialogResult.No)
				{
					return true;
				}
				else
				{
					return false;
				}
			}

		}





	}
}
