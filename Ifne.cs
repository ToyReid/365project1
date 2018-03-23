using System;
using System.Collections;


public class Ifne : IInstruction{
        public Ifne(int address){
                byte[] true = BitConverter.GetByte(2164260864 + address);
                ByteCode = new BitArray(32);
                BitArray tmp = new BitArray(true);
                ByteCode.Or(tmp);
        }
}
