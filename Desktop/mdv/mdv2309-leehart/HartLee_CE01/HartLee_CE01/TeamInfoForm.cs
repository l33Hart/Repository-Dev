using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HartLee_CE01
{//form to collect or change info
    public partial class TeamInfoForm : Form
    {//Event Handler to Communicate between forms Calling the TeamThrower Class of EventArgs
        public EventHandler<TeamThrower> ThrowTeam;
        public TeamInfoForm()
        {
            InitializeComponent();

        }

       //sets or gets info in form
        public object TeamSet
        {
            get {
                Team x = new Team();

                x.Name = nameTextBox1.Text;
                x.Location = locationTextBox.Text;
                x.Division = divisionBox.SelectedIndex;
                x.Conference = AFCRadio.Checked;

                
                


                return x as object;
                ; }
            set {
                Team x = value as Team;
                nameTextBox1.Text = x.Name;
               locationTextBox.Text = x.Location;
                 divisionBox.SelectedIndex = x.Division;


                if (x.Conference == true)
                { AFCRadio.Checked = true; }
                else { NFCRadioButton.Checked = true; }
                





                ;
            }

        }

        // when Event Handler is called it will be supplied with an object that will hold the teams info
        public class TeamThrower : EventArgs
        {
            object team;
            public TeamThrower(object x)
            {

                team = x;

            }
            public object TeamX { get { return team; }}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeamThrower teamthrow = new TeamThrower(TeamSet);
            ThrowTeam(this, teamthrow);
            Close();
        }

      
    }
    
}
