using System;
using System.Collections;
using System.Collections.Generic;

public class ParseInstruction {
	protected IInstruction curInstr;
	protected List<BitArray> instrList = new List<BitArray>();

	public List<BitArray> InstrList {
		get { return instrList; }
	}

	public ParseInstruction(List<string> lines, LabelDict labels) {
		int literal = 0;
		string instruction;
		foreach(string line in lines) {
			// Split line into two strings delimited by spaces
			// strs[0] = instruction, instr[1] = literal
			string[] strs = line.Split(' ');

			instruction = strs[0];
			if(strs.Length == 1)
				literal = 0;
			else
			{
				try {
					literal = ParseInt(strs[strs.Length - 1]);
				}
				catch(FormatException) {
					try {
						literal = labels[strs[strs.Length - 1]].Address;// - instrList.Count * 4;
					}
					catch(InvalidLabelException) {
					}
				}
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
					curInstr = new Goto(literal);
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
					curInstr = new Push(literal);
					instrList.Add(curInstr.ByteCode);
					break;
				default:
					break;
			}
		}
	}

	public static int ParseInt(string toParse)
	{
		int val;
		int base_ = 10;


		if(toParse.Length >= 2 && toParse.Substring(0,2) =="0x")
		{
			base_ = 16;
			toParse = toParse.Substring(2);
		}

		return Convert.ToInt32(toParse, base_);
	}
}
