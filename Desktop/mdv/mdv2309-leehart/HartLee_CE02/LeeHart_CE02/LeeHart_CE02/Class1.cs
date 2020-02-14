using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Windows.Forms;
namespace LeeHart_CE02
{
    class Class1
    {
        int id;
        string courseName;
        int courseNumber;
        string term;
        double creditHours;
        string track;
        public Class1(ListViewItem list)
        {
            string i;
            i = list.SubItems[5].Name.ToString();
            int.TryParse(i, out id);
            courseName = list.SubItems[0].Name.ToString();
            i = list.SubItems[1].Name.ToString();
            int.TryParse(i, out courseNumber);
            term = list.SubItems[2].Name.ToString();
            i = list.SubItems[3].Name.ToString();
            double.TryParse(i, out creditHours);
            track = list.SubItems[4].Name.ToString();



        }
        public Class1(DataRow data)
        {
            string i;
            i = data["ID"].ToString();
            int.TryParse(i, out id);
            courseName = data["CourseName"].ToString();
            i = data["CourseNumber"].ToString();
            int.TryParse(i, out courseNumber);
            term = data["Term"].ToString();
            i = data["CreditHours"].ToString();
            double.TryParse(i, out creditHours);
            track = data["Track"].ToString();
            
        }
        public ListViewItem ClassListViewItem()
        {
            ListViewItem item = new ListViewItem(id.ToString());
            item.Name = id.ToString();
            item.SubItems.Add(courseName);
            item.SubItems.Add(courseNumber.ToString());
            item.SubItems.Add(term);
            item.SubItems.Add(creditHours.ToString());
            item.SubItems.Add(track);
            item.SubItems.Add(id.ToString());
            item.Name = id.ToString();
            item.SubItems[0].Name = courseName;
            item.SubItems[1].Name = courseNumber.ToString();

            item.SubItems[2].Name = term;
            item.SubItems[3].Name = creditHours.ToString();
            item.SubItems[4].Name = track;
            item.SubItems[5].Name = id.ToString();
            item.Tag = this;



            return item;
        }
        public string AddQuery()
        {
            string re = $"Insert into Classes (CourseName, CourseNumber, Term, CreditHours, Track) Value('{courseName}',{courseNumber.ToString()},'{term}',{creditHours.ToString()},'{track}')";
           
            return re;
        }
        public string EditQuery()
        {
            string re = $"Update Classes set CourseName = '{courseName}', CourseNumber = {courseNumber.ToString()}, Term = '{term}', CreditHours = {creditHours.ToString()}, Track = '{track}' where ID = {id}"; 
           
            return re;


        }
        public string deleteRecord()
        {
            string re = $"Delete From Classes where ID = {id}";
            return re;


        }
    }
}
