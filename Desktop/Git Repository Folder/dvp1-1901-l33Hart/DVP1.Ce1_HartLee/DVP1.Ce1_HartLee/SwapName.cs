using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.Ce1_HartLee
{// Name: Lee Hart
 // Date: JAN 2019 
 // Course: Project & Portfolio 1  
 // Synopsis: This is the code that preforms swap name
    class SwapName
    {
        public static void SwapStart()
        {
            Menu.MenuDisplay();
            Console.WriteLine("Welcome to my Swap Name Challenge");
            Console.WriteLine("Please Enter your First name");
            string firstName;
            string lastName;
            decimal testDec;
            firstName = Console.ReadLine();

            string[] nameArrayTest = firstName.Split(' ');


            while (nameArrayTest.Length > 1) ;
            {
                Console.WriteLine("Only enter your first name");

                firstName = Console.ReadLine();

                nameArrayTest = firstName.Split(' ');
            }
            while (firstName == "")
            {
                Console.WriteLine("Only enter your first name");

                firstName = Console.ReadLine();
            }
            for (int i = 0; i < firstName.ToCharArray().Length; i++)
            {
                char[] test;
                test = firstName.ToCharArray();

                if (decimal.TryParse(test[i].ToString(), out testDec))
                {
                    Console.WriteLine("Please do not enter numbers, Please Re enter your First Name");
                    firstName = Console.ReadLine();

                }
                test = firstName.ToCharArray();

            }

            Console.WriteLine("Thank you {0} Please Enter your Last name", firstName);
            lastName = Console.ReadLine();
            nameArrayTest = lastName.Split(' ');

            while (nameArrayTest.Length > 1)
            {
                Console.WriteLine("Only enter your Last name");
                lastName = Console.ReadLine();
                nameArrayTest = lastName.Split(' ');
            }
            while (lastName == "")
            {
                Console.WriteLine("Only enter your last name");
                lastName = Console.ReadLine();
            }
            for (int i = 0; i < lastName.ToCharArray().Length; i++)
            {
                char[] test;
                test = lastName.ToCharArray();

                while (decimal.TryParse(test[i].ToString(), out testDec))
                {
                    Console.WriteLine("Please do not enter numbers, Please Re enter your last Name");
                    firstName = Console.ReadLine();

                }
                test = firstName.ToCharArray();

            }
            string name = firstName + " " + lastName;
            string swapName = SwapName.SwapNames(firstName, lastName);
            Console.WriteLine("Your Name is {0} and if we were to swap your first and last name, your name would be {1}", name, swapName);

            int selectionInt = Menu.MenuSelect();

            {

                if (selectionInt == 1)
                {
                    SwapName.SwapStart();
                }
                else if (selectionInt == 2)
                {
                    Backwards.BackwardsProg();

                }
                else if (selectionInt == 3)
                {

                    AgeConvert.AgeConvertProg();
                }
                else if (selectionInt == 4)
                {
                    TempConvert.TempStart();
                }
                else
                {
                    BigBlueFish.FishStart();
                }

            }

        }

        public static string SwapNames(string first, string last)
        {
            string nameSwap = last + " " + first;
            return nameSwap;
        }
    }
}


    

