/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-07-06
 * Time: 20:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Net;
using System.Text.RegularExpressions;

namespace vhosts_manager
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private VirtualHostReader reader;
		private WindowsHosts winHosts;
		private int selectedIndex = -1;
		
		public MainForm()
		{
			InitializeComponent();
			
//			@"C:\Windows\System32\drivers\etc\hosts"
//			@"C:\xampp\apache\conf\extra\httpd-vhosts.conf"
			
			this.reader = new VirtualHostReader(@"test\httpd-vhosts.conf");
			this.winHosts = new WindowsHosts(@"test\hosts");
			
			foreach(KeyValuePair<string, IPAddress> entry in winHosts.Hosts)
			{
				this.listView1.Items.Add(new ListViewItem(new string[] {entry.Key, entry.Value.ToString()}));
			}
		}
		
		private void ListView1Click(object sender, EventArgs e)
		{
			if(this.listView1.SelectedItems.Count != 0)
			{
				ListViewItem item = listView1.SelectedItems[0];
				this.selectedIndex = listView1.SelectedItems[0].Index;
				AssignFormData(IPAddress.Parse(item.SubItems[1].Text));
			}
		}
		
		private void AssignFormData(IPAddress addr)
		{
			VirtualHost vhost = this.reader.GetByIPAddress(addr);
			this.fieldServerNameWindows.Text = vhost.ServerName;
			this.fieldServerAlias.Text = vhost.ServerAlias;
			this.fieldIPAddress.Text = addr.ToString();
			this.fieldPort.Value = vhost.Port;
			this.fieldDocumentRoot.Text = vhost.DocumentRoot;
			this.fieldDirectoryIndex.Text = vhost.DirectoryIndex;
		}
		
		private void Button1Click(object sender, EventArgs e)
		{
			this.winHosts.Hosts.Remove(this.listView1.Items[this.selectedIndex].SubItems[0].Text);
			
			VirtualHost vhost = new VirtualHost();
			vhost.ServerName = this.fieldServerNameWindows.Text.Trim();
			vhost.ServerAlias = this.fieldServerAlias.Text.Trim();
			
			try {
				vhost.Address = IPAddress.Parse(this.fieldIPAddress.Text.Trim());
			}
			catch {
				MessageBox.Show("Invalid format of IP address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			vhost.DocumentRoot = "\"" + this.fieldDocumentRoot.Text + "\"";
			vhost.DirectoryIndex = this.fieldDirectoryIndex.Text;
			
			this.reader.UpdateVirtualHost(this.listView1.Items[this.selectedIndex].SubItems[0].Text, vhost);
			this.listView1.Items[this.selectedIndex].SubItems[0].Text = vhost.ServerName;
			this.listView1.Items[this.selectedIndex].SubItems[1].Text = vhost.Address.ToString();
			
			this.winHosts.Hosts.Add(vhost.ServerName, vhost.Address);
			
			SaveToFiles();
		}
		
		private void SaveToFiles()
		{
			this.winHosts.Save();
			this.reader.Save();
		}
		
		void FormAddClick(object sender, EventArgs e)
		{
			VirtualHost vhost = new VirtualHost();
			vhost.Address = IPAddress.Parse(fieldIPAddress.Text);
			vhost.Port = (int)fieldPort.Value;
			vhost.ServerName = fieldServerNameWindows.Text;
			vhost.ServerAlias = fieldServerAlias.Text;
			vhost.DocumentRoot = fieldDocumentRoot.Text;
			vhost.DirectoryIndex = fieldDirectoryIndex.Text;
			reader.AddVirtualHost(vhost);
			
			winHosts.Hosts.Add(vhost.ServerName, vhost.Address);
			listView1.Items.Add(new ListViewItem(new string[] {vhost.ServerName, vhost.Address.ToString()}));
			
			SaveToFiles();
		}
	}
}
