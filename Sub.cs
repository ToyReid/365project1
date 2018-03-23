using System;
using System.Collections;


public class Sub : IInstruction{
	
	byte[] true = BitConverter.GetByte(33);
	//byte[] true = BitConverter.GetByte(553648128);
	ByteCode = new BitArray(32);
	BitArray tmp = new BitArray(true);
	ByteCode.Or(tmp);
}

