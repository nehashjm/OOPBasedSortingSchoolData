using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingSchoolData
{
    class Teacher
    {
        public string Name { get; set; }
        public string Class { get; set; }

        public string Section {  get; set; }

        public Teacher(string name, string cls, string section)
        {
            Name = name;
            Class = cls;
            Section = section;
        }
    }

}
