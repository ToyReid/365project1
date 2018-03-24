using System;
using System.Collections;

public class Nop : IInstruction{
	public Nop(){
		ByteCode = new BitArray(32);
		ByteCode[24] = 1;
		ByteCode[25] = 1;
	}
}

