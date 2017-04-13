namespace ProjektBIAI
{
    partial class FormMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSimulator = new System.Windows.Forms.TabPage();
            this.userControlCharacter2 = new ProjektBIAI.Forms.UserControlCharacter();
            this.userControlCharacter1 = new ProjektBIAI.Forms.UserControlCharacter();
            this.butStartFight = new System.Windows.Forms.Button();
            this.textBoxResults = new System.Windows.Forms.RichTextBox();
            this.tabWorld = new System.Windows.Forms.TabPage();
            this.userControlWorld = new ProjektBIAI.UserControlWorld();
            this.tabControl1.SuspendLayout();
            this.tabSimulator.SuspendLayout();
            this.tabWorld.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSimulator);
            this.tabControl1.Controls.Add(this.tabWorld);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 413);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSimulator
            // 
            this.tabSimulator.Controls.Add(this.userControlCharacter2);
            this.tabSimulator.Controls.Add(this.userControlCharacter1);
            this.tabSimulator.Controls.Add(this.butStartFight);
            this.tabSimulator.Controls.Add(this.textBoxResults);
            this.tabSimulator.Location = new System.Drawing.Point(4, 22);
            this.tabSimulator.Name = "tabSimulator";
            this.tabSimulator.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimulator.Size = new System.Drawing.Size(772, 387);
            this.tabSimulator.TabIndex = 0;
            this.tabSimulator.Text = "Simulator";
            this.tabSimulator.UseVisualStyleBackColor = true;
            // 
            // userControlCharacter2
            // 
            this.userControlCharacter2.Location = new System.Drawing.Point(604, 5);
            this.userControlCharacter2.Name = "userControlCharacter2";
            this.userControlCharacter2.Size = new System.Drawing.Size(164, 310);
            this.userControlCharacter2.TabIndex = 6;
            // 
            // userControlCharacter1
            // 
            this.userControlCharacter1.Location = new System.Drawing.Point(5, 7);
            this.userControlCharacter1.Name = "userControlCharacter1";
            this.userControlCharacter1.Size = new System.Drawing.Size(164, 310);
            this.userControlCharacter1.TabIndex = 5;
            // 
            // butStartFight
            // 
            this.butStartFight.Location = new System.Drawing.Point(172, 287);
            this.butStartFight.Name = "butStartFight";
            this.butStartFight.Size = new System.Drawing.Size(433, 23);
            this.butStartFight.TabIndex = 4;
            this.butStartFight.Text = "FIGHT!";
            this.butStartFight.UseVisualStyleBackColor = true;
            this.butStartFight.Click += new System.EventHandler(this.butStartFight_Click);
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(172, 7);
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.Size = new System.Drawing.Size(433, 273);
            this.textBoxResults.TabIndex = 2;
            this.textBoxResults.Text = "";
            // 
            // tabWorld
            // 
            this.tabWorld.Controls.Add(this.userControlWorld);
            this.tabWorld.Location = new System.Drawing.Point(4, 22);
            this.tabWorld.Name = "tabWorld";
            this.tabWorld.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorld.Size = new System.Drawing.Size(772, 387);
            this.tabWorld.TabIndex = 1;
            this.tabWorld.Text = "World";
            this.tabWorld.UseVisualStyleBackColor = true;
            // 
            // userControlWorld
            // 
            this.userControlWorld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlWorld.Location = new System.Drawing.Point(3, 3);
            this.userControlWorld.Name = "userControlWorld";
            this.userControlWorld.Size = new System.Drawing.Size(766, 381);
            this.userControlWorld.TabIndex = 0;
            this.userControlWorld.Load += new System.EventHandler(this.userControlWorld_Load);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 413);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Battle Arena BIAI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSimulator.ResumeLayout(false);
            this.tabWorld.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSimulator;
        private System.Windows.Forms.TabPage tabWorld;
        private System.Windows.Forms.RichTextBox textBoxResults;
        private System.Windows.Forms.Button butStartFight;
        private UserControlWorld userControlWorld;
        private Forms.UserControlCharacter userControlCharacter1;
        private Forms.UserControlCharacter userControlCharacter2;
    }
}

