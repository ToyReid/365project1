using System;
using System.Collections;

//Inherits the IInstruction interface.
public class Ifez : IInstruction{
	//new local BitArray
	protected BitArray bc;
	
	//define the ByteCode Property located in IInstruction.
	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	//Ifez takes the PC relative offset as an int.
	public Ifez(int value){
		//Alloc 32 bit BitArray
		bc = new BitArray(32);
		
		//Two's Complement to handle negitive numbers.
		//True will contain the PC relative offset.
		byte[] True = BitConverter.GetBytes(value & 0xffffff);
		
		//new Bitarray which is constructed by using True.
		BitArray tmp = new BitArray(True);
		
		//set Information bits (23-0);
		bc.Or(tmp);
		
		//Manually set the instruction bits(31-24);
		bc[31] = true;
		bc[28] = true;
	}
}
