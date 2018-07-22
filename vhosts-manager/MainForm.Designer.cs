/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-07-06
 * Time: 20:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace vhosts_manager
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.panel1 = new System.Windows.Forms.Panel();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.formSave = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.formNew = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.fieldServerNameWindows = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.fieldServerAlias = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.fieldIPAddress = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.fieldPort = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.fieldDocumentRoot = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.fieldDirectoryIndex = new System.Windows.Forms.TextBox();
			this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.apacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fieldPort)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.commandsToolStripMenuItem,
									this.settingsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(786, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.listView1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(255, 384);
			this.panel1.TabIndex = 1;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.HideSelection = false;
			this.listView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(255, 384);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.Click += new System.EventHandler(this.ListView1Click);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ServerName";
			this.columnHeader1.Width = 126;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "IP";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 125;
			// 
			// formSave
			// 
			this.formSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.formSave.Location = new System.Drawing.Point(6, 339);
			this.formSave.Name = "formSave";
			this.formSave.Size = new System.Drawing.Size(110, 33);
			this.formSave.TabIndex = 7;
			this.formSave.Text = "Save";
			this.formSave.UseVisualStyleBackColor = true;
			this.formSave.Click += new System.EventHandler(this.Button1Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.formNew);
			this.panel2.Controls.Add(this.tableLayoutPanel1);
			this.panel2.Controls.Add(this.formSave);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(255, 24);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(531, 384);
			this.panel2.TabIndex = 2;
			// 
			// formNew
			// 
			this.formNew.Location = new System.Drawing.Point(122, 339);
			this.formNew.Name = "formNew";
			this.formNew.Size = new System.Drawing.Size(110, 33);
			this.formNew.TabIndex = 8;
			this.formNew.Text = "New";
			this.formNew.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.9434F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.0566F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.fieldServerNameWindows, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.fieldServerAlias, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.fieldIPAddress, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.fieldPort, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.fieldDocumentRoot, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.fieldDirectoryIndex, 1, 5);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.57534F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.42466F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(531, 211);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.Color.DeepPink;
			this.label1.Location = new System.Drawing.Point(4, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(210, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "ServerName (Windows)";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fieldServerNameWindows
			// 
			this.fieldServerNameWindows.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fieldServerNameWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.fieldServerNameWindows.Location = new System.Drawing.Point(221, 4);
			this.fieldServerNameWindows.Name = "fieldServerNameWindows";
			this.fieldServerNameWindows.Size = new System.Drawing.Size(306, 24);
			this.fieldServerNameWindows.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.ForeColor = System.Drawing.Color.DeepPink;
			this.label2.Location = new System.Drawing.Point(4, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(210, 36);
			this.label2.TabIndex = 2;
			this.label2.Text = "ServerAlias";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fieldServerAlias
			// 
			this.fieldServerAlias.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fieldServerAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.fieldServerAlias.Location = new System.Drawing.Point(221, 37);
			this.fieldServerAlias.Name = "fieldServerAlias";
			this.fieldServerAlias.Size = new System.Drawing.Size(306, 24);
			this.fieldServerAlias.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.ForeColor = System.Drawing.Color.DeepPink;
			this.label3.Location = new System.Drawing.Point(4, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(210, 33);
			this.label3.TabIndex = 4;
			this.label3.Text = "IP Address";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fieldIPAddress
			// 
			this.fieldIPAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fieldIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.fieldIPAddress.Location = new System.Drawing.Point(221, 74);
			this.fieldIPAddress.MaxLength = 15;
			this.fieldIPAddress.Name = "fieldIPAddress";
			this.fieldIPAddress.Size = new System.Drawing.Size(306, 24);
			this.fieldIPAddress.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label7.ForeColor = System.Drawing.Color.DeepPink;
			this.label7.Location = new System.Drawing.Point(4, 105);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(210, 34);
			this.label7.TabIndex = 13;
			this.label7.Text = "Port";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fieldPort
			// 
			this.fieldPort.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fieldPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.fieldPort.Location = new System.Drawing.Point(221, 108);
			this.fieldPort.Name = "fieldPort";
			this.fieldPort.Size = new System.Drawing.Size(306, 24);
			this.fieldPort.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.ForeColor = System.Drawing.Color.DeepPink;
			this.label4.Location = new System.Drawing.Point(4, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(210, 35);
			this.label4.TabIndex = 6;
			this.label4.Text = "DocumentRoot";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fieldDocumentRoot
			// 
			this.fieldDocumentRoot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fieldDocumentRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.fieldDocumentRoot.Location = new System.Drawing.Point(221, 143);
			this.fieldDocumentRoot.Name = "fieldDocumentRoot";
			this.fieldDocumentRoot.Size = new System.Drawing.Size(306, 24);
			this.fieldDocumentRoot.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.ForeColor = System.Drawing.Color.DeepPink;
			this.label6.Location = new System.Drawing.Point(4, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(210, 34);
			this.label6.TabIndex = 8;
			this.label6.Text = "DirectoryIndex";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fieldDirectoryIndex
			// 
			this.fieldDirectoryIndex.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fieldDirectoryIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.fieldDirectoryIndex.Location = new System.Drawing.Point(221, 179);
			this.fieldDirectoryIndex.Name = "fieldDirectoryIndex";
			this.fieldDirectoryIndex.Size = new System.Drawing.Size(306, 24);
			this.fieldDirectoryIndex.TabIndex = 6;
			// 
			// commandsToolStripMenuItem
			// 
			this.commandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.apacheToolStripMenuItem});
			this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
			this.commandsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
			this.commandsToolStripMenuItem.Text = "Commands";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// apacheToolStripMenuItem
			// 
			this.apacheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.runToolStripMenuItem,
									this.stopToolStripMenuItem,
									this.restartToolStripMenuItem});
			this.apacheToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("apacheToolStripMenuItem.Image")));
			this.apacheToolStripMenuItem.Name = "apacheToolStripMenuItem";
			this.apacheToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.apacheToolStripMenuItem.Text = "Apache";
			// 
			// runToolStripMenuItem
			// 
			this.runToolStripMenuItem.Name = "runToolStripMenuItem";
			this.runToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.runToolStripMenuItem.Text = "Run";
			// 
			// stopToolStripMenuItem
			// 
			this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
			this.stopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.stopToolStripMenuItem.Text = "Stop";
			// 
			// restartToolStripMenuItem
			// 
			this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
			this.restartToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.restartToolStripMenuItem.Text = "Restart";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(786, 408);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "vhosts-manager";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.fieldPort)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem apacheToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
		private System.Windows.Forms.NumericUpDown fieldPort;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button formNew;
		private System.Windows.Forms.Button formSave;
		private System.Windows.Forms.TextBox fieldServerAlias;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox fieldIPAddress;
		private System.Windows.Forms.TextBox fieldDocumentRoot;
		private System.Windows.Forms.TextBox fieldDirectoryIndex;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox fieldServerNameWindows;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
