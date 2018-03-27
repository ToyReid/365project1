using System;
using System.Collections;

public class Div : IInstruction{
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Div(){
		ByteCode = new BitArray(32);
		ByteCode[29] = true;
		ByteCode[25] = true;
		ByteCode[24] = true;
	}
}
