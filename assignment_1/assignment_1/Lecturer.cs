using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class Lecturer
    {
        private string id;
        private string name; 
        private int age;
        private string gender;
        private string dob;
        private string department;
    
        public Lecturer() {

        } 

        public Lecturer(string ID, string Name, int Age, string Gender, string DOB, string Department)
        {
            this.Id = ID;
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
            this.Dob = DOB;
            this.department = Department;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Department { get => department; set => department = value; }
    }
    
}
