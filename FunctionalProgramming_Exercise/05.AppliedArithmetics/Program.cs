using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Action<List<int>, string> ApplyArithmetics = (nums, opr) =>
            {
                if (opr == "add")
                {
                    numbers = nums.Select(n => ++n).ToList();
                }
                else if (opr == "multiply")
                {
                    numbers = nums.Select(n => n = n * 2).ToList();
                }
                else if (opr == "subtract")
                {
                    numbers = nums.Select(n => --n).ToList();
                }
                else if (opr == "print")
                {
                    Console.WriteLine(string.Join(" ", nums));
                }
            };

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                ApplyArithmetics(numbers, command);
                command = Console.ReadLine().ToLower();
            }
        }
    }
    }


