using System;
using System.Collections;

//Ifne inherits the IInstruction interface
public class Ifne : IInstruction {
	//new local BitArray
	protected BitArray bc;
	
	//Defining the ByteCode property from IInstruction.	
	public BitArray ByteCode {
		get {
			return bc;
		}
	}

	//Ifne constructor takes a PC relative offset of a label in the form of an int.
	public Ifne(int value){
		//alloc 32 bit BitArray
		bc = new BitArray(32);
		
		//two's complement(& 0xfffffff) handles negitive numbers.
		byte[] True = BitConverter.GetBytes(value & 0xffffff);
		
		//New Bit Array using the True Byte Array.
		BitArray tmp = new BitArray(True);
		
		//Or to set the information bits (23-0);
		bc.Or(tmp);

		//Set the Instruction bits (31-24) manually.
		bc[31] = true;
		bc[24] = true;
	}
}
