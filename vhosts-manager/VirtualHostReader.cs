﻿/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-07-17
 * Time: 20:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Net;

namespace vhosts_manager
{
	/// <summary>
	/// Description of VirtualHostReader.
	/// </summary>
	public class VirtualHostReader
	{
		private List<string> Lines = new List<string>();
		private List<string> LinesWithoutComments = new List<string>();
		
		public List<VirtualHost> VirtualHosts = new List<VirtualHost>();
		
		public string Text
		{
			get {
				string res = String.Empty;
				foreach(string str in this.LinesWithoutComments)
				{
					res += str + Environment.NewLine;
				}
				return res;
			}
		}
		
		public VirtualHostReader(string fileName)
		{
			string[] file = File.ReadAllLines(fileName);
			foreach(string str in file)
			{
				this.Lines.Add(str);
				if(str.Trim().Length > 0)
				{
					if(str.Trim()[0] != '#')
						this.LinesWithoutComments.Add(str);
				}
			}
			
			MatchCollection x = Regex.Matches(this.Text, "<VirtualHost(.*?)</VirtualHost>", RegexOptions.Singleline);
			foreach(Match m in x)
			{
				this.AddVirtualHost(m.Value);
			}
		}
		
		public void AddVirtualHost(string text)
		{
			VirtualHost vhost = new VirtualHost();
			
			vhost.Address = GetIPAddress(text);
			vhost.Port = 80;
			vhost.ServerName = GetValue(text, "ServerName");
			vhost.ServerAlias = GetValue(text, "serverAlias");
			vhost.DocumentRoot = GetValue(text, "DocumentRoot");
			vhost.DirectoryIndex = GetValue(text, "DirectoryIndex");
			
			this.VirtualHosts.Add(vhost);
		}
		
		private string GetValue(string content, string name)
		{
			try {
				return Regex.Match(content, name+"(.)*", RegexOptions.IgnoreCase).Value.Split(' ')[1].Trim();
			}
			catch {
				return String.Empty;
			}
		}
		
		private IPAddress GetIPAddress(string content)
		{
			try {
				string reg = Regex.Match(content, "<VirtualHost (.)*>", RegexOptions.IgnoreCase).Value.ToLower();
				reg = reg.Replace("<virtualhost ", "").Replace(">", "");
				reg = reg.Remove(reg.IndexOf(':'));
				return IPAddress.Parse(reg);
			}
			catch {
				return IPAddress.Parse("0.0.0.0");
			}
		}
		
		public VirtualHost GetByServerName(string server)
		{
			foreach(VirtualHost vhost in this.VirtualHosts)
			{
				if(vhost.ServerName == server)
					return vhost;
			}
			throw new ArgumentOutOfRangeException();
		}

	}
}
