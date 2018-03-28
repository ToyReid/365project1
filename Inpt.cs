using System;
using System.Collections;

//Inpt inherits the IInstruction interface.
public class Inpt : IInstruction{
	
	//new local Bit array
	protected BitArray bc;
	
	//Define the ByteCode property in IInstruction
	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Inpt(){
		//alloc 32 bit bitarray
		bc = new BitArray(32);
		
		//Instruction bits set (31 - 24)
		bc[25] = true;
	}
}
