using System.Diagnostics;
using System.Windows.Forms;
using KeyPassBusiness;
using System.Collections.Generic;


namespace KeyPassUserInterface
{
	public partial class StatusStripControl : UserControl
	{
		public StatusStripControl()
		{
			InitializeComponent();
		}


		public void updateStatus(int totalGroups, int totalKeysSelected, int totalkeys)
		{
			labelTotalGroups.Text = " Total Groups: " + totalGroups;
			labelTotalKeys.Text = "" + totalKeysSelected + " of " + totalkeys + " selected keys";

		}

		private void StatusStripControl_Load(object sender, System.EventArgs e)
		{
			Log.LogEvent += OnLog;
		}

		void OnLog(string message)
		{
			int i = _comboBoxLog.Items.Add(message);
			_comboBoxLog.SelectedIndex = i;
		}

	}
}
