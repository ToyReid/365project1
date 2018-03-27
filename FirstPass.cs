using System;
using System.IO;
using System.Collections.Generic;


class FirstPass
{

	string mFileName;

	FirstPass(string fileName)
	{
		mFileName = fileName;
	}

	public List<string> getCleanInput(out LabelDict dict)
	{
		List<string> rv = new List<string>();
		string line;
		dict = new LabelDict();

		using(var sr = new StreamReader(mFileName))
		{

			while((line = sr.ReadLine()) != null)
			{
				if(String.IsNullOrWhiteSpace(line)) continue;

				//cleaning the line
				line = RemoveAfterSubstring(line, "#");
				line = RemoveAfterSubstring(line, "//");
				line = line.Trim();
				line = line.ToLower();

				if(String.IsNullOrWhiteSpace(line)) continue;

				//is a label
				if(line.EndsWith(":"))
				{
					string label = line.Substring(0, line.Length-1);
					dict[label] = new Label(label, rv.Count * 4);
				}
				else
				{
					rv.Add(line);
				}
			}
		}
		return rv;
	}


	public static string RemoveAfterSubstring(string s, string substring)
	{
		int index = s.IndexOf(substring);
		if(index != -1) s = s.Substring(0, index);
		return s;
	}
}
