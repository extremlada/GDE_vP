namespace GDE_vP
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LoggedInName = new System.Windows.Forms.Label();
            this.LoggedInAs = new System.Windows.Forms.Label();
            this.StressTest = new System.Windows.Forms.Button();
            this.End_To_End = new System.Windows.Forms.Button();
            this.Cypress_TEST = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(599, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Sign in";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(599, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "log out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoggedInName
            // 
            this.LoggedInName.AutoSize = true;
            this.LoggedInName.Location = new System.Drawing.Point(722, 12);
            this.LoggedInName.Name = "LoggedInName";
            this.LoggedInName.Size = new System.Drawing.Size(0, 13);
            this.LoggedInName.TabIndex = 3;
            this.LoggedInName.Visible = false;
            // 
            // LoggedInAs
            // 
            this.LoggedInAs.AutoSize = true;
            this.LoggedInAs.Location = new System.Drawing.Point(728, 17);
            this.LoggedInAs.Name = "LoggedInAs";
            this.LoggedInAs.Size = new System.Drawing.Size(35, 13);
            this.LoggedInAs.TabIndex = 4;
            this.LoggedInAs.Text = "label1";
            this.LoggedInAs.Visible = false;
            this.LoggedInAs.Click += new System.EventHandler(this.LoggedInAs_Click);
            // 
            // StressTest
            // 
            this.StressTest.Location = new System.Drawing.Point(36, 362);
            this.StressTest.Name = "StressTest";
            this.StressTest.Size = new System.Drawing.Size(175, 35);
            this.StressTest.TabIndex = 5;
            this.StressTest.Text = "StressTest";
            this.StressTest.UseVisualStyleBackColor = true;
            // 
            // End_To_End
            // 
            this.End_To_End.Location = new System.Drawing.Point(361, 362);
            this.End_To_End.Name = "End_To_End";
            this.End_To_End.Size = new System.Drawing.Size(175, 35);
            this.End_To_End.TabIndex = 6;
            this.End_To_End.Text = "END_TO_END";
            this.End_To_End.UseVisualStyleBackColor = true;
            // 
            // Cypress_TEST
            // 
            this.Cypress_TEST.Location = new System.Drawing.Point(686, 362);
            this.Cypress_TEST.Name = "Cypress_TEST";
            this.Cypress_TEST.Size = new System.Drawing.Size(175, 35);
            this.Cypress_TEST.TabIndex = 7;
            this.Cypress_TEST.Text = "UserTest";
            this.Cypress_TEST.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tests you need to be logged in before using them";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(888, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cypress_TEST);
            this.Controls.Add(this.End_To_End);
            this.Controls.Add(this.StressTest);
            this.Controls.Add(this.LoggedInAs);
            this.Controls.Add(this.LoggedInName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LoggedInName;
        private System.Windows.Forms.Label LoggedInAs;
        private System.Windows.Forms.Button StressTest;
        private System.Windows.Forms.Button End_To_End;
        private System.Windows.Forms.Button Cypress_TEST;
        private System.Windows.Forms.Label label1;
    }
}

