using System;
using System.Collections;


public class Dup : IInstruction{
        public Dup(){
                ByteCode = new BitArray(32);
                ByteCode[24] = 1;
        }
}
