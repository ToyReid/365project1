using System;
using System.Collections;
  

public class Neg : IInstruction{

        byte[] true = BitConverter.GetByte(48);
        //byte[] true = BitConverter.GetByte(805306368);
	ByteCode = new BitArray(32);
        BitArray tmp = new BitArray(true);
        ByteCode.Or(tmp);
}
