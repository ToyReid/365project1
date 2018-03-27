using System;
using System.Collections;

public class Ifnz : IInstruction {
        protected BitArray bc;

        public BitArray ByteCode {
                get {
                        return bc;
                }
        }

        public Ifnz(int value) {
                bc = new BitArray(32);
                byte[] True = BitConverter.GetBytes(value & 0xffffff);
                BitArray tmp = new BitArray(True);
                bc.Or(tmp);
                bc[31] = true;
                bc[28] = true;
                bc[24] = true;
        }
}
