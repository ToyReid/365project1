using System;
using System.Collections;

public class Div : IInstruction{
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Div(){
		bc = new BitArray(32);
		bc[29] = true;
		bc[25] = true;
		bc[24] = true;
	}
}
