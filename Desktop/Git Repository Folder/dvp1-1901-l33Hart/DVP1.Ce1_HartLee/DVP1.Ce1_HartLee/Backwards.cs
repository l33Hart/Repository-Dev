using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.Ce1_HartLee
{// Name: Lee Hart
 // Date: JAN 2019 
 // Course: Project & Portfolio 1  
 // Synopsis: This reverses the sentence and is consiered the backward challenge
    class Backwards
    {

        public static void BackwardsProg()
        {
            Menu.MenuDisplay();
            Console.WriteLine("Welcome to my Backwards Challenge");
            Console.WriteLine("Please enter a sentence with at least six words.");
            string forwardSentence;

            forwardSentence = Console.ReadLine();

            string[] sentenceTestArray = forwardSentence.Split(' ');

            while (sentenceTestArray.Length < 6)
            {
                Console.WriteLine("Please enter a sentence with at least six words");
                forwardSentence = Console.ReadLine();
                sentenceTestArray = forwardSentence.Split(' ');

            }
            string backwardsSenten = Backwards.BackwardsSent(forwardSentence);
            Console.WriteLine(backwardsSenten);
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


        public static string BackwardsSent(string forwardsentence)
        { 
            char[] forwardSentenceArray = forwardsentence.ToCharArray();
            string backwardSentence = "";
            for (int i = forwardSentenceArray.Length - 1; i >= 0; i--)
            {

                backwardSentence += forwardSentenceArray[i];
            }
            
            
            return backwardSentence;
        }

    }
}
           
            


        
