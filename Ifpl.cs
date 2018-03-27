using System;
using System.Collections;


public class Ifpl : IInstruction{
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}

	public Ifpl(string value){
		ByteCode = new BitArray(32);
		byte[] True = BitConverter.GetByte(value);
		BitArray tmp = new BitArray(True);
		ByteCode.Or(tmp);
		ByteCode[31] = 1;
		ByteCode[24] = 1;
		ByteCode[28] = 1;
		ByteCode[25] = 1;
	}
}
