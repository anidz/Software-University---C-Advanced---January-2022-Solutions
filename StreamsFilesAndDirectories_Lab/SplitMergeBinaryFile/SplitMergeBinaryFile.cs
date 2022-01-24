namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string source, string first, string second)
        {
            byte[] sourceBytes = File.ReadAllBytes(source);
            bool isEven = sourceBytes.Length % 2 == 0;

            using FileStream fileStreamFirst = new FileStream(first, FileMode.Create);
            fileStreamFirst.Write(sourceBytes, 0, isEven ? sourceBytes.Length / 2 : (sourceBytes.Length / 2) + 1);

            using FileStream fileStreamSecond = new FileStream(second, FileMode.Create);
            fileStreamSecond.Write(sourceBytes, 0, sourceBytes.Length / 2);
        }

        public static void MergeBinaryFiles(string first, string second, string joined)
        {
            byte[] firstArr = File.ReadAllBytes(first);
            byte[] secondArr = File.ReadAllBytes(second);

            byte[] writeArr = new byte[firstArr.Length + secondArr.Length];
            firstArr.CopyTo(writeArr, 0);
            secondArr.CopyTo(writeArr, firstArr.Length);

            File.WriteAllBytes(joined, writeArr);
        }
        
        
    }
}