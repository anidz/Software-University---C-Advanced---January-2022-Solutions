﻿
namespace OddLines
{
    using System;
    using System.IO;
    public class OddLines
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputPath, outputPath);
        }

        public static void ExtractOddLines(string input, string output)
        {
            using StreamReader reader = new StreamReader(input);
            using StreamWriter writer = new StreamWriter(output);

            int count = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (count++ % 2 == 1)
                {
                    writer.WriteLine(line);
                }

                line = reader.ReadLine();
            }
        }
    }
}
