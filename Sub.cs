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
		ByteCode = new BitArray(32);
		ByteCode[29] = true;
		ByteCode[24] = true;
	}
}
