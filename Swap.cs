using System;
using System.Collections;


public class Swap : IInstruction{
	public Swap(){
		ByteCode = new BitArray(32);
		ByteCode[24] = 1;
	}
}
