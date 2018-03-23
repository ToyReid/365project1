using System;
using System.Collection;

public class And : IInstruction{
	public And(){
		byte[] true = BitConvertor.GetByte(37);
		//byte[] true = BitConverter.GetByte(620756992);
		ByteCode = new BitArray(32);
		BitArray tmp = new BitArray(true);
		ByteCode.Or(tmp);
	}
}
