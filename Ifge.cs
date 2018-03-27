using System;
using System.Collections;


public class Ifge : IInstruction{
	public Ifge(string value){
		int j;
		if(Int32.TryParse(value,out j)){
			ByteCode = new BitArray(32);
			byte[] True = BitConverter.GetByte(j);
			BitArray tmp = new BitArray(True);
			ByteCode.Or(tmp);
			ByteCode[31] = 1;
			ByteCode[24] = 1;
			ByteCode[26] = 1;
		}

	}
}

