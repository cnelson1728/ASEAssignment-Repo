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
            this.updateListButton = new System.Windows.Forms.Button();
            this.deleteBugButton = new System.Windows.Forms.Button();
            this.displayArchivedBugsButton = new System.Windows.Forms.Button();
            this.deleteBugID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 17);
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
            this.label1.Location = new System.Drawing.Point(132, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Archived Bugs";
            // 
            // archivedBugsListBox
            // 
            this.archivedBugsListBox.FormattingEnabled = true;
            this.archivedBugsListBox.Location = new System.Drawing.Point(12, 60);
            this.archivedBugsListBox.Name = "archivedBugsListBox";
            this.archivedBugsListBox.Size = new System.Drawing.Size(269, 329);
            this.archivedBugsListBox.TabIndex = 27;
            // 
            // updateListButton
            // 
            this.updateListButton.Location = new System.Drawing.Point(167, 406);
            this.updateListButton.Name = "updateListButton";
            this.updateListButton.Size = new System.Drawing.Size(97, 36);
            this.updateListButton.TabIndex = 28;
            this.updateListButton.Text = "Update List";
            this.updateListButton.UseVisualStyleBackColor = true;
            // 
            // deleteBugButton
            // 
            this.deleteBugButton.Location = new System.Drawing.Point(167, 454);
            this.deleteBugButton.Name = "deleteBugButton";
            this.deleteBugButton.Size = new System.Drawing.Size(97, 36);
            this.deleteBugButton.TabIndex = 29;
            this.deleteBugButton.Text = "Delete Bug";
            this.deleteBugButton.UseVisualStyleBackColor = true;
            // 
            // displayArchivedBugsButton
            // 
            this.displayArchivedBugsButton.Location = new System.Drawing.Point(21, 406);
            this.displayArchivedBugsButton.Name = "displayArchivedBugsButton";
            this.displayArchivedBugsButton.Size = new System.Drawing.Size(123, 36);
            this.displayArchivedBugsButton.TabIndex = 30;
            this.displayArchivedBugsButton.Text = "Display Archived Bugs";
            this.displayArchivedBugsButton.UseVisualStyleBackColor = true;
            this.displayArchivedBugsButton.Click += new System.EventHandler(this.displayArchivedBugsButton_Click);
            // 
            // deleteBugID
            // 
            this.deleteBugID.Location = new System.Drawing.Point(109, 463);
            this.deleteBugID.Name = "deleteBugID";
            this.deleteBugID.Size = new System.Drawing.Size(35, 20);
            this.deleteBugID.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Bug ID:";
            // 
            // archivedBugsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 509);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteBugID);
            this.Controls.Add(this.displayArchivedBugsButton);
            this.Controls.Add(this.deleteBugButton);
            this.Controls.Add(this.updateListButton);
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
        private System.Windows.Forms.Button updateListButton;
        private System.Windows.Forms.Button deleteBugButton;
        private System.Windows.Forms.Button displayArchivedBugsButton;
        private System.Windows.Forms.TextBox deleteBugID;
        private System.Windows.Forms.Label label2;
    }
}