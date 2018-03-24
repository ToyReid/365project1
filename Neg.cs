using System;
using System.Collections;
  

public class Neg : IInstruction{
	public Neg(){
		ByteCode = new BitArray(32);
		ByteCode[29] = 1;
		ByteCode[28] = 1;
	}
}
