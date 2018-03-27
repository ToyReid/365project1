using System;
using System.Collections;
class Assembler
{
	public static void Main(string[] argv)
	{
		LabelDict labels;

		var fp = new FirstPass(argv[0]);

		var commands = fp.GetCleanInput(out labels);

		var pi = new ParseInstruction(commands, labels);

		//print feed beef

		var feedbeef = new byte[] {0xfe, 0xed, 0xbe, 0xef};
		Console.Write(feedbeef.ToString());

		//for each instruction print the bytecode

		foreach(BitArray b in pi.InstrList)
		{
			Console.Write(b.ToString());
		}

	}

}
