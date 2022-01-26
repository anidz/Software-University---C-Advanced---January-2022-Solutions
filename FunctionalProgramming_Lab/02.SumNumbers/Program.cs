using System;
using System.Linq;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parseInt = x => int.Parse(x);
            int[] nums = Console.ReadLine()
                .Split(", ").Select(parseInt).ToArray();

            Console.WriteLine(nums.Length);
            Console.WriteLine(nums.Sum());
        }
    }
}
