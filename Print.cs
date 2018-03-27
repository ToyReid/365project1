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
		ByteCode = new BitArray(32);
		ByteCode[31] = 1;
		ByteCode[30] = 1;
		ByteCode[28] = 1;
	}
}
