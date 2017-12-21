namespace ASEAssignment
{
    partial class whiteBoxTesterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bugListBox = new System.Windows.Forms.ListBox();
            this.appNameTextBox = new System.Windows.Forms.TextBox();
            this.bugDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.bugCauseTextBox = new System.Windows.Forms.TextBox();
            this.classFileTextBox = new System.Windows.Forms.TextBox();
            this.methodTextBox = new System.Windows.Forms.TextBox();
            this.codeBlockTextBox = new System.Windows.Forms.TextBox();
            this.lineNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.displayBugsButton = new System.Windows.Forms.Button();
            this.clearBugsButton = new System.Windows.Forms.Button();
            this.clearBugButton = new System.Windows.Forms.Button();
            this.updateBugButton = new System.Windows.Forms.Button();
            this.pullBugButton = new System.Windows.Forms.Button();
            this.bugIDtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "White Box Tester";
            // 
            // bugListBox
            // 
            this.bugListBox.FormattingEnabled = true;
            this.bugListBox.Location = new System.Drawing.Point(374, 114);
            this.bugListBox.Name = "bugListBox";
            this.bugListBox.Size = new System.Drawing.Size(285, 342);
            this.bugListBox.TabIndex = 1;
            // 
            // appNameTextBox
            // 
            this.appNameTextBox.Location = new System.Drawing.Point(142, 114);
            this.appNameTextBox.Name = "appNameTextBox";
            this.appNameTextBox.ReadOnly = true;
            this.appNameTextBox.Size = new System.Drawing.Size(221, 20);
            this.appNameTextBox.TabIndex = 2;
            // 
            // bugDescriptionTextBox
            // 
            this.bugDescriptionTextBox.Location = new System.Drawing.Point(142, 154);
            this.bugDescriptionTextBox.Multiline = true;
            this.bugDescriptionTextBox.Name = "bugDescriptionTextBox";
            this.bugDescriptionTextBox.ReadOnly = true;
            this.bugDescriptionTextBox.Size = new System.Drawing.Size(221, 55);
            this.bugDescriptionTextBox.TabIndex = 3;
            // 
            // bugCauseTextBox
            // 
            this.bugCauseTextBox.Location = new System.Drawing.Point(142, 230);
            this.bugCauseTextBox.Multiline = true;
            this.bugCauseTextBox.Name = "bugCauseTextBox";
            this.bugCauseTextBox.ReadOnly = true;
            this.bugCauseTextBox.Size = new System.Drawing.Size(221, 53);
            this.bugCauseTextBox.TabIndex = 4;
            // 
            // classFileTextBox
            // 
            this.classFileTextBox.Location = new System.Drawing.Point(142, 306);
            this.classFileTextBox.Name = "classFileTextBox";
            this.classFileTextBox.Size = new System.Drawing.Size(221, 20);
            this.classFileTextBox.TabIndex = 5;
            // 
            // methodTextBox
            // 
            this.methodTextBox.Location = new System.Drawing.Point(142, 353);
            this.methodTextBox.Name = "methodTextBox";
            this.methodTextBox.Size = new System.Drawing.Size(221, 20);
            this.methodTextBox.TabIndex = 6;
            // 
            // codeBlockTextBox
            // 
            this.codeBlockTextBox.Location = new System.Drawing.Point(142, 395);
            this.codeBlockTextBox.Name = "codeBlockTextBox";
            this.codeBlockTextBox.Size = new System.Drawing.Size(221, 20);
            this.codeBlockTextBox.TabIndex = 7;
            // 
            // lineNumberTextBox
            // 
            this.lineNumberTextBox.Location = new System.Drawing.Point(142, 432);
            this.lineNumberTextBox.Name = "lineNumberTextBox";
            this.lineNumberTextBox.Size = new System.Drawing.Size(221, 20);
            this.lineNumberTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name of Application";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Brief Description of Bug";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cause of Bug";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Class File";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Method";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Code Block";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Line Number";
            // 
            // displayBugsButton
            // 
            this.displayBugsButton.Location = new System.Drawing.Point(451, 71);
            this.displayBugsButton.Name = "displayBugsButton";
            this.displayBugsButton.Size = new System.Drawing.Size(124, 37);
            this.displayBugsButton.TabIndex = 16;
            this.displayBugsButton.Text = "Display Bugs";
            this.displayBugsButton.UseVisualStyleBackColor = true;
            // 
            // clearBugsButton
            // 
            this.clearBugsButton.Location = new System.Drawing.Point(451, 462);
            this.clearBugsButton.Name = "clearBugsButton";
            this.clearBugsButton.Size = new System.Drawing.Size(124, 34);
            this.clearBugsButton.TabIndex = 17;
            this.clearBugsButton.Text = "Clear Bugs";
            this.clearBugsButton.UseVisualStyleBackColor = true;
            // 
            // clearBugButton
            // 
            this.clearBugButton.Location = new System.Drawing.Point(142, 462);
            this.clearBugButton.Name = "clearBugButton";
            this.clearBugButton.Size = new System.Drawing.Size(93, 34);
            this.clearBugButton.TabIndex = 18;
            this.clearBugButton.Text = "Clear Bug";
            this.clearBugButton.UseVisualStyleBackColor = true;
            // 
            // updateBugButton
            // 
            this.updateBugButton.Location = new System.Drawing.Point(262, 462);
            this.updateBugButton.Name = "updateBugButton";
            this.updateBugButton.Size = new System.Drawing.Size(101, 34);
            this.updateBugButton.TabIndex = 19;
            this.updateBugButton.Text = "Update Bug";
            this.updateBugButton.UseVisualStyleBackColor = true;
            // 
            // pullBugButton
            // 
            this.pullBugButton.Location = new System.Drawing.Point(252, 78);
            this.pullBugButton.Name = "pullBugButton";
            this.pullBugButton.Size = new System.Drawing.Size(111, 23);
            this.pullBugButton.TabIndex = 20;
            this.pullBugButton.Text = "Pull Bug Record";
            this.pullBugButton.UseVisualStyleBackColor = true;
            // 
            // bugIDtextBox
            // 
            this.bugIDtextBox.Location = new System.Drawing.Point(190, 80);
            this.bugIDtextBox.Name = "bugIDtextBox";
            this.bugIDtextBox.Size = new System.Drawing.Size(45, 20);
            this.bugIDtextBox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Bug ID";
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(13, 13);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(75, 23);
            this.mainMenuButton.TabIndex = 23;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // whiteBoxTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 560);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bugIDtextBox);
            this.Controls.Add(this.pullBugButton);
            this.Controls.Add(this.updateBugButton);
            this.Controls.Add(this.clearBugButton);
            this.Controls.Add(this.clearBugsButton);
            this.Controls.Add(this.displayBugsButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lineNumberTextBox);
            this.Controls.Add(this.codeBlockTextBox);
            this.Controls.Add(this.methodTextBox);
            this.Controls.Add(this.classFileTextBox);
            this.Controls.Add(this.bugCauseTextBox);
            this.Controls.Add(this.bugDescriptionTextBox);
            this.Controls.Add(this.appNameTextBox);
            this.Controls.Add(this.bugListBox);
            this.Controls.Add(this.label1);
            this.Name = "whiteBoxTesterForm";
            this.Text = "whiteBoxTesterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox bugListBox;
        private System.Windows.Forms.TextBox appNameTextBox;
        private System.Windows.Forms.TextBox bugDescriptionTextBox;
        private System.Windows.Forms.TextBox bugCauseTextBox;
        private System.Windows.Forms.TextBox classFileTextBox;
        private System.Windows.Forms.TextBox methodTextBox;
        private System.Windows.Forms.TextBox codeBlockTextBox;
        private System.Windows.Forms.TextBox lineNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button displayBugsButton;
        private System.Windows.Forms.Button clearBugsButton;
        private System.Windows.Forms.Button clearBugButton;
        private System.Windows.Forms.Button updateBugButton;
        private System.Windows.Forms.Button pullBugButton;
        private System.Windows.Forms.TextBox bugIDtextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button mainMenuButton;
    }
}