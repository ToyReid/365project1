using System;
using System.Collections;


public class Iflt : IInstruction{
        public Iflt(int address){
                byte[] true = BitConverter.GetByte(2181038080 + address);
                ByteCode = new BitArray(32);
                BitArray tmp = new BitArray(true);
                ByteCode.Or(tmp);
        }
}
