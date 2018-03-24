using System;
using System.Collections;
  

public class Or : IInstruction{
	public Or(){
		ByteCode = new BitArray(32);
		ByteCode[29] = 1;
		ByteCode[26] = 1;
		ByteCode[25] = 1;
	}
}
