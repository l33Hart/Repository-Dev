using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeeHart_CE02
{
    public partial class Form1 : Form
    {
        string query = @"Select * from Classes";
        DataCall call = new DataCall();
        public Form1()
        {

            InitializeComponent();

            FillListView();
        }
        public void FillListView()
        {
            listView1.Items.Clear();
          
            DataTable table = call.Data_Table(query);
            foreach (DataRow row in table.Rows)
            {
                Class1 course = new Class1(row);

                listView1.Items.Add(course.ClassListViewItem());
            }


        }
        public ListViewItem Display
        {
            get {
                
                ListViewItem item = new ListViewItem();
                item.Name = classID.Value.ToString();
                item.SubItems.Add(CourseName.Text);
                item.SubItems.Add(courseNumber.Value.ToString());
                item.SubItems.Add(Term.Text);
                item.SubItems.Add(creditHours.Value.ToString());
                item.SubItems.Add(Track.Text);
                item.SubItems.Add(classID.Value.ToString());
                item.SubItems[0].Name = CourseName.Text;
                item.SubItems[1].Name = courseNumber.Value.ToString();

                item.SubItems[2].Name = Term.Text;
                item.SubItems[3].Name = creditHours.Value.ToString();
                item.SubItems[4].Name = Track.Text;
                item.SubItems[5].Name = classID.Value.ToString();
                Class1 course = new Class1(item);
                item.Tag = course;
                

                return item;
            }
            set
            {
                string i;
                decimal b;
                ListViewItem list = value;
                i = list.SubItems[5].Name;
                decimal.TryParse(i, out b);
                classID.Value = b;
                CourseName.Text = list.SubItems[0].Name;
                i = list.SubItems[1].Name;
                decimal.TryParse(i, out b);
                courseNumber.Value = b;
                Term.Text = list.SubItems[2].Name;
                i = list.SubItems[3].Name;
                decimal.TryParse(i, out b);
                creditHours.Value = b;
               Track.Text = list.SubItems[4].Name;
                
                
                
                

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem list = Display;
            Class1 course = new Class1(list);
            call.AddData(course.AddQuery());

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {

                Display = listView1.SelectedItems[0];


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem list = Display;
            Class1 course = new Class1(list);
            call.AddData(course.EditQuery());
        }
    }
}
