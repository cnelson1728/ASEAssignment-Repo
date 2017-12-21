namespace ASEAssignment
{
    partial class mainMenu
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
            this.blackBoxTesterButton = new System.Windows.Forms.Button();
            this.whiteBoxTesterButton = new System.Windows.Forms.Button();
            this.developerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.archivedBugsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // blackBoxTesterButton
            // 
            this.blackBoxTesterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.blackBoxTesterButton.Location = new System.Drawing.Point(195, 161);
            this.blackBoxTesterButton.Name = "blackBoxTesterButton";
            this.blackBoxTesterButton.Size = new System.Drawing.Size(168, 56);
            this.blackBoxTesterButton.TabIndex = 0;
            this.blackBoxTesterButton.Text = "Black Box Tester";
            this.blackBoxTesterButton.UseVisualStyleBackColor = true;
            this.blackBoxTesterButton.Click += new System.EventHandler(this.blackBoxTesterButton_Click);
            // 
            // whiteBoxTesterButton
            // 
            this.whiteBoxTesterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.whiteBoxTesterButton.Location = new System.Drawing.Point(195, 223);
            this.whiteBoxTesterButton.Name = "whiteBoxTesterButton";
            this.whiteBoxTesterButton.Size = new System.Drawing.Size(168, 55);
            this.whiteBoxTesterButton.TabIndex = 1;
            this.whiteBoxTesterButton.Text = "White Box Tester";
            this.whiteBoxTesterButton.UseVisualStyleBackColor = true;
            this.whiteBoxTesterButton.Click += new System.EventHandler(this.whiteBoxTesterButton_Click);
            // 
            // developerButton
            // 
            this.developerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developerButton.Location = new System.Drawing.Point(195, 284);
            this.developerButton.Name = "developerButton";
            this.developerButton.Size = new System.Drawing.Size(168, 58);
            this.developerButton.TabIndex = 2;
            this.developerButton.Text = "Developer";
            this.developerButton.UseVisualStyleBackColor = true;
            this.developerButton.Click += new System.EventHandler(this.developerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(109, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bug Tracker Application";
            // 
            // archivedBugsButton
            // 
            this.archivedBugsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.archivedBugsButton.Location = new System.Drawing.Point(195, 379);
            this.archivedBugsButton.Name = "archivedBugsButton";
            this.archivedBugsButton.Size = new System.Drawing.Size(168, 55);
            this.archivedBugsButton.TabIndex = 4;
            this.archivedBugsButton.Text = "Archived Bugs";
            this.archivedBugsButton.UseVisualStyleBackColor = true;
            this.archivedBugsButton.Click += new System.EventHandler(this.archivedBugsButton_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 484);
            this.Controls.Add(this.archivedBugsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.developerButton);
            this.Controls.Add(this.whiteBoxTesterButton);
            this.Controls.Add(this.blackBoxTesterButton);
            this.Name = "mainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button blackBoxTesterButton;
        private System.Windows.Forms.Button whiteBoxTesterButton;
        private System.Windows.Forms.Button developerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button archivedBugsButton;
    }
}

