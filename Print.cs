using System;
using System.Collections;
  

public class Print : IInstruction {
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Print() {
		bc = new BitArray(32);
		bc[31] = true;
		bc[30] = true;
		bc[28] = true;
	}
}
