using System.Collections.Generic;

public class LabelDict
{
	public Dictionary<string, ILabel> labels;

	public LabelDict() {
		labels = new Dictionary<string, ILabel>();
	}

	public ILabel this[string label] {
		get {
			try {
				return labels[label];
			} catch (KeyNotFoundException) {
				throw new InvalidLabelException($"{label} is was not found");
			}
		}
		set {
			labels[label] = value;
		}
	}

}
