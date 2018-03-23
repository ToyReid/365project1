using System;
using System.Collections;


public class Ifmi : IInstruction{
        public Ifmi(int address){
                byte[] true = BitConverter.GetByte(2449473536 + address);
                ByteCode = new BitArray(32);
                BitArray tmp = new BitArray(true);
                ByteCode.Or(tmp);
        }
}

