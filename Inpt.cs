using System;
using System.Collections;

public class Inpt : IInstruction{
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Inpt(){
		ByteCode = new BitArray(32);
		ByteCode[25] = true;
	}
}
