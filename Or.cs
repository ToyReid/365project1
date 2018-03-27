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
		ByteCode = new BitArray(32);
		ByteCode[29] = 1;
		ByteCode[26] = 1;
		ByteCode[25] = 1;
	}
}
