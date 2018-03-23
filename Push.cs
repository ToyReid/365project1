using System;
using System.Collections;


public class Push : IInstruction{
	public Push(string val){
 		if(Int32.TryParse(inst,out j)){
                        ByteCode = new BitArray(32);
                        //byte[] true = BitConverter.GetByte(j + 4026531840);
                        BitArray tmp = new BitArray(true);
                        ByteCode.Or(tmp);
                }
	}
	
	public Push(int value){
		ByteCode = new BitArray(32);
		byte[] true = BitConverter.GetByte(value + 4026531840);
		BitArray tmp = new BitArray(true);
		ByteCode.Or(tmp);		
	}
}

