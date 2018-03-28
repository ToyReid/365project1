using System;
using System.Collections;
//Ifle inherits the IInstruction interface
public class Ifle : IInstruction {
	//New local bitarray
	protected BitArray bc;

	//Define the ByteCode Property in IInstruction
	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	//Ifle takes the PC relative Offset as an int.
	public Ifle(int value){
		//alloc a 32 bit BitArray 
		bc = new BitArray(32);
		
		//Two's complemnt to handle negitive values.
		//Put that value into a Byte Array.
		byte[] True = BitConverter.GetBytes(value & 0xffffff);
		
		//Construct a new BitArray using the ByteArray that contains the value.
		BitArray tmp = new BitArray(True);

		//Set information bits (23 - 0)
		bc.Or(tmp);

		//Set instruction bits (31 - 24)
		bc[31] = true;
		bc[26] = true;
	}
}
