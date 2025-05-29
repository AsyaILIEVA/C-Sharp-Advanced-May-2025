namespace LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);

            for (int i = 0; i < lines.Length; i++) 
            { 
                string currentLine = lines[i];
                int letters = 0, punctuation = 0;
                for (int j = 0; j < currentLine.Length; j++)
                {
                    if (char.IsLetter(currentLine[j])) letters++;
                    else if (char.IsPunctuation(currentLine[j])) punctuation++;
                    
                }

                lines[i] = $"Line {i + 1}: {lines[i]} ({letters})({punctuation})";
            }

            File.WriteAllLines(outputFilePath, lines);
        }
    }
}
