using System;
using System.Collections;

//Nop inherits the IInstruction interface
public class Nop : IInstruction {
	//new local Bitarray
	protected BitArray bc;
	
	//ByteCode Property defined.
	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Nop() {
		//alloc new 32 bit bitarray.
		bc = new BitArray(32);
		
		//set instruction bits manually (31-24)
		bc[24] = true;
		bc[25] = true;
	}
}

