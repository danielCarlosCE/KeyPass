namespace KeyPassUserInterface
{
	partial class AddEditKeyForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonTest = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.textBoxUserName = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
			this.textBoxURL = new System.Windows.Forms.TextBox();
			this.comboBoxGroups = new System.Windows.Forms.ComboBox();
			this.textBoxNotes = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonCancel.Location = new System.Drawing.Point(178, 3);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(169, 61);
			this.buttonCancel.TabIndex = 0;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonOK.Location = new System.Drawing.Point(353, 3);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(169, 61);
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonTest
			// 
			this.buttonTest.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonTest.Location = new System.Drawing.Point(3, 3);
			this.buttonTest.Name = "buttonTest";
			this.buttonTest.Size = new System.Drawing.Size(169, 61);
			this.buttonTest.TabIndex = 2;
			this.buttonTest.Text = "Test";
			this.buttonTest.UseVisualStyleBackColor = true;
			this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.buttonTest, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonOK, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(525, 67);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
			this.splitContainer1.Size = new System.Drawing.Size(525, 386);
			this.splitContainer1.SplitterDistance = 315;
			this.splitContainer1.TabIndex = 4;
			this.splitContainer1.TabStop = false;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.28514F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.71486F));
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
			this.tableLayoutPanel2.Controls.Add(this.label7, 0, 6);
			this.tableLayoutPanel2.Controls.Add(this.textBoxTitle, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.textBoxUserName, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.textBoxPassword, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.textBoxConfirmPass, 1, 4);
			this.tableLayoutPanel2.Controls.Add(this.textBoxURL, 1, 5);
			this.tableLayoutPanel2.Controls.Add(this.comboBoxGroups, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.textBoxNotes, 1, 6);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 7;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(525, 315);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "Group";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "Title";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 26);
			this.label3.TabIndex = 2;
			this.label3.Text = "User Name";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 79);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 26);
			this.label4.TabIndex = 3;
			this.label4.Text = "Password";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(3, 105);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 26);
			this.label5.TabIndex = 4;
			this.label5.Text = "Confirm Password";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Location = new System.Drawing.Point(3, 131);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 26);
			this.label6.TabIndex = 5;
			this.label6.Text = "URL";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Location = new System.Drawing.Point(3, 157);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(105, 158);
			this.label7.TabIndex = 6;
			this.label7.Text = "Notes";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxTitle.Location = new System.Drawing.Point(114, 30);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(408, 20);
			this.textBoxTitle.TabIndex = 8;
			// 
			// textBoxUserName
			// 
			this.textBoxUserName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxUserName.Location = new System.Drawing.Point(114, 56);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.Size = new System.Drawing.Size(408, 20);
			this.textBoxUserName.TabIndex = 9;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxPassword.Location = new System.Drawing.Point(114, 82);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(408, 20);
			this.textBoxPassword.TabIndex = 10;
			// 
			// textBoxConfirmPass
			// 
			this.textBoxConfirmPass.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxConfirmPass.Location = new System.Drawing.Point(114, 108);
			this.textBoxConfirmPass.Name = "textBoxConfirmPass";
			this.textBoxConfirmPass.Size = new System.Drawing.Size(408, 20);
			this.textBoxConfirmPass.TabIndex = 11;
			// 
			// textBoxURL
			// 
			this.textBoxURL.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxURL.Location = new System.Drawing.Point(114, 134);
			this.textBoxURL.Name = "textBoxURL";
			this.textBoxURL.Size = new System.Drawing.Size(408, 20);
			this.textBoxURL.TabIndex = 12;
			// 
			// comboBoxGroups
			// 
			this.comboBoxGroups.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxGroups.FormattingEnabled = true;
			this.comboBoxGroups.Location = new System.Drawing.Point(114, 3);
			this.comboBoxGroups.Name = "comboBoxGroups";
			this.comboBoxGroups.Size = new System.Drawing.Size(408, 21);
			this.comboBoxGroups.TabIndex = 13;
			// 
			// textBoxNotes
			// 
			this.textBoxNotes.BackColor = System.Drawing.SystemColors.Info;
			this.textBoxNotes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxNotes.Location = new System.Drawing.Point(114, 160);
			this.textBoxNotes.Multiline = true;
			this.textBoxNotes.Name = "textBoxNotes";
			this.textBoxNotes.Size = new System.Drawing.Size(408, 152);
			this.textBoxNotes.TabIndex = 14;
			// 
			// AddEditKeyForm
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(525, 386);
			this.Controls.Add(this.splitContainer1);
			this.Name = "AddEditKeyForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AddEditKeyForm";
			this.Load += new System.EventHandler(this.OnLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonTest;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.TextBox textBoxTitle;
		public System.Windows.Forms.TextBox textBoxUserName;
		public System.Windows.Forms.TextBox textBoxPassword;
		public System.Windows.Forms.TextBox textBoxConfirmPass;
		public System.Windows.Forms.TextBox textBoxURL;
		public System.Windows.Forms.TextBox textBoxNotes;
		public System.Windows.Forms.ComboBox comboBoxGroups;
	}
}