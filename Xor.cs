using System;
using System.Collections;
  

public class Xor : IInstruction{
	public Xor(){
		ByteCode = new BitArray(32);
		ByteCode[29] = 1;
		ByteCode[26] = 1;
		ByteCode[25] = 1;
		ByteCode[24] = 1;
	}
}
