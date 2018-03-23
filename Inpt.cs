using System;
using System.Collections;

public class Inpt : IInstruction{
	public Inpt(){
		byte[] true = BitConverter.GetByte(2);
		//byte[] true = BitConverter.GetByte(33554432);
		BitArray tmp = new BitArray(true);
		ByteCode = new BitArray(32);
		ByteCode.Or(tmp);
	}
}
