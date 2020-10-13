using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IEnumerable<int> left = new []{ 1, 2, 3, 4, 5, 6 };
            IEnumerable<int> right = new[] { 2, 3 };
            IEnumerable<int> result = left.Except(right);
            Console.Write(String.Join(',', result));
        }
    }

    public static class EnumerableExtensions
    {
        public static IEnumerable<int> Except(this IEnumerable<int> left, IEnumerable<int> right)
        {
            HashSet<int> rightSet = right.ToHashSet();
            foreach(int l in left)
            {
                if (!rightSet.Contains(l))
                {
                    yield return l;
                }
            }
        }
    }
}
