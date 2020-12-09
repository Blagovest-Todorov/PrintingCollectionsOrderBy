using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.SortingCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(7);
            numbers.Add(10);
            numbers.Add(-5);


            List<string> stringNumbers = new List<string>();
            stringNumbers.Add("5");
            stringNumbers.Add("7");
            stringNumbers.Add("10");
            stringNumbers.Add("-5");
            // numbers list is ordered by ascending
            Console.WriteLine("OrderBy: " + string.Join(" ", numbers.OrderBy(x => x))); // printing them sorted ascending !
            // here the elements are ordered probabley aphalbethically!
            Console.WriteLine(string.Join(" ", stringNumbers.OrderBy(x => x)));
            //different output than upper print
            Console.WriteLine("OrderByDescending: " + string.Join(" ", numbers.OrderByDescending(x => x)));
        }
    }
}
