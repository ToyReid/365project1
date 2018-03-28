using System;
using System.Collections;

//Add inherits the IInstruction interface;
public class Add : IInstruction {

	//new local instantance of a BitArray.
	protected BitArray bc;

	//Definition of ByteCode property located in the IInstruction interface.
	public BitArray ByteCode {
		get {
			//if ByteCode is accessed it will return the bc of this class.
			return bc;
		}
	}

	//Add does not take any parameters.
	public Add(){
		//bc is a new bitarray. that contains 32 bits / 4 bytes
		bc = new BitArray(32);
		
		//setting the 29th bit to be true. 
		bc[29] = true;
	}

}
