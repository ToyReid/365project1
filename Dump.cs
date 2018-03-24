using System;
using System.Collections;
  

public class Dump : IInstruction{
	public Dump(){
		ByteCode = new BitArray(32);
		ByteCode[31] = 1;
		ByteCode[30] = 1;
		ByteCode[29] = 1;
	}
}
