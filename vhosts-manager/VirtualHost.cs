/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-07-06
 * Time: 20:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net;

namespace vhosts_manager
{
	/// <summary>
	/// Description of VirtualHostInfo.
	/// </summary>
	public class VirtualHost
	{
		public IPAddress Address;
		public int Port;
		
		public string ServerName;
		public string ServerAlias;
		public string DocumentRoot;
		public string DirectoryIndex;
//		public string AllowOverride;
		
//		public bool AllowFromAll;
//		public bool OrderAllowDeny;
		
		public VirtualHost()
		{
		}
		
		public void Parse(string str)
		{
			// TODO VirtualHost.Parse(string)
		}
		
		public string RenderEntry()
		{
			string entry = String.Format("<VirtualHost {0}:{1}>"+Environment.NewLine, Address.ToString(), Port.ToString());
			entry += String.Format("\tServerName {0}"+Environment.NewLine, ServerName);
			entry += String.Format("\tServerAlias {0}"+Environment.NewLine, ServerAlias);
			entry += String.Format("\tDocumentRoot {0}"+Environment.NewLine, DocumentRoot);
			if(DirectoryIndex != String.Empty)
				entry += String.Format("\tDirectoryindex \"{0}\""+Environment.NewLine, DirectoryIndex);
			entry += "</VirtualHost>";
			
			return entry;
		}
	}
}
