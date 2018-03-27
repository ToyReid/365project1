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
		ByteCode = new BitArray(32);
		ByteCode[29] = true;
		ByteCode[28] = true;
		ByteCode[24] = true;
	}
}
