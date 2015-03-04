using KeyPassBusiness;
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


		private void OnGroupTreeLoad(object sender, EventArgs e)
		{
			Application.Idle += OnIdle;
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



			int totalGroups = DataManager.ListGroups().Count;
			int toalKeysSelected = UIContextManager.KeysSelected.Count;
			int totalKeys = UIContextManager.GroupSelected == null ? 0 : UIContextManager.GroupSelected.Keys.Count;

			statusBar.updateStatus(totalGroups, toalKeysSelected, totalKeys);


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

			SaveFileDialog saveFileDialog1 = new SaveFileDialog();

			saveFileDialog1.Filter = "Key Pass Files|*.xml";
			saveFileDialog1.FilterIndex = 2;
			saveFileDialog1.RestoreDirectory = true;

			Stream stream;
			using (saveFileDialog1)
			{

				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					if ((stream = saveFileDialog1.OpenFile()) != null)
					{

						DataManager.SaveDocument(stream);

					}
				}

			}




		}

		private void OnOpenDocument(object sender, EventArgs e)
		{
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
							groupTreeControl.getGroups();
						}

					}
				}

			}
		}

		private void OnNewDocument(object sender, EventArgs e)
		{
			if (DataManager.NewDocument())
			{
				groupTreeControl.getGroups();
			}
		}




	}
}
