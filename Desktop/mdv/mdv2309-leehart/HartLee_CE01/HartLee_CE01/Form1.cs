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
        int index;
        int ListIndex;
        List<Team> teams = new List<Team>();
        public Form1()
        {
            InitializeComponent();

        }
        public void listSort()
        {
            AFClistBox.Items.Clear();
            NFClistBox.Items.Clear();
            foreach (Team x in teams)
            {
                if (x.Conference == true) { AFClistBox.Items.Add(x); }

                if (x.Conference == false) { NFClistBox.Items.Add(x); }



            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeamInfoForm form = new TeamInfoForm();
            form.ThrowTeam += addTeam;
            form.Show();
        }

        private void addTeam(object sender, TeamInfoForm.TeamThrower e)
        {

            teams.Add(e.TeamX as Team);

            listSort();
        }

        private void AFClistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AFClistBox.SelectedItem != null)
            {
                index = AFClistBox.SelectedIndex;
                ListIndex = teams.IndexOf(AFClistBox.SelectedItem as Team);
            }

        }

        private void NFClistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NFClistBox.SelectedItem != null)
            {
                index = NFClistBox.SelectedIndex;
                ListIndex = teams.IndexOf(NFClistBox.SelectedItem as Team);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AFClistBox.SelectedIndex == index) { int i; i = teams.IndexOf(AFClistBox.SelectedItem as Team); teams[i].Conference = false; listSort(); }
            if (NFClistBox.SelectedIndex == index) { int i; i = teams.IndexOf(NFClistBox.SelectedItem as Team); teams[i].Conference = true; listSort(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AFClistBox.SelectedIndex != -1 || NFClistBox.SelectedIndex != -1)
            {

                TeamInfoForm form = new TeamInfoForm();
                form.ThrowTeam += AlterTeam;
                object o = teams[ListIndex];
                form.TeamSet = o;
                form.Show();
            }
        }
        private void AlterTeam(object sender, TeamInfoForm.TeamThrower e)
        {
            teams[ListIndex] = e.TeamX as Team;


            listSort();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (AFClistBox.SelectedIndex != -1 || NFClistBox.SelectedIndex != -1)
            {
                teams.RemoveAt(ListIndex);
                listSort();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) { AFClistBox.ForeColor = Color.Red; NFClistBox.ForeColor = Color.Red; }
            if (radioButton1.Checked == false) { AFClistBox.ForeColor = Color.Blue; NFClistBox.ForeColor = Color.Blue; }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
         if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter write = new StreamWriter(saveFileDialog1.FileName))
                {
                    foreach (Team t in teams) { write.WriteLine(t.ToPrint()); }

                }

            }

        }



    }
}
