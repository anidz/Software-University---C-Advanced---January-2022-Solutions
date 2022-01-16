using System;
using System.Linq;

namespace _6.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsLength = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rowsLength][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = new int[elements.Length];

                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] = elements[col];
                }
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                int row = 0;
                int col = 0;
                int value = 0;

                row = int.Parse(command[1]);
                col = int.Parse(command[2]);
                value = int.Parse(command[3]);

                if (row < 0 || row >= jaggedArray.Length || col < 0 || col >= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine().Split();
                    continue;
                }

                if (command[0] == "Add")
                {
                    jaggedArray[row][col] += value;
                }
                else if (command[0] == "Subtract")
                {
                    jaggedArray[row][col] -= value;
                }

                command = Console.ReadLine().Split();
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine(String.Join(" ", jaggedArray[row]));
            }
        }
    }
}
