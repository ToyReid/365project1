using System;
using System.Collections;
  
//Print inherits the IInstruction interface
public class Print : IInstruction {
	protected BitArray bc;

	//ByteCode Property defined.
	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Print() {
		//alloc 32 bit bitarray
		bc = new BitArray(32);

		//Set the instruction bits (31-28)
		bc[31] = true;
		bc[30] = true;
		bc[28] = true;
	}
}
