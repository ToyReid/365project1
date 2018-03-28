using System;
using System.Collections;
//Ifnz inherits the IInstruction interface.
public class Ifnz : IInstruction {
        
	//new local bitarray
	protected BitArray bc;

	//Define the ByteCode Property located in IInstruction
        public BitArray ByteCode {
                get {
                        return bc;
                }
        }

	//Ifnz constructor takes the PC relative Offset as a int.
        public Ifnz(int value) {
		//alloc a 32 bit BitArray
                bc = new BitArray(32);

		//True will contain the value given by the parameter.
		//The Two's Complement will handle negitive numbers (& 0xfffffff);
                byte[] True = BitConverter.GetBytes(value & 0xffffff);
                
		//New BitArray that will contain the byteArray that has the Value.
		BitArray tmp = new BitArray(True);

		//Set information bits (23 - 0)
                bc.Or(tmp);

		//Manually set instruction bits (31 - 24)
                bc[31] = true;
                bc[28] = true;
                bc[24] = true;
        }
}
