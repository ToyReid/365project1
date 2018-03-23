using System;
using System.Collections;


public class Ifnz : IInstruction{
        public Ifnz(int address){
                byte[] true = BitConverter.GetByte(2432696320 + address);
                ByteCode = new BitArray(32);
                BitArray tmp = new BitArray(true);
                ByteCode.Or(tmp);
        }
}
