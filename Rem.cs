using System;
using System.Collection;

public class Rem : IInstruction {
	protected BitArray bc;

	public BitArray ByteCode {
		get {
			return bc;
		}
	}
	
	public Rem() {
		bc = new BitArray(32);
		bc[29] = true;
		bc[26] = true;
	}
} 
