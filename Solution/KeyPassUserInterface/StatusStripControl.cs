using System.Windows.Forms;

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
	}
}
