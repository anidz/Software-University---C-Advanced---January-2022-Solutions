namespace ZipAndExtract
{
    using System;
    using System.IO;
    using System.IO.Compression;

    public class ZipAndExtract
    {
        private static string zipArchive;
        private static string file;

        static void Main(string[] args)
        {
            string inputFile = @"..\..\..\copyMe.png";
            string zipArchiveFile = @"..\..\..\archive.zip";
            string extractedFile = @"..\..\..\extracted.png";

            ZipFileToArchive(inputFile, zipArchiveFile);

            var fileNameOnly = Path.GetFileName(inputFile);
            ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }

        public static void ZipFileToArchive(string input, string zipArchiveFilePath)
        {
            using ZipArchive zip = ZipFile.Open(zipArchive, ZipArchiveMode.Create);
            zip.CreateEntryFromFile(input, "copyMe.png");
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string output)
        {
            using ZipArchive zip = ZipFile.OpenRead(zipArchive);
            ZipArchiveEntry currZip = zip.GetEntry(file);
            currZip.ExtractToFile(output);
        }
    }
}
