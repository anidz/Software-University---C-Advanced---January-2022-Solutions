﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> isDiv = (x, y) => x % y == 0;

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToArray();

            int y = int.Parse(Console.ReadLine());

            List<int> result = numbers.Where(x => !isDiv(x, y)).ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
