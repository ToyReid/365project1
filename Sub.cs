using System;
using System.Collections;

public class Sub : IInstruction {
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Sub() {
		bc = new BitArray(32);
		bc[29] = true;
		bc[24] = true;
	}
}
