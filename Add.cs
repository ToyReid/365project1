using System;
using System.Collections;

public class Add : IInstruction {
	public Add(){
		byte[] true = BitConverter.GetByte(32);
		//byte[] true = BitConverter.GetByte(536870912);
		BitArray tmp = new BitArray(true);
		ByteCode = new BitArray(32);
		ByteCode.Or(tmp);
	}
}
