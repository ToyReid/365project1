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
		ByteCode[29] = true;
		ByteCode[26] = true;
		ByteCode[25] = true;
	}
}
