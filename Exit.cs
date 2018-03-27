using System;
using System.Collections;

public class Exit : IInstruction{
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}

	//This Constructor is for when we are given an exit code.
	public Exit(int value){

		//Should Parse the value into an int if possible. then the int gets put into j
		ByteCode = new BitArray(32);
		byte[] True = BitConverter.GetByte(value);
		BitArray tmp = new BitArray(True);
		ByteCode.Or(tmp);
	}

	//No Exit code given constructor.
	public Exit(){
		ByteCode = new BitArray(32);
	}
}

