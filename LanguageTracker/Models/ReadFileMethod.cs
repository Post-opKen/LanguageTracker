using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace LanguageTracker.Models
{
	public class ReadFileMethod
	{
		//method to read the file and convert it to a table
		public static bool ReadFile(Stream stream)
		{
			if (stream != null)
			{
				StreamReader reader = new StreamReader(stream);
				//display the file as an html table
				string table = "";
				while (!reader.EndOfStream)
				{
					table += "<tr>";
					string line = reader.ReadLine();
					string[] cols = line.Split(",");
					foreach (string col in cols)
					{
						table += $"<td>{col}</td>";
					}
					table += "</tr>";
				}
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
