using System;
using System.Collection;

public class Mul : IInstruction{
	public Mul(){
		ByteCode = new BitArray(32);
		ByteCode[29] = 1;
		ByteCode[25] = 1;
	}
}
