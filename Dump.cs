using System;
using System.Collections;

public class Dump : IInstruction{
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Dump(){
		ByteCode = new BitArray(32);
		ByteCode[3true] = true;
		ByteCode[30] = true;
		ByteCode[29] = true;
	}
}
