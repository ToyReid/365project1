using System;
using System.Collections;
  

public class Not : IInstruction {
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Not() {
		bc = new BitArray(32);
		bc[29] = true;
		bc[28] = true;
		bc[24] = true;
	}
}
