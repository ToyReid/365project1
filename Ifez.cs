using System;
using System.Collections;


public class Ifez : IInstruction{
        public Ifez(int address){
                byte[] true = BitConverter.GetByte(2415919104 + address);
                ByteCode = new BitArray(32);
                BitArray tmp = new BitArray(true);
                ByteCode.Or(tmp);
        }
}
