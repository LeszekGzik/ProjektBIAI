namespace ProjektBIAI
{
    partial class UserControlWorld
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
            ProjektBIAI.Character character1 = new ProjektBIAI.Character();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.labelIsPopulationCreated = new System.Windows.Forms.Label();
            this.buttonCreatePopulation = new System.Windows.Forms.Button();
            this.nudSizeOfPopulation = new System.Windows.Forms.NumericUpDown();
            this.labelSizeOfPopulation = new System.Windows.Forms.Label();
            this.labStepForFitness = new System.Windows.Forms.Label();
            this.nudStepForFitness = new System.Windows.Forms.NumericUpDown();
            this.nudNumberOfBattlesForCalculateFitness = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOfBattlesForCalculateFitness = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPopulation = new System.Windows.Forms.TabPage();
            this.labelRecalculateFitness = new System.Windows.Forms.Label();
            this.buttonRecalculateFitness = new System.Windows.Forms.Button();
            this.listViewPopulation = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFitness = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPreviousFitness = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxCalculateFitness = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.userControlCharacter1 = new ProjektBIAI.Forms.UserControlCharacter();
            this.columnHeaderChange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeOfPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStepForFitness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfBattlesForCalculateFitness)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPopulation.SuspendLayout();
            this.groupBoxCalculateFitness.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.labelIsPopulationCreated);
            this.groupBoxSettings.Controls.Add(this.buttonCreatePopulation);
            this.groupBoxSettings.Controls.Add(this.nudSizeOfPopulation);
            this.groupBoxSettings.Controls.Add(this.labelSizeOfPopulation);
            this.groupBoxSettings.Location = new System.Drawing.Point(6, 6);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(261, 95);
            this.groupBoxSettings.TabIndex = 1;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // labelIsPopulationCreated
            // 
            this.labelIsPopulationCreated.AutoSize = true;
            this.labelIsPopulationCreated.Location = new System.Drawing.Point(7, 72);
            this.labelIsPopulationCreated.Name = "labelIsPopulationCreated";
            this.labelIsPopulationCreated.Size = new System.Drawing.Size(114, 13);
            this.labelIsPopulationCreated.TabIndex = 7;
            this.labelIsPopulationCreated.Text = "Population not created";
            this.labelIsPopulationCreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCreatePopulation
            // 
            this.buttonCreatePopulation.Location = new System.Drawing.Point(10, 46);
            this.buttonCreatePopulation.Name = "buttonCreatePopulation";
            this.buttonCreatePopulation.Size = new System.Drawing.Size(245, 23);
            this.buttonCreatePopulation.TabIndex = 2;
            this.buttonCreatePopulation.Text = "Create population";
            this.buttonCreatePopulation.UseVisualStyleBackColor = true;
            this.buttonCreatePopulation.Click += new System.EventHandler(this.buttonCreatePopulation_Click);
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
            this.labelSizeOfPopulation.Location = new System.Drawing.Point(7, 22);
            this.labelSizeOfPopulation.Name = "labelSizeOfPopulation";
            this.labelSizeOfPopulation.Size = new System.Drawing.Size(91, 13);
            this.labelSizeOfPopulation.TabIndex = 0;
            this.labelSizeOfPopulation.Text = "Size of population";
            // 
            // labStepForFitness
            // 
            this.labStepForFitness.AutoSize = true;
            this.labStepForFitness.Location = new System.Drawing.Point(6, 50);
            this.labStepForFitness.Name = "labStepForFitness";
            this.labStepForFitness.Size = new System.Drawing.Size(125, 13);
            this.labStepForFitness.TabIndex = 6;
            this.labStepForFitness.Text = "Step (level of opponents)";
            // 
            // nudStepForFitness
            // 
            this.nudStepForFitness.Location = new System.Drawing.Point(183, 48);
            this.nudStepForFitness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStepForFitness.Name = "nudStepForFitness";
            this.nudStepForFitness.Size = new System.Drawing.Size(72, 20);
            this.nudStepForFitness.TabIndex = 5;
            this.nudStepForFitness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStepForFitness.ValueChanged += new System.EventHandler(this.nudStepForFitness_ValueChanged);
            // 
            // nudNumberOfBattlesForCalculateFitness
            // 
            this.nudNumberOfBattlesForCalculateFitness.Location = new System.Drawing.Point(183, 19);
            this.nudNumberOfBattlesForCalculateFitness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfBattlesForCalculateFitness.Name = "nudNumberOfBattlesForCalculateFitness";
            this.nudNumberOfBattlesForCalculateFitness.Size = new System.Drawing.Size(72, 20);
            this.nudNumberOfBattlesForCalculateFitness.TabIndex = 4;
            this.nudNumberOfBattlesForCalculateFitness.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumberOfBattlesForCalculateFitness.ValueChanged += new System.EventHandler(this.nudNumberOfBattlesForCalculateFitness_ValueChanged);
            // 
            // labelNumberOfBattlesForCalculateFitness
            // 
            this.labelNumberOfBattlesForCalculateFitness.AutoSize = true;
            this.labelNumberOfBattlesForCalculateFitness.Location = new System.Drawing.Point(7, 21);
            this.labelNumberOfBattlesForCalculateFitness.Name = "labelNumberOfBattlesForCalculateFitness";
            this.labelNumberOfBattlesForCalculateFitness.Size = new System.Drawing.Size(90, 13);
            this.labelNumberOfBattlesForCalculateFitness.TabIndex = 3;
            this.labelNumberOfBattlesForCalculateFitness.Text = "Number of battles";
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
            this.tabPopulation.Controls.Add(this.labelRecalculateFitness);
            this.tabPopulation.Controls.Add(this.buttonRecalculateFitness);
            this.tabPopulation.Controls.Add(this.listViewPopulation);
            this.tabPopulation.Controls.Add(this.groupBoxCalculateFitness);
            this.tabPopulation.Controls.Add(this.userControlCharacter1);
            this.tabPopulation.Controls.Add(this.groupBoxSettings);
            this.tabPopulation.Location = new System.Drawing.Point(4, 22);
            this.tabPopulation.Name = "tabPopulation";
            this.tabPopulation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPopulation.Size = new System.Drawing.Size(762, 504);
            this.tabPopulation.TabIndex = 0;
            this.tabPopulation.Text = "Population";
            this.tabPopulation.UseVisualStyleBackColor = true;
            // 
            // labelRecalculateFitness
            // 
            this.labelRecalculateFitness.AutoSize = true;
            this.labelRecalculateFitness.Location = new System.Drawing.Point(177, 230);
            this.labelRecalculateFitness.MaximumSize = new System.Drawing.Size(90, 0);
            this.labelRecalculateFitness.Name = "labelRecalculateFitness";
            this.labelRecalculateFitness.Size = new System.Drawing.Size(0, 13);
            this.labelRecalculateFitness.TabIndex = 10;
            // 
            // buttonRecalculateFitness
            // 
            this.buttonRecalculateFitness.Enabled = false;
            this.buttonRecalculateFitness.Location = new System.Drawing.Point(177, 189);
            this.buttonRecalculateFitness.Name = "buttonRecalculateFitness";
            this.buttonRecalculateFitness.Size = new System.Drawing.Size(90, 34);
            this.buttonRecalculateFitness.TabIndex = 9;
            this.buttonRecalculateFitness.Text = "Recalculate fitness";
            this.buttonRecalculateFitness.UseVisualStyleBackColor = true;
            this.buttonRecalculateFitness.Click += new System.EventHandler(this.buttonRecalculateFitness_Click);
            // 
            // listViewPopulation
            // 
            this.listViewPopulation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderFitness,
            this.columnHeaderPreviousFitness,
            this.columnHeaderChange});
            this.listViewPopulation.Location = new System.Drawing.Point(274, 7);
            this.listViewPopulation.Name = "listViewPopulation";
            this.listViewPopulation.Size = new System.Drawing.Size(482, 491);
            this.listViewPopulation.TabIndex = 8;
            this.listViewPopulation.UseCompatibleStateImageBehavior = false;
            this.listViewPopulation.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 100;
            // 
            // columnHeaderFitness
            // 
            this.columnHeaderFitness.Text = "Fitness";
            this.columnHeaderFitness.Width = 128;
            // 
            // columnHeaderPreviousFitness
            // 
            this.columnHeaderPreviousFitness.Text = "Previous fitness";
            this.columnHeaderPreviousFitness.Width = 100;
            // 
            // groupBoxCalculateFitness
            // 
            this.groupBoxCalculateFitness.Controls.Add(this.labelNumberOfBattlesForCalculateFitness);
            this.groupBoxCalculateFitness.Controls.Add(this.nudNumberOfBattlesForCalculateFitness);
            this.groupBoxCalculateFitness.Controls.Add(this.labStepForFitness);
            this.groupBoxCalculateFitness.Controls.Add(this.nudStepForFitness);
            this.groupBoxCalculateFitness.Location = new System.Drawing.Point(7, 108);
            this.groupBoxCalculateFitness.Name = "groupBoxCalculateFitness";
            this.groupBoxCalculateFitness.Size = new System.Drawing.Size(260, 74);
            this.groupBoxCalculateFitness.TabIndex = 7;
            this.groupBoxCalculateFitness.TabStop = false;
            this.groupBoxCalculateFitness.Text = "Fitness calculation settings";
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
            // userControlCharacter1
            // 
            character1.Fitness = 0;
            character1.Stats = new byte[] {
        ((byte)(1)),
        ((byte)(1)),
        ((byte)(1)),
        ((byte)(1)),
        ((byte)(1)),
        ((byte)(1)),
        ((byte)(1)),
        ((byte)(1)),
        ((byte)(1))};
            this.userControlCharacter1.Character = character1;
            this.userControlCharacter1.Location = new System.Drawing.Point(6, 188);
            this.userControlCharacter1.Name = "userControlCharacter1";
            this.userControlCharacter1.Size = new System.Drawing.Size(164, 310);
            this.userControlCharacter1.TabIndex = 2;
            // 
            // columnHeaderChange
            // 
            this.columnHeaderChange.Text = "Change";
            // 
            // UserControlWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControlWorld";
            this.Size = new System.Drawing.Size(770, 530);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeOfPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStepForFitness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfBattlesForCalculateFitness)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPopulation.ResumeLayout(false);
            this.tabPopulation.PerformLayout();
            this.groupBoxCalculateFitness.ResumeLayout(false);
            this.groupBoxCalculateFitness.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown nudNumberOfBattlesForCalculateFitness;
        private System.Windows.Forms.Label labelNumberOfBattlesForCalculateFitness;
        private System.Windows.Forms.Label labStepForFitness;
        private System.Windows.Forms.NumericUpDown nudStepForFitness;
        private Forms.UserControlCharacter userControlCharacter1;
        private System.Windows.Forms.Label labelIsPopulationCreated;
        private System.Windows.Forms.Button buttonRecalculateFitness;
        private System.Windows.Forms.ListView listViewPopulation;
        private System.Windows.Forms.GroupBox groupBoxCalculateFitness;
        private System.Windows.Forms.Label labelRecalculateFitness;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderFitness;
        private System.Windows.Forms.ColumnHeader columnHeaderPreviousFitness;
        private System.Windows.Forms.ColumnHeader columnHeaderChange;
    }
}
