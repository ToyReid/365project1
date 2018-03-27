using System;
using System.Collections;

public class Mul : IInstruction {
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}

	public Mul() {
		bc = new BitArray(32);
		bc[29] = true;
		bc[25] = true;
	}
}
