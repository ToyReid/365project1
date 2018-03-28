using System;
using System.Collections;

//Ifmi inherits the IInstruction interface
public class Ifmi : IInstruction {
	//new local BitArray
	protected BitArray bc;

	//Define ByteCode Property found in IInstruction
	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	//IFmi takes the PC relative offset as int parameter.
	public Ifmi(int value){
		//alloc 32 bit BitArray
		bc = new BitArray(32);
		
		//Take the value and turn it into a byte array.
		//use Two's Complement to handle negitive numbers.
		byte[] True = BitConverter.GetBytes(value & 0xffffff);

		//New BitArray that was constructed by using the value byte array.
		BitArray tmp = new BitArray(True);
		
		//Setting the information bits (23 - 0)
		bc.Or(tmp);

		//setting the instruction bits (31-24)
		bc[31] = true;
		bc[28] = true;
		bc[25] = true;
	}
}

