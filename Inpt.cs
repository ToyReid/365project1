using System;
using System.Collections;

public class Inpt : IInstruction{
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Inpt(){
		bc = new BitArray(32);
		bc[25] = true;
	}
}
