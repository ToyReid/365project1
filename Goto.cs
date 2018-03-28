using System;
using System.Collections;

//Goto inherits the IInstruction interface.
public class Goto : IInstruction{
	//New BitArray local.
	protected BitArray bc;
	
	//Define the ByteCode Property in IInstruction interface.
	public BitArray ByteCode {
		get {
			return bc;
		}
	}

	//Goto takes an int as a parameter. This int will be the PC relative offset and will be linked to a label.
	public Goto(int value){

		//Alloc a new 32 bit BitArray.
		bc = new BitArray(32);
		
		//Using Two's Complement (& 0xfffffff) to handle negitive values.	
		byte[] True = BitConverter.GetBytes(value & 0xfffffff);
		
		//New BitArray using True as the parameter in the constructor.
		BitArray tmp = new BitArray(True);		
		
		//Or tmp and the 32 bit BitArray together to set information bits 27-0.
		bc.Or(tmp);
		
		//Instruction Bits 31-28 are set.
		bc[30] = true;
		bc[29] = true;
		bc[28] = true;
	}
}
