using System;
using System.Collections;

//Dump inherits the IInstruction interface.

public class Dump : IInstruction{
	//new local BitArray 
	protected BitArray bc;
	
	//Define the Property given by the IInstruction interface.
	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	//Dump constructor takes no parameters.
	public Dump(){
		//alloc new Bitarray of 32 bits / 4 bytes
		bc = new BitArray(32);
		
		//set the instruction bits. These will never change.
		bc[31] = true;
		bc[30] = true;
		bc[29] = true;
	}
}
