namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = "report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(inputFolderPath);

            Dictionary<string, List<FileInfo>> filesByExtention = new Dictionary<string, List<FileInfo>>();
            foreach (FileInfo file in directoryInfo.EnumerateFiles())
            {
                if (!filesByExtention.ContainsKey(file.Extension))
                {
                    filesByExtention[file.Extension] = new List<FileInfo>();
                }
                filesByExtention[file.Extension].Add(file);
            }

            StringBuilder sb = new StringBuilder();
            foreach (var (extension, files) in filesByExtention
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key))
            {
                sb.AppendLine(extension);

                foreach (FileInfo file in files.OrderBy(x => x.Length))
                {
                    double sizeInKb = file.Length / 1024.0;
                    sb.AppendLine($"--{file.Name} - {sizeInKb}");
                }
            }

            return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string pathToDesktop = Environment.GetFolderPath
                (Environment.SpecialFolder.CommonDesktopDirectory);
            string fullPathToReport=Path.Combine(pathToDesktop, reportFileName);

            File.WriteAllText(fullPathToReport, textContent);
        }
    }
}
