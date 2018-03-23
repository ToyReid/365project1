public class Label : ILabel
{
	protected int address;
	protected string label;

	public int Address {
		get {
			return address;
		}
	}

	public string Label{
		get{
			return label;
		}
	}

	public Label(string lab, int addr) {
		address = addr;
		label = lab;
	}
}