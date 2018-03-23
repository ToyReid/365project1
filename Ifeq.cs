using System;
using System.Collections;


public class Ifeq : IInstruction{
        public Ifeq(int address){
                byte[] true = BitConverter.GetByte(2147483648 + address);
                ByteCode = new BitArray(32);
                BitArray tmp = new BitArray(true);
                ByteCode.Or(tmp);
        }
}
