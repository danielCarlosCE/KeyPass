namespace KeyPassUserInterface
{
	partial class GroupTreeControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupTreeControl));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripNewGroup = new System.Windows.Forms.ToolStripButton();
			this.toolStripEditGroup = new System.Windows.Forms.ToolStripButton();
			this.toolStripDeleteGroup = new System.Windows.Forms.ToolStripButton();
			this.treeViewGroup = new System.Windows.Forms.TreeView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._tsmAddGroup = new System.Windows.Forms.ToolStripMenuItem();
			this._tsmEditGroup = new System.Windows.Forms.ToolStripMenuItem();
			this._tmsDeleteGroup = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this._tsmCopyGroup = new System.Windows.Forms.ToolStripMenuItem();
			this._tsmPasteGroup = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNewGroup,
            this.toolStripEditGroup,
            this.toolStripDeleteGroup});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(37, 483);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripNewGroup
			// 
			this.toolStripNewGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripNewGroup.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.toolStripNewGroup.Image = global::KeyPassUserInterface.Properties.Resources.Folder;
			this.toolStripNewGroup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripNewGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripNewGroup.Name = "toolStripNewGroup";
			this.toolStripNewGroup.Size = new System.Drawing.Size(34, 36);
			this.toolStripNewGroup.Text = "toolStripButton1";
			this.toolStripNewGroup.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
			this.toolStripNewGroup.ToolTipText = "New Group";
			this.toolStripNewGroup.Click += new System.EventHandler(this.onAddGroup);
			// 
			// toolStripEditGroup
			// 
			this.toolStripEditGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripEditGroup.Enabled = false;
			this.toolStripEditGroup.Image = global::KeyPassUserInterface.Properties.Resources.Folder_blue;
			this.toolStripEditGroup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripEditGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripEditGroup.Name = "toolStripEditGroup";
			this.toolStripEditGroup.Size = new System.Drawing.Size(34, 36);
			this.toolStripEditGroup.Text = "Edit Group";
			this.toolStripEditGroup.Click += new System.EventHandler(this.OnEditGroup);
			// 
			// toolStripDeleteGroup
			// 
			this.toolStripDeleteGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDeleteGroup.Enabled = false;
			this.toolStripDeleteGroup.Image = global::KeyPassUserInterface.Properties.Resources.Delete;
			this.toolStripDeleteGroup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripDeleteGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDeleteGroup.Name = "toolStripDeleteGroup";
			this.toolStripDeleteGroup.Size = new System.Drawing.Size(34, 36);
			this.toolStripDeleteGroup.Text = "Delete Group";
			this.toolStripDeleteGroup.Click += new System.EventHandler(this.OnDeleteGroup);
			// 
			// treeViewGroup
			// 
			this.treeViewGroup.ContextMenuStrip = this.contextMenuStrip1;
			this.treeViewGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewGroup.HideSelection = false;
			this.treeViewGroup.ImageIndex = 0;
			this.treeViewGroup.ImageList = this.imageList1;
			this.treeViewGroup.Location = new System.Drawing.Point(37, 0);
			this.treeViewGroup.Name = "treeViewGroup";
			this.treeViewGroup.SelectedImageIndex = 0;
			this.treeViewGroup.Size = new System.Drawing.Size(244, 483);
			this.treeViewGroup.TabIndex = 2;
			this.treeViewGroup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnGroupSelected);
			this.treeViewGroup.DoubleClick += new System.EventHandler(this.OnEditGroup);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmAddGroup,
            this._tsmEditGroup,
            this._tmsDeleteGroup,
            this.toolStripSeparator1,
            this._tsmCopyGroup,
            this._tsmPasteGroup});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(181, 142);
			// 
			// _tsmAddGroup
			// 
			this._tsmAddGroup.Name = "_tsmAddGroup";
			this._tsmAddGroup.Size = new System.Drawing.Size(180, 22);
			this._tsmAddGroup.Text = "Add Group..";
			this._tsmAddGroup.Click += new System.EventHandler(this.onAddGroup);
			// 
			// _tsmEditGroup
			// 
			this._tsmEditGroup.Name = "_tsmEditGroup";
			this._tsmEditGroup.Size = new System.Drawing.Size(180, 22);
			this._tsmEditGroup.Text = "Edit Group...";
			this._tsmEditGroup.Click += new System.EventHandler(this.OnEditGroup);
			// 
			// _tmsDeleteGroup
			// 
			this._tmsDeleteGroup.Name = "_tmsDeleteGroup";
			this._tmsDeleteGroup.Size = new System.Drawing.Size(180, 22);
			this._tmsDeleteGroup.Text = "Delete Group...";
			this._tmsDeleteGroup.Click += new System.EventHandler(this.OnDeleteGroup);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "Lock.ico");
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// _tsmCopyGroup
			// 
			this._tsmCopyGroup.Name = "_tsmCopyGroup";
			this._tsmCopyGroup.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this._tsmCopyGroup.Size = new System.Drawing.Size(180, 22);
			this._tsmCopyGroup.Text = "Copy Group";
			this._tsmCopyGroup.Click += new System.EventHandler(this.OnCopyGroup);
			// 
			// _tsmPasteGroup
			// 
			this._tsmPasteGroup.Name = "_tsmPasteGroup";
			this._tsmPasteGroup.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this._tsmPasteGroup.Size = new System.Drawing.Size(180, 22);
			this._tsmPasteGroup.Text = "Paste Group";
			this._tsmPasteGroup.Click += new System.EventHandler(this.OnPasteGroup);
			// 
			// GroupTreeControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.treeViewGroup);
			this.Controls.Add(this.toolStrip1);
			this.Name = "GroupTreeControl";
			this.Size = new System.Drawing.Size(281, 483);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripNewGroup;
		private System.Windows.Forms.ToolStripButton toolStripEditGroup;
		private System.Windows.Forms.ToolStripButton toolStripDeleteGroup;
		private System.Windows.Forms.TreeView treeViewGroup;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem _tsmAddGroup;
		private System.Windows.Forms.ToolStripMenuItem _tsmEditGroup;
		private System.Windows.Forms.ToolStripMenuItem _tmsDeleteGroup;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem _tsmCopyGroup;
		private System.Windows.Forms.ToolStripMenuItem _tsmPasteGroup;
	}
}
