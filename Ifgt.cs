using System;
using System.Collections;


public class Ifgt : IInstruction{
        public Ifgt(int address){
                byte[] true = BitConverter.GetByte(2197815296 + address);
                ByteCode = new BitArray(32);
                BitArray tmp = new BitArray(true);
                ByteCode.Or(tmp);
        }
}
