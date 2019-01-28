using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.Ce1_HartLee
{// Name: Lee Hart
 // Date: JAN 2019 
 // Course: Project & Portfolio 1  
 // Synopsis: This converts tempature
    class TempConvert
    {
        public static void TempStart()
        {
            Menu.MenuDisplay();
            Console.WriteLine("Welcome to my Temp Converter Challenge");
            Console.WriteLine(" Please select, type of tempature measurement you would like to convert\r\n Kelvin Enter 1\r\n Celcius Enter 2\r\n Farenheight Enter 3");
            string Selection = Console.ReadLine();
            int SelectInt;
            int.TryParse(Selection, out SelectInt);

            while (((SelectInt <= 0) || (SelectInt > 3)) || (!(int.TryParse(Selection, out SelectInt))))

            {
                Console.WriteLine("Please make a valid selection. \r\n 1 for Kelvin\r\n 2 for Celcius \r\n 3 for Farenheight ");
                Selection = Console.ReadLine();
                int.TryParse(Selection, out SelectInt);
            }
            if (SelectInt == 1)
            {
                Console.WriteLine("Please enter the Temp in Kelvins you are wanting to convert. ");
                double kelvins;
                string kelvinString;
                kelvinString = Console.ReadLine();
                while (!(double.TryParse(kelvinString, out kelvins)))
                {
                    Console.WriteLine("Please enter a valid Temp in Kelvins you are wanting to convert. ");
                    kelvinString = Console.ReadLine();
                }
                string Answer = TempConvert.TempConverter(kelvins, SelectInt);
                Console.WriteLine(Answer);

            }
            else if (SelectInt == 2)
            {
                Console.WriteLine("Please enter the Temp in Celcius you are wanting to convert. ");
                double celcius;
                string celciusString;
                celciusString = Console.ReadLine();
                while (!(double.TryParse(celciusString, out celcius)))
                {
                    Console.WriteLine("Please enter a valid Temp in Celcius you are wanting to convert. ");
                    celciusString = Console.ReadLine();
                }
                string Answer = TempConvert.TempConverter(celcius, SelectInt);
                Console.WriteLine(Answer);
            }
            else
            {
                Console.WriteLine("Please enter the Temp in Farenheit you are wanting to convert. ");
                double farenheit;
                string farenheitString;
                farenheitString = Console.ReadLine();
                while (!(double.TryParse(farenheitString, out farenheit)))
                {
                    Console.WriteLine("Please enter a valid Temp in farenheit you are wanting to convert. ");
                    farenheitString = Console.ReadLine();
                }
                string Answer = "Your convertered temp is " + TempConvert.TempConverter(farenheit, SelectInt);
                Console.WriteLine(Answer);


            }

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



        public static string TempConverter(double t, int select)
        {

            string Kelvin;
            double K;
            double F;
            double C;

            if (select == 1)
            {
                C = t - 273.15;

                F = C * 1.8 + 32;

                Kelvin = "The temp you entered in Kelvins was " + t;
                Console.WriteLine(Kelvin);
                Console.WriteLine("Select how you want the temp converted? \r\nPress 1 for Celcius \r\n Press 2 for Farenheit");
                string conversion = Console.ReadLine().Trim();
                int Selection;
                while (!(int.TryParse(conversion, out Selection)) || (Selection > 2))
                {
                    Console.WriteLine("Invalid Selection please \r\nPress 1 for Celcius \r\n Press 2 for Farenheit");
                    conversion = Console.ReadLine().Trim();
                }
                if (Selection == 1)
                {
                    return C.ToString();
                }
                else
                {
                    return F.ToString();
                }
            }
            if (select == 2)
            {
                K = t + 273.15;

                F = t * 1.8 + 32;

                Kelvin = "The temp you entered in Celcius was " + t;
                Console.WriteLine(Kelvin);
                Console.WriteLine("Select how you want the temp converted? \r\nPress 1 for Kelvins \r\n Press 2 for Farenheit");
                string conversion = Console.ReadLine().Trim();
                int Selection;
                while (!(int.TryParse(conversion, out Selection)) || (Selection > 2))
                {
                    Console.WriteLine("Invalid Selection please \r\nPress 1 for Kelvins \r\n Press 2 for Farenheit");
                    conversion = Console.ReadLine().Trim();
                }
                if (Selection == 1)
                {
                    return K.ToString();
                }
                else
                {
                    return F.ToString();
                }




            }
            else
            {


                C = (t - 32) * 5 / 9;
                K = C + 273.15;
                Kelvin = "The temp you entered in farenheit was " + t;
                Console.WriteLine(Kelvin);
                Console.WriteLine("Select how you want the temp converted? \r\nPress 1 for Celcius \r\n Press 2 for Kelvins");
                string conversion = Console.ReadLine().Trim();
                int Selection;
                while (!(int.TryParse(conversion, out Selection)) || (Selection > 2))
                {
                    Console.WriteLine("Invalid Selection please \r\nPress 1 for Celcius \r\n Press 2 for Kelvins");
                    conversion = Console.ReadLine().Trim();
                }
                if (Selection == 1)
                {
                    return C.ToString();
                }
                else
                {
                    return K.ToString();
                }
            }
        }
    }
}




        
    

      

