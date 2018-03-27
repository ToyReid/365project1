using System;
using System.Collections;


public class Swap : IInstruction {
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Swap() {
		ByteCode = new BitArray(32);
		ByteCode[24] = true;
	}
}
