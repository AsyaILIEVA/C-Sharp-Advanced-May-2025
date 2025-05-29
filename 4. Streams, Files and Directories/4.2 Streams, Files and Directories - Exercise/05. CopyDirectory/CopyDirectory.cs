﻿namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath =  Console.ReadLine();
            string outputPath = Console.ReadLine();

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath, recursive: true);
            }
            Directory.CreateDirectory(outputPath);

            foreach (string pathToSourceFile in Directory.EnumerateFiles(inputPath))
            {
                string name = Path.GetFileName(pathToSourceFile);
                string pathToDestinationFile = Path.Combine(outputPath, name);

                File.Copy(pathToSourceFile, pathToDestinationFile);
            }
        }
    }
}
