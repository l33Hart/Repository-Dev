namespace HartLee_CE01
{
    partial class EntryForm
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
            this.entryFormGroupBox = new System.Windows.Forms.GroupBox();
            this.gradeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.completedCheckBox = new System.Windows.Forms.CheckBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.classNameTextBox = new System.Windows.Forms.TextBox();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.entryFormGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // entryFormGroupBox
            // 
            this.entryFormGroupBox.Controls.Add(this.gradeNumericUpDown);
            this.entryFormGroupBox.Controls.Add(this.completedCheckBox);
            this.entryFormGroupBox.Controls.Add(this.startDate);
            this.entryFormGroupBox.Controls.Add(this.classNameTextBox);
            this.entryFormGroupBox.Controls.Add(this.courseTextBox);
            this.entryFormGroupBox.Controls.Add(this.codeTextBox);
            this.entryFormGroupBox.Controls.Add(this.label5);
            this.entryFormGroupBox.Controls.Add(this.label4);
            this.entryFormGroupBox.Controls.Add(this.label3);
            this.entryFormGroupBox.Controls.Add(this.label2);
            this.entryFormGroupBox.Controls.Add(this.label1);
            this.entryFormGroupBox.Controls.Add(this.saveButton);
            this.entryFormGroupBox.Location = new System.Drawing.Point(12, 12);
            this.entryFormGroupBox.Name = "entryFormGroupBox";
            this.entryFormGroupBox.Size = new System.Drawing.Size(608, 367);
            this.entryFormGroupBox.TabIndex = 0;
            this.entryFormGroupBox.TabStop = false;
            this.entryFormGroupBox.Text = "Course Information";
            // 
            // gradeNumericUpDown
            // 
            this.gradeNumericUpDown.DecimalPlaces = 2;
            this.gradeNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.gradeNumericUpDown.Location = new System.Drawing.Point(75, 263);
            this.gradeNumericUpDown.Name = "gradeNumericUpDown";
            this.gradeNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.gradeNumericUpDown.TabIndex = 12;
            // 
            // completedCheckBox
            // 
            this.completedCheckBox.AutoSize = true;
            this.completedCheckBox.Location = new System.Drawing.Point(10, 233);
            this.completedCheckBox.Name = "completedCheckBox";
            this.completedCheckBox.Size = new System.Drawing.Size(112, 24);
            this.completedCheckBox.TabIndex = 11;
            this.completedCheckBox.Text = "Completed";
            this.completedCheckBox.UseVisualStyleBackColor = true;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(75, 190);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 26);
            this.startDate.TabIndex = 10;
            // 
            // classNameTextBox
            // 
            this.classNameTextBox.Location = new System.Drawing.Point(75, 66);
            this.classNameTextBox.Name = "classNameTextBox";
            this.classNameTextBox.Size = new System.Drawing.Size(329, 26);
            this.classNameTextBox.TabIndex = 9;
            // 
            // courseTextBox
            // 
            this.courseTextBox.Location = new System.Drawing.Point(75, 108);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(329, 26);
            this.courseTextBox.TabIndex = 8;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(75, 150);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(154, 26);
            this.codeTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Grade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(502, 69);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(95, 37);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 708);
            this.Controls.Add(this.entryFormGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EntryForm";
            this.Text = "EntryForm";
            this.entryFormGroupBox.ResumeLayout(false);
            this.entryFormGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox entryFormGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown gradeNumericUpDown;
        private System.Windows.Forms.CheckBox completedCheckBox;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.TextBox classNameTextBox;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label5;
    }
}