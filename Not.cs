using System;
using System.Collections;
  

public class Not : IInstruction{

        byte[] true = BitConverter.GetByte(49);
        //byte[] true = BitConverter.GetByte(822083584);
	ByteCode = new BitArray(32);
        BitArray tmp = new BitArray(true);
        ByteCode.Or(tmp);
}
