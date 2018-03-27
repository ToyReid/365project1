using System;
using System.Collections;
  
public class Neg : IInstruction {
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Neg() {
		bc = new BitArray(32);
		bc[29] = true;
		bc[28] = true;
	}
}
