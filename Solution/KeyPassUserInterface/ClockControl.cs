using System;
using System.Windows.Forms;

namespace KeyPassUserInterface
{
	public partial class ClockControl : UserControl
	{
		public ClockControl()
		{
			InitializeComponent();
			clockLabel.Text = DateTime.Now.ToString();
		}

		private void OnTick(object sender, EventArgs e)
		{
			clockLabel.Text = DateTime.Now.ToString();
		}
	}
}
