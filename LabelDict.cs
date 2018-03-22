using System.Collections.Generic;

class LabelDict
{
	public Dictionary<string, Ilabel> labels;

	public LabelDict() {
		labels = new Dictionary<string, Ilabel>;
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
			return labels[label] = value;
		}
	}

}
