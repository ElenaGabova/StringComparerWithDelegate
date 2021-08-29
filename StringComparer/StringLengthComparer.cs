using System.Collections.Generic;

namespace StringComparer
{
	class StringLengthComparer : IComparer<string>
	{
		public bool Descending { get; set; }
		public int Compare(string x, string y)
		{
			return x.Length.CompareTo(y.Length) *
				(Descending ? -1 : 1);
		}
	}
}
