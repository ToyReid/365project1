using System;
using System.Collection;

public class Mul : IInstruction{
	public Mul(){
		byte[] true = BitConverter.GetByte(34);
		//byte[] true = BitConverter.GetByte(570425344);
		ByteCode = new BitArray(32);
		BitArray tmp = new BitArray(true);
		ByteCode.Or(tmp);
	}
}
