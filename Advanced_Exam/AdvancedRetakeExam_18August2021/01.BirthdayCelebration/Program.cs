using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.BirthdayCelebration
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> guests = new Queue<int>(Console
             .ReadLine()
             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToList());
            Stack<int> plates = new Stack<int>(Console
            .ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList());

            int wastedFood = 0;
            while ((guests.Count > 0) && (plates.Count > 0))
            {
                int guest = guests.Dequeue();

                while ((guest > 0) && (plates.Count > 0))
                {
                    int plate = plates.Pop();
                    guest -= plate;

                    if (guest < 0)
                    {
                        wastedFood += (-1) * guest;
                    }
                }
            }

            StringBuilder sb = new StringBuilder();

            if (guests.Count > 0)
            {
                sb.AppendLine($"Guests: {string.Join(" ", guests)}");
            }

            if (plates.Count > 0)
            {
                sb.AppendLine($"Plates: {string.Join(" ", plates)}");
            }

            sb.AppendLine($"Wasted grams of food: {wastedFood}");

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}



