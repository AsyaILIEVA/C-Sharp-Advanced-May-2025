namespace SplitMergeBinaryFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            var fileBytes=File.ReadAllBytes(sourceFilePath);

            var partOneBytes = new List<byte>();
            var partTwoBytes = new List<byte>();

            for (int i = 0; i < fileBytes.Length; i++)
            {
                var partOneLength = fileBytes.Length % 2 == 0
                    ? fileBytes.Length / 2
                    : fileBytes.Length / 2 + 1;

                if (i < partOneLength)
                {
                    partOneBytes.Add(fileBytes[i]);
                }
                else 
                {
                    partTwoBytes.Add(fileBytes[i]);
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            var partOneBytes = File.ReadAllBytes(partOneFilePath);
            var partTwoBytes = File.ReadAllBytes(partTwoFilePath);

            var joinedBytes = new List<byte>();

            foreach (var bytes in partOneBytes) 
            { 
                joinedBytes.Add(bytes); 
            }

            foreach (var bytes in partTwoBytes)
            {
                joinedBytes.Add(bytes);
            }

            File.WriteAllBytes(joinedFilePath, joinedBytes.ToArray());
        }
    }
}