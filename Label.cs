public class Label : ILabel
{
	protected uint address;
	protected string label;

	public uint Address {
		get {
			return address;
		}
	}

	public string Label{
		get{
			return label;
		}
	}

	public Label(string lab, uint addr) {
		address = addr;
		label = lab;
	}
}
