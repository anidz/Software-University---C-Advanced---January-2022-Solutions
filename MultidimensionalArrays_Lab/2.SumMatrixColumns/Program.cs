using System;
using System.Linq;

namespace _2.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowinput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < rowinput.Length; col++)
                {
                    matrix[row, col] = rowinput[col];
                }
            }
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                int colsum = 0;
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    colsum += matrix[row,col];
                }
                Console.WriteLine(colsum);
            }
        }
    }
}
