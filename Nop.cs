using System;
using System.Collections;

public class Nop : IInstruction {
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Nop() {
		ByteCode = new BitArray(32);
		ByteCode[24] = true;
		ByteCode[25] = true;
	}
}

