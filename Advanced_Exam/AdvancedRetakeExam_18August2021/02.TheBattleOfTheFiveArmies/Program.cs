using System;

namespace _02.TheBattleOfTheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armour = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            if (rows == 0)
            {
                return;
            }

            char[] firstRowInput = Console.ReadLine().ToCharArray();
            int columns = firstRowInput.Length;
            char[,] matrix = new char[rows, columns];

            for (int col = 0; col < columns; col++)
            {
                matrix[0, col] = firstRowInput[col];
            }

            for (int row = 1; row < rows; row++)
            {
                char[] colElements = Console.ReadLine().ToCharArray();
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int armyRow = -1;
            int armyCol = -1;
            int enemyRow = -1;
            int enemyCol = -1;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    if (matrix[row, col] == 'A')
                    {
                        armyRow = row;
                        armyCol = col;
                    }
                }
            }

            while (true)
            {
                string[] directionAndIndexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string direction = directionAndIndexes[0];
                enemyRow = int.Parse(directionAndIndexes[1]);
                enemyCol = int.Parse(directionAndIndexes[2]);
                matrix[enemyRow, enemyCol] = 'O';

                armour--;
                switch (direction)
                {
                    case "up":
                        matrix[armyRow, armyCol] = '-';
                        armyRow -= 1;
                        if (!isInTheMatrix(matrix, armyRow, armyCol))
                        {
                            armyRow += 1;
                        }
                        if (armour <= 0 && matrix[armyRow, armyCol] != 'M')
                        {
                            Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
                            matrix[armyRow, armyCol] = 'X';
                            PrintMatrix(matrix);
                            return;
                        }
                        if (matrix[armyRow, armyCol] == 'O')
                        {
                            armour -= 2;
                            if (armour <= 0)
                            {
                                Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
                                matrix[armyRow, armyCol] = 'X';
                                PrintMatrix(matrix);
                                return;
                            }
                        }
                        if (matrix[armyRow, armyCol] == 'M')
                        {
                            matrix[armyRow, armyCol] = '-';
                            Console.WriteLine($"The army managed to free the Middle World! Armor left: {armour}");
                            PrintMatrix(matrix);
                            return;
                        }
                        matrix[armyRow, armyCol] = 'A';
                        break;
                    case "down":
                        matrix[armyRow, armyCol] = '-';
                        armyRow += 1;
                        if (!isInTheMatrix(matrix, armyRow, armyCol))
                        {
                            armyRow -= 1;
                        }
                        if (armour <= 0 && matrix[armyRow, armyCol] != 'M')
                        {
                            Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
                            matrix[armyRow, armyCol] = 'X';
                            PrintMatrix(matrix);
                            return;
                        }
                        if (matrix[armyRow, armyCol] == 'O')
                        {
                            armour -= 2;
                            if (armour <= 0)
                            {
                                Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
                                matrix[armyRow, armyCol] = 'X';
                                PrintMatrix(matrix);
                                return;
                            }
                        }
                        if (matrix[armyRow, armyCol] == 'M')
                        {
                            matrix[armyRow, armyCol] = '-';
                            Console.WriteLine($"The army managed to free the Middle World! Armor left: {armour}");
                            PrintMatrix(matrix);
                            return;
                        }
                        matrix[armyRow, armyCol] = 'A';
                        break;
                    case "left":
                        matrix[armyRow, armyCol] = '-';
                        armyCol -= 1;
                        if (!isInTheMatrix(matrix, armyRow, armyCol))
                        {
                            armyCol += 1;
                        }
                        if (armour <= 0 && matrix[armyRow, armyCol] != 'M')
                        {
                            Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
                            matrix[armyRow, armyCol] = 'X';
                            PrintMatrix(matrix);
                            return;
                        }
                        if (matrix[armyRow, armyCol] == 'O')
                        {
                            armour -= 2;
                            if (armour <= 0)
                            {
                                Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
                                matrix[armyRow, armyCol] = 'X';
                                PrintMatrix(matrix);
                                return;
                            }
                        }
                        if (matrix[armyRow, armyCol] == 'M')
                        {
                            matrix[armyRow, armyCol] = '-';
                            Console.WriteLine($"The army managed to free the Middle World! Armor left: {armour}");
                            PrintMatrix(matrix);
                            return;
                        }
                        matrix[armyRow, armyCol] = 'A';
                        break;
                    case "right":
                        matrix[armyRow, armyCol] = '-';
                        armyCol += 1;
                        if (!isInTheMatrix(matrix, armyRow, armyCol))
                        {
                            armyCol -= 1;
                        }
                        if (armour <= 0 && matrix[armyRow, armyCol] != 'M')
                        {
                            Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
                            matrix[armyRow, armyCol] = 'X';
                            PrintMatrix(matrix);
                            return;
                        }
                        if (matrix[armyRow, armyCol] == 'O')
                        {
                            armour -= 2;
                            if (armour <= 0)
                            {
                                Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
                                matrix[armyRow, armyCol] = 'X';
                                PrintMatrix(matrix);
                                return;
                            }
                        }
                        if (matrix[armyRow, armyCol] == 'M')
                        {
                            matrix[armyRow, armyCol] = '-';
                            Console.WriteLine($"The army managed to free the Middle World! Armor left: {armour}");
                            PrintMatrix(matrix);
                            return;
                        }
                        matrix[armyRow, armyCol] = 'A';
                        break;
                }
            }
        }

        private static bool isInTheMatrix(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
