using System;
using System.Collections;

public class Ifez : IInstruction{
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}

	public Ifez(int value){
		bc = new BitArray(32);
		byte[] True = BitConverter.GetBytes(value);
		BitArray tmp = new BitArray(True);
		bc.Or(tmp);
		bc[31] = true;
		bc[28] = true;
	}
}
