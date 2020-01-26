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
            this.MobDevGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.incompleteButton = new System.Windows.Forms.Button();
            this.CompletedButton = new System.Windows.Forms.Button();
            this.removeClassButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.classesNeeded = new System.Windows.Forms.ListBox();
            this.classesCompleted = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.MobDevGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MobDevGroupBox
            // 
            this.MobDevGroupBox.Controls.Add(this.label2);
            this.MobDevGroupBox.Controls.Add(this.label1);
            this.MobDevGroupBox.Controls.Add(this.editButton);
            this.MobDevGroupBox.Controls.Add(this.incompleteButton);
            this.MobDevGroupBox.Controls.Add(this.CompletedButton);
            this.MobDevGroupBox.Controls.Add(this.removeClassButton);
            this.MobDevGroupBox.Controls.Add(this.addButton);
            this.MobDevGroupBox.Controls.Add(this.classesNeeded);
            this.MobDevGroupBox.Controls.Add(this.classesCompleted);
            this.MobDevGroupBox.Location = new System.Drawing.Point(13, 48);
            this.MobDevGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MobDevGroupBox.Name = "MobDevGroupBox";
            this.MobDevGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MobDevGroupBox.Size = new System.Drawing.Size(946, 571);
            this.MobDevGroupBox.TabIndex = 2;
            this.MobDevGroupBox.TabStop = false;
            this.MobDevGroupBox.Text = "Mobile Development Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Completed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Needed";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editButton.Location = new System.Drawing.Point(401, 138);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(134, 35);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit Class";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // incompleteButton
            // 
            this.incompleteButton.Location = new System.Drawing.Point(401, 228);
            this.incompleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.incompleteButton.Name = "incompleteButton";
            this.incompleteButton.Size = new System.Drawing.Size(134, 35);
            this.incompleteButton.TabIndex = 7;
            this.incompleteButton.Text = "< Incomplete";
            this.incompleteButton.UseVisualStyleBackColor = true;
            this.incompleteButton.Click += new System.EventHandler(this.incompleteButton_Click);
            // 
            // CompletedButton
            // 
            this.CompletedButton.Location = new System.Drawing.Point(401, 183);
            this.CompletedButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CompletedButton.Name = "CompletedButton";
            this.CompletedButton.Size = new System.Drawing.Size(134, 35);
            this.CompletedButton.TabIndex = 6;
            this.CompletedButton.Text = "Completed >";
            this.CompletedButton.UseVisualStyleBackColor = true;
            this.CompletedButton.Click += new System.EventHandler(this.CompletedButton_Click);
            // 
            // removeClassButton
            // 
            this.removeClassButton.Location = new System.Drawing.Point(401, 340);
            this.removeClassButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeClassButton.Name = "removeClassButton";
            this.removeClassButton.Size = new System.Drawing.Size(134, 35);
            this.removeClassButton.TabIndex = 5;
            this.removeClassButton.Text = "Remove";
            this.removeClassButton.UseVisualStyleBackColor = true;
            this.removeClassButton.Click += new System.EventHandler(this.removeClassButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(401, 50);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(134, 35);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add Class";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // classesNeeded
            // 
            this.classesNeeded.FormattingEnabled = true;
            this.classesNeeded.ItemHeight = 20;
            this.classesNeeded.Location = new System.Drawing.Point(8, 50);
            this.classesNeeded.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.classesNeeded.Name = "classesNeeded";
            this.classesNeeded.Size = new System.Drawing.Size(385, 524);
            this.classesNeeded.TabIndex = 2;
            this.classesNeeded.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // classesCompleted
            // 
            this.classesCompleted.FormattingEnabled = true;
            this.classesCompleted.ItemHeight = 20;
            this.classesCompleted.Location = new System.Drawing.Point(543, 50);
            this.classesCompleted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.classesCompleted.Name = "classesCompleted";
            this.classesCompleted.Size = new System.Drawing.Size(385, 524);
            this.classesCompleted.TabIndex = 3;
            this.classesCompleted.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 627);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(987, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Class App File|*.cap|All files|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "Text Files|*.txt|All files|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 649);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MobDevGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MobDevGroupBox.ResumeLayout(false);
            this.MobDevGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MobDevGroupBox;
        private System.Windows.Forms.ListBox classesNeeded;
        private System.Windows.Forms.ListBox classesCompleted;
        private System.Windows.Forms.Button removeClassButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button incompleteButton;
        private System.Windows.Forms.Button CompletedButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

