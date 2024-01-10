using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        class Student : Person
        {
            public string ClassAndSection { get; set; }

            public void DisplayStudentInfo()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Class and Section: {ClassAndSection}\n");
            }
        }

        class Teacher : Person
        {
            public string ClassAndSection { get; set; }

            public void DisplayTeacherInfo()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Class and Section: {ClassAndSection}\n");
            }
        }

        class Subject
        {
            public string Name { get; set; }
            public string SubjectCode { get; set; }
            public Teacher AssignedTeacher { get; set; }

            public void DisplaySubjectInfo()
            {
                Console.WriteLine($"Subject: {Name}");
                Console.WriteLine($"Subject Code: {SubjectCode}");
                Console.WriteLine($"Assigned Teacher: {AssignedTeacher.Name}\n");
            }
        }

        class program
        {
            static void Main()
            {
                List<Student> students = new List<Student>
        {
            new Student { Name = "student1", Age = 15, ClassAndSection = "ClassA Section1" },
            new Student { Name = "student2", Age = 13, ClassAndSection = "ClassB Section2" }
        };

                List<Teacher> teachers = new List<Teacher>
        {
            new Teacher { Name = "teacher1", Age = 30, ClassAndSection = "ClassA Section1" },
            new Teacher { Name = "teacher2", Age = 35, ClassAndSection = "ClassB Section2" }
        };

                List<Subject> subjects = new List<Subject>
        {
            new Subject { Name = "Mathematics", SubjectCode = "MTA", AssignedTeacher = teachers[0] },
            new Subject { Name = "English", SubjectCode = "EGB", AssignedTeacher = teachers[1] }
        };

                Console.WriteLine("Students in ClassA Section1:");
                foreach (var student in students)
                {
                    if (student.ClassAndSection == "ClassA Section1")
                    {
                        student.DisplayStudentInfo();
                    }
                }
                Console.WriteLine("Students in ClassB Section2:");
                foreach (var student in students)
                {
                    if (student.ClassAndSection == "ClassB Section2")
                    {
                        student.DisplayStudentInfo();
                    }
                }

                Console.WriteLine("Subjects taught by Teacher2:");
                foreach (var subject in subjects)
                {
                    if (subject.AssignedTeacher.Name == "teacher2")
                    {
                        subject.DisplaySubjectInfo();
                    }
                }
            }
        }
    }
}