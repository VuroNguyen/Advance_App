using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class Student
    {
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string dob { get; set; }
        public string batch { get; set; }

        public Student() { }

        public Student(string ID, string Name, int Age, string Gender, string DOB, string Batch)
        {
            this.id = ID;
            this.name = Name;
            this.age = Age;
            this.gender = Gender;
            this.dob = DOB;
            this.batch = Batch;
        }
    }
}
