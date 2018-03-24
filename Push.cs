using System;
using System.Collections;


public class Push : IInstruction{
	//Given a Literal Constructor
	
	public Push(string val){
		if(Int32.TryParse(inst,out j)){
			ByteCode = new BitArray(32);
			byte[] true = BitConverter.GetByte(j);
			BitArray tmp = new BitArray(true);
			ByteCode.Or(tmp);
			ByteCode[31] = 1;
			ByteCode[30] = 1;
			ByteCode[29] = 1;
			ByteCode[28] = 1;
		}
	}
	
	//Memory Address Push Constructor.

	public Push(int value){
		ByteCode = new BitArray(32);
		byte[] true = BitConverter.GetByte(value);
		BitArray tmp = new BitArray(true);
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

