using System;
using System.Collection;

public class Rem : IInstruction{
	public Rem(){
		ByteCode = new BitArray(32);
		ByteCode[29] = 1;
		ByteCode[26] = 1;
	}
} 
