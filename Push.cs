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
	public Push(int val) {
		ByteCode = new BitArray(32);
		byte[] True = BitConverter.GetByte(value);
		BitArray tmp = new BitArray(True);
		ByteCode.Or(tmp);
		ByteCode[31] = 1;
		ByteCode[30] = 1;
		ByteCode[29] = 1;
		ByteCode[28] = 1;
	}
	
	//Memory Address Push Constructor.

	public Push(int value){
		ByteCode = new BitArray(32);
		byte[] True = BitConverter.GetByte(value);
		BitArray tmp = new BitArray(True);
		ByteCode.Or(tmp);		
		ByteCode[31] = 1;
		ByteCode[30] = 1;
		ByteCode[29] = 1;
		ByteCode[28] = 1;
	}

	//No value given Constructor.
	
	public Push(){
		ByteCode = new BitArray(32);
		ByteCode[31] = 1;
		ByteCode[30] = 1;
		ByteCode[29] = 1;
		ByteCode[28] = 1;
	}
}

