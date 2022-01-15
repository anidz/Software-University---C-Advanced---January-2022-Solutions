using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothingInTheBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rack = int.Parse(Console.ReadLine());
            int numOfRacks = 0;
            int clothesOnTheRack = 0;
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < clothingInTheBox.Length; i++)
            {
                stack.Push(clothingInTheBox[i]);
            }

            while (stack.Count > 0)
            {
                int currentCloth = stack.Peek();

                if (currentCloth + clothesOnTheRack > rack)
                {
                    clothesOnTheRack = 0;
                    numOfRacks++;
                    continue;
                }
                if (clothesOnTheRack + currentCloth == rack)
                {
                    clothesOnTheRack = 0;
                    stack.Pop();
                    numOfRacks++;
                    continue;
                }
                if (stack.Count == 1 && clothesOnTheRack + currentCloth < rack)
                {
                    stack.Pop();
                    numOfRacks++;
                }
                else
                {
                    stack.Pop();
                    clothesOnTheRack += currentCloth;
                }

            }
            Console.WriteLine(numOfRacks);
        }
    }
}
