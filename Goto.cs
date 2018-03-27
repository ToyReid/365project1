using System;
using System.Collections;

public class Goto : IInstruction{
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}

	public Goto(int value){
		bc = new BitArray(32);
		byte[] True = BitConverter.GetByte(value);
		BitArray tmp = new BitArray(True);
		bc.Or(tmp);
		bc[30] = true;
		bc[29] = true;
		bc[28] = true;
	}
}
