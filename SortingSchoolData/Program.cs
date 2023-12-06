using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingSchoolData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            // Add sample student data
            school.AddStudent(new Student("Alice", "7","A"));
            school.AddStudent(new Student("Olivia", "7", "A"));
            school.AddStudent(new Student("Benjamin", "7", "A")); 
            school.AddStudent(new Student("Elijah", "7", "A"));
            school.AddStudent(new Student("Sophia", "7","A"));
            school.AddStudent(new Student("Charlie", "8","B"));
            school.AddStudent(new Student("Liam", "8", "B"));
            school.AddStudent(new Student("Noah", "9","C"));
            school.AddStudent(new Student("Emma", "9","C"));

            // Add sample teacher data
            school.AddTeacher(new Teacher("Mr. Jones", "7" ,"A"));
            school.AddTeacher(new Teacher("Ms. Smith", "7" ,"B"));
            school.AddTeacher(new Teacher("Mr. Brown", "7" ,"C"));

            // Add sample subject data
            school.AddSubject(new Subject("Science", "SCI101", school.teachers[0]));
            school.AddSubject(new Subject("Maths", "MATH101", school.teachers[0]));
            school.AddSubject(new Subject("Social", "SOCI101", school.teachers[1]));
            school.AddSubject(new Subject("Hindi", "HIN101", school.teachers[1]));
            school.AddSubject(new Subject("English", "ENGL101", school.teachers[2]));
            school.AddSubject(new Subject("Drawing", "DRAW101", school.teachers[2]));
            

            // Display students in class 
            Console.WriteLine("Students in 7th Class:");
            foreach (Student student in school.GetStudentsByClass("7"))
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Students in 8th Class:");
            foreach (Student student in school.GetStudentsByClass("8"))
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Students in 9th Class:");
            foreach (Student student in school.GetStudentsByClass("9"))
            {
                Console.WriteLine(student.Name);
            }

            // Display subjects taught by Teachers
            Console.WriteLine("\nSubjects taught by Mr. Jones:");
            foreach (Subject subject in school.GetSubjectsTaughtByTeacher("Mr. Jones"))
            {
                Console.WriteLine(subject.Name);
            }
            
            Console.WriteLine("\nSubjects taught by Ms. Smith:");
            foreach (Subject subject in school.GetSubjectsTaughtByTeacher("Ms. Smith"))
            {
                Console.WriteLine(subject.Name);
            }
            Console.WriteLine("\nSubjects taught by Mr. Brown:");
            foreach (Subject subject in school.GetSubjectsTaughtByTeacher("Mr. Brown"))
            {
                Console.WriteLine(subject.Name);
            }

            Console.ReadKey();

        }
    }

}
