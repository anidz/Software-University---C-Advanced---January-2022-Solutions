using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ranges = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string oddEven = Console.ReadLine();

            List<int> numbers = new List<int>();

            for (int i = ranges[0]; i <= ranges[1]; i++)
            {
                numbers.Add(i);
            }
            Predicate<int> isEven = x
                => x % 2 == 0;
            Predicate<int> isOdd = x
               => x % 2 != 0;

            List<int> result;

            if (oddEven == "even")
            {
                result = numbers.FindAll(isEven);
            }
            else
            {
                result = numbers.FindAll(isOdd);
             }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
