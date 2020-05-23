using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class StudentM : General
    {
        public List<Student> StuList = new List<Student>();
        
        
        public override void Add()
        {
            Console.Write("Input Student ID:");
            string idInput = Console.ReadLine();
            Console.Write("Input Student Full Name:");
            string nameInput = Console.ReadLine();
            Console.Write("Input Student Age:");
            int ageInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Student Gender:");
            string genderInput = Console.ReadLine();
            Console.Write("Input Student Date of Birth:");
            string dobInput = Console.ReadLine();
            Console.Write("Input Student Batch:");
            string batchInput = Console.ReadLine();

            StuList.Add(new Student(idInput, nameInput, ageInput, genderInput, dobInput, batchInput));
        }

        public override void View()
        {        
            foreach (Student stu in StuList)
            {
                Console.WriteLine(stu.id+ "||" + stu.name + "||" + stu.age + "||" + stu.gender + "||" + stu.dob + "||" + stu.batch);
                            
            }            

            Console.ReadLine();
           
        }

        public override void Search()
        {
            Console.Write("Input the Student ID:");
            string inputSearch = Console.ReadLine();
            for (int i = 0; i < StuList.Count; i++)
            {
                if (StuList[i].id == inputSearch)
                {
                    Console.WriteLine(StuList[i].id + "||" + StuList[i].name + "||" + StuList[i].age + "||" + StuList[i].gender + "||" + StuList[i].dob + "||" + StuList[i].batch);
                  
                }
            }
            
            Console.ReadLine();
        }

        public override void Delete()
        {
            Console.Write("Input the Student ID:");
            string inputDel = Console.ReadLine();

            for (int i = 0; i < StuList.Count; i++)
            {
                if (StuList[i].id == inputDel)
                {
                    StuList.RemoveAt(i);

                }
            }

        }

        public override void Update()
        {
            Console.Write("Input the Student ID: ");
            string inputUpdate = Console.ReadLine();

            for (int i = 0; i < StuList.Count; i++)
            {
                if (StuList[i].id == inputUpdate)
                {
                    Console.Write("Input Student ID:");
                    string idinput = Console.ReadLine();
                    Console.Write("Input Student Full Name:");
                    string nameinput = Console.ReadLine();
                    Console.Write("Input Student Age:");
                    int ageinput = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input Student Gender:");
                    string genderinput = Console.ReadLine();
                    Console.Write("Input Student Date of Birth:");
                    string dobinput = Console.ReadLine();
                    Console.Write("Input Student Major:");
                    string batchinput = Console.ReadLine();

                    StuList[i].id = idinput;
                    nameinput = StuList[i].name;
                    ageinput = StuList[i].age;
                    genderinput = StuList[i].gender;
                    dobinput = StuList[i].dob;
                    batchinput = StuList[i].batch;

                }
            }

            
        }
    }
}
