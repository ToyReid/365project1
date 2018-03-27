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
		ByteCode[29] = true;
		ByteCode[26] = true;
		ByteCode[24] = true;
	}
}
