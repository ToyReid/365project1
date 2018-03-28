using System;
using System.Collections;
using System.IO;

class Assembler
{
	public static void Main(string[] argv)
	{
		LabelDict labels;

		if(argv.Length != 2)
		{
			Console.WriteLine("Usage: Assembler.exe assembly_file output_file");
		}

		//Make a first pass with given file
		var fp = new FirstPass(argv[0]);


		//clean the input on the forst pass and get labels
		var commands = fp.GetCleanInput(out labels);

		//parse all instructions
		var pi = new ParseInstruction(commands, labels);

		//open file and write output
		using(var br = new BinaryWriter(File.Open(argv[1], FileMode.Create)))
		{

			var feedbeef = new byte[] { 0xfe, 0xed, 0xbe, 0xef};

			//print magic header
			br.Write(feedbeef);

			//print the bytecode
			foreach(BitArray b in pi.InstrList)
			{
				byte[] temp = new byte[4];
				b.CopyTo(temp, 0);
				br.Write(temp);
			}
		}

	}

}
