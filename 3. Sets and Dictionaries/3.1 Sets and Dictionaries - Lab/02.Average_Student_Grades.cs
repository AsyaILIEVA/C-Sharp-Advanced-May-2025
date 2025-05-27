using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            // var totalEntries = int.Parse(Console.ReadLine());

            // var grades = new Dictionary<string, List<decimal>>();
            // for (int i = 0; i < totalEntries; i++)
            // {
            //     var currentEntry = Console.ReadLine().Split();

            //     var studentName = currentEntry[0];
            //     var studentGrade = decimal.Parse(currentEntry[1]);

            //     if (!grades.ContainsKey(studentName))
            //     {
            //         grades[studentName] = new List<decimal>();
            //         //grades.Add(studentName, new List<decimal>());
            //     }
            //     grades[studentName].Add(studentGrade);
            // }

            //foreach (var entry in grades)
            // {
            //     var studentName = entry.Key;
            //     var studentGrades = entry.Value;

            //     //var studentGradesFixed = studentGrades.Select(st => st.ToString("F2"));

            //     var formattedStudentGrades = string.Join(" ", studentGrades);
            //     var averageStudentGrades = studentGrades.Average();

            //     Console.WriteLine($"{studentName:F2} -> {formattedStudentGrades:F2} (avg: {averageStudentGrades:F2})");
            // }

            //------------------------------------
            var studentGrades = new Dictionary<string, List<decimal>>();
            int gradesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < gradesCount; i++)
            {
                string[] line = Console.ReadLine().Split();
                string name = line[0];
                decimal grade = decimal.Parse(line[1]);
                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<decimal>());
                }
                studentGrades[name].Add(grade);
            }
            foreach (var name in studentGrades.Keys)
            {
                List<decimal> grades = studentGrades[name];
                string gradesStr = string.Join(" ",
                    grades.Select(g => g.ToString("f2")));
                decimal avg = grades.Average();
                Console.WriteLine($"{name} -> {gradesStr} (avg: {avg:f2})");

            }
        }
    }
}
