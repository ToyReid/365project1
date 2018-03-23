using System;
using System.Collection;

public class Div : IInstruction{
	public Div(){
		byte[] true = BitConverter.GetByte(35);
		//byte[] true = BitConverter.GetByte(587202560);
		ByteCode = new BitArray(32);
		BitArray tmp = new BitArray(true);
		ByteCode.Or(tmp);
	}
}
