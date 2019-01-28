using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.Ce1_HartLee
{
    class Menu
    {// Name: Lee Hart
     // Date: JAN 2019 
     // Course: Project & Portfolio 1  
     // Synopsis: Tthis is the display and selection to select the game


        public static void MenuDisplay()
        {


            Console.WriteLine("__   __  ____ __    __   ______");
            Console.WriteLine("| |  | | | __|| |   | |  |     |");
            Console.WriteLine("| |__| | | |_ | |   | |  |  _  |");
            Console.WriteLine("|  __  | |  _|| |   | |  | [ ] |");
            Console.WriteLine("| |  | | | |_ | |__ | |__|  -  |");
            Console.WriteLine("|_|  |_| |___||____||____|_____|");
      

        }
        public static int MenuSelect()
        {
            Console.WriteLine("Welcome to my Coding Challenge");
            Console.WriteLine("This is the Menu");
            string selection;
            Console.WriteLine("Please Make your Selection");
            Console.WriteLine("[1] Swap Name \r\n[2] Backwards\r\n[3] Age Convert\r\n[4] Temp Convert\r\n[5] Big Blue Fish ");
            selection = Console.ReadLine();
            int selectionInt;
            int.TryParse(selection, out selectionInt);
            while ((selectionInt >= 6 || selectionInt <= 0) || !(int.TryParse(selection, out selectionInt)))
            {
                Console.WriteLine("Please Enter a valid selection");
                selection = Console.ReadLine();
                int.TryParse(selection, out selectionInt);
            }
            return (selectionInt);
         
        }
    }
}
