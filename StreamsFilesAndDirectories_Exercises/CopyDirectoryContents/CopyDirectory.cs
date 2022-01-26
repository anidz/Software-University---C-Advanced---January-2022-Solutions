namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main(string[] args)
        {
            string inputPath = Console.ReadLine();
            string outputPath = Console.ReadLine();

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string input, string output)
        {
            if (Directory.Exists(output)) Directory.Delete(output);
            else Directory.CreateDirectory(output);

            string[] files = Directory.GetFiles(input);
            foreach (string file in files)
            {
                string fileName = output + "\\" + Path.GetFileName(file);
                File.Copy(file, fileName);
            }
        }
    }
}
