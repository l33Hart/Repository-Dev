using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.Ce1_HartLee
{// Name: Lee Hart
 // Date: JAN 2019 
 // Course: Project & Portfolio 1  
 // Synopsis: This program runs the blue fish challenge 
    class BigBlueFish
    {
        public static void FishStart()
        {
            Menu.MenuDisplay();
            Console.WriteLine("Welcome to my Big Blue Fish Challenge");
            string[] BigFishColors = { "red", "blue", "blue", "red", "orange", "green", "orange", "green", "blue", "red", "orange", "green" };
            double[] FishSizes = { 12.34, 18.43, 19.45, 14.45, 18.97, 19.57, 20.66, 17.89, 16.44, 15.99, 19.50, 18.05 };
            Console.WriteLine("We are going to find the biggest fish by color \r\nSelect a color.\r\n Press 1 for Red\r\n Press 2 for Blue\r\n Press 3 for Orange\r\n Press 4 for Green.");
            string selection = Console.ReadLine();
            int selectInt;
            int.TryParse(selection, out selectInt);
            while (!(int.TryParse(selection, out selectInt) || (selectInt > 4)))
            {
                Console.WriteLine("Please enter a valid fish color selection.\r\nSelect a color.\r\n Press 1 for Red\r\n Press 2 for Blue\r\n Press 3 for Orange\r\n Press 4 for Green.");
                selection = Console.ReadLine();
                int.TryParse(selection, out selectInt);
            }

            string results = BigBlueFish.FishFinder(FishSizes, BigFishColors, selectInt);
            Console.WriteLine("The fish you selected is the " + results);
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

        public static string FishFinder(double[] fishSize, string[] fishColor, int Select)
        {
            string SelectColor = "";
            double BigFish = 0;
            double LittleFish = 10000000;
            if (Select == 1)
            {
                for (int i = 0; i < fishColor.Length; i++)
                {
                    if ((fishColor[i] == "red") && (BigFish < fishSize[i]))
                    {
                        BigFish = fishSize[i];
                        SelectColor = "red";
                    }
                    else if (fishSize[i] < LittleFish)
                    {
                        LittleFish = fishSize[i];
                    }
                    
                }

            }
            else if (Select == 2)
            {
                {
                    for (int i = 0; i < fishColor.Length; i++)
                    {
                        if ((fishColor[i] == "blue") && (BigFish < fishSize[i]))
                        {
                            BigFish = fishSize[i];
                            SelectColor = "blue";
                        }
                        else if ((fishColor[i] == "blue")&&(fishSize[i] < LittleFish))
                        {
                            LittleFish = fishSize[i];
                        }
                        
                    }

                }

            }
            else if (Select == 3)
            {

                for (int i = 0; i < fishColor.Length; i++)
                {
                    if ((fishColor[i] == "orange") && (BigFish < fishSize[i]))
                    {
                        BigFish = fishSize[i];
                        SelectColor = "orange";

                    }
                    else if ((fishColor[i] == "orange")&&(fishSize[i] < LittleFish))
                    {
                        LittleFish = fishSize[i];
                    }
                }

               

            }
            else
            {
                
                    for (int i = 0; i < fishColor.Length; i++)
                    {
                        if ((fishColor[i] == "green") && (BigFish < fishSize[i]))
                        {
                            BigFish = fishSize[i];
                        SelectColor = "green";
                        }
                    else if ((fishSize[i] < LittleFish)&& (fishColor[i] == "green"))
                    {
                        LittleFish = fishSize[i];
                    }
                }

                

            }
            SelectColor += " and it is ";
            SelectColor += (BigFish.ToString() + " long" + " The smallest fish was " + LittleFish.ToString());
            return SelectColor;
        }






           


        }



    }
