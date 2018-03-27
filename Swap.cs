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
		bc = new BitArray(32);
		bc[24] = true;
	}
}
