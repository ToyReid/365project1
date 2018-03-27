using System;
using System.Collections;

public class Add : IInstruction {

	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}

	public Add(){
		bc = new BitArray(32);
		bc[29] = true;
	}

}
