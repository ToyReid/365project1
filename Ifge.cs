using System;
using System.Collections;

//Ifge inherits the IInstruction interface
public class Ifge : IInstruction{
	//local BitArray.
	protected BitArray bc;

	//Define ByteCode property found in IInstruction
	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	//Ifge Constructor Takes the PC relative offset as an int.
	public Ifge(int value){
		//alloc 32 bit BitArray.
		bc = new BitArray(32);

		//Make a byte array that contains the information value in byte form.
		//Two's Complement to ensure negitive numbers are handled.
		byte[] True = BitConverter.GetBytes(value & 0xffffff);
		
		//New Bitarray using the True byteArray as a constructor.
		BitArray tmp = new BitArray(True);

		//Set the information bits (23-0);
		bc.Or(tmp);

		//Manually set the instruction bits (31-24)
		bc[31] = true;
		bc[24] = true;
		bc[26] = true;
	}
}

