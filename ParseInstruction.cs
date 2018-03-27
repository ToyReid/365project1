using System;
using System.Collections;
using System.Collections.Generic;

public class ParseInstruction {
	protected int labelLoc;
	protected int literal;
	protected string instruction;
	protected IInstruction curInstr;
	protected List<BitArray> instrList = new List<BitArray>();
	bool haveLabel;

	public List<BitArray> InstrList {
		get { return instrList; }
	}

	public ParseInstruction(string line, LabelDict labels) {
		// Split line into two strings delimited by spaces
		// strs[0] = instruction, instr[1] = literal
		string[] strs = line.Split(null);

		instruction = strs[0];
		if(strs[1] == string.Empty)
			literal = 0;
		else
			literal = Convert.ToInt32(strs[1]);

		haveLabel = true;
		try {
			labelLoc = labels[strs[1]].Address;
		}
		catch(InvalidLabelException ex) {
			Console.Error.WriteLine($"{ex} Label not found in dictionary.");
			haveLabel = false;
		}

		switch (instruction) {
			case "exit":
				curInstr = new Exit(literal);
				instrList.Add(curInstr.ByteCode);
				break;
			case "swap":
				curInstr = new Swap();
				instrList.Add(curInstr.ByteCode);
				break;
			case "inpt":
				curInstr = new Inpt();
				instrList.Add(curInstr.ByteCode);
				break;
			case "nop":
				curInstr = new Nop();
				instrList.Add(curInstr.ByteCode);
				break;
			case "pop":
				curInstr = new Pop();
				instrList.Add(curInstr.ByteCode);
				break;
			case "add":
				curInstr = new Add();
				instrList.Add(curInstr.ByteCode);
				break;
			case "sub":
				curInstr = new Sub();
				instrList.Add(curInstr.ByteCode);
				break;
			case "mul":
				curInstr = new Mul();
				instrList.Add(curInstr.ByteCode);
				break;
			case "div":
				curInstr = new Div();
				instrList.Add(curInstr.ByteCode);
				break;
			case "rem":
				curInstr = new Rem();
				instrList.Add(curInstr.ByteCode);
				break;
			case "and":
				curInstr = new And();
				instrList.Add(curInstr.ByteCode);
				break;
			case "or":
				curInstr = new Or();
				instrList.Add(curInstr.ByteCode);
				break;
			case "xor":
				curInstr = new Xor();
				instrList.Add(curInstr.ByteCode);
				break;
			case "neg":
				curInstr = new Neg();
				instrList.Add(curInstr.ByteCode);
				break;
			case "not":
				curInstr = new Not();
				instrList.Add(curInstr.ByteCode);
				break;
			case "goto":
				curInstr = new Goto(labelLoc);
				instrList.Add(curInstr.ByteCode);
				break;
			case "ifeq":
				curInstr = new Ifeq(literal);
				instrList.Add(curInstr.ByteCode);
				break;
			case "ifne":
				curInstr = new Ifne(literal);
				instrList.Add(curInstr.ByteCode);
				break;
			case "iflt":
				curInstr = new Iflt(literal);
				instrList.Add(curInstr.ByteCode);
				break;
			case "ifgt":
				curInstr = new Ifgt(literal);
				instrList.Add(curInstr.ByteCode);
				break;
			case "ifle":
				curInstr = new Ifle(literal);
				instrList.Add(curInstr.ByteCode);
				break;
			case "ifge":
				curInstr = new Ifge(literal);
				instrList.Add(curInstr.ByteCode);
				break;
			case "ifez":
				curInstr = new Ifez(literal);
				instrList.Add(curInstr.ByteCode);
				break;
			case "ifnz":
				curInstr = new Ifnz(literal);
				instrList.Add(curInstr.ByteCode);
				break;
			case "ifmi":
				curInstr = new Ifmi(literal);
				instrList.Add(curInstr.ByteCode);
				break;
			case "ifpl":
				curInstr = new Ifpl(literal);
				instrList.Add(curInstr.ByteCode);
				break;
			case "dup":
				curInstr = new Dup(literal);
				instrList.Add(curInstr.ByteCode);
				break;
			case "print":
				curInstr = new Print();
				instrList.Add(curInstr.ByteCode);
				break;
			case "dump":
				curInstr = new Dump();
				instrList.Add(curInstr.ByteCode);
				break;
			case "push":
				if(haveLabel)
					curInstr = new Push(labelLoc);
				else
					curInstr = new Push(literal);
				instrList.Add(curInstr.ByteCode);
				break;
			default:
				break;
		}
	}
}
