using System;
using System.Collections;

public class Goto : IInstruction{
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}

	public Goto(int value){
		ByteCode = new BitArray(32);
		byte[] True = BitConverter.GetByte(value);
		BitArray tmp = new BitArray(True);
		ByteCode.Or(tmp);
		ByteCode[30] = 1;
		ByteCode[29] = 1;
		ByteCode[28] = 1;
	}
}
