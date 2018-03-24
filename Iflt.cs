using System;
using System.Collections;


public class Iflt : IInstruction{
	public Iflt(string value){
		int j;  
		if(Int32.TryParse(value,out j)){
			ByteCode = new BitArray(32);
			byte[] true = BitConverter.GetByte(j);
			BitArray tmp = new BitArray(true);
			ByteCode.Or(tmp);
			ByteCode[31] = 1;
			ByteCode[25] = 1;
		}

	}        
}
