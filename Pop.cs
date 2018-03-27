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
		bc = new BitArray(32);
		bc[28] = true;
	}
}
