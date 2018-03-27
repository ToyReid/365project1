using System;
using System.Collections;


public class Goto : IInstruction{
	public Goto(int value){
		ByteCode = new BitArray(32);
		byte[] true = BitConverter.GetByte(value);
		BitArray tmp = new BitArray(true);
		ByteCode.Or(tmp);
		ByteCode[30] = 1;
		ByteCode[29] = 1;
		ByteCode[28] = 1;
	}
}
