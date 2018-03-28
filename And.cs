using System;
using System.Collections;
//And inherits the IInstruction interface
public class And : IInstruction{
	//new local BitArray which will be used when adding to the List of BitArrays
	protected BitArray bc;

	//Defining the property ByteCode in IInstruction
	public BitArray ByteCode {
		get {
			return bc;
		}
	}

//And takes no parameters
	public And(){
		//Alloc mem for a Bit Array with 32 bits / 4 bytes
		bc = new BitArray(32);
		
		//Setting all of the proper bits which encode the instruction.
		bc[29] = true;
		bc[26] = true;
		bc[24] = true;
	}
}
