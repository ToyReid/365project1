public class Instruction : IInstruction {
    protected BitArray bCode;

	public BitArray ByteCode {
		get {
			return bCode;
		}
	}

	public Instruction(string line) {
		
	}
}