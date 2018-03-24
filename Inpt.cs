using System;
using System.Collections;

public class Inpt : IInstruction{
	public Inpt(){
		ByteCode = new BitArray(32);
		ByteCode[25] = 1;
	}
}
