using System;
using System.Collections;


public class Sub : IInstruction{
	public Sub(){
		ByteCode = new BitArray(32);
		ByteCode[29] = 1;
		ByteCode[24] = 1;
	}
}

