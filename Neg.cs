using System;
using System.Collections;
//Neg inherits IInstruction interface  
public class Neg : IInstruction {
	protected BitArray bc;

	//Define the ByteCode Property in IInstruction
	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	
	public Neg() {
		//alloc a new 32 bit bitarray
		bc = new BitArray(32);

		//instruction bits set (31 - 24)
		bc[29] = true;
		bc[28] = true;
	}
}
