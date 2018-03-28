using System;
using System.Collections;
  
//Not inherits the IInstruction interface
public class Not : IInstruction {
	protected BitArray bc;

	//ByteCode property defined from IInstruction
	public BitArray ByteCode {
		get {
			return bc;
		}
	}


	
	public Not() {
		
		//alloc new 32bit bitarray
		bc = new BitArray(32);

		//Set the instruction bits (31-24)
		bc[29] = true;
		bc[28] = true;
		bc[24] = true;
	}
}
