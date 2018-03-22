using System;

static class StringHelper
{
	public static string RemoveAfterSubstring(this string s, string substring)
	{
		int index = s.IndexOf(substring);
		if(index != -1) s = s.Substring(0, index);
		return s;
	}
}
