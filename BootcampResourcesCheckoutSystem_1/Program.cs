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

            // set program in a loop for restart option

            int restart = 0;
            int menuItem;
            do
            {

            // create general header - had trouble keeping as header when clearing the console - so ended up reusing on each secton in switch
                Console.Clear();
                string title = "BOOTCAMP RESOURCES CHECKOUT SYSTEM";
                Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                Console.WriteLine(title + "\n\n", Console.Title);

                Console.WriteLine("Main Menu");
                Console.WriteLine("1: View Students");
                Console.WriteLine("2: View Available Resources");
                Console.WriteLine("3: View Student Accounts");
                Console.WriteLine("4: Checkout Item");
                Console.WriteLine("5: Return Item");
                Console.WriteLine("6: Exit");






                // 2 static arrays - one with students, one with books - creates a column & row
                // 1 updated array - tells if books are in, or names who the book is assigned to.
                // sorted two static arrays and convert to upper case // start off with all books in

                bool a;
                string[] bookArray = { "Lots Of Programming Stuff", "Even More on C#", "Big Book of C#", "Databases and More", "SQL and You", "Big Book of Outdated Code", "Beginner's Guide to C#", "Beginner's Database Handbook", "C# Player's Guide", "String Comparison Basics" };
                string[] studentArray = { "Jimmy Jones", "Jamie Noel", "Scott Bridges", "Alexander Zill", "Wilford Williams" };
                bookArray = bookArray.Select(s => s.ToUpperInvariant()).ToArray();
                studentArray = studentArray.Select(s => s.ToUpperInvariant()).ToArray();
                Array.Sort(bookArray);
                Array.Sort(studentArray);

                string[] bookStatusAll3 = new string[10];
                string[] bookStatusAll2 = new string[10];
                string[] bookStatusAll1 = new string[10];
                string[] bookStatusAll = new string[10];


                string bookStatus1 = "in";
                string bookStatus2 = "in";
                string bookStatus3 = "in";
                string bookStatus4 = "in";
                string bookStatus5 = "in";
                string bookStatus6 = "in";
                string bookStatus7 = "in";
                string bookStatus8 = "in";
                string bookStatus9 = "in";
                string bookStatus0 = "in";
                string[] studentAccounts = { bookStatus0, bookStatus1, bookStatus2, bookStatus3, bookStatus4, bookStatus5, bookStatus6, bookStatus7, bookStatus8, bookStatus9 };

                int restart2 = 0;
                int booksCheckedOut = 0;
                Console.WriteLine("\n\n\nEnter Menu Item Number");
           
              
                // do while loop to ensure user input is a number 
                do
                {
                   

                    string menuAsString = Console.ReadLine();
                  
                        bool numVer = int.TryParse(menuAsString, out menuItem);
                        if ((menuItem != 0))
                        {
                            break;
                        }
                        if (menuItem == 0)
                        {
                            Console.WriteLine("That is not a valid entry, please enter a number that corresponds to the menu choices above.");
                        }
                    }
                    while (menuItem == 0) ;

                // do while loop to create a temporary aray of books that are "in" - placed in same order as sorted static book array. null assigned to element if book is assigned out.
                do

                {

                    if (studentAccounts[0] == "in")
                    {
                        bookStatusAll[0] = bookArray[0];
                    }
                    else
                    {
                        bookStatusAll[0] = null;
                    }



                    if (studentAccounts[1] == "in")
                    {
                        bookStatusAll[1] = bookArray[1];
                    }
                    else
                    {
                        bookStatusAll[1] = null;
                    }




                    if (studentAccounts[2] == "in")
                    {
                        bookStatusAll[2] = bookArray[2];
                    }
                    else
                    {
                        bookStatusAll[2] = null;
                    }



                    if (studentAccounts[3] == "in")
                    {
                        bookStatusAll[3] = bookArray[3];
                    }
                    else
                    {
                        bookStatusAll[3] = null;
                    }



                    if (studentAccounts[4] == "in")
                    {
                        bookStatusAll[4] = bookArray[4];
                    }
                    else
                    {
                        bookStatusAll[4] = null;
                    }




                    if (studentAccounts[5] == "in")
                    {
                        bookStatusAll[5] = bookArray[5];
                    }
                    else
                    {
                        bookStatusAll[5] = null;
                    }



                    if (studentAccounts[6] == "in")
                    {
                        bookStatusAll[6] = bookArray[6];
                    }
                    else
                    {
                        bookStatusAll[6] = null;
                    }



                    if (studentAccounts[7] == "in")
                    {
                        bookStatusAll[7] = bookArray[7];
                    }
                    else
                    {
                        bookStatusAll[7] = null;
                    }



                    if (studentAccounts[8] == "in")
                    {
                        bookStatusAll[8] = bookArray[8];
                    }
                    else
                    {
                        bookStatusAll[8] = null;
                    }



                    if (studentAccounts[9] == "in")
                    {
                        bookStatusAll[9] = bookArray[9];
                    }
                    else
                    {
                        bookStatusAll[9] = null;
                    }

                    // beginning of switch statement - used for each menu choice

                    switch (menuItem)
                    {
                        // case 1 switch, prints out alphabetical list of students / do while loop to make sure user input is a number & that is not a return

                        case 1: // view students
                            {
                                Console.Clear();
                                title = "BOOTCAMP RESOURCES CHECKOUT SYSTEM";
                                Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                                Console.WriteLine(title + "\n\n", Console.Title);

                                Console.WriteLine("Main Menu");
                                Console.WriteLine("1: View Students");
                                Console.WriteLine("2: View Available Resources");
                                Console.WriteLine("3: View Student Accounts");
                                Console.WriteLine("4: Checkout Item");
                                Console.WriteLine("5: Return Item");
                                Console.WriteLine("6: Exit");


                                Console.WriteLine("\nStudent Names:\n");
                                Array.Sort(studentArray);
                                foreach (string student in studentArray)
                                    Console.WriteLine(student);

                                Console.WriteLine("\n\nWhat would you like to do next? Enter a menu number:");
                                do
                                {

                                    string menuAsString = Console.ReadLine();


                                    bool numVer = int.TryParse(menuAsString, out menuItem);
                                    if ((menuItem != 0))
                                    {
                                        break;
                                    }
                                    if (menuItem == 0)
                                    {
                                        Console.WriteLine("That is not a valid entry, please enter a number that corresponds to the menu choices above.");
                                    }
                                }
                                while (menuItem == 0);

                                if (menuItem == 1)
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }

                       

                            }

                            // case 2 array prints out available resources - prints list from temporary array of books - removes null 
                            // if index of array does not include "in", then all resources are out.
                        case 2: //avail resources
                            Console.Clear();
                            title = "BOOTCAMP RESOURCES CHECKOUT SYSTEM";
                            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                            Console.WriteLine(title + "\n\n", Console.Title);

                            Console.WriteLine("Main Menu");
                            Console.WriteLine("1: View Students");
                            Console.WriteLine("2: View Available Resources");
                            Console.WriteLine("3: View Student Accounts");
                            Console.WriteLine("4: Checkout Item");
                            Console.WriteLine("5: Return Item");
                            Console.WriteLine("6: Exit");



                            Console.WriteLine("\nAvailable Resources:\n");
                            Array.Sort(bookStatusAll);

                            if ((Array.IndexOf(studentAccounts, "in")) == -1)
                            {
                                Console.WriteLine("\n\nAllResources Are Checked Out");
                            }
                            else
                            {

                                foreach (string book in bookStatusAll)
                                    if (book != null)
                                        Console.WriteLine(book);
                            }
                            Console.WriteLine("\n\nWhat would you like to do next? Enter a menu number:");
                            do
                            {

                                string menuAsString = Console.ReadLine();


                                bool numVer = int.TryParse(menuAsString, out menuItem);
                                if ((menuItem != 0))
                                {
                                    break;
                                }
                                if (menuItem == 0)
                                {
                                    Console.WriteLine("That is not a valid entry, please enter a number that corresponds to the menu choices above.");
                                }
                            }
                            while (menuItem == 0);


                            if (menuItem == 2)
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }


                            // create booklist of all items where student account array includes a student name rather than "in" 

                        case 3: // Student Account

                            Console.Clear();
                            title = "BOOTCAMP RESOURCES CHECKOUT SYSTEM";
                            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                            Console.WriteLine(title + "\n\n", Console.Title);

                            Console.WriteLine("Main Menu");
                            Console.WriteLine("1: View Students");
                            Console.WriteLine("2: View Available Resources");
                            Console.WriteLine("3: View Student Accounts");
                            Console.WriteLine("4: Checkout Item");
                            Console.WriteLine("5: Return Item");
                            Console.WriteLine("6: Exit");

                            int restart3 = 0;
                            int nameMatch = 0;
                            int bookMatch = 0;
                            bookStatusAll1 = new string[10];
                            booksCheckedOut = 0;

                            do
                            {

                                Console.WriteLine("\n\nEnter User Name To View Account Information:\n\n");
                                string userNameInput = Console.ReadLine();
                                string userNameInputUpper = userNameInput.ToUpper();
          
                                a = string.IsNullOrWhiteSpace(userNameInput);
                                {
                                    if (a == true)
                                    {
                                        Console.WriteLine("Error: Request Unavailable");

                                        Console.WriteLine("\n\nWhat would you like to do next? Enter a menu number:");
                                        do
                                        {

                                            string menuAsString = Console.ReadLine();


                                            bool numVer = int.TryParse(menuAsString, out menuItem);
                                            if ((menuItem != 0))
                                            {
                                                break;
                                            }
                                            if (menuItem == 0)
                                            {
                                                Console.WriteLine("That is not a valid entry, please enter a number that corresponds to the menu choices above.");
                                            }
                                        }
                                        while (menuItem == 0);

                                        if (menuItem != 0)
                                        {
                                            break;
                                        }

                                    }
                                }


                                if (studentAccounts[0] == userNameInputUpper)
                                {

                                    bookStatusAll1[0] = bookArray[0];
                                }
                                else
                                {
                                    bookStatusAll1[0] = null;

                                }
                                if (studentAccounts[1] == userNameInputUpper)
                                {
                                    bookStatusAll1[1] = bookArray[1];
                                }
                                else
                                {
                                    bookStatusAll1[1] = null;

                                }

                                if (studentAccounts[2] == userNameInputUpper)
                                {
                                    bookStatusAll1[2] = bookArray[2];
                                }
                                else
                                {
                                    bookStatusAll1[2] = null;

                                }
                                if (studentAccounts[3] == userNameInputUpper)
                                {
                                    bookStatusAll1[3] = bookArray[3];
                                }
                                else
                                {
                                    bookStatusAll1[3] = null;

                                }
                                if (studentAccounts[4] == userNameInputUpper)
                                {
                                    bookStatusAll1[4] = bookArray[4];
                                }
                                else
                                {
                                    bookStatusAll1[4] = null;

                                }
                                if (studentAccounts[5] == userNameInputUpper)
                                {
                                    bookStatusAll1[5] = bookArray[5];
                                }
                                else
                                {
                                    bookStatusAll1[5] = null;

                                }
                                if (studentAccounts[6] == userNameInputUpper)
                                {
                                    bookStatusAll1[6] = bookArray[6];
                                }
                                else
                                {
                                    bookStatusAll1[6] = null;

                                }

                                if (studentAccounts[7] == userNameInputUpper)
                                {
                                    bookStatusAll1[7] = bookArray[7];
                                }
                                else
                                {
                                    bookStatusAll1[7] = null;

                                }
                                if (studentAccounts[8] == userNameInputUpper)
                                {
                                    bookStatusAll1[8] = bookArray[8];
                                }
                                else
                                {
                                    bookStatusAll1[8] = null;

                                }

                                if (studentAccounts[9] == userNameInputUpper)
                                {
                                    bookStatusAll1[9] = bookArray[9];
                                }
                                else
                                {
                                    bookStatusAll1[9] = null;

                                }
                             
// for statment to loop through static name list to verify user input matches account

                                for (int students = 0; students < studentArray.Length; students++)
                                {

                                    if (userNameInputUpper == (studentArray[students]))
                                    {
                                        nameMatch++;

                                    }
                                    else
                                        continue;

                                }

// if no match, error - offer menu option

                                if (nameMatch == 0)

                                {
                                    Console.WriteLine("Error: Request Unavailable");
                                    Console.WriteLine("\n\nWhat would you like to do next? Enter a menu number:");
                                    do
                                    {

                                        string menuAsString = Console.ReadLine();


                                        bool numVer = int.TryParse(menuAsString, out menuItem);
                                        if ((menuItem != 0))
                                        {
                                            break;
                                        }
                                        if (menuItem == 0)
                                        {
                                            Console.WriteLine("That is not a valid entry, please enter a number that corresponds to the menu choices above.");
                                        }
                                    }
                                    while (menuItem == 0);

                                    if (menuItem == 1)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }

                                   
                                }

                                else
                                {
  
// loop through array to determine if student name appears in the stuent account array 
                                    for (int booksOut = 0; booksOut < studentAccounts.Length; booksOut++)
                                    {
                                        if (userNameInputUpper == (studentAccounts[booksOut]))
                                        {

                                            booksCheckedOut++;

                                        }
                                        else
                                            continue;
                                    }
                   // if no books checked out, tell user & give menu option
                                    if (booksCheckedOut == 0)
                                    {
                                        Console.WriteLine("\n\nYou Have No Books Checked Out");
                                        Console.WriteLine("\n\nWhat would you like to do next? Enter a menu number:");
                                        do
                                        {

                                            string menuAsString = Console.ReadLine();


                                            bool numVer = int.TryParse(menuAsString, out menuItem);
                                            if ((menuItem != 0))
                                            {
                                                break;
                                            }
                                            if (menuItem == 0)
                                            {
                                                Console.WriteLine("That is not a valid entry, please enter a number that corresponds to the menu choices above.");
                                                continue;
                                            }
                                        }
                                        while (menuItem == 0);

                                        {
                                            break;
                                        }

                                        menuItem = int.Parse(Console.ReadLine());
                                        restart3 = 1;
                           
                                    }
// if books cheked out, print them from temporary array & give menu options

                                    else if (booksCheckedOut >= 0)
                                    {
                                        Array.Sort(bookStatusAll1);
                                        Console.WriteLine("\n\nChecked Out Books:\n");


                                        foreach (string book in bookStatusAll1)
                                            if (book != null) Console.WriteLine(book);
                                        {

                                            Console.WriteLine("\n\nWhat would you like to do next? Enter a menu number:");
                                            do
                                            {

                                                string menuAsString = Console.ReadLine();


                                                bool numVer = int.TryParse(menuAsString, out menuItem);
                                                if ((menuItem != 0))
                                                {
                                                    break;
                                                }
                                                if (menuItem == 0)
                                                {
                                                    Console.WriteLine("That is not a valid entry, please enter a number that corresponds to the menu choices above.");
                                                }
                                            }
                                            while (menuItem == 0);

                                            {
                                                break;
                                            }


                                            //menuItem = int.Parse(Console.ReadLine());


                                            //restart3 = 1;

                                        }

                                    }   
                               
                                }
                            }
                            while (restart3 == 0);
                            break;

// checkout - verify user input matches student name / create temporary arrays - one with all books identified as "in" - one with all books identified as having been assigned to student


                        case 4: // CHECKOUT

                            Console.Clear();
                            title = "BOOTCAMP RESOURCES CHECKOUT SYSTEM";
                            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                            Console.WriteLine(title + "\n\n", Console.Title);

                            Console.WriteLine("Main Menu");
                            Console.WriteLine("1: View Students");
                            Console.WriteLine("2: View Available Resources");
                            Console.WriteLine("3: View Student Accounts");
                            Console.WriteLine("4: Checkout Item");
                            Console.WriteLine("5: Return Item");
                            Console.WriteLine("6: Exit");

                            int restart4 = 0;
                            nameMatch = 0;
                            bookMatch = 0;
                            bookStatusAll2 = new string[10];
                            bookStatusAll3 = new string[10];


                            do
                            {
                                booksCheckedOut = 0;
                                bookStatusAll2 = new string[10];
                                bookStatusAll3 = new string[10];


                                Console.WriteLine("\n\nEnter User Name To Begin Checkout:\n\n");
                                string userNameInput = Console.ReadLine();
                                string userNameInputUpper = userNameInput.ToUpper();


                                a = string.IsNullOrWhiteSpace(userNameInput);
                                {
                                    if (a == true)
                                    {
                                        Console.WriteLine("Error: Request Unavailable");

                                        Console.WriteLine("\n\nWhat would you like to do next? Enter a menu number:");
                                        do
                                        {

                                            string menuAsString = Console.ReadLine();


                                            bool numVer = int.TryParse(menuAsString, out menuItem);
                                            if ((menuItem != 0))
                                            {
                                                break;
                                            }
                                            if (menuItem == 0)
                                            {
                                                Console.WriteLine("That is not a valid entry, please enter a number that corresponds to the menu choices above.");
                                            }
                                        }
                                        while (menuItem == 0);

                                        if (menuItem != 0)
                                        {
                                            break;
                                        }

                                    }
                                }

                                    {
                                        if (studentAccounts[0] == userNameInputUpper)
                                        {

                                            bookStatusAll3[0] = bookArray[0];
                                            bookStatusAll2[0] = null;
                                        }
                                        else
                                        {
                                            bookStatusAll3[0] = null;
                                            bookStatusAll2[0] = bookArray[0];
                                        }


                                        if (studentAccounts[1] == userNameInputUpper)
                                        {

                                            bookStatusAll3[1] = bookArray[1];
                                            bookStatusAll2[1] = null;
                                        }
                                        else
                                        {
                                            bookStatusAll3[1] = null;
                                            bookStatusAll2[1] = bookArray[1];
                                        }


                                        if (studentAccounts[2] == userNameInputUpper)
                                        {

                                            bookStatusAll3[2] = bookArray[2];
                                            bookStatusAll2[2] = null;
                                        }
                                        else
                                        {
                                            bookStatusAll3[2] = null;
                                            bookStatusAll2[2] = bookArray[2];
                                        }


                                        if (studentAccounts[3] == userNameInputUpper)
                                        {

                                            bookStatusAll3[3] = bookArray[3];
                                            bookStatusAll2[3] = null;
                                        }
                                        else
                                        {
                                            bookStatusAll3[3] = null;
                                            bookStatusAll2[3] = bookArray[3];
                                        }

                                        if (studentAccounts[4] == userNameInputUpper)
                                        {

                                            bookStatusAll3[4] = bookArray[4];
                                            bookStatusAll2[4] = null;
                                        }
                                        else
                                        {
                                            bookStatusAll3[4] = null;
                                            bookStatusAll2[4] = bookArray[4];
                                        }

                                        if (studentAccounts[5] == userNameInputUpper)
                                        {

                                            bookStatusAll3[5] = bookArray[5];
                                            bookStatusAll2[5] = null;
                                        }
                                        else
                                        {
                                            bookStatusAll3[5] = null;
                                            bookStatusAll2[5] = bookArray[5];
                                        }

                                        if (studentAccounts[6] == userNameInputUpper)
                                        {

                                            bookStatusAll3[6] = bookArray[6];
                                            bookStatusAll2[6] = null;
                                        }
                                        else
                                        {
                                            bookStatusAll3[6] = null;
                                            bookStatusAll2[6] = bookArray[6];
                                        }

                                        if (studentAccounts[7] == userNameInputUpper)
                                        {

                                            bookStatusAll3[7] = bookArray[7];
                                            bookStatusAll2[7] = null;
                                        }
                                        else
                                        {
                                            bookStatusAll3[7] = null;
                                            bookStatusAll2[7] = bookArray[7];
                                        }

                                        if (studentAccounts[8] == userNameInputUpper)
                                        {

                                            bookStatusAll3[8] = bookArray[8];
                                            bookStatusAll2[8] = null;
                                        }
                                        else
                                        {
                                            bookStatusAll3[8] = null;
                                            bookStatusAll2[8] = bookArray[8];
                                        }

                                        if (studentAccounts[9] == userNameInputUpper)
                                        {

                                            bookStatusAll3[9] = bookArray[9];
                                            bookStatusAll2[9] = null;
                                        }
                                        else
                                        {
                                            bookStatusAll3[9] = null;
                                            bookStatusAll2[9] = bookArray[9];
                                        }

                                    }
// loop through student list to make sure user input matches

                                for (int students = 0; students < studentArray.Length; students++)
                                {

                                    if (userNameInputUpper == (studentArray[students]))
                                    {
                                        nameMatch++;
                                        break;           
                                    }
                                    else
                                        continue;

                                }

                                if (nameMatch == 0)

                                {

                                    Console.WriteLine("Error: Request Unavailable");
                                    Console.WriteLine("\n\nWhat would you like to do next? Enter a menu number:");
                                    string menuAsString = Console.ReadLine();
                                    do
                                    {


                                        bool numVer = int.TryParse(menuAsString, out menuItem);
                                        if ((menuItem != 0))
                                        {

                                            break;
                                        }
                                        if (menuItem == 0)
                                        {
                                            Console.WriteLine("That is not a valid entry, please enter a number that corresponds to the menu choices above.");
                                            menuAsString = Console.ReadLine();
                                        }
                                    }
                                    while (menuItem == 0);

                                    if (menuItem != 0)
                                    {
                                        break;
                                    }

                                }
// if name matches, loop through student accounts to sum the total times a name is included in the array - if 3x, max number of books taken out

                                if (nameMatch != 0)
                                {
                                    for (int booksOut = 0; booksOut < studentAccounts.Length; booksOut++)
                                    {


                                        if (userNameInputUpper == (studentAccounts[booksOut]))
                                        {
                                            booksCheckedOut++;
                         
                                        }
                                        else
                                            continue;
                                    }

                                    if (booksCheckedOut >= 3)
                                    {
                                        Console.WriteLine("\n\n" + userNameInput + " has checked out the max number of resources");
                                        Console.WriteLine("\n\nWhat would you like to do next? Enter a menu number:");
                                        do
                                        {

                                            string menuAsString = Console.ReadLine();


                                            bool numVer = int.TryParse(menuAsString, out menuItem);
                                            if ((menuItem != 0))
                                            {
                                                break;
                                            }
                                            if (menuItem == 0)
                                            {
                                                Console.WriteLine("That is not a valid entry, please enter a number that corresponds to the menu choices above.");
                                            }
                                        }
                                        while (menuItem == 0);


                                        {
                                            break;
                                        }

                                        menuItem = int.Parse(Console.ReadLine());

                                        {
                                            break;
                                        }

                                    }

// if less than three - index of array to make sure at least one book is "in"

                                    else if (booksCheckedOut < 3)
                                    {
                                        Array.Sort(bookStatusAll2);

                                        if ((Array.IndexOf(studentAccounts, "in")) == -1)
                                        {
                                            Console.WriteLine("\n\nAllResources Are Currently Checked Out");
                                        }
// else, print a list of available resources for user to choose from
                                        else
                                        {

                                            Console.WriteLine("\n\nWhat book from Available Resources Would You Like to Check Out?\n");
                                            Console.WriteLine("Available Resources:\n");

                                            foreach (string book in bookStatusAll)
                                            {
                                                if (book != null)

                                                    Console.WriteLine(book);
                                            }
// compare user input of book choice against book array to make sure it is available
                                            Console.WriteLine("\n\nChoose A Book To CheckOut");
                                            string checkoutItem = Console.ReadLine();
                                            string checkoutItemUpper = checkoutItem.ToUpper();
                                            int checkoutInt = 0;

                                               
                                            {
                                                for (int i = 0; i < bookArray.Length; i++)
                                                    if (checkoutItemUpper == bookStatusAll[i])
                                   
                                                {
                                                    checkoutInt++;
                                                }
                                                else
                                                {
                                                    continue;
                                                }
                                            }

// if book is available - change from "in" to sudent name in student account array - use index of array to make sure assigning to the correct position - give menu options
                                            if (checkoutInt > 0)
                                            {
                                                int bookArrayIndex = Array.IndexOf(bookArray, checkoutItemUpper);

                                                studentAccounts[bookArrayIndex] = userNameInputUpper;

                                                Console.WriteLine("\n\n" + userNameInput + " has checked out " + checkoutItem);
                                               
                                            }
                                        else

                                            Console.WriteLine("Error: Request Unavailable");
                                            Console.WriteLine("\n\nWhat would you like to do next? Enter a menu number:");
                                            string menuAsString = Console.ReadLine();
                                            do
                                            {


                                                bool numVer = int.TryParse(menuAsString, out menuItem);
                                                if ((menuItem != 0))
                                                {

                                                    break;
                                                }
                                                if (menuItem == 0)
                                                {
                                                    Console.WriteLine("That is not a valid entry, please enter a number that corresponds to the menu choices above.");
                                                    menuAsString = Console.ReadLine();
                                                }
                                            }
                                            while (menuItem == 0);

                                            if (menuItem != 0)
                                            {
                                                break;
                                            }
                                        }


                                        }
                                        Console.WriteLine("\n\nWhat would you like to do next? Enter a menu number:");
                                    do
                                    {

                                        string menuAsString = Console.ReadLine();


                                        bool numVer = int.TryParse(menuAsString, out menuItem);
                                        if ((menuItem != 0))
                                        {
                                            break;
                                        }
                                        if (menuItem == 0)
                                        {
                                            Console.WriteLine("That is not a valid entry, please enter a number that corresponds to the menu choices above.");
                                        }
                                    }
                                    while (menuItem == 0);

                                    {
                                        break;
                                    }

                                    menuItem = int.Parse(Console.ReadLine());
   
                                    {
                                    Console.WriteLine("\n\nWhat would you like to do next? Enter a menu number:");
                                        do
                                        {

                                            string menuAsString = Console.ReadLine();


                                            bool numVer = int.TryParse(menuAsString, out menuItem);
                                            if ((menuItem != 0))
                                            {
                                                break;
                                            }
                                            if (menuItem == 0)
                                            {
                                                Console.WriteLine("That is not a valid entry, please enter the a number that corresponds to the menu choices above.");
                                            }
                                        }
                                        while (menuItem == 0);

                                        if (menuItem == 1)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            break;
                                        }

                                        menuItem = int.Parse(Console.ReadLine());

                                        break;
                                    }
                                }

                            }
                            while (restart4 == 0);
                            break;

// return book - use same temporary tables as checkout to create 2 lists os books - one "in", the other assigned out
                        case 5: // RETURN

                            Console.Clear();
                            title = "BOOTCAMP RESOURCES CHECKOUT SYSTEM";
                            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                            Console.WriteLine(title + "\n\n", Console.Title);

                            Console.WriteLine("Main Menu");
                            Console.WriteLine("1: View Students");
                            Console.WriteLine("2: View Available Resources");
                            Console.WriteLine("3: View Student Accounts");
                            Console.WriteLine("4: Checkout Item");
                            Console.WriteLine("5: Return Item");
                            Console.WriteLine("6: Exit");

                            int restart5 = 0;
                            nameMatch = 0;
                            bookMatch = 0;
                            bookStatusAll2 = new string[10];
                            bookStatusAll3 = new string[10];


                            do
                            {
                                booksCheckedOut = 0;
                                bookStatusAll2 = new string[10];
                                bookStatusAll3 = new string[10];


                                Console.WriteLine("\n\nEnter User Name To Begin Checkout:\n\n");
                                string userNameInput = Console.ReadLine();
                                string userNameInputUpper = userNameInput.ToUpper();


                                a = string.IsNullOrWhiteSpace(userNameInput);
                                {
                                    if (a == true)
                                    {
                                        Console.WriteLine("Error: Request Unavailable");

                                        Console.WriteLine("\n\nWhat would you like to do next? Enter a menu number:");
                                        do
                                        {

                                            string menuAsString = Console.ReadLine();


                                            bool numVer = int.TryParse(menuAsString, out menuItem);
                                            if ((menuItem != 0))
                                            {
                                                break;
                                            }
                                            if (menuItem == 0)
                                            {
                                                Console.WriteLine("That is not a valid entry, please enter a number that corresponds to the menu choices above.");
                                            }
                                        }
                                        while (menuItem == 0);

                                        if (menuItem != 0)
                                        {
                                            break;
                                        }

                                    }
                                }

                                {

                                    if (studentAccounts[0] == userNameInputUpper)
                                    {

                                        bookStatusAll3[0] = bookArray[0];
                                        bookStatusAll2[0] = null;
                                    }
                                    else
                                    {
                                        bookStatusAll3[0] = null;
                                        bookStatusAll2[0] = bookArray[0];
                                    }


                                    if (studentAccounts[1] == userNameInputUpper)
                                    {

                                        bookStatusAll3[1] = bookArray[1];
                                        bookStatusAll2[1] = null;
                                    }
                                    else
                                    {
                                        bookStatusAll3[1] = null;
                                        bookStatusAll2[1] = bookArray[1];
                                    }


                                    if (studentAccounts[2] == userNameInputUpper)
                                    {

                                        bookStatusAll3[2] = bookArray[2];
                                        bookStatusAll2[2] = null;
                                    }
                                    else
                                    {
                                        bookStatusAll3[2] = null;
                                        bookStatusAll2[2] = bookArray[2];
                                    }


                                    if (studentAccounts[3] == userNameInputUpper)
                                    {

                                        bookStatusAll3[3] = bookArray[3];
                                        bookStatusAll2[3] = null;
                                    }
                                    else
                                    {
                                        bookStatusAll3[3] = null;
                                        bookStatusAll2[3] = bookArray[3];
                                    }

                                    if (studentAccounts[4] == userNameInputUpper)
                                    {

                                        bookStatusAll3[4] = bookArray[4];
                                        bookStatusAll2[4] = null;
                                    }
                                    else
                                    {
                                        bookStatusAll3[4] = null;
                                        bookStatusAll2[4] = bookArray[4];
                                    }

                                    if (studentAccounts[5] == userNameInputUpper)
                                    {

                                        bookStatusAll3[5] = bookArray[5];
                                        bookStatusAll2[5] = null;
                                    }
                                    else
                                    {
                                        bookStatusAll3[5] = null;
                                        bookStatusAll2[5] = bookArray[5];
                                    }

                                    if (studentAccounts[6] == userNameInputUpper)
                                    {

                                        bookStatusAll3[6] = bookArray[6];
                                        bookStatusAll2[6] = null;
                                    }
                                    else
                                    {
                                        bookStatusAll3[6] = null;
                                        bookStatusAll2[6] = bookArray[6];
                                    }

                                    if (studentAccounts[7] == userNameInputUpper)
                                    {

                                        bookStatusAll3[7] = bookArray[7];
                                        bookStatusAll2[7] = null;
                                    }
                                    else
                                    {
                                        bookStatusAll3[7] = null;
                                        bookStatusAll2[7] = bookArray[7];
                                    }

                                    if (studentAccounts[8] == userNameInputUpper)
                                    {

                                        bookStatusAll3[8] = bookArray[8];
                                        bookStatusAll2[8] = null;
                                    }
                                    else
                                    {
                                        bookStatusAll3[8] = null;
                                        bookStatusAll2[8] = bookArray[8];
                                    }

                                    if (studentAccounts[9] == userNameInputUpper)
                                    {

                                        bookStatusAll3[9] = bookArray[9];
                                        bookStatusAll2[9] = null;
                                    }
                                    else
                                    {
                                        bookStatusAll3[9] = null;
                                        bookStatusAll2[9] = bookArray[9];
                                    }

                                }

  // use loops to run through arrays and make sure name & title matches
                                for (int students = 0; students < studentArray.Length; students++)
                                {

                                    if (userNameInputUpper == (studentArray[students]))
                                    {
                                        nameMatch++;
                                        break;
                                    }
                                    else
                                        continue;

                                }

                                if (nameMatch == 0)

                                {

                                    Console.WriteLine("Error: Request Unavailable");
                                    Console.WriteLine("\n\nWhat would you like to do next? Enter a menu number:");
                                    string menuAsString = Console.ReadLine();
                                    do
                                    {


                                        bool numVer = int.TryParse(menuAsString, out menuItem);
                                        if ((menuItem != 0))
                                        {

                                            break;
                                        }
                                        if (menuItem == 0)
                                        {
                                            Console.WriteLine("That is not a valid entry, please enter a number that corresponds to the menu choices above.");
                                            menuAsString = Console.ReadLine();
                                        }
                                    }
                                    while (menuItem == 0);

                                    if (menuItem != 0)
                                    {
                                        break;
                                    }

                                }

                                if (nameMatch != 0)
                                {
                                    for (int booksOut = 0; booksOut < studentAccounts.Length; booksOut++)
                                    {


                                        if (userNameInputUpper == (studentAccounts[booksOut]))
                                        {
                                            booksCheckedOut++;

                                        }
                                        else
                                            continue;
                                    }
// if no occurance of name in student accounts array - tell user that no books are checked out
                                    if (booksCheckedOut == 0)
                                    {
                                        Console.WriteLine("\n\n" + userNameInput + " has no books checked out\n\n");
                                        Console.WriteLine("\n\nWhat would you like to do next? Enter a menu number:");
                                        do
                                        {

                                            string menuAsString = Console.ReadLine();


                                            bool numVer = int.TryParse(menuAsString, out menuItem);
                                            if ((menuItem != 0))
                                            {
                                                break;
                                            }
                                            if (menuItem == 0)
                                            {
                                                Console.WriteLine("That is not a valid entry, please enter a number that corresponds to the menu choices above.");
                                            }
                                        }
                                        while (menuItem == 0);


                                        {
                                            break;
                                        }

                                        menuItem = int.Parse(Console.ReadLine());

                                        {
                                            break;
                                        }

                                    }

                                    else if (booksCheckedOut > 0)
                                    {
      // verify title of book to be checked out - provide a list of available options
                              
                                        Console.WriteLine("\n\nWhat Book Would You Like to Check In?\n");
                                        Console.WriteLine("Books You Have Checked Out:");

                                        foreach (string book in bookStatusAll3)
                                        {
                                            if (book != null)

                                                Console.WriteLine(book);
                                        }
                                        Console.WriteLine("\n\nChoose A Book To CheckIn");
                                        string checkoutItem = Console.ReadLine();
                                        string checkoutItemUpper = checkoutItem.ToUpper();
                                        int checkoutInt = 0;


                                        {
                                            for (int i = 0; i < bookArray.Length; i++)
                                                if (checkoutItemUpper == bookStatusAll3[i])

                                                {
                                                    checkoutInt++;
                                                }
                                                else
                                                {
                                                    continue;
                                                }
                                        }
                   // change status in student accounts table back to "in" & tell user the book has been checked back in

                                        if (checkoutInt > 0)
                                        {
                                            int bookArrayIndex = Array.IndexOf(bookArray, checkoutItemUpper);

                                            studentAccounts[bookArrayIndex] = "in";

                                            Console.WriteLine("\n\n" + userNameInput + " has checked in " + checkoutItem);

                                        }
                                        else

                                        Console.WriteLine("Error: Request Unavailable");
                                        Console.WriteLine("\n\nWhat would you like to do next? Enter a menu number:");
                                        string menuAsString = Console.ReadLine();
                                        do
                                        {


                                            bool numVer = int.TryParse(menuAsString, out menuItem);
                                            if ((menuItem != 0))
                                            {

                                                break;
                                            }
                                            if (menuItem == 0)
                                            {
                                                Console.WriteLine("That is not a valid entry, please enter a number that corresponds to the menu choices above.");
                                                menuAsString = Console.ReadLine();
                                            }
                                        }
                                        while (menuItem == 0);

                                        if (menuItem != 0)
                                        {
                                            break;
                                        }
                                      


                                    }
                                    Console.WriteLine("\n\nWhat would you like to do next? Enter a menu number:");
                                    do
                                    {

                                        string menuAsString = Console.ReadLine();


                                        bool numVer = int.TryParse(menuAsString, out menuItem);
                                        if ((menuItem != 0))
                                        {
                                            break;
                                        }
                                        if (menuItem == 0)
                                        {
                                            Console.WriteLine("That is not a valid entry, please enter a number that corresponds to the menu choices above.");
                                        }
                                    }
                                    while (menuItem == 0);


                                    {
                                        break;
                                    }

                                    menuItem = int.Parse(Console.ReadLine());

                                    {

                                        {

                                        }
                                        Console.WriteLine("\n\nWhat would you like to do next? Enter a menu number:");
                                        do
                                        {

                                            string menuAsString = Console.ReadLine();


                                            bool numVer = int.TryParse(menuAsString, out menuItem);
                                            if ((menuItem != 0))
                                            {
                                                break;
                                            }
                                            if (menuItem == 0)
                                            {
                                                Console.WriteLine("That is not a valid entry, please enter the a number that corresponds to the menu choices above.");
                                            }
                                        }
                                        while (menuItem == 0);

                                        if (menuItem == 1)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            break;
                                        }

                                        menuItem = int.Parse(Console.ReadLine());

                                        break;
                                    }
                                }
                                }
                                while (restart5 == 0) ;
                                break;
// provide option for exit & restart in case chosen in error

                        case 6: //EXIT
                            {

                                Console.WriteLine("Are you sure you want to exit? \nPress \"N\" to restart program\nPress any other key to exit");
                                //     restart = 1;



                                var restartAsString = Console.ReadLine();
                          

                                    if (restartAsString.Equals("n", StringComparison.CurrentCultureIgnoreCase))
                                    {
                                        restart2 = 1;
                                    }
                                    else
                                    {

                                    Console.WriteLine("Goodbye");

                                    Environment.Exit(0);
                                    }
                                break;
                            }
                        default:
                            {
                                    Console.WriteLine("That is not a valid entry, please enter a number between 1 and 6");
                                    break;
                                }
                            }
                    }
                    while (restart2 == 0) ;
            
              
            } while(restart == 0);


       
        }
    }
}
