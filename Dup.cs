using System;
using System.Collections;

public class Dup : IInstruction{
	protected BitArray bc;

	public BitArray ByteCode{
		get {
			return bc;
		}
	}

	public Dup(int off){
		bc = new BitArray(32);
		byte[] True = BitConverter.GetByte(off * 4);
		BitArray tmp = new BitArray(True);
		bc.Or(tmp);
		bc[30] = true;
		bc[31] = true;
	}
}
