using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HartLee_CE01
{
    class Classes
    {
        //Creates the Class
        public Classes()
        { }

        string className;
        string course;
        string code;
        DateTime startDate;
        bool completed;
        decimal grade;


        public string ClassName { get{ return className; } set { className = value; } }
        public string Course { get{ return course; } set { course = value; } }
        public string Code { get { return code; } set { code = value; } }
        public DateTime StartDate { get { return startDate; }set { startDate = value; } }
    
        public bool Completed { get { return completed; } set { completed = value; } }
        public decimal Grade { get { return grade; } set { grade = value; } }


        public override string ToString()
        {
            return className + " : " + course;
        }
        public string ToFile()
        {

            return className + "|" + course + "|" + code + "|" + startDate.ToString() + "|" + completed.ToString() + "|" + grade + "}";


        }

        public string ToPrint()
        {
            string printString = $"Class Name : {className}\r\n" +
                                 $"Course     : {course}\r\n" +
                                 $"Code       : {code}\r\n" +
                                 $"Start Date : {StartDate.ToString("MMDDYYYY")}\r\n";
                 

            if (completed)
            {
                printString += $"Complete   : Yes\r\n";
            }
            else
            {
                printString += $"Complete   : Yes\r\n";
            }
            printString += $"Grade      : {grade}\r\n";


            return printString;
        }
    }
}
