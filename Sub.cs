using System;
using System.Collections;

//Sub inherits the IInstruction interface
public class Sub : IInstruction {
	protected BitArray bc;

	//Define the ByteCode Property located in IInstruction
	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	
	public Sub() {
		//Alloc new 32bit Bitarray
		bc = new BitArray(32);

		//Set the instruction bits (31 - 24)
		bc[29] = true;
		bc[24] = true;
	}
}
