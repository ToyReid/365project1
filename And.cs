using System;
using System.Collections;

public class And : IInstruction{
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public And(){
		ByteCode = new BitArray(32);
		ByteCode[29] = 1;
		ByteCode[26] = 1;
		ByteCode[24] = 1;
	}
}
