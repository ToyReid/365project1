using System;
using System.Collections;
//Div inherits the IInstruction interface
public class Div : IInstruction{
	//New local BitArray
	protected BitArray bc;

	//Defining the ByteCode Property in IInstruction.
	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	//Div constructor takes no parameters.
	public Div(){
		//new BitArray with 32 bits / 4bytes alloc 
		bc = new BitArray(32);
		
		//Setting the instruction bits. 
		bc[29] = true;
		bc[25] = true;
		bc[24] = true;
	}
}
