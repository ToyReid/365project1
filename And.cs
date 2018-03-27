using System;
using System.Collections;

public class And : IInstruction{
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}

	public And(){
		bc = new BitArray(32);
		bc[29] = true;
		bc[26] = true;
		bc[24] = true;
	}
}
