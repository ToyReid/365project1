using System;
using System.Collections;

//Ifpl inherits IInstruction interface
public class Ifpl : IInstruction{
	//new local BitArray
	protected BitArray bc;
	
	//ByteCode property from IInstruction defined
	public BitArray ByteCode {
		get {
			return bc;
		}
	}

	//Ifpl constructor takes the PC relative offset as an int parameter.
	public Ifpl(int value){
		//alloc 32 bit Bitarray
		bc = new BitArray(32);
		
		//new Byte Array that has value in it.
		//Two's Complement will handle Negitive numbers.
		byte[] True = BitConverter.GetBytes(value & 0xffffff);

		//Make a new bitarray using the value byte array in the constructor.
		BitArray tmp = new BitArray(True);
		
		//Information Bits (23 - 0) set
		bc.Or(tmp);
	
		//Instruction Bits (31-24) set
		bc[31] = true;
		bc[24] = true;
		bc[28] = true;
		bc[25] = true;
	}
}
