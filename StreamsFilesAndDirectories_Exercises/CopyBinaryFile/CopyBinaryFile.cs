using System.IO;

namespace CopyBinaryFile
{
    public class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            string inputPath = @"..\..\..\copyMe.png";
            string outputPath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputPath, outputPath);
        }

        public static void CopyFile(string input, string output)
        {
            using FileStream fsReader = new FileStream(input, FileMode.Open);
            using FileStream fsWriter = new FileStream(output, FileMode.Create);

            byte[] bytes = new byte[4096];
            while (true)
            {
                int currBytes = fsReader.Read(bytes, 0, bytes.Length);
                if (currBytes == 0) break;
                fsWriter.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
