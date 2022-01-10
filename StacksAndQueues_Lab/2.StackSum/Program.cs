using System;
using System.Collections.Generic;

namespace _2.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbersAsString = Console.ReadLine();
            Stack<int> numbers = new Stack<int>();
            string[] numbersList = numbersAsString.Split(' ');

            foreach (var number in numbersList)
            {
                numbers.Push(int.Parse(number));
            }
            while (true)
            {
                string line = Console.ReadLine();
                string[] lineParts = line.Split(' ');
                string command = lineParts[0].ToLower();
                if (command == "end")
                {
                    break;
                }
                else if(command == "add")
                {
                    numbers.Push(int.Parse(lineParts[1]));
                    numbers.Push(int.Parse(lineParts[2]));
                }
                else if(command == "remove")
                {
                    var numberOfElementsToRemove = int.Parse(lineParts[1]);
                    if(numberOfElementsToRemove <= numbers.Count)
                    {
                        for (int i = 0; i < numberOfElementsToRemove; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
            }
            int sum = 0;
            while(numbers.Count > 0)
            {
                int number = numbers.Pop();
                sum += number;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
