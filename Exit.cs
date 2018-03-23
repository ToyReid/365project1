using System;
using System.Collections;


public class Exit : IInstruction{
	public Exit(string inst){
		int j;
	
		if(Int32.TryParse(inst,out j)){
			ByteCode = new BitArray(32);
			byte[] true = BitConverter.GetByte(j);
			BitArray tmp = new BitArray(true);
			ByteCode.Or(tmp);
		}
	}
}

