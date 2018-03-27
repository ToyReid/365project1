using System;
using System.Collections;

public class Pop : IInstruction {
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Pop() {
		ByteCode = new BitArray(32);
		ByteCode[28] = 1;
	}
}
