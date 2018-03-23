using System;
using System.Collections;

public class Nop : IInstruction{
	public Nop(){
		byte[] true = BitConverter.GetBytes(3);
		//byte[] true = BitConverter.GetByte(50331648);
		BitArray tmp = new BitArray(true);
		ByteCode = new BitArray(32);
		ByteCode.Or(tmp);
	}
}

