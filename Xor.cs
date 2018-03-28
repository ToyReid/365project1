using System;
using System.Collections;
  
//Xor inherits IInstruction interface
public class Xor : IInstruction {
	protected BitArray bc;

	//Define ByteCode property in IInstruction
	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Xor() {
			
		//alloc a new 32 bit bitarray
		bc = new BitArray(32);

		//Set the instruction bits (31-24)
		bc[29] = true;
		bc[26] = true;
		bc[25] = true;
		bc[24] = true;
	}
}
