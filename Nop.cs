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
		bc = new BitArray(32);
		bc[24] = true;
		bc[25] = true;
	}
}

