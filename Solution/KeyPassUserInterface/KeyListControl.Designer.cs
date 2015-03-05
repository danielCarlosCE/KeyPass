namespace KeyPassUserInterface
{
	partial class KeyListControl
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
			this.listViewKeys = new System.Windows.Forms.ListView();
			this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonEditKey = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonDeleteKey = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.contextMenuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listViewKeys
			// 
			this.listViewKeys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title,
            this.name,
            this.password,
            this.url});
			this.listViewKeys.ContextMenuStrip = this.contextMenuStrip1;
			this.listViewKeys.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listViewKeys.FullRowSelect = true;
			this.listViewKeys.GridLines = true;
			this.listViewKeys.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewKeys.HideSelection = false;
			this.listViewKeys.Location = new System.Drawing.Point(3, 43);
			this.listViewKeys.Name = "listViewKeys";
			this.listViewKeys.Size = new System.Drawing.Size(748, 368);
			this.listViewKeys.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listViewKeys.TabIndex = 0;
			this.listViewKeys.UseCompatibleStateImageBehavior = false;
			this.listViewKeys.View = System.Windows.Forms.View.Details;
			this.listViewKeys.SelectedIndexChanged += new System.EventHandler(this.listViewKeys_SelectedIndexChanged);
			this.listViewKeys.DoubleClick += new System.EventHandler(this.OnEditKey);
			// 
			// title
			// 
			this.title.Text = "   Title   ";
			this.title.Width = 101;
			// 
			// name
			// 
			this.name.Text = "   Name   ";
			this.name.Width = 161;
			// 
			// password
			// 
			this.password.Text = "   Password   ";
			this.password.Width = 182;
			// 
			// url
			// 
			this.url.Text = "   URL   ";
			this.url.Width = 313;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEntryToolStripMenuItem,
            this.editEntryToolStripMenuItem,
            this.deleteEntryToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(147, 70);
			// 
			// addEntryToolStripMenuItem
			// 
			this.addEntryToolStripMenuItem.Name = "addEntryToolStripMenuItem";
			this.addEntryToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.addEntryToolStripMenuItem.Text = "Add Entry...";
			this.addEntryToolStripMenuItem.Click += new System.EventHandler(this.OnAddKey);
			// 
			// editEntryToolStripMenuItem
			// 
			this.editEntryToolStripMenuItem.Name = "editEntryToolStripMenuItem";
			this.editEntryToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.editEntryToolStripMenuItem.Text = "Edit Entry...";
			this.editEntryToolStripMenuItem.Click += new System.EventHandler(this.OnEditKey);
			// 
			// deleteEntryToolStripMenuItem
			// 
			this.deleteEntryToolStripMenuItem.Name = "deleteEntryToolStripMenuItem";
			this.deleteEntryToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.deleteEntryToolStripMenuItem.Text = "Delete Entry...";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButtonEditKey,
            this.toolStripButtonDeleteKey,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.toolStripComboBox1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(291, 39);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = global::KeyPassUserInterface.Properties.Resources.Entry;
			this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
			this.toolStripButton1.Text = "Add key";
			this.toolStripButton1.Click += new System.EventHandler(this.OnAddKey);
			// 
			// toolStripButtonEditKey
			// 
			this.toolStripButtonEditKey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonEditKey.Enabled = false;
			this.toolStripButtonEditKey.Image = global::KeyPassUserInterface.Properties.Resources.Edit;
			this.toolStripButtonEditKey.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonEditKey.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonEditKey.Name = "toolStripButtonEditKey";
			this.toolStripButtonEditKey.Size = new System.Drawing.Size(36, 36);
			this.toolStripButtonEditKey.Text = "Edit Key";
			this.toolStripButtonEditKey.Click += new System.EventHandler(this.OnEditKey);
			// 
			// toolStripButtonDeleteKey
			// 
			this.toolStripButtonDeleteKey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonDeleteKey.Enabled = false;
			this.toolStripButtonDeleteKey.Image = global::KeyPassUserInterface.Properties.Resources.Delete;
			this.toolStripButtonDeleteKey.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonDeleteKey.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonDeleteKey.Name = "toolStripButtonDeleteKey";
			this.toolStripButtonDeleteKey.Size = new System.Drawing.Size(36, 36);
			this.toolStripButtonDeleteKey.Text = "Delete Keys";
			this.toolStripButtonDeleteKey.Click += new System.EventHandler(this.OnDeleteKeys);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = global::KeyPassUserInterface.Properties.Resources.Find;
			this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(36, 36);
			this.toolStripButton4.Text = "toolStripButton4";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripComboBox1
			// 
			this.toolStripComboBox1.Name = "toolStripComboBox1";
			this.toolStripComboBox1.Size = new System.Drawing.Size(121, 39);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.listViewKeys, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 414);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// KeyListControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "KeyListControl";
			this.Size = new System.Drawing.Size(754, 414);
			this.Load += new System.EventHandler(this.OnLoad);
			this.contextMenuStrip1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonEditKey;
		private System.Windows.Forms.ToolStripButton toolStripButtonDeleteKey;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ColumnHeader title;
		private System.Windows.Forms.ListView listViewKeys;
		private System.Windows.Forms.ColumnHeader name;
		private System.Windows.Forms.ColumnHeader password;
		private System.Windows.Forms.ColumnHeader url;
		private System.Windows.Forms.ToolStripMenuItem addEntryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editEntryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteEntryToolStripMenuItem;
	}
}
