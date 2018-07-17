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
using System.Text.RegularExpressions;

namespace vhosts_manager
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			string hosts = File.ReadAllText(@"C:\Windows\System32\drivers\etc\hosts");
			string httpdVhosts = File.ReadAllText(@"C:\xampp\apache\conf\extra\httpd-vhosts.conf");
			
//			var x = Regex.Matches(httpdVhosts, "<VirtualHost(.*?)</VirtualHost>", RegexOptions.Singleline);
//			MessageBox.Show(x[2].Value);
			
			
			VirtualHostReader reader = new VirtualHostReader(@"C:\xampp\apache\conf\extra\httpd-vhosts.conf");
		}
	}
}
