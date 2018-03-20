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

	public List<string> getCleanInput()
	{
		List<string> rv = new List<string>();
		string line;

		using(var sr = new StreamReader(mFileName))
		{

			while((line = sr.ReadLine()) != null)
			{
				line = StripComments(line, "#");
				line = StripComments(line, "//");

				Console.WriteLine(line);
			}


		}
		return rv;
	}//ladskfjsldkfj

	public static string StripComments(string line, string commentDelimiter)
	{
		int index;

		index = line.IndexOf(commentDelimiter);

		if(index == -1) return line;

		return line.Substring(0, index);

	}
}
