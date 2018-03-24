using System;
using System.Collections;


public class Exit : IInstruction{
	
	//This Constructor is for when we are given an exit code.
	public Exit(string value){
	int j;
		
		//Should Parse the value into an int if possible. then the int gets put into j

		if(Int32.TryParse(value,out j)){
			ByteCode = new BitArray(32);
			byte[] true = BitConverter.GetByte(j);
			BitArray tmp = new BitArray(true);
			ByteCode.Or(tmp);
		}


	}
	
	//No Exit code given constructor.
	public Exit(){
		ByteCode = new BitArray(32);
	}
}

