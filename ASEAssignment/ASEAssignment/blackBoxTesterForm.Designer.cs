namespace ASEAssignment
{
    partial class blackBoxTesterForm
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
            this.bugSubmitButton = new System.Windows.Forms.Button();
            this.appNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.symptomTextBox = new System.Windows.Forms.TextBox();
            this.causeOfBugTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bugSubmitButton
            // 
            this.bugSubmitButton.Location = new System.Drawing.Point(106, 303);
            this.bugSubmitButton.Name = "bugSubmitButton";
            this.bugSubmitButton.Size = new System.Drawing.Size(121, 47);
            this.bugSubmitButton.TabIndex = 0;
            this.bugSubmitButton.Text = "Submit Bug";
            this.bugSubmitButton.UseVisualStyleBackColor = true;
            this.bugSubmitButton.Click += new System.EventHandler(this.bugSubmitButton_Click);
            // 
            // appNameTextBox
            // 
            this.appNameTextBox.Location = new System.Drawing.Point(154, 105);
            this.appNameTextBox.Multiline = true;
            this.appNameTextBox.Name = "appNameTextBox";
            this.appNameTextBox.Size = new System.Drawing.Size(169, 26);
            this.appNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Symptom";
            // 
            // symptomTextBox
            // 
            this.symptomTextBox.Location = new System.Drawing.Point(154, 154);
            this.symptomTextBox.Multiline = true;
            this.symptomTextBox.Name = "symptomTextBox";
            this.symptomTextBox.Size = new System.Drawing.Size(169, 47);
            this.symptomTextBox.TabIndex = 4;
            // 
            // causeOfBugTextBox
            // 
            this.causeOfBugTextBox.Location = new System.Drawing.Point(154, 222);
            this.causeOfBugTextBox.Multiline = true;
            this.causeOfBugTextBox.Name = "causeOfBugTextBox";
            this.causeOfBugTextBox.Size = new System.Drawing.Size(169, 48);
            this.causeOfBugTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cause of Bug";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(159, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Black Box Tester";
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(12, 12);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(75, 23);
            this.mainMenuButton.TabIndex = 24;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // blackBoxTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 382);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.causeOfBugTextBox);
            this.Controls.Add(this.symptomTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appNameTextBox);
            this.Controls.Add(this.bugSubmitButton);
            this.Name = "blackBoxTesterForm";
            this.Text = "blackBoxTesterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bugSubmitButton;
        private System.Windows.Forms.TextBox appNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox symptomTextBox;
        private System.Windows.Forms.TextBox causeOfBugTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button mainMenuButton;
    }
}