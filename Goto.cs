using System;
using System.Collections;


public class Goto : IInstruction{
	public Goto(int value){
		
			ByteCode = new BitArray(32);
			byte[] tru = BitConverter.GetByte(j);
			BitArray tmp = new BitArray(tru);
			ByteCode.Or(tmp);
			ByteCode[30] = 1;
			ByteCode[29] = 1;
			ByteCode[28] = 1;

	}
}
