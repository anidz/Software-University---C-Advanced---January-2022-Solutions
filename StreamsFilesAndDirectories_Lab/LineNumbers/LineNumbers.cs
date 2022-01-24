namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main(string[] args)
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string input, string output)
        {
            using StreamReader reader = new StreamReader(input);
            using StreamWriter writer = new StreamWriter(output);

            int n = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                writer.WriteLine($"{++n}. {line}");
                line = reader.ReadLine();
            }
        }
    }
}
