using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class Menu
    {
        public static void Run()
        {
            Console.WriteLine("===============");
            Console.WriteLine("1. Manage Student");
            Console.WriteLine("2. Manage Lecturer");
            Console.WriteLine("3. Exit");
            Console.WriteLine("===============");
            Console.WriteLine("Please choose your number:");
            MenuS ms = new MenuS();
            MenuL ml = new MenuL();
            int input = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        ms.Run();
                        break;
                    case 2:
                        Console.Clear();
                        ml.Run();
                        break;
                    case 3:
                        return;
                    default:
                        break;
                }
                Console.ReadLine();
            }
            while (input != 3);
            Console.ReadLine();
        }
    }
}
