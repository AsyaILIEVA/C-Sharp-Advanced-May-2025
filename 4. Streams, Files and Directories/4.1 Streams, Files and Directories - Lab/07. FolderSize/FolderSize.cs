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

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            var directories = Directory.GetDirectories(folderPath + @"\..", "*", SearchOption.AllDirectories);

            double totalSize = 0;

            foreach (var d in directories)
            {
                var files = Directory.GetFiles(d);

                foreach (var file in files)
                {
                    var fileInfo = new FileInfo(file);

                    totalSize += fileInfo.Length;
                }
            }

            var totalSizeInKb = totalSize / 1024;

            File.WriteAllText(outputFilePath, $"{totalSizeInKb} KB");
        }
    }
}
