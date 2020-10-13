using Algoritms;
using System;
using System.Collections.Generic;

namespace Resucsion
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 6,2,4,1,3,7 };
            Console.WriteLine($"{String.Join(',', Sorting.QSort(list))}");
        }
    }
}
