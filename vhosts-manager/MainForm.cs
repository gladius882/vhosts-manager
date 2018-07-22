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
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
//			string hosts = File.ReadAllText(@"C:\Windows\System32\drivers\etc\hosts");
//			string httpdVhosts = File.ReadAllText(@"C:\xampp\apache\conf\extra\httpd-vhosts.conf");			
			
			this.reader = new VirtualHostReader(@"C:\xampp\apache\conf\extra\httpd-vhosts.conf");
			this.winHosts = new WindowsHosts();
			
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
				VirtualHost vhost = this.reader.GetByServerName(item.SubItems[0].Text);
				AssignFormData(vhost);
			}
		}
		
		private void AssignFormData(VirtualHost vhost)
		{
			this.fieldServerName.Text = vhost.ServerName;
			this.fieldServerAlias.Text = vhost.ServerAlias;
			this.fieldIPAddress.Text = vhost.Address.ToString();
			this.fieldDocumentRoot.Text = vhost.DocumentRoot;
			this.fieldDirectoryIndex.Text = vhost.DirectoryIndex;
		}
	}
}
