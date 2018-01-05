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
            this.clearBugButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.editSourceCodeTextBox = new System.Windows.Forms.TextBox();
            this.sourceCodeWebBrowser = new System.Windows.Forms.WebBrowser();
            this.displaySourceCode = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.viewArchivedBugsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 31);
            this.button6.TabIndex = 24;
            this.button6.Text = "Main Menu";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bugsDisplayBox
            // 
            this.bugsDisplayBox.FormattingEnabled = true;
            this.bugsDisplayBox.Location = new System.Drawing.Point(9, 60);
            this.bugsDisplayBox.Name = "bugsDisplayBox";
            this.bugsDisplayBox.Size = new System.Drawing.Size(213, 472);
            this.bugsDisplayBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bug ID";
            // 
            // chosenBugIDBox
            // 
            this.chosenBugIDBox.Location = new System.Drawing.Point(273, 70);
            this.chosenBugIDBox.Name = "chosenBugIDBox";
            this.chosenBugIDBox.Size = new System.Drawing.Size(37, 20);
            this.chosenBugIDBox.TabIndex = 29;
            // 
            // chosenBugDisplayBox
            // 
            this.chosenBugDisplayBox.FormattingEnabled = true;
            this.chosenBugDisplayBox.Location = new System.Drawing.Point(233, 100);
            this.chosenBugDisplayBox.Name = "chosenBugDisplayBox";
            this.chosenBugDisplayBox.Size = new System.Drawing.Size(237, 186);
            this.chosenBugDisplayBox.TabIndex = 30;
            // 
            // displayBugButton
            // 
            this.displayBugButton.Location = new System.Drawing.Point(316, 64);
            this.displayBugButton.Name = "displayBugButton";
            this.displayBugButton.Size = new System.Drawing.Size(75, 30);
            this.displayBugButton.TabIndex = 31;
            this.displayBugButton.Text = "Display";
            this.displayBugButton.UseVisualStyleBackColor = true;
            this.displayBugButton.Click += new System.EventHandler(this.displayBugButton_Click);
            // 
            // fixerNameTextBox
            // 
            this.fixerNameTextBox.Location = new System.Drawing.Point(297, 300);
            this.fixerNameTextBox.Name = "fixerNameTextBox";
            this.fixerNameTextBox.Size = new System.Drawing.Size(173, 20);
            this.fixerNameTextBox.TabIndex = 32;
            // 
            // fixDateTextBox
            // 
            this.fixDateTextBox.Location = new System.Drawing.Point(297, 346);
            this.fixDateTextBox.Name = "fixDateTextBox";
            this.fixDateTextBox.Size = new System.Drawing.Size(173, 20);
            this.fixDateTextBox.TabIndex = 33;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(297, 379);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(173, 112);
            this.commentTextBox.TabIndex = 34;
            // 
            // archiveBugsButton
            // 
            this.archiveBugsButton.Location = new System.Drawing.Point(387, 499);
            this.archiveBugsButton.Name = "archiveBugsButton";
            this.archiveBugsButton.Size = new System.Drawing.Size(83, 36);
            this.archiveBugsButton.TabIndex = 35;
            this.archiveBugsButton.Text = "Archive Bug";
            this.archiveBugsButton.UseVisualStyleBackColor = true;
            this.archiveBugsButton.Click += new System.EventHandler(this.archiveBugsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fixer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Fix Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Comment";
            // 
            // deleteBugButton
            // 
            this.deleteBugButton.Location = new System.Drawing.Point(476, 64);
            this.deleteBugButton.Name = "deleteBugButton";
            this.deleteBugButton.Size = new System.Drawing.Size(77, 30);
            this.deleteBugButton.TabIndex = 39;
            this.deleteBugButton.Text = "Delete Bug";
            this.deleteBugButton.UseVisualStyleBackColor = true;
            this.deleteBugButton.Click += new System.EventHandler(this.deleteBugButton_Click);
            // 
            // clearBugButton
            // 
            this.clearBugButton.Location = new System.Drawing.Point(397, 64);
            this.clearBugButton.Name = "clearBugButton";
            this.clearBugButton.Size = new System.Drawing.Size(73, 30);
            this.clearBugButton.TabIndex = 42;
            this.clearBugButton.Text = "Clear Bug";
            this.clearBugButton.UseVisualStyleBackColor = true;
            this.clearBugButton.Click += new System.EventHandler(this.clearBugButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(440, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Developer";
            // 
            // editSourceCodeTextBox
            // 
            this.editSourceCodeTextBox.Location = new System.Drawing.Point(476, 99);
            this.editSourceCodeTextBox.Multiline = true;
            this.editSourceCodeTextBox.Name = "editSourceCodeTextBox";
            this.editSourceCodeTextBox.Size = new System.Drawing.Size(467, 189);
            this.editSourceCodeTextBox.TabIndex = 44;
            // 
            // sourceCodeWebBrowser
            // 
            this.sourceCodeWebBrowser.Location = new System.Drawing.Point(476, 346);
            this.sourceCodeWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.sourceCodeWebBrowser.Name = "sourceCodeWebBrowser";
            this.sourceCodeWebBrowser.Size = new System.Drawing.Size(467, 189);
            this.sourceCodeWebBrowser.TabIndex = 45;
            // 
            // displaySourceCode
            // 
            this.displaySourceCode.Location = new System.Drawing.Point(476, 300);
            this.displaySourceCode.Name = "displaySourceCode";
            this.displaySourceCode.Size = new System.Drawing.Size(117, 36);
            this.displaySourceCode.TabIndex = 46;
            this.displaySourceCode.Text = "Display Formatted Source Code";
            this.displaySourceCode.UseVisualStyleBackColor = true;
            this.displaySourceCode.Click += new System.EventHandler(this.displaySourceCode_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(666, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Source Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(624, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Formatted Source Code";
            // 
            // viewArchivedBugsButton
            // 
            this.viewArchivedBugsButton.Location = new System.Drawing.Point(818, 12);
            this.viewArchivedBugsButton.Name = "viewArchivedBugsButton";
            this.viewArchivedBugsButton.Size = new System.Drawing.Size(125, 31);
            this.viewArchivedBugsButton.TabIndex = 49;
            this.viewArchivedBugsButton.Text = "View Archived Bugs";
            this.viewArchivedBugsButton.UseVisualStyleBackColor = true;
            this.viewArchivedBugsButton.Click += new System.EventHandler(this.viewArchivedBugsButton_Click);
            // 
            // developerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 545);
            this.Controls.Add(this.viewArchivedBugsButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.displaySourceCode);
            this.Controls.Add(this.sourceCodeWebBrowser);
            this.Controls.Add(this.editSourceCodeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clearBugButton);
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
            this.Controls.Add(this.button6);
            this.Name = "developerForm";
            this.Text = "developerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
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
        private System.Windows.Forms.Button clearBugButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox editSourceCodeTextBox;
        private System.Windows.Forms.WebBrowser sourceCodeWebBrowser;
        private System.Windows.Forms.Button displaySourceCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button viewArchivedBugsButton;
    }
}