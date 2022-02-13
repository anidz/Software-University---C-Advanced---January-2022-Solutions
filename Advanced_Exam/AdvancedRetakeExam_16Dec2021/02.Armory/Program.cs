using System;

namespace _02.Armory
{
    class Program
    {
        static void Main(string[] args)
        {
            int goldCounter = 0;
            int[] m1 = new int[2];
            int[] m2 = new int[2];
            int[] aPos = new int[2];
            int size = int.Parse(Console.ReadLine());
            char[,] armory = new char[size, size];

            armory = GetArray(armory, m1, m2, aPos);

            string input = Console.ReadLine().ToLower();
            while (input != null)
            {
                string direction = input;

                switch (direction)
                {
                    case "left":
                        if (IsInRange(armory, aPos[0], aPos[1] - 1))
                        {
                            armory[aPos[0], aPos[1]] = '-';
                            aPos[1]--;
                        }
                        else
                        {
                            armory[aPos[0], aPos[1]] = '-';
                            Output(armory, goldCounter);
                        }
                        break;
                    case "right":
                        if (IsInRange(armory, aPos[0], aPos[1] + 1))
                        {
                            armory[aPos[0], aPos[1]] = '-';
                            aPos[1]++;
                        }
                        else
                        {
                            armory[aPos[0], aPos[1]] = '-';
                            Output(armory, goldCounter);
                        }
                        break;
                    case "up":
                        if (IsInRange(armory, aPos[0] - 1, aPos[1]))
                        {
                            armory[aPos[0], aPos[1]] = '-';
                            aPos[0]--;
                        }
                        else
                        {
                            armory[aPos[0], aPos[1]] = '-';
                            Output(armory, goldCounter);
                        }
                        break;
                    case "down":
                        if (IsInRange(armory, aPos[0] + 1, aPos[1]))
                        {
                            armory[aPos[0], aPos[1]] = '-';
                            aPos[0]++;
                        }
                        else
                        {
                            armory[aPos[0], aPos[1]] = '-';
                            Output(armory, goldCounter);
                        }
                        break;
                }

                if (char.IsDigit(armory[aPos[0], aPos[1]]))
                {
                    int gold = (int)char.GetNumericValue(armory[aPos[0], aPos[1]]);
                    goldCounter += gold;
                    armory[aPos[0], aPos[1]] = 'A';
                    if (goldCounter >= 65) Output(armory, goldCounter);
                }
                else if ((aPos[0] == m1[0] && aPos[1] == m1[1]) || (aPos[0] == m2[0] && aPos[1] == m2[1]))
                {
                    bool isFirstMirror = (aPos[0].Equals(m1[0]) && aPos[1].Equals(m1[1]));

                    if (isFirstMirror)
                    {
                        armory[aPos[0], aPos[1]] = '-';
                        aPos[0] = m2[0];
                        aPos[1] = m2[1];
                        armory[aPos[0], aPos[1]] = 'A';
                    }
                    else
                    {
                        armory[aPos[0], aPos[1]] = '-';
                        aPos[0] = m1[0];
                        aPos[1] = m1[1];
                        armory[aPos[0], aPos[1]] = 'A';
                    }
                }

                input = Console.ReadLine().ToLower();
            }

            Output(armory, goldCounter);
        }

        public static char[,] GetArray(char[,] arr, int[] m1, int[] m2, int[] aPos)
        {
            bool isFirstMirrorFound = false;
            for (int r = 0; r < arr.GetLength(0); r++)
            {
                char[] getChars = Console.ReadLine().ToCharArray();
                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    arr[r, c] = getChars[c];

                    if (arr[r, c] == 'A')
                    {
                        aPos[0] = r;
                        aPos[1] = c;
                        continue;
                    }

                    if (arr[r, c] == 'M' && !isFirstMirrorFound)
                    {
                        m1[0] = r;
                        m1[1] = c;
                        isFirstMirrorFound = true;
                    }
                    else if (arr[r, c] == 'M')
                    {
                        m2[0] = r;
                        m2[1] = c;
                    }
                }
            }

            return arr;
        }

        public static void Output(char[,] arr, int gold)
        {
            if (gold >= 65)
            {
                Console.WriteLine($"Very nice swords, I will come back for more!");
            }
            else
            {
                Console.WriteLine($"I do not need more swords!");
            }

            Console.WriteLine($"The king paid {gold} gold coins.");

            for (int r = 0; r < arr.GetLength(0); r++)
            {
                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    Console.Write(arr[r, c]);
                }
                Console.WriteLine();
            }

            Environment.Exit(0);
        }

        public static bool IsInRange(char[,] arr, int y, int x)
        {
            return (x >= 0 && x < arr.GetLength(1)
                 && y >= 0 && y < arr.GetLength(0));
        }
    }
}
    

