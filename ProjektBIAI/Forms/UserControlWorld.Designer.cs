﻿namespace ProjektBIAI
{
    partial class UserControlEnvironment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.nudSizeOfPopulation = new System.Windows.Forms.NumericUpDown();
            this.labelSizeOfPopulation = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPopulation = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonCreatePopulation = new System.Windows.Forms.Button();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeOfPopulation)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPopulation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.buttonCreatePopulation);
            this.groupBoxSettings.Controls.Add(this.nudSizeOfPopulation);
            this.groupBoxSettings.Controls.Add(this.labelSizeOfPopulation);
            this.groupBoxSettings.Location = new System.Drawing.Point(6, 6);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(261, 123);
            this.groupBoxSettings.TabIndex = 1;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // nudSizeOfPopulation
            // 
            this.nudSizeOfPopulation.Location = new System.Drawing.Point(183, 20);
            this.nudSizeOfPopulation.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudSizeOfPopulation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSizeOfPopulation.Name = "nudSizeOfPopulation";
            this.nudSizeOfPopulation.Size = new System.Drawing.Size(72, 20);
            this.nudSizeOfPopulation.TabIndex = 1;
            this.nudSizeOfPopulation.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelSizeOfPopulation
            // 
            this.labelSizeOfPopulation.AutoSize = true;
            this.labelSizeOfPopulation.Location = new System.Drawing.Point(7, 20);
            this.labelSizeOfPopulation.Name = "labelSizeOfPopulation";
            this.labelSizeOfPopulation.Size = new System.Drawing.Size(91, 13);
            this.labelSizeOfPopulation.TabIndex = 0;
            this.labelSizeOfPopulation.Text = "Size of population";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPopulation);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 530);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPopulation
            // 
            this.tabPopulation.Controls.Add(this.groupBoxSettings);
            this.tabPopulation.Location = new System.Drawing.Point(4, 22);
            this.tabPopulation.Name = "tabPopulation";
            this.tabPopulation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPopulation.Size = new System.Drawing.Size(762, 504);
            this.tabPopulation.TabIndex = 0;
            this.tabPopulation.Text = "Population";
            this.tabPopulation.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonCreatePopulation
            // 
            this.buttonCreatePopulation.Location = new System.Drawing.Point(10, 94);
            this.buttonCreatePopulation.Name = "buttonCreatePopulation";
            this.buttonCreatePopulation.Size = new System.Drawing.Size(245, 23);
            this.buttonCreatePopulation.TabIndex = 2;
            this.buttonCreatePopulation.Text = "Create population";
            this.buttonCreatePopulation.UseVisualStyleBackColor = true;
            this.buttonCreatePopulation.Click += new System.EventHandler(this.buttonCreatePopulation_Click);
            // 
            // UserControlEnvironment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControlEnvironment";
            this.Size = new System.Drawing.Size(770, 530);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeOfPopulation)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPopulation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.NumericUpDown nudSizeOfPopulation;
        private System.Windows.Forms.Label labelSizeOfPopulation;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPopulation;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonCreatePopulation;
    }
}
