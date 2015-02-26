using KeyPassBusiness;
using System;
using System.Windows.Forms;

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

		private void OnGroupAdd(object sender, EventArgs e)
		{
			groupTreeControl1.addGroupDialog();
		}

		private void OnGroupEdit(object sender, EventArgs e)
		{
			groupTreeControl1.editGroupDialog();

		}

		private void OnGroupDelete(object sender, EventArgs e)
		{
			groupTreeControl1.deleteGroup();

		}

		private void OnGroupTreeLoad(object sender, EventArgs e)
		{
			Application.Idle += OnIdle;
		}

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
			groupTreeControl1.enableDisableStripItems(groupEnable);

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




	}
}
