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
		bc = new BitArray(32);
		bc[31] = true;
		bc[30] = true;
		bc[29] = true;
	}
}
