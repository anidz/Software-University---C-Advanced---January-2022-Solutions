using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int toPush = inputNumbers[0];
            int toPop = inputNumbers[1];
            int specialNumber = inputNumbers[2];

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < toPush; i++)
            {
                stack.Push(inputElements[i]);
            }
            for (int i = 0; i < toPop; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(specialNumber))
            {
                Console.WriteLine("true");
            }
            else if(stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
