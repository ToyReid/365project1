using System;
using System.Collection;

public class Rem : IInstruction{
	public Rem(){
		byte[] true = BitConverter.GetByte(36);
		//byte[] true = BitConverter.GetByte(603979776);
		ByteCode = new BitArray(32);
		BitArray tmp = new BitArray(true);
		ByteCode.Or(tmp);
	}
} 
