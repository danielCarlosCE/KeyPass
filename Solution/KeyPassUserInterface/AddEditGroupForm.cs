using KeyPassBusiness;
using System;
using System.Windows.Forms;

namespace KeyPassUserInterface
{
	public partial class AddEditGroupForm : Form
	{

		public String GroupName
		{

			get { return textBoxGroupName.Text; }
			set { textBoxGroupName.Text = value; }
		}

		public AddEditGroupForm()
		{
			InitializeComponent();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (!ValidateInput())
			{
				MessageBox.Show("Error: Group Name Cannot be Empty.");
				return;
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		private bool ValidateInput()
		{
			return !string.IsNullOrEmpty(textBoxGroupName.Text);
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void buttonTest_Click(object sender, EventArgs e)
		{
			textBoxGroupName.Text = Util.generateRandomText();
			buttonOK.Focus();
		}
	}
}
