using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class LecturerM : General
    {
        public List<Lecturer> LecList = new List<Lecturer>();


        public override void Add()
        {
            Console.Write("Input Lecturer ID:");
            string idInput = Console.ReadLine();
            Console.Write("Input Lecturer Full Name:");
            string nameInput = Console.ReadLine();
            Console.Write("Input Lecturer Age:");
            int ageInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Lecturer Gender:");
            string genderInput = Console.ReadLine();
            Console.Write("Input Lecturer Date of Birth:");
            string dobInput = Console.ReadLine();
            Console.Write("Input Lecturer department:");
            string deInput = Console.ReadLine();

            LecList.Add(new Lecturer(idInput, nameInput, ageInput, genderInput, dobInput, deInput));
        }

        public override void View()
        {
            foreach (Lecturer lec in LecList)
            {
                Console.WriteLine(lec.Id + "||" + lec.Name + "||" + lec.Age + "||" + lec.Gender + "||" + lec.Dob + "||" + lec.Department);

            }

            Console.ReadLine();

        }

        public override void Search()
        {
            Console.Write("Input the Lecturer ID:");
            string inputSearch = Console.ReadLine();
            for (int i = 0; i < LecList.Count; i++)
            {
                if (LecList[i].Id == inputSearch)
                {
                    Console.WriteLine(LecList[i].Id + "||" + LecList[i].Name + "||" + LecList[i].Age + "||" + LecList[i].Gender + "||" + LecList[i].Dob + "||" + LecList[i].Department);

                }
            }

            Console.ReadLine();
        }

        public override void Delete()
        {
            Console.Write("Input the Lecturer ID:");
            string inputDel = Console.ReadLine();

            for (int i = 0; i < LecList.Count; i++)
            {
                if (LecList[i].Id == inputDel)
                {
                    LecList.RemoveAt(i);

                }
            }

        }

        public override void Update()
        {
            Console.Write("Input the Lecturer ID: ");
            string inputUpdate = Console.ReadLine();

            for (int i = 0; i < LecList.Count; i++)
            {
                if (LecList[i].Id == inputUpdate)
                {
                    Console.Write("Input Lecturer ID:");
                    string idinput = Console.ReadLine();
                    Console.Write("Input Lecturer Full Name:");
                    string nameinput = Console.ReadLine();
                    Console.Write("Input Lecturer Age:");
                    int ageinput = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input Lecturer Gender:");
                    string genderinput = Console.ReadLine();
                    Console.Write("Input Lecturer Date of Birth:");
                    string dobinput = Console.ReadLine();
                    Console.Write("Input Lecturer Department:");
                    string deinput = Console.ReadLine();

                    LecList[i].Id = idinput;
                    nameinput = LecList[i].Name;
                    ageinput = LecList[i].Age;
                    genderinput = LecList[i].Gender;
                    dobinput = LecList[i].Dob;
                    deinput = LecList[i].Department;

                }
            }


        }
    }
}
