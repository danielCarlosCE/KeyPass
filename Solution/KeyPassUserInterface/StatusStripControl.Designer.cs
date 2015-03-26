namespace KeyPassUserInterface
{
	partial class StatusStripControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusStripControl));
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.labelTotalKeys = new System.Windows.Forms.Label();
			this.labelTotalGroups = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this._comboBoxLog = new System.Windows.Forms.ComboBox();
			this.clockControl1 = new KeyPassUserInterface.ClockControl();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTotalKeys
			// 
			resources.ApplyResources(this.labelTotalKeys, "labelTotalKeys");
			this.labelTotalKeys.Name = "labelTotalKeys";
			// 
			// labelTotalGroups
			// 
			resources.ApplyResources(this.labelTotalGroups, "labelTotalGroups");
			this.labelTotalGroups.Name = "labelTotalGroups";
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.labelTotalGroups, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelTotalKeys, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this._comboBoxLog, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.clockControl1, 3, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// _comboBoxLog
			// 
			resources.ApplyResources(this._comboBoxLog, "_comboBoxLog");
			this._comboBoxLog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._comboBoxLog.FormattingEnabled = true;
			this._comboBoxLog.Name = "_comboBoxLog";
			// 
			// clockControl1
			// 
			this.clockControl1.Cursor = System.Windows.Forms.Cursors.Hand;
			resources.ApplyResources(this.clockControl1, "clockControl1");
			this.clockControl1.Name = "clockControl1";
			// 
			// StatusStripControl
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "StatusStripControl";
			this.Load += new System.EventHandler(this.StatusStripControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.BindingSource bindingSource1;

		private System.Windows.Forms.Label labelTotalKeys;
		private System.Windows.Forms.Label labelTotalGroups;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ComboBox _comboBoxLog;
		private ClockControl clockControl1;
	}
}
