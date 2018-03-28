using System;
using System.Collections;

//Pop inherits IInstruction interface
public class Pop : IInstruction {
	protected BitArray bc;

	//Define the ByteCode Property found in IInstruction
	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Pop() {
		//alloc 32 bit bitarray
		bc = new BitArray(32);

		//set the instruction bits (31-28)
		bc[28] = true;
	}
}
