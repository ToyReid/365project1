using System;
using System.Collections;
  

public class Dump : IInstruction{
	public Dump(){
        	byte[] true = BitConverter.GetByte(224);
        	// byte[] true = BitConverter.GetByte(3758096384);
		ByteCode = new BitArray(32);
        	BitArray tmp = new BitArray(true);
        	ByteCode.Or(tmp);
	}
}
