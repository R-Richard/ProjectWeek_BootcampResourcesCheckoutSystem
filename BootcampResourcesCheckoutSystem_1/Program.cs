using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampResourcesCheckoutSystem_1
{
    class Program
    {
        static void Main(string[] args)
        {   
            
              string title = "BOOTCAMP RESOURCES CHECKOUT SYSTEM";
                Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                Console.WriteLine(title + "\n\n\n\n\n", Console.Title);

            Console.WriteLine("Main Menu");
            Console.WriteLine("1: View Students");
            Console.WriteLine("2: View Available Resources");
            Console.WriteLine("3: View Student Accounts");
            Console.WriteLine("4: Checkout Item");
            Console.WriteLine("5: Return Item");
            Console.WriteLine("6: Exit");


            Console.WriteLine("\n\n\nEnter Menu Item Number");
            int menuItem = int.Parse(Console.ReadLine());


            bool coninueFlag = true;

            while (true)
            {
                Console.Write("test");
                string response = Console.ReadLine();
                Console.Clear();
            }
         //   string bookArray = {"Lots Of Programming Stuff", "Even More on C#", }

        }
    }
}
