using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.Ce1_HartLee
{// Name: Lee Hart
 // Date: JAN 2019 
 // Course: Project & Portfolio 1  
 // Synopsis: This starts the age converter
    class AgeConvert
    {
        static public void AgeConvertProg()
        {
            Menu.MenuDisplay();
            DateTime now;
            now = DateTime.Now;
            Console.WriteLine("Todays Date is " + now);
            Console.WriteLine("Please enter your birth date and time if known");
            string birthDate;
            birthDate = Console.ReadLine();
            DateTime birthday;

            while (!DateTime.TryParse(birthDate, out birthday))
            {
                Console.WriteLine("Please enter a valid birth date, do not enter ordinal numbers \r\n( An Ordinal Number is a number that tells the position of something in a list, such as 1st, 2nd, 3rd, 4th, 5th etc) \r\n  , also time if known. When entering time you must use this time format( 12:00 am )");
                birthDate = Console.ReadLine();
            }

            Console.WriteLine(birthday);

            int age;
            age = now.Year - birthday.Year;

            if (now.DayOfYear < birthday.DayOfYear)
            {
                age--;

            }


            int[] DayConvert = new int[5];
            DayConvert = DayConverter(now, birthday);

            string secondsOld;
            string minutesOld;
            string hoursOld;
            string daysOld;
            string leapYears;

            secondsOld = DayConvert[0].ToString();
            minutesOld = DayConvert[1].ToString();
            hoursOld = DayConvert[2].ToString();
            daysOld = DayConvert[3].ToString();
            leapYears = DayConvert[4].ToString();



            Console.WriteLine("Your age is {0}", age);
            Console.WriteLine("Your have lived \r\n {4} Leap Years\r\n {0} days \r\n {2} hours ,\r\n {1}  minutes , \r\n {3} seconds....and counting ", daysOld, minutesOld, hoursOld, secondsOld, leapYears);


            int selectionInt = Menu.MenuSelect();



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




        public static int[] DayConverter(DateTime now, DateTime birthday)
        {

            int age = now.Year - birthday.Year;
            int days = now.DayOfYear - birthday.DayOfYear;
            int leapDaysAdded = age / 4;

            int daysOld = age * 365 + days + leapDaysAdded;
            int hours = now.Hour - birthday.Hour;
            int hoursOld = daysOld * 24 + hours;
            int minutes = now.Minute - birthday.Minute;
            int minutesOld = hoursOld * 60 + minutes;
            int seconds = now.Second - birthday.Second;
            int secondsOld = minutesOld * 60 + seconds;

            int[] Birthday = new int[5];

            Birthday[0] = secondsOld;
            Birthday[1] = minutesOld;
            Birthday[2] = hoursOld;
            Birthday[3] = daysOld;
            Birthday[4] = leapDaysAdded;

            return Birthday;

        }
    }

}



            
        
  


