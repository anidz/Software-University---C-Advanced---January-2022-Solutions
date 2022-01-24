namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folder, string output)
        {
            double sum = 0;

            DirectoryInfo dir = new DirectoryInfo(folder);
            FileInfo[] info = dir.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo fi in info) sum += fi.Length;

            sum = sum / 1024 / 1024;
            File.WriteAllText(output, sum.ToString());
        }
    }
}
