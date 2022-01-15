using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsАndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputCups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> cups = new Queue<int>(inputCups);
            Stack<int> bottles = new Stack<int>(inputBottles);

            int wastedLiters = 0;
            //bool isNewOne = true;
            //int currentCup = 0;

            while (bottles.Count > 0 && cups.Count > 0)
            {
                int currentBottle = bottles.Pop();
                int currentCup = cups.Dequeue();
                if (currentBottle - currentCup >= 0)
                {
                    wastedLiters += currentBottle - currentCup;
                    continue;
                }
                currentCup -= currentBottle;
                while (bottles.Count > 0)
                {
                    int bottle = bottles.Pop();
                    if (bottle - currentCup >= 0)
                    {
                        wastedLiters += bottle - currentCup;
                        break;
                    }
                    currentCup -= bottle;
                }
            }
            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedLiters}");
        }
    }
}









