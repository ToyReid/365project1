using System;
using System.Collections;


public class Goto : IInstruction{

	public Goto(int value){
		int j;
		if(Int32.TryParse(value,out j)){
			ByteCode = new BitArray(32);
			byte[] True = BitConverter.GetByte(j);
			BitArray tmp = new BitArray(True);
			ByteCode.Or(tmp);
			ByteCode[30] = 1;
			ByteCode[29] = 1;
			ByteCode[28] = 1;

	}
}
