using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string, int, bool> isLessOrEqual = (names, length) => names.Length <= length;

            string[] result = names
                .Where(x => isLessOrEqual(x, n))
                .ToArray();
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
