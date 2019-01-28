using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.Ce1_HartLee
{

    class Program
    {// Name: Lee Hart
     // Date: JAN 2019 
     // Course: Project & Portfolio 1  
     // Synopsis: This starts the program



        static void Main(string[] args)
        {//test commit



            Menu.MenuDisplay();


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
    }
}

