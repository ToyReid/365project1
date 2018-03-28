using System;
using System.Collections;
  
//Or inherits the IInstruction interface
public class Or : IInstruction {
	protected BitArray bc;


	//Define ByteCode property located in IInstruction
	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Or() {
		//alloc a new 32 bit bitarray
		bc = new BitArray(32);

		//Set Instruction bits (31 - 24);
		bc[29] = true;
		bc[26] = true;
		bc[25] = true;
	}
}
