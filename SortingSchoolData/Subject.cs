using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingSchoolData
{
    class Subject
    {
        public string Name { get; set; }
        public string SubjectCode { get; set; }
        public Teacher Teacher { get; set; }

        public Subject(string name, string subjectCode, Teacher teacher)
        {
            Name = name;
            SubjectCode = subjectCode;
            Teacher = teacher;
        }
    }

}
