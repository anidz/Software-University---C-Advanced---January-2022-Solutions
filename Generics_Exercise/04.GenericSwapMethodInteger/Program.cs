﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxOfStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                list.Add(input);
            }

            var box = new Box<int>(list);

            var indexes = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var firstIndex = indexes[0];
            var secondIndex = indexes[1];

            box.Swap(firstIndex, secondIndex);

            Console.WriteLine(box);
        }
    }
}