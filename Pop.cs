using System;
using System.Collections;

public class Pop : IInstruction {
	public Pop(){
		ByteCode = new BitArray(32);
		ByteCode[28] = 1;
	}
}
