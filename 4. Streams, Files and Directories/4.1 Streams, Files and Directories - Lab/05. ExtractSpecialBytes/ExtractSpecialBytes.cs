namespace ExtractSpecialBytes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            var allBytes = File.ReadAllBytes(binaryFilePath);

            var bytesToCheck = File.ReadAllLines(bytesFilePath)
                                   .Select(byte.Parse)
                                   .ToHashSet();

            var result = new List<byte>();

            foreach (var bytes in allBytes)
            {
                if (bytesToCheck.Contains(bytes))
                {
                    result.Add(bytes);
                }
            }

            File.WriteAllBytes(outputPath, result.ToArray());
        }
    }
}
