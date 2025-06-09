using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomProject
{
    public class Classroom
    {
        List<Student> students;
        //public List<Student> students { get; set; }
        public int Capacity { get; set; }
        //public int Count { get; set; }
        public int Count => this.students.Count;

        public Classroom(int capacity)
        {
            Capacity = capacity;

            this.students = new List<Student>(capacity);
        }

        //Method RegisterStudent(Student student) – adds an entity to the students if there is an empty seat for the student.
        //Returns "Added student {firstName} {lastName}" if the student is successfully added
        //Returns "No seats in the classroom" – if there are no more seats in the classroom

        public string RegisterStudent(Student student)
        {
            if (this.Capacity > this.Count)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            return $"No seats in the classroom";
        }

        //Method DismissStudent(string firstName, string lastName) removes the student by the given names
        //Returns "Dismissed student {firstName} {lastName}" if the student is successfully dismissed
        //Returns "Student not found" if the student is not in the classroom
        public string DismissStudent(string firstName, string lastName)
        {
            if (this.students.Any(s => s.FirstName == firstName && s.LastName == lastName))
            {
                //var removedStudent = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
                var removedStudent = students.Where(s => s.FirstName == firstName && s.LastName == lastName).First();
                students.Remove(removedStudent);
                return $"Dismissed student {firstName} {lastName}";
                //return $"Dismissed student {removedStudent?.FirstName} {removedStudent?.LastName}";
            }

            return $"Student not found";
        }

        //Method GetSubjectInfo(string subject) – returns all the students with the given subject in the following format:
        //"Subject: {subjectName}
        //Students:
        //{firstName} {lastName}
        //{ firstName} { lastName}
        //…"
        //Returns "No students enrolled for the subject" if the student is not in the classroom
        public string GetSubjectInfo(string subject)
        {
            if (students.Any(s => s.Subject == subject))
            {
                StringBuilder result = new StringBuilder();

                result.AppendLine($"Subject: {subject}");
                result.AppendLine("Students:");

                foreach (var student in students.Where(student => student.Subject == subject))
                {
                    result.AppendLine($"{student.FirstName} {student.LastName}");
                }

                return result.ToString().TrimEnd();
            }

            return "No students enrolled for the subject";
        }

        //Method GetStudentsCount() – returns the count of the students in the classroom.
        public string GetStudentsCount()
        {
            return $"{students.Count}";
        }
        //Method GetStudent(string firstName, string lastName) – returns the student with the given names. 

        public Student GetStudent(string firstName, string lastName)
        {
            var student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
            return student;
        }
    }
}
