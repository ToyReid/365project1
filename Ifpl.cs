using System;
using System.Collections;


public class Ifpl : IInstruction{
        public Ifpl(int address){
                byte[] true = BitConverter.GetByte(2466250752 + address);
                ByteCode = new BitArray(32);
                BitArray tmp = new BitArray(true);
                ByteCode.Or(tmp);
        }
}
