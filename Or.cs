using System;
using System.Collections;
  

public class Or : IInstruction{

        byte[] true = BitConverter.GetByte(38);
        //byte[] true = BitConverter.GetByte(637534208);
	ByteCode = new BitArray(32);
        BitArray tmp = new BitArray(true);
        ByteCode.Or(tmp);
}
