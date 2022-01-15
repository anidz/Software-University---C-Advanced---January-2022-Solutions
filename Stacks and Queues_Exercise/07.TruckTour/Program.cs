using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> truckTour = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int petrol = input[0];
                int distance = input[1];
                truckTour.Enqueue(new int[] { petrol, distance });
            }
            int starIndex = 0;
            while (true)
            {
                int currentPetrol = 0;
                foreach (var info in truckTour)
                {
                    int truckPetrol = info[0];
                    int truckDistance = info[1];
                    currentPetrol += truckPetrol;
                    currentPetrol -= truckDistance;
                    if(currentPetrol < 0)
                    {
                        int[] element = truckTour.Dequeue();
                        truckTour.Enqueue(element);
                        starIndex++;
                        break;
                    }
                }
                if(currentPetrol >= 0)
                {
                    Console.WriteLine(starIndex);
                    break;
                }
            }
                
                
        }
    }
}
