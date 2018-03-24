using System;
using System.Collections;
  

public class Print : IInstruction{
	public Print(){
		ByteCode = new BitArray(32);
		ByteCode[31] = 1;
		ByteCode[30] = 1;
		ByteCode[28] = 1;
	}
}
