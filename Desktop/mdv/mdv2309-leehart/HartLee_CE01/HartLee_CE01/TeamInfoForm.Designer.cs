namespace HartLee_CE01
{
    partial class TeamInfoForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NFCRadioButton = new System.Windows.Forms.RadioButton();
            this.AFCRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.divisionBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NFCRadioButton);
            this.groupBox1.Controls.Add(this.AFCRadio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.divisionBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.locationTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team Info";
            // 
            // NFCRadioButton
            // 
            this.NFCRadioButton.AutoSize = true;
            this.NFCRadioButton.Location = new System.Drawing.Point(97, 195);
            this.NFCRadioButton.Name = "NFCRadioButton";
            this.NFCRadioButton.Size = new System.Drawing.Size(66, 24);
            this.NFCRadioButton.TabIndex = 16;
            this.NFCRadioButton.TabStop = true;
            this.NFCRadioButton.Text = "NFC";
            this.NFCRadioButton.UseVisualStyleBackColor = true;
            // 
            // AFCRadio
            // 
            this.AFCRadio.AutoSize = true;
            this.AFCRadio.Location = new System.Drawing.Point(97, 165);
            this.AFCRadio.Name = "AFCRadio";
            this.AFCRadio.Size = new System.Drawing.Size(66, 24);
            this.AFCRadio.TabIndex = 15;
            this.AFCRadio.TabStop = true;
            this.AFCRadio.Text = "AFC";
            this.AFCRadio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Division";
            // 
            // divisionBox
            // 
            this.divisionBox.FormattingEnabled = true;
            this.divisionBox.Items.AddRange(new object[] {
            "North",
            "South",
            "East",
            "West"});
            this.divisionBox.Location = new System.Drawing.Point(97, 120);
            this.divisionBox.Name = "divisionBox";
            this.divisionBox.Size = new System.Drawing.Size(121, 28);
            this.divisionBox.TabIndex = 13;
            this.divisionBox.Text = "Division";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Team";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(98, 32);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(100, 26);
            this.locationTextBox.TabIndex = 10;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(97, 77);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeamInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "TeamInfoForm";
            this.Text = "TeamInfoForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton NFCRadioButton;
        private System.Windows.Forms.RadioButton AFCRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox divisionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.Button button1;
    }
}