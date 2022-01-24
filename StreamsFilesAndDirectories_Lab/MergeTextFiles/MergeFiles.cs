namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main(string[] args)
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string first, string second, string output)
        {
            using StreamReader readerFirst = new StreamReader(first);
            using StreamReader readerSecond = new StreamReader(second);
            using StreamWriter writer = new StreamWriter(output);

            bool isFirstEmpty = false;
            bool isSecondEmpty = false;

            string lineOne = readerFirst.ReadLine();
            string lineTwo = readerSecond.ReadLine();

            while (!isFirstEmpty && !isSecondEmpty)
            {
                if (lineOne == null)
                {
                    isFirstEmpty = true;
                    break;
                }

                if (lineTwo == null)
                {
                    isSecondEmpty = true;
                    break;
                }

                writer.WriteLine(lineOne);
                writer.WriteLine(lineTwo);

                lineOne = readerFirst.ReadLine();
                lineTwo = readerSecond.ReadLine();
            }

            if (isFirstEmpty) writer.WriteLine(lineTwo);
            if (isSecondEmpty) writer.WriteLine(lineOne);
        }
    }
}
    

