namespace ASEAssignment
{
    partial class archivedBugsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.archivedBugsListBox = new System.Windows.Forms.ListBox();
            this.deleteBugButton = new System.Windows.Forms.Button();
            this.deleteBugID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.displaySourceCode = new System.Windows.Forms.TextBox();
            this.displaySourceCodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 25;
            this.button6.Text = "Main Menu";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Archived Bugs";
            // 
            // archivedBugsListBox
            // 
            this.archivedBugsListBox.FormattingEnabled = true;
            this.archivedBugsListBox.Location = new System.Drawing.Point(15, 60);
            this.archivedBugsListBox.Name = "archivedBugsListBox";
            this.archivedBugsListBox.Size = new System.Drawing.Size(421, 368);
            this.archivedBugsListBox.TabIndex = 27;
            // 
            // deleteBugButton
            // 
            this.deleteBugButton.Location = new System.Drawing.Point(324, 439);
            this.deleteBugButton.Name = "deleteBugButton";
            this.deleteBugButton.Size = new System.Drawing.Size(112, 36);
            this.deleteBugButton.TabIndex = 29;
            this.deleteBugButton.Text = "Delete Bug";
            this.deleteBugButton.UseVisualStyleBackColor = true;
            this.deleteBugButton.Click += new System.EventHandler(this.deleteBugButton_Click);
            // 
            // deleteBugID
            // 
            this.deleteBugID.Location = new System.Drawing.Point(272, 448);
            this.deleteBugID.Name = "deleteBugID";
            this.deleteBugID.Size = new System.Drawing.Size(35, 20);
            this.deleteBugID.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Bug ID:";
            // 
            // displaySourceCode
            // 
            this.displaySourceCode.Enabled = false;
            this.displaySourceCode.Location = new System.Drawing.Point(471, 60);
            this.displaySourceCode.Multiline = true;
            this.displaySourceCode.Name = "displaySourceCode";
            this.displaySourceCode.Size = new System.Drawing.Size(314, 368);
            this.displaySourceCode.TabIndex = 33;
            // 
            // displaySourceCodeButton
            // 
            this.displaySourceCodeButton.Location = new System.Drawing.Point(471, 439);
            this.displaySourceCodeButton.Name = "displaySourceCodeButton";
            this.displaySourceCodeButton.Size = new System.Drawing.Size(123, 36);
            this.displaySourceCodeButton.TabIndex = 34;
            this.displaySourceCodeButton.Text = "Display Source Code";
            this.displaySourceCodeButton.UseVisualStyleBackColor = true;
            this.displaySourceCodeButton.Click += new System.EventHandler(this.displaySourceCodeButton_Click);
            // 
            // archivedBugsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 490);
            this.Controls.Add(this.displaySourceCodeButton);
            this.Controls.Add(this.displaySourceCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteBugID);
            this.Controls.Add(this.deleteBugButton);
            this.Controls.Add(this.archivedBugsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Name = "archivedBugsForm";
            this.Text = "archivedBugsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox archivedBugsListBox;
        private System.Windows.Forms.Button deleteBugButton;
        private System.Windows.Forms.TextBox deleteBugID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox displaySourceCode;
        private System.Windows.Forms.Button displaySourceCodeButton;
    }
}