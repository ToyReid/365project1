using System;
using System.Collections;

//Iflt inherits the IInstruction interface
public class Iflt : IInstruction {
	
	//new local BitArray
	protected BitArray bc;

	//Define the ByteCode Property in IInstruction
	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	//Iflt takes the PC relative offset as int
	public Iflt(int value){
		
		//alloc a 32 bit BitArray
		bc = new BitArray(32);

		//Byte array that contains the Value.
		//Two's Complement to handle negitive values.
		byte[] True = BitConverter.GetBytes(value & 0xffffff);

		//calling BitArray constructor with Value Byte Array.
		BitArray tmp = new BitArray(True);
		
		//Setting Information bits(23-0)
		bc.Or(tmp);

		//Setting instruction bits(31-24)
		bc[31] = true;
		bc[25] = true;
	}
}
