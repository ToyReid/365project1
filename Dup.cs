using System;
using System.Collections;

//Dup inherits the IInstruction interface
public class Dup : IInstruction{
	//New local BitArray
	protected BitArray bc;

	//Definition of the ByteCode Property found in IInstruction
	public BitArray ByteCode{
		get {
			return bc;
		}
	}

	//Dup takes a int as a parameter.
	public Dup(int off){
		//alloc 32 bit BitArray
		bc = new BitArray(32);
		
		//Dup is the offset * 4 to ensure two zeros at the end of the bit array (position 0 and 1).
		//& 0xfffffff is for negitive numbers using two's complement. 
		byte[] True = BitConverter.GetBytes((off * 4) & 0xfffffff);
		BitArray tmp = new BitArray(True);
		bc.Or(tmp);
		bc[30] = true;
		bc[31] = true;
	}
}
