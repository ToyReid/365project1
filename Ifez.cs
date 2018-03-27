using System;
using System.Collections;


public class Ifez : IInstruction{
	public Ifez(string value){
		int j;
		if(Int32.TryParse(value,out j)){
			ByteCode = new BitArray(32);
			byte[] True = BitConverter.GetByte(j);
			BitArray tmp = new BitArray(True);
			ByteCode.Or(tmp);
			ByteCode[31] = 1;
			ByteCode[28] = 1;
		}

	}
}
