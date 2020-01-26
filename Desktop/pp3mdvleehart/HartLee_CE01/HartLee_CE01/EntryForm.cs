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
{
    
    public partial class EntryForm : Form
    {
        
        Classes current = new Classes();
        public EventHandler<SendDatatoForm> Transferinfo;
        Classes classes = new Classes();
        public EntryForm()
        {
            InitializeComponent();
        }
        public object getDataFromForm
        {
            get
            {
                current = new Classes();
                current.ClassName = classNameTextBox.Text;
                current.Course = courseTextBox.Text;
                current.Code = codeTextBox.Text;
                current.StartDate = startDate.Value;
                current.Grade = gradeNumericUpDown.Value;
                current.Completed = completedCheckBox.Checked;

                return current;
            }
            set
            {
                Classes current = value as Classes;
               classNameTextBox.Text = current.ClassName;
               courseTextBox.Text = current.Course;
                codeTextBox.Text = current.Code;
                startDate.Value = current.StartDate;
                 gradeNumericUpDown.Value = current.Grade;
                completedCheckBox.Checked = current.Completed;
                

            }

        }
      public class SendDatatoForm  : EventArgs
        {
            public SendDatatoForm(object lvi) { item = lvi as Classes; }
            Classes item;
            public object Item { get { return item; } set { item = value as Classes ; } }
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           
            SendDatatoForm ThrowtoForm = new SendDatatoForm(getDataFromForm);
            Transferinfo(this, ThrowtoForm);
            this.Close();
        }

     

        private void EditSaveButton_Click(object sender, EventArgs e)
        {
            SendDatatoForm ThrowtoForm = new SendDatatoForm(getDataFromForm);
            Transferinfo(this, ThrowtoForm);
            this.Close();

        }
    }
}
