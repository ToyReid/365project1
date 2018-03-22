public class Label : ILabel
{
    protected uint address;

    public uint Address {
        get {
            return address;
        }
    }

    public Label(uint addr) {
        address = addr;
    }
}