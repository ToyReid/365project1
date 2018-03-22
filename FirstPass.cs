using System;
using System.IO;
using System.Collections.Generic;


class FirstPass
{

	public static void Main(string[] argv)
	{
		var fp = new FirstPass(argv[0]);
		fp.getCleanInput();
	}

	string mFileName;

	FirstPass(string fileName)
	{
		mFileName = fileName;
	}

	public List<string> getCleanInput(out Dictionary<string, ILabel> labels)
	{
		List<string> rv = new List<string>();
		string line;

		using(var sr = new StreamReader(mFileName))
		{

			while((line = sr.ReadLine()) != null)
			{
				if(String.IsNullOrWhiteSpace(line)) continue;

				//cleaning the line
				line = line.RemoveAfterSubstring("#");
				line = line.RemoveAfterSubstring("//");
				line = line.Trim();

				if(String.IsNullOrWhiteSpace(line)) continue;

				Console.WriteLine(line);
			}
		}
		return rv;
	}

}
