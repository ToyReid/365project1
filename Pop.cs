using System;
using System.Collections;

public class Pop : IInstruction {
	byte[] tmp = BitConverter.GetByte(16);
	//byte[] true = BitConverter.GetByte(268435456);
	BitArray true = new BitArray(tmp);
	ByteCode = new BitArray(32);
	ByteCode.Or(true);	
}
