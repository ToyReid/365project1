using System;
using System.Collections;


public class Ifle : IInstruction{
        public Ifle(int address){
                byte[] true = BitConverter.GetByte(2214592512 + address);
                ByteCode = new BitArray(32);
                BitArray tmp = new BitArray(true);
                ByteCode.Or(tmp);
        }
}
