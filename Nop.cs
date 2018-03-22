using System;
using System.Collections;

public class Nop : IInstruction{
	byte[] tmp = BitConverter.GetBytes(3);
	ByteCode = new BitArray(tmp);
}

