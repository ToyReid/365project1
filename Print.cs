using System;
using System.Collections;
  

public class Print : IInstruction{
	public Print(){
        	byte[] true = BitConverter.GetByte(208);
        	//byte[] true = BitConverter.GetByte(3489660928);
		ByteCode = new BitArray(32);
        	BitArray tmp = new BitArray(true);
        	ByteCode.Or(tmp);
	}
}
