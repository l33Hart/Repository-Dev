namespace LeeHart_CE02
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.classID = new System.Windows.Forms.NumericUpDown();
            this.CourseName = new System.Windows.Forms.TextBox();
            this.courseNumber = new System.Windows.Forms.NumericUpDown();
            this.Term = new System.Windows.Forms.TextBox();
            this.creditHours = new System.Windows.Forms.NumericUpDown();
            this.Track = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.classID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditHours)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(721, 108);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(571, 637);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // classID
            // 
            this.classID.Location = new System.Drawing.Point(497, 125);
            this.classID.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.classID.Name = "classID";
            this.classID.ReadOnly = true;
            this.classID.Size = new System.Drawing.Size(69, 26);
            this.classID.TabIndex = 1;
            // 
            // CourseName
            // 
            this.CourseName.Location = new System.Drawing.Point(236, 178);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(330, 26);
            this.CourseName.TabIndex = 2;
            // 
            // courseNumber
            // 
            this.courseNumber.Location = new System.Drawing.Point(497, 228);
            this.courseNumber.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.courseNumber.Name = "courseNumber";
            this.courseNumber.Size = new System.Drawing.Size(69, 26);
            this.courseNumber.TabIndex = 3;
            // 
            // Term
            // 
            this.Term.Location = new System.Drawing.Point(236, 278);
            this.Term.Name = "Term";
            this.Term.Size = new System.Drawing.Size(330, 26);
            this.Term.TabIndex = 4;
            // 
            // creditHours
            // 
            this.creditHours.Location = new System.Drawing.Point(497, 327);
            this.creditHours.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.creditHours.Name = "creditHours";
            this.creditHours.Size = new System.Drawing.Size(69, 26);
            this.creditHours.TabIndex = 5;
            // 
            // Track
            // 
            this.Track.Location = new System.Drawing.Point(236, 379);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(330, 26);
            this.Track.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Course ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Course Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Term";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Credit Hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(581, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Track";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(471, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(471, 619);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 30);
            this.button3.TabIndex = 15;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 770);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Track);
            this.Controls.Add(this.creditHours);
            this.Controls.Add(this.Term);
            this.Controls.Add(this.courseNumber);
            this.Controls.Add(this.CourseName);
            this.Controls.Add(this.classID);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.classID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.NumericUpDown classID;
        private System.Windows.Forms.TextBox CourseName;
        private System.Windows.Forms.NumericUpDown courseNumber;
        private System.Windows.Forms.TextBox Term;
        private System.Windows.Forms.NumericUpDown creditHours;
        private System.Windows.Forms.TextBox Track;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

