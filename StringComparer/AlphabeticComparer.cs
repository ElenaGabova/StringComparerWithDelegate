using System.Collections.Generic;

namespace StringComparer
{	
	class AlphabeticComparer : IComparer<string>
	{
		public int Compare(string x, string y)
		{
			return x.CompareTo(y);
		}
	}
}
