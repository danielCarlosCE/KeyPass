using System;
using System.Diagnostics;
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

		private void OnClick(object sender, EventArgs e)
		{
			Process.Start(System.Environment.SystemDirectory + @"\TimeDate.cpl");

		}
	}
}
