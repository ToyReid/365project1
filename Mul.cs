using System;
using System.Collections;

//Mul inherits the IInstruction interface
public class Mul : IInstruction {
	
	//new local BitArray 
	protected BitArray bc;

	//define the ByteCode Property in IInstruction
	public BitArray ByteCode {
		get {
			return bc;
		}
	}


	public Mul() {
		
		//New 32 bit bitarray
		bc = new BitArray(32);

		//Set Instruction bits (31-24)
		bc[29] = true;
		bc[25] = true;
	}
}
