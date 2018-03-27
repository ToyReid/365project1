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
		ByteCode[30] = true;
		ByteCode[29] = true;
		ByteCode[28] = true;
	}
}
