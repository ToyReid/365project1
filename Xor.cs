using System;
using System.Collections;
  

public class Xor : IInstruction{

        byte[] true = BitConverter.GetByte(39);
        //byte[] true = BitConverter.GetByte(654311424);
	ByteCode = new BitArray(32);
        BitArray tmp = new BitArray(true);
        ByteCode.Or(tmp);
}
