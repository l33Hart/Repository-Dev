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
using System.Xml;

namespace TicTacToe
{
    public partial class frmTicTacToe : Form
    {
        // NAME: Lee Hart
        // CLASS AND TERM:
        // PROJECT: Tic Tac Toe

        /* THINGS TO CONSIDER:
            - You must change the project name to conform to the required
              naming convention.
            - You must comment the code throughout.  Failure to do so could result
              in a lower grade.
            - All button names and other provided variables and controls must
              remain the same.  Changing these could result in a 0 on the project.
            - Selecting Blue or Red on the View menu should change the imageList
              attached to all buttons so that any current play will change the color
              of all button images.
            - Saved games should save to XML.  A game should load only from XML and
              should not crash the application if a user tries to load an incorrect 
              file.
        */
        int currentPlayer = 0;
        List<Button> buttons = new List<Button>();
      
        public frmTicTacToe()
        {
            InitializeComponent();
            HandleClientWindowSize();
            buttons.Add(r1c1button);buttons.Add(r1c2button);buttons.Add(r1c3button); buttons.Add(r2c1button);  buttons.Add(r2c2button);buttons.Add(r2c3button);buttons.Add(r3c1button); buttons.Add(r3c2button);buttons.Add(r3c3button);
        }
        void ChangeButton(object sender, EventArgs e)
        {
            int i = currentPlayer;
            Button clicked = (Button)sender;
           
            if (clicked.ImageIndex == -1)
            {
                
                clicked.ImageIndex = i;
                ChangePlayer(currentPlayer);
                CheckForWinner(sender,e);
            }





        }
        void ChangePlayer(int player)
        {

            switch (player)
            {
                case 0: { currentPlayer = 1; }break;
                case 1: { currentPlayer = 0; }break;


            }
               



        }
        private void r1c1button_Click(object sender, EventArgs e)
        {
            ChangeButton(sender, e);
            
        }

        private void r1c2button_Click(object sender, EventArgs e)
        {
            ChangeButton(sender, e);
        }

        private void r1c3button_Click(object sender, EventArgs e)
        {
            ChangeButton(sender, e);
        }

        private void r2c1button_Click(object sender, EventArgs e)
        {
            ChangeButton(sender, e);
        }

        private void r2c2button_Click(object sender, EventArgs e)
        {
            ChangeButton(sender, e);
        }

        private void r2c3button_Click(object sender, EventArgs e)
        {
            ChangeButton(sender, e);
        }

        private void r3c1button_Click(object sender, EventArgs e)
        {
            ChangeButton(sender, e);
        }

        private void r3c2button_Click(object sender, EventArgs e)
        {
            ChangeButton(sender, e);
        }

        private void r3c3button_Click(object sender, EventArgs e)
        {
            ChangeButton(sender, e);
        }
        
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Button b in buttons)
            {

                b.ImageList = blueImages;

            }
            blueToolStripMenuItem.Checked = true;
            redToolStripMenuItem.Checked = false;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Button b in buttons)
            {
                b.ImageList = redImages;
            }
            redToolStripMenuItem.Checked = true;
            blueToolStripMenuItem.Checked = false;
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        { if (currentPlayer != 1)
            {
                currentPlayer = 1;
                foreach (Button b in buttons)
                {
                    if(b.ImageIndex == 0)
                    {

                        currentPlayer = 0;
                    }
                    if(b.ImageIndex == 1)
                    {
                        currentPlayer = 0;

                    }
                }
            }
        
           
           
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (currentPlayer != 0)
            {
                currentPlayer = 0;
                foreach (Button b in buttons)
                {
                    if (b.ImageIndex == 0)
                    {

                        currentPlayer = 1;
                    }
                    if (b.ImageIndex == 1)
                    {
                        currentPlayer = 1;

                    }
                }
            }


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach(Button b in buttons)
            {

                b.ImageIndex = -1;


            }
        }
        void CheckForWinner(object sender, EventArgs e)
        {
            int i = 0;
            string[] players = new string[] { "O", "X", "NO One" };
           
           
                if ((buttons[0].ImageIndex == 1 || buttons[0].ImageIndex == 0) && buttons[1].ImageIndex == buttons[2].ImageIndex)
            {
                if(buttons[0].ImageIndex == buttons[1].ImageIndex) { MessageBox.Show($"{players[buttons[0].ImageIndex]} is the Winner \r\nA New Game Wiil Start"); toolStripButton1_Click(sender, e); }


            }
            if ((buttons[3].ImageIndex == 1 || buttons[3].ImageIndex == 0) && buttons[4].ImageIndex == buttons[5].ImageIndex)
            {
                if (buttons[3].ImageIndex == buttons[4].ImageIndex) { MessageBox.Show($"{players[buttons[3].ImageIndex]} is the Winner \r\nA New Game Wiil Start"); toolStripButton1_Click(sender, e);  }


            }
            if ((buttons[6].ImageIndex == 1 || buttons[6].ImageIndex == 0) && buttons[7].ImageIndex == buttons[8].ImageIndex)
            {
                if (buttons[6].ImageIndex == buttons[7].ImageIndex) { MessageBox.Show($"{players[buttons[6].ImageIndex]} is the Winner \r\nA New Game Wiil Start"); toolStripButton1_Click(sender, e); }


            }
            if ((buttons[0].ImageIndex == 1 || buttons[0].ImageIndex == 0) && buttons[4].ImageIndex == buttons[8].ImageIndex)
            {
                if (buttons[0].ImageIndex == buttons[4].ImageIndex) { MessageBox.Show($"{players[buttons[0].ImageIndex]} is the Winner \r\nA New Game Wiil Start"); toolStripButton1_Click(sender, e); }


            }
            if ((buttons[2].ImageIndex == 1 || buttons[2].ImageIndex == 0) && buttons[4].ImageIndex == buttons[6].ImageIndex)
            {
                if (buttons[2].ImageIndex == buttons[4].ImageIndex) { MessageBox.Show($"{players[buttons[2].ImageIndex]} is the Winner \r\nA New Game Wiil Start"); toolStripButton1_Click(sender, e);  }


            }
            if ((buttons[0].ImageIndex == 1 || buttons[0].ImageIndex == 0) && buttons[3].ImageIndex == buttons[6].ImageIndex)
            {
                if (buttons[0].ImageIndex == buttons[3].ImageIndex) { MessageBox.Show($"{players[buttons[0].ImageIndex]} is the Winner \r\nA New Game Wiil Start"); toolStripButton1_Click(sender, e);  }


            }
            if ((buttons[1].ImageIndex == 1 || buttons[1].ImageIndex == 0) && buttons[4].ImageIndex == buttons[7].ImageIndex)
            {
                if (buttons[1].ImageIndex == buttons[4].ImageIndex) { MessageBox.Show($"{players[buttons[1].ImageIndex]} is the Winner \r\nA New Game Wiil Start"); toolStripButton1_Click(sender, e);  }


            }
            if ((buttons[2].ImageIndex == 1 || buttons[2].ImageIndex == 0) && buttons[5].ImageIndex == buttons[8].ImageIndex)
            {
                if (buttons[2].ImageIndex == buttons[5].ImageIndex) { MessageBox.Show($"{players[buttons[2].ImageIndex]} is the Winner \r\nA New Game Wiil Start"); toolStripButton1_Click(sender, e); }


            }
            foreach (Button b in buttons)
            {

                if (b.ImageIndex >= 0) { i++; }

            }
            if (i == 9)
            {

                MessageBox.Show($"{players[2]} is the Winner \r\nA New Game Wiil Start"); toolStripButton1_Click(sender, e);

            }


        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlWriterSettings setting = new XmlWriterSettings();
                setting.Indent = true;
                setting.NewLineOnAttributes = true;
                using (XmlWriter xmlWriter = XmlWriter.Create(saveFileDialog1.FileName, setting))
                {
                    xmlWriter.WriteStartElement("TicTacToexml");
                    xmlWriter.WriteAttributeString("currentPlayer", currentPlayer.ToString());
                    foreach (Button b in buttons)
                    {

                        xmlWriter.WriteAttributeString(b.Name, b.ImageIndex.ToString());


                    }
                    xmlWriter.WriteEndElement();


                }
            }
        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                string num;
                int index;
                using (XmlReader reader = XmlReader.Create(openFileDialog1.FileName))
                {
                    
                    reader.MoveToContent();
                    num = reader.GetAttribute("currentPlayer");
                    int.TryParse(num, out index);
                    currentPlayer = index;
                    foreach (Button b in buttons)
                    {
                        
                            num = reader.GetAttribute(b.Name).ToString();
                            int.TryParse(num, out index);
                            b.ImageIndex = index;
                      
                    }


                }
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTicTacToe_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.L) { loadGameToolStripMenuItem_Click(sender, e); }
            if(e.KeyCode == Keys.S) { saveGameToolStripMenuItem_Click(sender, e); }
            if(e.KeyCode == Keys.Q) { exitToolStripMenuItem_Click(sender, e); }
        }

        //Written by Keith Webster.  Used with permission.  Not to be distributed.  
        //Place this inside the class space in the form you would like to size.
        //Call this method AFTER InitializeComponent() inside the form's constructor.
        void HandleClientWindowSize()
        {
            //Modify ONLY these float values
            float HeightValueToChange = 1.4f;
            float WidthValueToChange = 6.0f;

            //DO NOT MODIFY THIS CODE
            int height = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Height / HeightValueToChange);
            int width = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Width / WidthValueToChange);
            if (height < Size.Height)
                height = Size.Height;
            if (width < Size.Width)
                width = Size.Width;
            this.Size = new Size(width, height);
            //this.Size = new Size(376, 720);
        }

    }
}
 