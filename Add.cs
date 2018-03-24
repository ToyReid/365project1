using System;
using System.Collections;

public class Add : IInstruction {
	public Add(){
		ByteCode = new BitArray(32);
		ByteCode[29] = 1;
	}
}
