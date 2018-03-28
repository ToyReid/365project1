using System;
using System.Collections;
using System.IO;

class Assembler
{
	public static void Main(string[] argv)
	{
		LabelDict labels;

		var fp = new FirstPass(argv[0]);

		var commands = fp.GetCleanInput(out labels);

		var pi = new ParseInstruction(commands, labels);

		int i = 0;
		using(var br = new BinaryWriter(File.Open(argv[1], FileMode.Create)))
		{
			var feedbeef = new byte[] { 0xfe, 0xed, 0xbe, 0xef};

			br.Write(feedbeef);

			foreach(BitArray b in pi.InstrList)
			{
				byte[] temp = new byte[4];
				b.CopyTo(temp, 0);
				br.Write(temp);
			}
		}

	}

}
