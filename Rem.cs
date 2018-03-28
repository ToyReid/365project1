using System;
using System.Collections;

//Rem inherits IInstruction interface
public class Rem : IInstruction {
	protected BitArray bc;

	//Define ByteCode Property located in IInstruction
	public BitArray ByteCode {
		get {
			return bc;
		}
	}

	public Rem() {
		//alloc new 32 bit bitarray
		bc = new BitArray(32);

		//Set the instruction bits (31 - 24)
		bc[29] = true;
		bc[26] = true;
	}
}
