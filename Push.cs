using System;
using System.Collections;

//Push inherits the IInstruction interface
public class Push : IInstruction {
	protected BitArray bc;

	//Define the ByteCode Property in IInstruction
	public BitArray ByteCode {
		get {
			return bc;
		}
	}

	//Push's constructor is given a value as an int.  
	public Push(int value) {
		bc = new BitArray(32);
		
		//make a byte array that contains the value.
		//Two's complement to handle the negitive values.

		byte[] True = BitConverter.GetBytes(value & 0xfffffff);
		
		//Tmp is a bitarray that has the same value in True.
		BitArray tmp = new BitArray(True);
		
		//Set all of the information bits (27-0)
		bc.Or(tmp);

		//Set all of the instrucion bits (31-28)
		bc[31] = true;
		bc[30] = true;
		bc[29] = true;
		bc[28] = true;
	}
}

