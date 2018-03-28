using System;
using System.Collections;

//Exit inherits the Iinstruction interface
public class Exit : IInstruction{
	//new local BitArray
	protected BitArray bc;
	
	//Define the ByteCode property given by the Interface.
	public BitArray ByteCode {
		get {
			return bc;
		}
	}

	//This Constructor is for when we are given an exit code.
	public Exit(int value){
		//new 32 bit BitArray alloc.
		bc = new BitArray(32);
		
		//using two's complement we ensure that value will take care of negitive numbers(& 0xfffffff).
		byte[] True = BitConverter.GetBytes(value & 0xfffffff);
		
		//Have a new BitArray equal to the True Byte array which contains the int value.
		BitArray tmp = new BitArray(True);

		//tmp Or with the 32 bit BitArray. Since value will not be more then 8 bits we are ensured
		//that this Or will take up bits 7-0;
		bc.Or(tmp);
	
	}
}

