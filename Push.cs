using System;
using System.Collections;


public class Push : IInstruction{
	
	get{
	return ByteCode;
	}
		
	public Push(int value){
		ByteCode = new BitArray(32);
		byte[] true = BitConverter.GetByte(value);
		BitArray tmp = new BitArray(true);
		ByteCode.Or(tmp);		
		ByteCode[31] = 1;
		ByteCode[30] = 1;
		ByteCode[29] = 1;
		ByteCode[28] = 1;
	}

}

