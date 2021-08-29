using System;
using System.Collections.Generic;

namespace StringComparer
{
    public class Program
    {
		public static void Sort<T>(T[] array, Func<T, T, int> comparer)
		{
			for (int i = array.Length - 1; i > 0; i--)
			{
				for (int j = 1; j <= i; j++)
				{
					var element1 = array[j - 1];
					var element2 = array[j];
					if (comparer(element1, element2) > 0)
					{
						var temporary = array[j];
						array[j] = array[j - 1];
					}
				}
			}
		}

		static void Main()
		{
			var strings = new[] { "A", "B", "AA" };

			var lComaparer = new StringLengthComparer() { Descending = true };
			//	var aComaparer = new AlphabeticComparer();


			//передача в метод лямбда выражения
			Sort(strings, lComaparer.Compare);

            //передача в метод лямбда выражения

            Sort(strings,
                (x, y) => x.Length.CompareTo(y));

		}
	}
}
