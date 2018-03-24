using System;
using System.Collections;


public class Ifnz : IInstruction{
        public Ifnz(int address){
                byte[] true = BitConverter.GetByte(address);
                ByteCode = new BitArray(32);
                BitArray tmp = new BitArray(true);
                ByteCode.Or(tmp);
		ByteCode[31] = 1;
		ByteCode[28] = 1;
		ByteCode[24] = 1;
        }
}
