using System;
using System.Collection;

public class Div : IInstruction{
	public Div(){
		ByteCode = new BitArray(32);
		ByteCode[29] = 1;
		ByteCode[25] = 1;
		ByteCode[24] = 1;
	}
}
