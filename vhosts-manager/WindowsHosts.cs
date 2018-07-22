/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-07-22
 * Time: 17:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Net;
using System.Collections.Generic;

namespace vhosts_manager
{
	/// <summary>
	/// Description of WindowsHosts.
	/// </summary>
	public class WindowsHosts
	{
		public Dictionary<string, IPAddress> Hosts = new Dictionary<string, IPAddress>();
		private string fileName;
		
		public WindowsHosts(string file = @"C:\Windows\System32\drivers\etc\hosts")
		{
			this.fileName = file;
			foreach(string line in File.ReadAllLines(file))
			{
				this.AddLine(line);
			}
		}
		
		private void AddLine(string line)
		{
			if(isValidLine(line))
			{
				string[] arr = line.Split(' ');
				string host = arr[1];
				IPAddress addr = IPAddress.Parse(arr[0]);
				this.Hosts.Add(host, addr);
			}
		}
		
		public void Add(string host, IPAddress addr)
		{
			this.Hosts.Add(host, addr);
		}
		
		private bool isValidLine(string line)
		{
			if(line.Length > 0)
			{
				if(line[0] != '#')
					return true;
			}
			return false;
		}
		
		public void Save()
		{
			File.WriteAllText(this.fileName, "");
			foreach(KeyValuePair<string, IPAddress> entry in this.Hosts)
			{
				File.AppendAllText(this.fileName, entry.Value.ToString().Trim() + " " + entry.Key.Trim() + Environment.NewLine);
			}
		}
		
		public string GetServerName(IPAddress addr)
		{
			foreach(KeyValuePair<string, IPAddress> entry in this.Hosts)
			{
				if(entry.Value.ToString() == addr.ToString())
					return entry.Key;
			}
			throw new ArgumentOutOfRangeException();
		}
	}
	
}
