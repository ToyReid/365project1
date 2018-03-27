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

		//print feed beef

		using(var br = new BinaryWriter(File.OpenWrite(argv[1])))
		{
			var feedbeef = new byte[] { 0xfe, 0xed, 0xbe, 0xef};

			//SwapBytes(feedbeef);
			foreach(byte b in feedbeef)
			{
				br.Write(b);
			}

			foreach(BitArray b in pi.InstrList)
			{
				byte[] temp = new byte[8];
				b.CopyTo(temp, 0);
				//SwapBytes(temp);
				foreach(byte t in temp)
				{
					br.Write(t);
				}

			}
		}

	}

	public static void SwapBytes(byte[] b)
	{
		int i;
		byte temp;
		for(i = 0; i < b.Length/2; i++)
		{
			temp = b[i];
			b[i] = b[b.Length - i - 1];
			b[b.Length - i - 1] = temp;

		}
	}

}
