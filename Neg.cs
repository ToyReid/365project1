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
		ByteCode = new BitArray(32);
		ByteCode[29] = true;
		ByteCode[28] = true;
	}
}
