using System.Collections.Generic;

class FirstPass
{

	public statice void Main(string[] args)
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
		List<string> rv;
		string line;

		using(var sr = new StreamReader(mFileName))
		{
			int index;
			while(sr.BaseStream.Position != sr.BaseStream.Length)
			{
				line = sr.ReadLine();

				if(line.IsNullOrWhitespace()) continue;

				StripComments(line, "#");
				StripComments(line, "//");

				Console.WriteLine(line);
			}


		}
	}

	public static string StripComments(string line, string commentDelimiter)
	{
		int index;

		if(line.IsNullOrEmpty) return line;

		index = line.IndexOf(commentDelimiter);

		if(index == -1) return line;

		return line.Substring(0, index);

	}
}
