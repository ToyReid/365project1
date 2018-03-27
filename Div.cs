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
		ByteCode[29] = 1;
		ByteCode[25] = 1;
		ByteCode[24] = 1;
	}
}
