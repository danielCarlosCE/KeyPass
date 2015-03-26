using KeyPassBusiness;
using KeyPassInfoObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace KeyPassUserInterface
{
	public partial class MainForm : Form
	{
		private const string extension = ".mkp";
		private const string _filter = "My Key Pass Files|*"+extension;
		private PrintDocument _printDoc = new PrintDocument(); 

		public MainForm()
		{
			InitializeComponent();
		}


		private void MainForm_Load(object sender, EventArgs e)
		{
			Application.Idle += OnIdle;
			DataManager.DataModifiedEvent += OnDataModified;
			_printDoc.PrintPage += OnPrintPage;


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

			#region enabling menus
			bool groupEnable = UIContextManager.GroupSelected != null;
			bool keyEnableDelete = groupEnable && UIContextManager.KeysSelected.Count > 0;
			bool keyEnableEdit = groupEnable && UIContextManager.KeysSelected.Count == 1;

			editGroupToolStripMenuItem.Enabled = groupEnable;
			deleteGroupToolStripMenuItem.Enabled = groupEnable;
			groupTreeControl.enableDisableStripItems(groupEnable);

			editEntryToolStripMenuItem.Enabled = keyEnableEdit;
			deleteEntryToolStripMenuItem.Enabled = keyEnableDelete;
			keyListControl.enableDisableStripItems(keyEnableEdit, keyEnableDelete);
			#endregion

			this.Text = (UIContextManager.FileName != null) ? UIContextManager.FileName : "KeyPass";

			updateRichText(keyEnableEdit);

			#region Update Status Bar
			int totalGroups = DataManager.ListGroups().Count;
			int toalKeysSelected = UIContextManager.KeysSelected.Count;
			int totalKeys = UIContextManager.GroupSelected == null ? 0 : UIContextManager.GroupSelected.Keys.Count;
			statusBar.updateStatus(totalGroups, toalKeysSelected, totalKeys);
			#endregion

		}

		#region call children methods
		private void updateRichText(Boolean keySelected)
		{
			if (!keySelected)
			{
				richText.Text = "";
				return; 
			}
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
		#endregion

		private void OnSaveDocument(object sender, EventArgs e)
		{
			SaveDocument();

		}

		private bool SaveDocument()
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
				return stream != null;

			
		}

		private void OnSaveAsDocument(object sender, EventArgs e)
		{
			Stream stream = StreamSaveFile();
			using (stream)
			{
			
				if (stream != null && DataManager.SaveDocument(stream))
				{
					saveToolStripButton.Enabled = false;
					saveToolStripMenuItem.Enabled = false;
				}

			}
		}

		private static Stream StreamSaveFile()
		{
			Stream stream = null;
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();

			saveFileDialog1.Filter = _filter;
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

			openFileDialog.Filter = _filter;
			openFileDialog.FilterIndex = 2;
			openFileDialog.RestoreDirectory = true;

			Stream stream;
			using (openFileDialog)
			{

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					if ((stream = openFileDialog.OpenFile()) != null)
					{
						using (stream)
						{
							UpdateInterfaceOpenDocument(openFileDialog.FileName, stream);
						}

					}
				}

			}
		}

		private void UpdateInterfaceOpenDocument(string fileName, Stream stream)
		{
			if (DataManager.OpenDocument(stream) != null)
			{
				
				UIContextManager.FileName = fileName;
				groupTreeControl.getGroups();
				saveAsToolStripMenuItem.Enabled = true;
				saveToolStripButton.Enabled = false;
				saveToolStripMenuItem.Enabled = false;
			}
			else
			{
				MessageBox.Show("Sorry, but the application only accepts valid " + extension + " files.");
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
			if (CheckIfWantSaveChanges())
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
					return SaveDocument();
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

		private void OnDragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
				string fileName = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
				Console.WriteLine(fileName);
				if (Path.GetExtension(fileName).ToLower() != extension)
				{
					e.Effect = DragDropEffects.None;
					return;
				}
				e.Effect = DragDropEffects.All;
			}else
				e.Effect = DragDropEffects.None;
		}

		private void OnDragDrop(object sender, DragEventArgs e)
		{
			
			if (!CheckIfWantSaveChanges())
				return;

			string fileName = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
			

			using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
			{
				UpdateInterfaceOpenDocument(fileName, fileStream);
			}

		}

		private void OnPrintPreview(object sender, EventArgs e)
		{

			PrintPreviewDialog _printViewDialog = new PrintPreviewDialog();
			((Form)_printViewDialog).WindowState = FormWindowState.Maximized;
			_printViewDialog.Document = _printDoc;
			_printViewDialog.ShowDialog();
		}

		

		private void OnPrint(object sender, EventArgs e)
		{
			

			PrintDialog dlg = new PrintDialog(); 
			dlg.Document = _printDoc;
			if (dlg.ShowDialog() != DialogResult.OK)
				return; 

			_printDoc.Print();


		}

		void OnPrintPage(object sender, PrintPageEventArgs e)
		{
			Graphics g = e.Graphics;
			Font font = new Font("Times New Roman", 12);
			StringFormat strFormat = new StringFormat();
			// Horizontally Center-justify each line of text.
			strFormat.Alignment = StringAlignment.Center;
			// Center text (vertically) in the rectangle.
			strFormat.LineAlignment = StringAlignment.Center;
			strFormat.Trimming = StringTrimming.EllipsisCharacter;


			float offset = 30.0f;
			float x = 0.0f;
			float y = offset;
			float groupHeight = 70.0f;
			float keyHeight = 20.0f;

			List<Group> groups = DataManager.ListGroups();
			

			for (int i = 0; i < groups.Count ;i++ )
			{
				RectangleF groupRect = new RectangleF(x, y, (e.PageBounds.Size.Width), groupHeight);
				g.FillRectangle(Brushes.Navy, groupRect);

				g.DrawString(groups[i].Name, font, new
				   SolidBrush(Color.White), groupRect, strFormat);
				g.DrawRectangle(new Pen(Color.Navy), groupRect.X, groupRect.Y, groupRect.Width,
					   groupRect.Height);

				List<Key> keys = groups[i].Keys;

				y += groupHeight;

				var props = new Key().GetType().GetProperties();
				float attWidht = (e.PageBounds.Size.Width / props.Length);

				for (int column = 0; column < props.Length; column++, x += attWidht)
				{
					string header = (string)props[column].Name;
					RectangleF headerRect = new RectangleF(x, y, attWidht , keyHeight);
					g.FillRectangle(Brushes.LightBlue, headerRect);
					g.DrawString(header, font, new SolidBrush(Color.Blue), headerRect, strFormat);
				}

				x = 0.0f;
				y += keyHeight;

				for (int row = 0; row < keys.Count; row++)
				{
					Key key = keys[row];

					for (int column = 0; column < props.Length; column++, x += attWidht)
					{
						string value = (string) key.GetType().GetProperties()[column].GetValue(key, null);
						RectangleF keyRect = new RectangleF(x, y, attWidht , keyHeight);
						g.DrawString(value, font, new SolidBrush(Color.Blue), keyRect, strFormat);
						g.DrawRectangle(new Pen(Color.Red), keyRect.X, keyRect.Y, keyRect.Width, keyRect.Height);
					}
					x = 0.0f;
					y += keyHeight;
					
				}

				y += offset;
			}

			e.HasMorePages = false;
				

		}



	}
}
