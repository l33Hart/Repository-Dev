namespace HartLee_CE01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AFClistBox = new System.Windows.Forms.ListBox();
            this.NFClistBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.afclabel = new System.Windows.Forms.Label();
            this.nfcLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AFClistBox
            // 
            this.AFClistBox.ForeColor = System.Drawing.Color.Blue;
            this.AFClistBox.FormattingEnabled = true;
            this.AFClistBox.ItemHeight = 20;
            this.AFClistBox.Location = new System.Drawing.Point(23, 47);
            this.AFClistBox.Name = "AFClistBox";
            this.AFClistBox.Size = new System.Drawing.Size(296, 444);
            this.AFClistBox.TabIndex = 0;
            this.AFClistBox.SelectedIndexChanged += new System.EventHandler(this.AFClistBox_SelectedIndexChanged);
            // 
            // NFClistBox
            // 
            this.NFClistBox.ForeColor = System.Drawing.Color.Blue;
            this.NFClistBox.FormattingEnabled = true;
            this.NFClistBox.ItemHeight = 20;
            this.NFClistBox.Location = new System.Drawing.Point(508, 47);
            this.NFClistBox.Name = "NFClistBox";
            this.NFClistBox.Size = new System.Drawing.Size(296, 444);
            this.NFClistBox.TabIndex = 1;
            this.NFClistBox.SelectedIndexChanged += new System.EventHandler(this.NFClistBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.afclabel);
            this.groupBox1.Controls.Add(this.nfcLabel);
            this.groupBox1.Controls.Add(this.NFClistBox);
            this.groupBox1.Controls.Add(this.AFClistBox);
            this.groupBox1.Location = new System.Drawing.Point(23, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 514);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NFL Teams";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(354, 453);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 24);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Blue";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(354, 423);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 24);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "Red";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(325, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 35);
            this.button4.TabIndex = 7;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(325, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "< Switch >";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // afclabel
            // 
            this.afclabel.AutoSize = true;
            this.afclabel.Location = new System.Drawing.Point(19, 24);
            this.afclabel.Name = "afclabel";
            this.afclabel.Size = new System.Drawing.Size(41, 20);
            this.afclabel.TabIndex = 3;
            this.afclabel.Text = "AFC";
            // 
            // nfcLabel
            // 
            this.nfcLabel.AutoSize = true;
            this.nfcLabel.Location = new System.Drawing.Point(513, 24);
            this.nfcLabel.Name = "nfcLabel";
            this.nfcLabel.Size = new System.Drawing.Size(41, 20);
            this.nfcLabel.TabIndex = 2;
            this.nfcLabel.Text = "NFC";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(132, 30);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "\"txt files|*.txt|All Files|*.*\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 605);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AFClistBox;
        private System.Windows.Forms.ListBox NFClistBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label afclabel;
        private System.Windows.Forms.Label nfcLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

