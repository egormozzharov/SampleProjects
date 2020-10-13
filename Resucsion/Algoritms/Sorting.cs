using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritms
{
    public class Sorting
    {
        public static IEnumerable<int> QSort(IEnumerable<int> arr)
        {
            if (arr.Count() < 2)
            {
                return arr;
            }
            int baseElement = arr.First();
            IEnumerable<int> smaller = arr.Where(el => el < baseElement).ToArray();
            IEnumerable<int> greater = arr.Where(el => el > baseElement).ToArray();
            IEnumerable<int> sortedSmaller = QSort(smaller);
            IEnumerable<int> sortedGreater = QSort(greater);

            return sortedSmaller.Concat(new[] { baseElement }).Concat(sortedGreater).ToArray();
        }
    }
}
