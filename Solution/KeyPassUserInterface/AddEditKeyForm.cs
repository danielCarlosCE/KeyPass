using KeyPassBusiness;
using KeyPassInfoObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KeyPassUserInterface
{
	public partial class AddEditKeyForm : Form
	{
		public AddEditKeyForm()
		{
			InitializeComponent();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (!validateInput())
			{
				return;
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void buttonTest_Click(object sender, EventArgs e)
		{
			textBoxTitle.Text = Util.generateRandomText();

			textBoxUserName.Text = Util.generateRandomText();

			textBoxPassword.Text = Util.generateRandomText();

			textBoxConfirmPass.Text = textBoxPassword.Text;

			textBoxURL.Text = Util.generateRandomText();

			textBoxNotes.Text = Util.generateRandomText();

			buttonOK.Focus();

		}

		private bool validateInput()
		{
			bool valide = true;
			if (string.IsNullOrEmpty(textBoxTitle.Text) || string.IsNullOrEmpty(textBoxUserName.Text)
				|| string.IsNullOrEmpty(textBoxPassword.Text) || string.IsNullOrEmpty(textBoxConfirmPass.Text)
				|| string.IsNullOrEmpty(textBoxURL.Text))
			{

				MessageBox.Show("Only Notes can be empty.");
				valide = false;
			}

			if (!textBoxPassword.Text.Equals(textBoxConfirmPass.Text))
			{
				MessageBox.Show("The Password and Confirmation don't match.");
				valide = false;
			}
			return valide;

		}

		private void OnLoad(object sender, EventArgs e)
		{
			List<Group> groups = DataManager.ListGroups();
			comboBoxGroups.DataSource = groups;
			comboBoxGroups.SelectedItem = UIContextManager.GroupSelected;

		}
	}
}
