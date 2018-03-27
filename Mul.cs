using System;
using System.Collection;

public class Mul : IInstruction {
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Mul() {
		ByteCode = new BitArray(32);
		ByteCode[29] = true;
		ByteCode[25] = true;
	}
}
