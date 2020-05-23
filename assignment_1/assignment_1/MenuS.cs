using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class MenuS
    {
        StudentM stu1 = new StudentM();
        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("================");
            Console.WriteLine("1. Add new Student");
            Console.WriteLine("2. View all student");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Update Student");
            Console.WriteLine("6. Back to Main Menu");
            Console.WriteLine("================");

            Console.WriteLine("Please choose your number: ");
        }

        public void Run()
        {
            int input;

            do
            {
                menu();
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        stu1.Add();
                        break;
                    case 2:
                        Console.Clear();
                        stu1.View();
                        break;
                    case 3:
                        Console.Clear();
                        stu1.Search();
                        break;
                    case 4:
                        Console.Clear();
                        stu1.Delete();
                        break;
                    case 5:
                        Console.Clear();
                        stu1.Update();
                        break;
                    case 6:
                        Console.Clear();
                        Menu.Run();
                        break;
                }
                menu();
            }
            while (input != 6);

           
        }
    }
}
