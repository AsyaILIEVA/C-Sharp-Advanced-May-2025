namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static readonly char[] punctuation = new char[] { '-', ',', '.', '!', '?' };
        const char replacement = '@';
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using StreamReader streamreader = new StreamReader(inputFilePath);

            StringBuilder sb = new StringBuilder();
            bool isEven = true;
            while (!streamreader.EndOfStream)
            {
                string currentLine = streamreader.ReadLine();
                if (isEven)
                {
                    string[] words = currentLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    sb.AppendLine(string.Join(' ', words.Select(w => ReplacePunctuation(w)).Reverse()));
                }
                isEven = !isEven;
            }
            return sb.ToString();
        }
        static string ReplacePunctuation(string word)
        {
            string result = word;
            foreach (char characterToReplace in punctuation)
                result = result.Replace(characterToReplace, replacement);

            return result;
        }
    }
}
