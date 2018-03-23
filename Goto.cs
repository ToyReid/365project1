using System;
using System.Collections;


public class Goto : IInstruction{
        public Goto(int address){
                byte[] true = BitConverter.GetByte(1879048192 + address);
                ByteCode = new BitArray(32);
                BitArray tmp = new BitArray(true);
                ByteCode.Or(tmp);
        }
}
