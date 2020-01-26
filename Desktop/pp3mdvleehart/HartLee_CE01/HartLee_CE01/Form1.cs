using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HartLee_CE01
{
    public partial class Form1 : Form
    {

        int index = 0;
        bool updateBool;
        public Form1()
        {
            InitializeComponent();
        }
        void ListViewAdd(Classes listItem)
        {

            if (listItem.Completed)
            {
                classesCompleted.Items.Add(listItem);


            }
            else
            {
                classesNeeded.Items.Add(listItem);
            }



        }

        public void GetEntryFormData(object sender, EntryForm.SendDatatoForm e)
        {
            Classes current = e.Item as Classes;
            ListViewAdd(current);


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (classesNeeded.SelectedItem != null)
            {
                index = classesNeeded.Items.IndexOf(classesNeeded.SelectedItem);
                editButton.Visible = true;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classesCompleted.SelectedItem != null)
            {
                index = classesCompleted.Items.IndexOf(classesCompleted.SelectedItem);
                editButton.Visible = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            EntryForm formEnter = new EntryForm();

            formEnter.Show();
            formEnter.Transferinfo += GetEntryFormData;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (classesCompleted.SelectedItems.Count > 0)
            {
                index = classesCompleted.Items.IndexOf(classesCompleted.SelectedItems[0]);
                EntryForm formEnter = new EntryForm();
                formEnter.getDataFromForm = classesCompleted.SelectedItems[0];
                formEnter.Show();
                formEnter.Transferinfo += UpdateEntryFormData;
                updateBool = true;
            }
            if (classesNeeded.SelectedItems.Count > 0)
            {
                index = classesNeeded.Items.IndexOf(classesNeeded.SelectedItems[0]);
                EntryForm formEnter = new EntryForm();
                formEnter.getDataFromForm = classesNeeded.SelectedItems[0];
                formEnter.Show();
                formEnter.Transferinfo += UpdateEntryFormData;
                updateBool = false;

            }
        }

        private void UpdateEntryFormData(object sender, EntryForm.SendDatatoForm e)
        {
            if (updateBool && classesCompleted.Items[index] != null)
            {

                classesCompleted.Items[index] = e.Item;



            }
            if (!updateBool && classesNeeded.Items[index] != null)
            {

                classesNeeded.Items[index] = e.Item;


            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter write = new StreamWriter(saveFileDialog1.FileName))
                {

                    write.WriteLine("1122 }");
                    foreach (Classes c in classesCompleted.Items)
                    {


                        write.WriteLine(c.ToFile());



                    }
                    foreach (Classes c in classesNeeded.Items)
                    {


                        write.WriteLine(c.ToFile());



                    }

                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string read = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    while (reader.Peek() != -1)
                    {
                        read += reader.ReadLine();
                    }
                }
               

            }
            string[] classesArray = read.Split('}');
            if (classesArray[0].Trim(' ') == "1122")
            {
                classesCompleted.Items.Clear();
                classesNeeded.Items.Clear();
                for (int i = 1; i < classesArray.Count(); i++)
                {
                    Classes c = new Classes();
                    string[] cArray = classesArray[i].Split('|');
                    if (cArray.Count() > 2)
                    {
                        c.ClassName = cArray[0];
                        c.Course = cArray[1];
                        c.Code = cArray[2];
                        DateTime date;
                        DateTime.TryParse(cArray[3], out date);
                        c.StartDate = date;
                        bool complete;
                        bool.TryParse(cArray[4], out complete);
                        c.Completed = complete;
                        decimal grade;
                        decimal.TryParse(cArray[5], out grade);
                        c.Grade = grade;
                        ListViewAdd(c);
                    }


                }
            }
            else { MessageBox.Show("File not Correct Type"); }

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {

                using (StreamWriter write = new StreamWriter(saveFileDialog2.FileName))
                {
                    foreach (Classes c in classesCompleted.Items)
                    {
                        write.WriteLine(c.ToPrint());
                    }
                    foreach (Classes c in classesNeeded.Items)
                    {
                        write.WriteLine(c.ToPrint());
                    }
                }


            }
        }

        private void CompletedButton_Click(object sender, EventArgs e)
        {

            if (classesNeeded.SelectedItems.Count > 0)
            {
                Classes c = classesNeeded.SelectedItems[0] as Classes;
                c.Completed = true;
                index = classesNeeded.Items.IndexOf(classesNeeded.SelectedItems[0]);
                classesNeeded.Items.RemoveAt(index);
                ListViewAdd(c);

            }

        }

        private void incompleteButton_Click(object sender, EventArgs e)
        {
            if (classesCompleted.SelectedItems.Count > 0)
            {
                Classes c = classesCompleted.SelectedItems[0] as Classes;
                c.Completed = false;
                index = classesCompleted.Items.IndexOf(classesCompleted.SelectedItems[0]);
                classesCompleted.Items.RemoveAt(index);
                ListViewAdd(c);

            }
        }

        private void removeClassButton_Click(object sender, EventArgs e)
        {
            if (classesCompleted.SelectedItems.Count > 0)
            {
                index = classesCompleted.Items.IndexOf(classesCompleted.SelectedItems[0]);
                classesCompleted.Items.RemoveAt(index);
            }
            if (classesNeeded.SelectedItems.Count > 0)
            {
                index = classesNeeded.Items.IndexOf(classesNeeded.SelectedItems[0]);
                classesNeeded.Items.RemoveAt(index);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Q) { exitToolStripMenuItem_Click(sender, new EventArgs()); }
            if (e.KeyCode == Keys.S) { saveToolStripMenuItem_Click(sender, new EventArgs()); }
            if (e.KeyCode == Keys.L) { loadToolStripMenuItem_Click(sender, new EventArgs()); }
            if(e.KeyCode == Keys.P) { printToolStripMenuItem_Click(sender, new EventArgs()); }
        }
    }
}
