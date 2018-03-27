using System;
using System.Collections;

public class Ifmi : IInstruction {
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Ifmi(int value){
		ByteCode = new BitArray(32);
		byte[] True = BitConverter.GetByte(value);
		BitArray tmp = new BitArray(True);
		ByteCode.Or(tmp);
		ByteCode[31] = true;
		ByteCode[28] = true;
		ByteCode[25] = true;
	}
}

