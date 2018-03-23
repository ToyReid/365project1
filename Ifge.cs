using System;
using System.Collections;


public class Ifge : IInstruction{
        public Ifge(int address){
                byte[] true = BitConverter.GetByte(2231369728 + address);
                ByteCode = new BitArray(32);
                BitArray tmp = new BitArray(true);
                ByteCode.Or(tmp);
        }
}
