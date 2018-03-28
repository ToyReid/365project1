using System;
using System.Collections;

//Ifgt inherits the IInstruction interface
public class Ifgt : IInstruction{
	//new local BitArray
	protected BitArray bc;
	
	//Define the ByteCode Property found in IInstruction
	public BitArray ByteCode {
		get {
			return bc;
		}
	}
		
	//Ifgt constructor takes the PC Relative Offset as a int.
	public Ifgt(int value){
		//alloc a new BitArray that is 32 bits.
		bc = new BitArray(32);

		//Byte Array which contains the PC relative offset in byte form.
		//Two's complement to handle negitive numbers.
		byte[] True = BitConverter.GetBytes(value & 0xffffff);
		
		//New Bit Array which contains True.
		BitArray tmp = new BitArray(True);
		
		//Set information bits (23-0)
		bc.Or(tmp);

		//Manually set instruction bits (31-24)
		bc[31] = true;
		bc[24] = true;
		bc[25] = true;
	}
}
