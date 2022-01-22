using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> elements = NewMethod();

            int qty = int.Parse(Console.ReadLine());
            for (int i = 0; i < qty; i++)
            {
                string[] chemicals = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (string chemical in chemicals) elements.Add(chemical);
            }

            Console.WriteLine(string.Join(" ", elements));
        }

        private static SortedSet<string> NewMethod()
        {
            return new SortedSet<string>();
        }
    }
    }

