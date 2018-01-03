namespace ASEAssignment
{
    partial class developerForm
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
            this.button6 = new System.Windows.Forms.Button();
            this.displayBugsButton = new System.Windows.Forms.Button();
            this.clearBugsButton = new System.Windows.Forms.Button();
            this.bugsDisplayBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chosenBugIDBox = new System.Windows.Forms.TextBox();
            this.chosenBugDisplayBox = new System.Windows.Forms.ListBox();
            this.displayBugButton = new System.Windows.Forms.Button();
            this.fixerNameTextBox = new System.Windows.Forms.TextBox();
            this.fixDateTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.archiveBugsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteBugButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fixedBugIDTextBox = new System.Windows.Forms.TextBox();
            this.clearBugButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "Main Menu";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // displayBugsButton
            // 
            this.displayBugsButton.Location = new System.Drawing.Point(63, 53);
            this.displayBugsButton.Name = "displayBugsButton";
            this.displayBugsButton.Size = new System.Drawing.Size(89, 36);
            this.displayBugsButton.TabIndex = 25;
            this.displayBugsButton.Text = "Display Bugs";
            this.displayBugsButton.UseVisualStyleBackColor = true;
            this.displayBugsButton.Click += new System.EventHandler(this.displayBugsButton_Click);
            // 
            // clearBugsButton
            // 
            this.clearBugsButton.Location = new System.Drawing.Point(63, 456);
            this.clearBugsButton.Name = "clearBugsButton";
            this.clearBugsButton.Size = new System.Drawing.Size(89, 36);
            this.clearBugsButton.TabIndex = 26;
            this.clearBugsButton.Text = "Clear Bugs";
            this.clearBugsButton.UseVisualStyleBackColor = true;
            this.clearBugsButton.Click += new System.EventHandler(this.clearBugsButton_Click);
            // 
            // bugsDisplayBox
            // 
            this.bugsDisplayBox.FormattingEnabled = true;
            this.bugsDisplayBox.Location = new System.Drawing.Point(9, 95);
            this.bugsDisplayBox.Name = "bugsDisplayBox";
            this.bugsDisplayBox.Size = new System.Drawing.Size(213, 355);
            this.bugsDisplayBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bug ID";
            // 
            // chosenBugIDBox
            // 
            this.chosenBugIDBox.Location = new System.Drawing.Point(311, 66);
            this.chosenBugIDBox.Name = "chosenBugIDBox";
            this.chosenBugIDBox.Size = new System.Drawing.Size(37, 20);
            this.chosenBugIDBox.TabIndex = 29;
            // 
            // chosenBugDisplayBox
            // 
            this.chosenBugDisplayBox.FormattingEnabled = true;
            this.chosenBugDisplayBox.Location = new System.Drawing.Point(243, 95);
            this.chosenBugDisplayBox.Name = "chosenBugDisplayBox";
            this.chosenBugDisplayBox.Size = new System.Drawing.Size(213, 355);
            this.chosenBugDisplayBox.TabIndex = 30;
            // 
            // displayBugButton
            // 
            this.displayBugButton.Location = new System.Drawing.Point(354, 66);
            this.displayBugButton.Name = "displayBugButton";
            this.displayBugButton.Size = new System.Drawing.Size(75, 23);
            this.displayBugButton.TabIndex = 31;
            this.displayBugButton.Text = "Display";
            this.displayBugButton.UseVisualStyleBackColor = true;
            this.displayBugButton.Click += new System.EventHandler(this.displayBugButton_Click);
            // 
            // fixerNameTextBox
            // 
            this.fixerNameTextBox.Location = new System.Drawing.Point(534, 136);
            this.fixerNameTextBox.Name = "fixerNameTextBox";
            this.fixerNameTextBox.Size = new System.Drawing.Size(166, 20);
            this.fixerNameTextBox.TabIndex = 32;
            // 
            // fixDateTextBox
            // 
            this.fixDateTextBox.Location = new System.Drawing.Point(534, 178);
            this.fixDateTextBox.Name = "fixDateTextBox";
            this.fixDateTextBox.Size = new System.Drawing.Size(166, 20);
            this.fixDateTextBox.TabIndex = 33;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(534, 217);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(166, 109);
            this.commentTextBox.TabIndex = 34;
            // 
            // archiveBugsButton
            // 
            this.archiveBugsButton.Location = new System.Drawing.Point(534, 351);
            this.archiveBugsButton.Name = "archiveBugsButton";
            this.archiveBugsButton.Size = new System.Drawing.Size(139, 39);
            this.archiveBugsButton.TabIndex = 35;
            this.archiveBugsButton.Text = "Archive Bug";
            this.archiveBugsButton.UseVisualStyleBackColor = true;
            this.archiveBugsButton.Click += new System.EventHandler(this.archiveBugsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fixer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Fix Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Comment";
            // 
            // deleteBugButton
            // 
            this.deleteBugButton.Location = new System.Drawing.Point(352, 456);
            this.deleteBugButton.Name = "deleteBugButton";
            this.deleteBugButton.Size = new System.Drawing.Size(77, 36);
            this.deleteBugButton.TabIndex = 39;
            this.deleteBugButton.Text = "Delete Bug";
            this.deleteBugButton.UseVisualStyleBackColor = true;
            this.deleteBugButton.Click += new System.EventHandler(this.deleteBugButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Bug ID";
            // 
            // fixedBugIDTextBox
            // 
            this.fixedBugIDTextBox.Location = new System.Drawing.Point(534, 96);
            this.fixedBugIDTextBox.Name = "fixedBugIDTextBox";
            this.fixedBugIDTextBox.Size = new System.Drawing.Size(39, 20);
            this.fixedBugIDTextBox.TabIndex = 41;
            // 
            // clearBugButton
            // 
            this.clearBugButton.Location = new System.Drawing.Point(261, 456);
            this.clearBugButton.Name = "clearBugButton";
            this.clearBugButton.Size = new System.Drawing.Size(73, 36);
            this.clearBugButton.TabIndex = 42;
            this.clearBugButton.Text = "Clear Bug";
            this.clearBugButton.UseVisualStyleBackColor = true;
            this.clearBugButton.Click += new System.EventHandler(this.clearBugButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Developer";
            // 
            // developerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 528);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clearBugButton);
            this.Controls.Add(this.fixedBugIDTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteBugButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.archiveBugsButton);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.fixDateTextBox);
            this.Controls.Add(this.fixerNameTextBox);
            this.Controls.Add(this.displayBugButton);
            this.Controls.Add(this.chosenBugDisplayBox);
            this.Controls.Add(this.chosenBugIDBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bugsDisplayBox);
            this.Controls.Add(this.clearBugsButton);
            this.Controls.Add(this.displayBugsButton);
            this.Controls.Add(this.button6);
            this.Name = "developerForm";
            this.Text = "developerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button displayBugsButton;
        private System.Windows.Forms.Button clearBugsButton;
        private System.Windows.Forms.ListBox bugsDisplayBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chosenBugIDBox;
        private System.Windows.Forms.ListBox chosenBugDisplayBox;
        private System.Windows.Forms.Button displayBugButton;
        private System.Windows.Forms.TextBox fixerNameTextBox;
        private System.Windows.Forms.TextBox fixDateTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Button archiveBugsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteBugButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fixedBugIDTextBox;
        private System.Windows.Forms.Button clearBugButton;
        private System.Windows.Forms.Label label6;
    }
}