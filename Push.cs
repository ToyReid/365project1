using System;
using System.Collections;


public class Push : IInstruction {
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	//Given a Literal Constructor
	public Push(int value) {
		ByteCode = new BitArray(32);
		byte[] True = BitConverter.GetByte(value);
		BitArray tmp = new BitArray(True);
		ByteCode.Or(tmp);
		ByteCode[31] = true;
		ByteCode[30] = true;
		ByteCode[29] = true;
		ByteCode[28] = true;
	}
	
	//Memory Address Push Constructor.

	public Push(int value){
		ByteCode = new BitArray(32);
		byte[] True = BitConverter.GetByte(value);
		BitArray tmp = new BitArray(True);
		ByteCode.Or(tmp);		
		ByteCode[31] = true;
		ByteCode[30] = true;
		ByteCode[29] = true;
		ByteCode[28] = true;
	}

}

