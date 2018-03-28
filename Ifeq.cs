using System;
using System.Collections;

//Ifeq inherits the IInstruction interface
public class Ifeq : IInstruction{
	//new local BitArray.
	protected BitArray bc;
	
	//Defining the ByteCode property from IInstruction.
	public BitArray ByteCode {
		get {
			return bc;
		}
	}

	//Ifeq will recieve the integer value of the PC relative offset of a label.
	public Ifeq(int value){
		//alloc 32 bit BitArray
		bc = new BitArray(32);

		//using Two's Complement (& 0xfffffff) to handle negitive numbers.
		byte[] True = BitConverter.GetBytes(value & 0xffffff);
		
		//new BitArray using True as a parameter to the constructor. 
		BitArray tmp = new BitArray(True);
		
		//32 bit BitArray and the tmp BitArray or'ed together will result in information bits 23-0 to be set.
		bc.Or(tmp);
		
		//Instruction encoding bit set. (1000 0000);
		bc[31] = true;
	}
}
