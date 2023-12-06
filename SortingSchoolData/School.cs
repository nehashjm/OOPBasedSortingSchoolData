using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SortingSchoolData
{
    class School
    {
        public List<Student> students = new List<Student>();
        public List<Teacher> teachers = new List<Teacher>();
        public List<Subject> subjects = new List<Subject>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }

        public List<Student> GetStudentsByClass(string cls)
        {
            List<Student> classStudents = new List<Student>();
            foreach (Student student in students)
            {
                if (student.Class == cls)
                {
                    classStudents.Add(student);
                }
            }
            return classStudents;
        }

        public List<Subject> GetSubjectsTaughtByTeacher(string teacherName)
        {
            List<Subject> teacherSubjects = new List<Subject>();
            foreach (Subject subject in subjects)
            {
                if (subject.Teacher.Name == teacherName)
                {
                    teacherSubjects.Add(subject);
                }
            }
            return teacherSubjects;
        }
    }

}
