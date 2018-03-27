using System;
class InvalidLabelException : Exception
{
	public InvalidLabelException(string msg) : base(msg) { }
}
