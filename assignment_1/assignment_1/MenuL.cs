using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class MenuL
    {
        LecturerM lec1 = new LecturerM();
        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("================");
            Console.WriteLine("1. Add new Lecturer");
            Console.WriteLine("2. View all Lecturer");
            Console.WriteLine("3. Search Lecturer");
            Console.WriteLine("4. Delete Lecturer");
            Console.WriteLine("5. Update Lecturer");
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
                        lec1.Add();
                        break;
                    case 2:
                        Console.Clear();
                        lec1.View();
                        break;
                    case 3:
                        Console.Clear();
                        lec1.Search();
                        break;
                    case 4:
                        Console.Clear();
                        lec1.Delete();
                        break;
                    case 5:
                        Console.Clear();
                        lec1.Update();
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
