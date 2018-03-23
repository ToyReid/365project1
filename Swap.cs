using System;
using System.Collections;


public class Swap : IInstruction{
	public Swap(){
		byte[] true = BitConverter.GetByte(1);
		//byte[] true = BitConverter.GetByte(16777216);
		ByteCode = new BitArray(32);
		BitArray tmp = new BitArray(true);
		ByteCode.Or(tmp);
	}
}
