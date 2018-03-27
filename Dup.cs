using System;
using System.Collections;


public class Dup : IInstruction{
	protected BitArray bc;

	public BitArray ByteCode{
		get{
			return bc;
		}	
	}

	public Dup(int off){
		ByteCode = new BitArray(32);
		byte[] True = BitConverter.GetByte(off * 4);
		BitArray tmp = new BitArray(True);
		ByteCode.Or(tmp);
		ByteCode[30] = 1;
		ByteCode[31] = 1;
	}
}
