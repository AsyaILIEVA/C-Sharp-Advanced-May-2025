namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;  
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            var words = File.ReadAllText(wordsFilePath);
            var text = File.ReadAllText(textFilePath);

            var allWords = words.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var result = new Dictionary<string, int>();

            foreach (var word in allWords)
            {
                var wordCount = CountWords(text, word);
                result[word] = wordCount;
            }

            var sortedResult = result
                .OrderByDescending(r => r.Value);

            var linesForFile = new List<string>();

            foreach (var (word, count) in sortedResult)
            {
                linesForFile.Add($"{word} - {count}");
            }

            File.WriteAllLines(outputFilePath, linesForFile);
        }
        public static int CountWords(string text, string word)
        {
            var loweredText = text.ToLower();
            var loweredWord = word.ToLower();

            var index = 0;
            var count = 0;

            while (true)
            {
                var nextWordOccurence = loweredText.IndexOf(loweredWord, index);

                if (nextWordOccurence < 0)
                {
                    break;
                }
                index = nextWordOccurence + 1;

                var previousSymbolIndex = nextWordOccurence - 1;
                var nextSymbolIndex = nextWordOccurence + word.Length;

                

                if (previousSymbolIndex >= 0 &&
                    char.IsLetter(text[previousSymbolIndex]))
                {
                    continue;
                }

                if (nextSymbolIndex < text.Length &&
                    char.IsLetter(text[nextSymbolIndex]))
                {
                    continue;
                }

                count++;

                
            }

            return count;
        }
    }
}
