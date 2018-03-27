using System;

public class ParseInstruction {
	protected int labelLoc;
	protected int literal;
	protected string instruction;
	bool haveLabel;

	public ParseInstruction(string line, LabelDict labels) {
		// Split line into two strings delimited by spaces
		// strs[0] = instruction, instr[1] = literal
		string[] strs = line.Split(null);

		instruction = strs[0];
		if(strs[1] = string.Empty)
			literal = 0;
		else
			literal = Convert.ToInt32(strs[1]);

		haveLabel = true;
		try {
			labelLoc = labels[strs[1]];
		}
		catch(InvalidLabelException ex) {
			Console.Error($"{ex} Label not found in dictionary.");
			haveLabel = false;
		}

		switch (instruction) {
			case "exit":
				Exit(literal);
				break;
			case "swap":
				Swap();
				break;
			case "inpt":
				Inpt();
				break;
			case "nop":
				Nop();
				break;
			case "pop":
				Pop();
				break;
			case "add":
				Add();
				break;
			case "sub":
				Sub();
				break;
			case "mul":
				Mul();
				break;
			case "div":
				Div();
				break;
			case "rem":
				Rem();
				break;
			case "and":
				And();
				break;
			case "or":
				Or();
				break;
			case "xor":
				Xor();
				break;
			case "neg":
				Neg();
				break;
			case "not":
				Not();
				break;
			case "goto":
				Goto(labelLoc);
				break;
			case "ifeq":
				Ifeq(literal);
				break;
			case "ifne":
				Ifne(literal);
				break;
			case "iflt":
				Iflt(literal);
				break;
			case "ifgt":
				Ifgt(literal);
				break;
			case "ifle":
				Ifle(literal);
				break;
			case "ifge":
				Ifge(literal);
				break;
			case "ifez":
				Ifez(literal);
				break;
			case "ifnz":
				Ifnz(literal);
				break;
			case "ifmi":
				Ifmi(literal);
				break;
			case "ifpl":
				Ifpl(literal);
				break;
			case "dup":
				Dup();
				break;
			case "print":
				Print();
				break;
			case "dump":
				Dump();
				break;
			case "push":
				if(haveLabel)
					Push(labelLoc);
				else
					Push(literal);
				break;
			default:
				break;
		}
	}
}
