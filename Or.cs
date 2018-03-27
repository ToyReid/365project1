using System;
using System.Collections;
  

public class Or : IInstruction {
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Or() {
		bc = new BitArray(32);
		bc[29] = true;
		bc[26] = true;
		bc[25] = true;
	}
}
