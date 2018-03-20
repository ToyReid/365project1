using System;

static class StringHelper
{
	public static bool IsNullOrWhiteSpace(this string s)
	{
		return String.IsNullOrWhiteSpace(s);
	}

	public static string RemoveAfterSubstring(this string s, string substring)
	{
		if(s != null)
		{
			int index = s.IndexOf(substring);
			if(index != -1) s = s.Substring(0, index);
		}
		return s;
	}
}
