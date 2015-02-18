namespace KeyPassUserInterface
{
	partial class ClockControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.clockLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.OnTick);
			// 
			// clockLabel
			// 
			this.clockLabel.AllowDrop = true;
			this.clockLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.clockLabel.Location = new System.Drawing.Point(0, 0);
			this.clockLabel.Name = "clockLabel";
			this.clockLabel.Size = new System.Drawing.Size(182, 72);
			this.clockLabel.TabIndex = 0;
			this.clockLabel.Text = "label1";
			this.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ClockControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.clockLabel);
			this.Name = "ClockControl";
			this.Size = new System.Drawing.Size(182, 72);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label clockLabel;
	}
}
