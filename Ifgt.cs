using System;
using System.Collections;

public class Ifgt : IInstruction{
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}

	public Ifgt(int value){
		bc = new BitArray(32);
		byte[] True = BitConverter.GetByte(value);
		BitArray tmp = new BitArray(True);
		bc.Or(tmp);
		bc[31] = true;
		bc[24] = true;
		bc[25] = true;
	}
}
