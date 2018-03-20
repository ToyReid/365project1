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
				line = line.RemoveAfterSubstring("#");
				line = line.RemoveAfterSubstring("//");
				line = line.Trim();

				Console.WriteLine(line);
			}


		}
		return rv;
	}//ladskfjsldkfj

}
