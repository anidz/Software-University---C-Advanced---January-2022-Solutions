using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _5.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>();

            foreach (var item in input)
            {
                if(item % 2 == 0)
                {
                    numbers.Enqueue(item);
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
