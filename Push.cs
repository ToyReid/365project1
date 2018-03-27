using System;
using System.Collections;


public class Push : IInstruction {
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}

	//Given a Literal Constructor
	public Push(int value) {
		bc = new BitArray(32);
		byte[] True = BitConverter.GetBytes(value & 0xfffffff);
		BitArray tmp = new BitArray(True);
		bc.Or(tmp);
		bc[31] = true;
		bc[30] = true;
		bc[29] = true;
		bc[28] = true;
	}

}

