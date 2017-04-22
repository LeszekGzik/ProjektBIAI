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
            ProjektBIAI.Character character2 = new ProjektBIAI.Character();
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
            this.nudGenerationNumber = new System.Windows.Forms.NumericUpDown();
            this.labelGenerationNumber = new System.Windows.Forms.Label();
            this.labelRecalculateFitness = new System.Windows.Forms.Label();
            this.buttonRecalculateFitness = new System.Windows.Forms.Button();
            this.listViewPopulation = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFitness = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPreviousFitness = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderChange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGenotype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxCalculateFitness = new System.Windows.Forms.GroupBox();
            this.userControlCharacter1 = new ProjektBIAI.Forms.UserControlCharacter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxCrossover = new System.Windows.Forms.GroupBox();
            this.groupBoxMutationMethod = new System.Windows.Forms.GroupBox();
            this.nudPercentMutation = new System.Windows.Forms.NumericUpDown();
            this.nudConstantMutation = new System.Windows.Forms.NumericUpDown();
            this.nudRandomMutation = new System.Windows.Forms.NumericUpDown();
            this.radioButtonPercentMutation = new System.Windows.Forms.RadioButton();
            this.radioButtonConstantMutation = new System.Windows.Forms.RadioButton();
            this.radioButtonRandomMutation = new System.Windows.Forms.RadioButton();
            this.groupBoxSelectionSettings = new System.Windows.Forms.GroupBox();
            this.radioButtonLinearIndex = new System.Windows.Forms.RadioButton();
            this.radioButtonBiasedRoulette = new System.Windows.Forms.RadioButton();
            this.groupBoxMutationSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxDisableMutation = new System.Windows.Forms.CheckBox();
            this.nudMutationRate = new System.Windows.Forms.NumericUpDown();
            this.labelMutationRate = new System.Windows.Forms.Label();
            this.groupBoxGenerationControls = new System.Windows.Forms.GroupBox();
            this.labelCreatingGenerationStatus = new System.Windows.Forms.Label();
            this.nudXGenerations = new System.Windows.Forms.NumericUpDown();
            this.buttonXGenerations = new System.Windows.Forms.Button();
            this.buttonNextGeneration = new System.Windows.Forms.Button();
            this.listViewGenerations = new System.Windows.Forms.ListView();
            this.columnHeaderGen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMaxFitness = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMinFitness = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAvgFitness = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nudCrossoverChance = new System.Windows.Forms.NumericUpDown();
            this.nudSinglePointCrossover = new System.Windows.Forms.NumericUpDown();
            this.nudTwoPointCrossover = new System.Windows.Forms.NumericUpDown();
            this.labelCrossoverChance = new System.Windows.Forms.Label();
            this.labelSinglePointCrossover = new System.Windows.Forms.Label();
            this.labelTwoPointCrossover = new System.Windows.Forms.Label();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeOfPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStepForFitness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfBattlesForCalculateFitness)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPopulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGenerationNumber)).BeginInit();
            this.groupBoxCalculateFitness.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxCrossover.SuspendLayout();
            this.groupBoxMutationMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercentMutation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConstantMutation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandomMutation)).BeginInit();
            this.groupBoxSelectionSettings.SuspendLayout();
            this.groupBoxMutationSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutationRate)).BeginInit();
            this.groupBoxGenerationControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXGenerations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCrossoverChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSinglePointCrossover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTwoPointCrossover)).BeginInit();
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
            this.tabPopulation.Controls.Add(this.nudGenerationNumber);
            this.tabPopulation.Controls.Add(this.labelGenerationNumber);
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
            // nudGenerationNumber
            // 
            this.nudGenerationNumber.Location = new System.Drawing.Point(349, 20);
            this.nudGenerationNumber.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudGenerationNumber.Name = "nudGenerationNumber";
            this.nudGenerationNumber.Size = new System.Drawing.Size(38, 20);
            this.nudGenerationNumber.TabIndex = 12;
            this.nudGenerationNumber.ValueChanged += new System.EventHandler(this.nudGenerationNumber_ValueChanged);
            // 
            // labelGenerationNumber
            // 
            this.labelGenerationNumber.AutoSize = true;
            this.labelGenerationNumber.Location = new System.Drawing.Point(274, 22);
            this.labelGenerationNumber.Name = "labelGenerationNumber";
            this.labelGenerationNumber.Size = new System.Drawing.Size(69, 13);
            this.labelGenerationNumber.TabIndex = 11;
            this.labelGenerationNumber.Text = "Generation #";
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
            this.columnHeaderChange,
            this.columnHeaderGenotype});
            this.listViewPopulation.FullRowSelect = true;
            this.listViewPopulation.GridLines = true;
            this.listViewPopulation.Location = new System.Drawing.Point(274, 41);
            this.listViewPopulation.MultiSelect = false;
            this.listViewPopulation.Name = "listViewPopulation";
            this.listViewPopulation.Size = new System.Drawing.Size(482, 457);
            this.listViewPopulation.TabIndex = 8;
            this.listViewPopulation.UseCompatibleStateImageBehavior = false;
            this.listViewPopulation.View = System.Windows.Forms.View.Details;
            this.listViewPopulation.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewPopulation_ColumnClick);
            this.listViewPopulation.DoubleClick += new System.EventHandler(this.listViewPopulation_DoubleClick);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderFitness
            // 
            this.columnHeaderFitness.Text = "Fitness";
            this.columnHeaderFitness.Width = 90;
            // 
            // columnHeaderPreviousFitness
            // 
            this.columnHeaderPreviousFitness.Text = "Previous fitness";
            this.columnHeaderPreviousFitness.Width = 90;
            // 
            // columnHeaderChange
            // 
            this.columnHeaderChange.Text = "Change";
            // 
            // columnHeaderGenotype
            // 
            this.columnHeaderGenotype.Text = "Genotype";
            this.columnHeaderGenotype.Width = 163;
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
            // userControlCharacter1
            // 
            character2.Fitness = 0;
            character2.Stats = new byte[] {
        ((byte)(1)),
        ((byte)(1)),
        ((byte)(1)),
        ((byte)(1)),
        ((byte)(1)),
        ((byte)(1)),
        ((byte)(1)),
        ((byte)(1)),
        ((byte)(1))};
            this.userControlCharacter1.Character = character2;
            this.userControlCharacter1.Location = new System.Drawing.Point(6, 188);
            this.userControlCharacter1.Name = "userControlCharacter1";
            this.userControlCharacter1.Size = new System.Drawing.Size(164, 310);
            this.userControlCharacter1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxCrossover);
            this.tabPage2.Controls.Add(this.groupBoxMutationMethod);
            this.tabPage2.Controls.Add(this.groupBoxSelectionSettings);
            this.tabPage2.Controls.Add(this.groupBoxMutationSettings);
            this.tabPage2.Controls.Add(this.groupBoxGenerationControls);
            this.tabPage2.Controls.Add(this.listViewGenerations);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Generations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxCrossover
            // 
            this.groupBoxCrossover.Controls.Add(this.labelTwoPointCrossover);
            this.groupBoxCrossover.Controls.Add(this.labelSinglePointCrossover);
            this.groupBoxCrossover.Controls.Add(this.labelCrossoverChance);
            this.groupBoxCrossover.Controls.Add(this.nudTwoPointCrossover);
            this.groupBoxCrossover.Controls.Add(this.nudSinglePointCrossover);
            this.groupBoxCrossover.Controls.Add(this.nudCrossoverChance);
            this.groupBoxCrossover.Location = new System.Drawing.Point(7, 375);
            this.groupBoxCrossover.Name = "groupBoxCrossover";
            this.groupBoxCrossover.Size = new System.Drawing.Size(247, 122);
            this.groupBoxCrossover.TabIndex = 13;
            this.groupBoxCrossover.TabStop = false;
            this.groupBoxCrossover.Text = "Crossing settings";
            // 
            // groupBoxMutationMethod
            // 
            this.groupBoxMutationMethod.Controls.Add(this.nudPercentMutation);
            this.groupBoxMutationMethod.Controls.Add(this.nudConstantMutation);
            this.groupBoxMutationMethod.Controls.Add(this.nudRandomMutation);
            this.groupBoxMutationMethod.Controls.Add(this.radioButtonPercentMutation);
            this.groupBoxMutationMethod.Controls.Add(this.radioButtonConstantMutation);
            this.groupBoxMutationMethod.Controls.Add(this.radioButtonRandomMutation);
            this.groupBoxMutationMethod.Location = new System.Drawing.Point(6, 266);
            this.groupBoxMutationMethod.Name = "groupBoxMutationMethod";
            this.groupBoxMutationMethod.Size = new System.Drawing.Size(248, 102);
            this.groupBoxMutationMethod.TabIndex = 2;
            this.groupBoxMutationMethod.TabStop = false;
            this.groupBoxMutationMethod.Text = "Mutation method";
            // 
            // nudPercentMutation
            // 
            this.nudPercentMutation.Location = new System.Drawing.Point(196, 74);
            this.nudPercentMutation.Name = "nudPercentMutation";
            this.nudPercentMutation.Size = new System.Drawing.Size(46, 20);
            this.nudPercentMutation.TabIndex = 5;
            this.nudPercentMutation.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudConstantMutation
            // 
            this.nudConstantMutation.Location = new System.Drawing.Point(196, 47);
            this.nudConstantMutation.Name = "nudConstantMutation";
            this.nudConstantMutation.Size = new System.Drawing.Size(46, 20);
            this.nudConstantMutation.TabIndex = 4;
            this.nudConstantMutation.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudRandomMutation
            // 
            this.nudRandomMutation.Location = new System.Drawing.Point(196, 20);
            this.nudRandomMutation.Name = "nudRandomMutation";
            this.nudRandomMutation.Size = new System.Drawing.Size(46, 20);
            this.nudRandomMutation.TabIndex = 3;
            this.nudRandomMutation.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // radioButtonPercentMutation
            // 
            this.radioButtonPercentMutation.AutoSize = true;
            this.radioButtonPercentMutation.Location = new System.Drawing.Point(10, 74);
            this.radioButtonPercentMutation.Name = "radioButtonPercentMutation";
            this.radioButtonPercentMutation.Size = new System.Drawing.Size(140, 17);
            this.radioButtonPercentMutation.TabIndex = 2;
            this.radioButtonPercentMutation.Text = "Increase/decrease by %";
            this.radioButtonPercentMutation.UseVisualStyleBackColor = true;
            this.radioButtonPercentMutation.CheckedChanged += new System.EventHandler(this.radioButtonPercentMutation_CheckedChanged);
            // 
            // radioButtonConstantMutation
            // 
            this.radioButtonConstantMutation.AutoSize = true;
            this.radioButtonConstantMutation.Location = new System.Drawing.Point(10, 47);
            this.radioButtonConstantMutation.Name = "radioButtonConstantMutation";
            this.radioButtonConstantMutation.Size = new System.Drawing.Size(169, 17);
            this.radioButtonConstantMutation.TabIndex = 1;
            this.radioButtonConstantMutation.Text = "Add/subtract constant number";
            this.radioButtonConstantMutation.UseVisualStyleBackColor = true;
            this.radioButtonConstantMutation.CheckedChanged += new System.EventHandler(this.radioButtonConstantMutation_CheckedChanged);
            // 
            // radioButtonRandomMutation
            // 
            this.radioButtonRandomMutation.AutoSize = true;
            this.radioButtonRandomMutation.Checked = true;
            this.radioButtonRandomMutation.Location = new System.Drawing.Point(10, 20);
            this.radioButtonRandomMutation.Name = "radioButtonRandomMutation";
            this.radioButtonRandomMutation.Size = new System.Drawing.Size(190, 17);
            this.radioButtonRandomMutation.TabIndex = 0;
            this.radioButtonRandomMutation.TabStop = true;
            this.radioButtonRandomMutation.Text = "Add/subtract random number up to";
            this.radioButtonRandomMutation.UseVisualStyleBackColor = true;
            this.radioButtonRandomMutation.CheckedChanged += new System.EventHandler(this.radioButtonRandomMutation_CheckedChanged);
            // 
            // groupBoxSelectionSettings
            // 
            this.groupBoxSelectionSettings.Controls.Add(this.radioButtonLinearIndex);
            this.groupBoxSelectionSettings.Controls.Add(this.radioButtonBiasedRoulette);
            this.groupBoxSelectionSettings.Location = new System.Drawing.Point(6, 116);
            this.groupBoxSelectionSettings.Name = "groupBoxSelectionSettings";
            this.groupBoxSelectionSettings.Size = new System.Drawing.Size(248, 71);
            this.groupBoxSelectionSettings.TabIndex = 12;
            this.groupBoxSelectionSettings.TabStop = false;
            this.groupBoxSelectionSettings.Text = "Selection method";
            // 
            // radioButtonLinearIndex
            // 
            this.radioButtonLinearIndex.AutoSize = true;
            this.radioButtonLinearIndex.Location = new System.Drawing.Point(10, 47);
            this.radioButtonLinearIndex.Name = "radioButtonLinearIndex";
            this.radioButtonLinearIndex.Size = new System.Drawing.Size(82, 17);
            this.radioButtonLinearIndex.TabIndex = 1;
            this.radioButtonLinearIndex.Text = "Linear index";
            this.radioButtonLinearIndex.UseVisualStyleBackColor = true;
            // 
            // radioButtonBiasedRoulette
            // 
            this.radioButtonBiasedRoulette.AutoSize = true;
            this.radioButtonBiasedRoulette.Checked = true;
            this.radioButtonBiasedRoulette.Location = new System.Drawing.Point(10, 24);
            this.radioButtonBiasedRoulette.Name = "radioButtonBiasedRoulette";
            this.radioButtonBiasedRoulette.Size = new System.Drawing.Size(95, 17);
            this.radioButtonBiasedRoulette.TabIndex = 0;
            this.radioButtonBiasedRoulette.TabStop = true;
            this.radioButtonBiasedRoulette.Text = "Biased roulette";
            this.radioButtonBiasedRoulette.UseVisualStyleBackColor = true;
            // 
            // groupBoxMutationSettings
            // 
            this.groupBoxMutationSettings.Controls.Add(this.checkBoxDisableMutation);
            this.groupBoxMutationSettings.Controls.Add(this.nudMutationRate);
            this.groupBoxMutationSettings.Controls.Add(this.labelMutationRate);
            this.groupBoxMutationSettings.Location = new System.Drawing.Point(6, 193);
            this.groupBoxMutationSettings.Name = "groupBoxMutationSettings";
            this.groupBoxMutationSettings.Size = new System.Drawing.Size(248, 67);
            this.groupBoxMutationSettings.TabIndex = 11;
            this.groupBoxMutationSettings.TabStop = false;
            this.groupBoxMutationSettings.Text = "Mutation settings";
            // 
            // checkBoxDisableMutation
            // 
            this.checkBoxDisableMutation.AutoSize = true;
            this.checkBoxDisableMutation.Location = new System.Drawing.Point(13, 19);
            this.checkBoxDisableMutation.Name = "checkBoxDisableMutation";
            this.checkBoxDisableMutation.Size = new System.Drawing.Size(147, 17);
            this.checkBoxDisableMutation.TabIndex = 3;
            this.checkBoxDisableMutation.Text = "Disable random mutations";
            this.checkBoxDisableMutation.UseVisualStyleBackColor = true;
            this.checkBoxDisableMutation.CheckedChanged += new System.EventHandler(this.checkBoxDisableMutation_CheckedChanged);
            // 
            // nudMutationRate
            // 
            this.nudMutationRate.Location = new System.Drawing.Point(196, 37);
            this.nudMutationRate.Name = "nudMutationRate";
            this.nudMutationRate.Size = new System.Drawing.Size(46, 20);
            this.nudMutationRate.TabIndex = 1;
            this.nudMutationRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelMutationRate
            // 
            this.labelMutationRate.AutoSize = true;
            this.labelMutationRate.Location = new System.Drawing.Point(10, 39);
            this.labelMutationRate.Name = "labelMutationRate";
            this.labelMutationRate.Size = new System.Drawing.Size(104, 13);
            this.labelMutationRate.TabIndex = 0;
            this.labelMutationRate.Text = "Mutation chance [%]";
            // 
            // groupBoxGenerationControls
            // 
            this.groupBoxGenerationControls.Controls.Add(this.labelCreatingGenerationStatus);
            this.groupBoxGenerationControls.Controls.Add(this.nudXGenerations);
            this.groupBoxGenerationControls.Controls.Add(this.buttonXGenerations);
            this.groupBoxGenerationControls.Controls.Add(this.buttonNextGeneration);
            this.groupBoxGenerationControls.Location = new System.Drawing.Point(6, 7);
            this.groupBoxGenerationControls.Name = "groupBoxGenerationControls";
            this.groupBoxGenerationControls.Size = new System.Drawing.Size(248, 103);
            this.groupBoxGenerationControls.TabIndex = 10;
            this.groupBoxGenerationControls.TabStop = false;
            this.groupBoxGenerationControls.Text = "Generation Control";
            // 
            // labelCreatingGenerationStatus
            // 
            this.labelCreatingGenerationStatus.AutoSize = true;
            this.labelCreatingGenerationStatus.Location = new System.Drawing.Point(10, 78);
            this.labelCreatingGenerationStatus.Name = "labelCreatingGenerationStatus";
            this.labelCreatingGenerationStatus.Size = new System.Drawing.Size(0, 13);
            this.labelCreatingGenerationStatus.TabIndex = 3;
            // 
            // nudXGenerations
            // 
            this.nudXGenerations.Enabled = false;
            this.nudXGenerations.Location = new System.Drawing.Point(189, 51);
            this.nudXGenerations.Name = "nudXGenerations";
            this.nudXGenerations.Size = new System.Drawing.Size(53, 20);
            this.nudXGenerations.TabIndex = 2;
            this.nudXGenerations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonXGenerations
            // 
            this.buttonXGenerations.Enabled = false;
            this.buttonXGenerations.Location = new System.Drawing.Point(6, 48);
            this.buttonXGenerations.Name = "buttonXGenerations";
            this.buttonXGenerations.Size = new System.Drawing.Size(173, 23);
            this.buttonXGenerations.TabIndex = 1;
            this.buttonXGenerations.Text = "Do X Generations";
            this.buttonXGenerations.UseVisualStyleBackColor = true;
            this.buttonXGenerations.Click += new System.EventHandler(this.buttonXGenerations_Click);
            // 
            // buttonNextGeneration
            // 
            this.buttonNextGeneration.Enabled = false;
            this.buttonNextGeneration.Location = new System.Drawing.Point(6, 19);
            this.buttonNextGeneration.Name = "buttonNextGeneration";
            this.buttonNextGeneration.Size = new System.Drawing.Size(236, 23);
            this.buttonNextGeneration.TabIndex = 0;
            this.buttonNextGeneration.Text = "Next Generation";
            this.buttonNextGeneration.UseVisualStyleBackColor = true;
            this.buttonNextGeneration.Click += new System.EventHandler(this.buttonNextGeneration_Click);
            // 
            // listViewGenerations
            // 
            this.listViewGenerations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderGen,
            this.columnHeaderMaxFitness,
            this.columnHeaderMinFitness,
            this.columnHeaderAvgFitness});
            this.listViewGenerations.FullRowSelect = true;
            this.listViewGenerations.GridLines = true;
            this.listViewGenerations.Location = new System.Drawing.Point(260, 6);
            this.listViewGenerations.MultiSelect = false;
            this.listViewGenerations.Name = "listViewGenerations";
            this.listViewGenerations.Size = new System.Drawing.Size(496, 491);
            this.listViewGenerations.TabIndex = 9;
            this.listViewGenerations.UseCompatibleStateImageBehavior = false;
            this.listViewGenerations.View = System.Windows.Forms.View.Details;
            this.listViewGenerations.SelectedIndexChanged += new System.EventHandler(this.listViewGenerations_SelectedIndexChanged);
            this.listViewGenerations.DoubleClick += new System.EventHandler(this.listViewGenerations_DoubleClick);
            // 
            // columnHeaderGen
            // 
            this.columnHeaderGen.Text = "Generation";
            this.columnHeaderGen.Width = 100;
            // 
            // columnHeaderMaxFitness
            // 
            this.columnHeaderMaxFitness.Text = "Max. Fitness";
            this.columnHeaderMaxFitness.Width = 128;
            // 
            // columnHeaderMinFitness
            // 
            this.columnHeaderMinFitness.Text = "Min. Fitness";
            this.columnHeaderMinFitness.Width = 100;
            // 
            // columnHeaderAvgFitness
            // 
            this.columnHeaderAvgFitness.Text = "Average";
            // 
            // nudCrossoverChance
            // 
            this.nudCrossoverChance.Location = new System.Drawing.Point(195, 20);
            this.nudCrossoverChance.Name = "nudCrossoverChance";
            this.nudCrossoverChance.Size = new System.Drawing.Size(46, 20);
            this.nudCrossoverChance.TabIndex = 0;
            this.nudCrossoverChance.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // nudSinglePointCrossover
            // 
            this.nudSinglePointCrossover.Location = new System.Drawing.Point(195, 46);
            this.nudSinglePointCrossover.Name = "nudSinglePointCrossover";
            this.nudSinglePointCrossover.Size = new System.Drawing.Size(46, 20);
            this.nudSinglePointCrossover.TabIndex = 1;
            this.nudSinglePointCrossover.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSinglePointCrossover.ValueChanged += new System.EventHandler(this.nudSinglePointCrossover_ValueChanged);
            // 
            // nudTwoPointCrossover
            // 
            this.nudTwoPointCrossover.Location = new System.Drawing.Point(195, 72);
            this.nudTwoPointCrossover.Name = "nudTwoPointCrossover";
            this.nudTwoPointCrossover.Size = new System.Drawing.Size(46, 20);
            this.nudTwoPointCrossover.TabIndex = 2;
            this.nudTwoPointCrossover.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudTwoPointCrossover.ValueChanged += new System.EventHandler(this.nudTwoPointCrossover_ValueChanged);
            // 
            // labelCrossoverChance
            // 
            this.labelCrossoverChance.AutoSize = true;
            this.labelCrossoverChance.Location = new System.Drawing.Point(9, 22);
            this.labelCrossoverChance.Name = "labelCrossoverChance";
            this.labelCrossoverChance.Size = new System.Drawing.Size(110, 13);
            this.labelCrossoverChance.TabIndex = 3;
            this.labelCrossoverChance.Text = "Crossover chance [%]";
            // 
            // labelSinglePointCrossover
            // 
            this.labelSinglePointCrossover.AutoSize = true;
            this.labelSinglePointCrossover.Location = new System.Drawing.Point(9, 48);
            this.labelSinglePointCrossover.Name = "labelSinglePointCrossover";
            this.labelSinglePointCrossover.Size = new System.Drawing.Size(161, 13);
            this.labelSinglePointCrossover.TabIndex = 4;
            this.labelSinglePointCrossover.Text = "Single-point crossover probability";
            // 
            // labelTwoPointCrossover
            // 
            this.labelTwoPointCrossover.AutoSize = true;
            this.labelTwoPointCrossover.Location = new System.Drawing.Point(9, 74);
            this.labelTwoPointCrossover.Name = "labelTwoPointCrossover";
            this.labelTwoPointCrossover.Size = new System.Drawing.Size(153, 13);
            this.labelTwoPointCrossover.TabIndex = 5;
            this.labelTwoPointCrossover.Text = "Two-point crossover probability";
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
            ((System.ComponentModel.ISupportInitialize)(this.nudGenerationNumber)).EndInit();
            this.groupBoxCalculateFitness.ResumeLayout(false);
            this.groupBoxCalculateFitness.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBoxCrossover.ResumeLayout(false);
            this.groupBoxCrossover.PerformLayout();
            this.groupBoxMutationMethod.ResumeLayout(false);
            this.groupBoxMutationMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercentMutation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConstantMutation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandomMutation)).EndInit();
            this.groupBoxSelectionSettings.ResumeLayout(false);
            this.groupBoxSelectionSettings.PerformLayout();
            this.groupBoxMutationSettings.ResumeLayout(false);
            this.groupBoxMutationSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutationRate)).EndInit();
            this.groupBoxGenerationControls.ResumeLayout(false);
            this.groupBoxGenerationControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXGenerations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCrossoverChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSinglePointCrossover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTwoPointCrossover)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxGenerationControls;
        private System.Windows.Forms.NumericUpDown nudXGenerations;
        private System.Windows.Forms.Button buttonXGenerations;
        private System.Windows.Forms.Button buttonNextGeneration;
        private System.Windows.Forms.ListView listViewGenerations;
        private System.Windows.Forms.ColumnHeader columnHeaderGen;
        private System.Windows.Forms.ColumnHeader columnHeaderMaxFitness;
        private System.Windows.Forms.ColumnHeader columnHeaderMinFitness;
        private System.Windows.Forms.ColumnHeader columnHeaderAvgFitness;
        private System.Windows.Forms.Label labelGenerationNumber;
        private System.Windows.Forms.GroupBox groupBoxMutationSettings;
        private System.Windows.Forms.NumericUpDown nudMutationRate;
        private System.Windows.Forms.Label labelMutationRate;
        private System.Windows.Forms.NumericUpDown nudGenerationNumber;
        private System.Windows.Forms.GroupBox groupBoxSelectionSettings;
        private System.Windows.Forms.RadioButton radioButtonLinearIndex;
        private System.Windows.Forms.RadioButton radioButtonBiasedRoulette;
        private System.Windows.Forms.GroupBox groupBoxMutationMethod;
        private System.Windows.Forms.RadioButton radioButtonPercentMutation;
        private System.Windows.Forms.RadioButton radioButtonConstantMutation;
        private System.Windows.Forms.RadioButton radioButtonRandomMutation;
        private System.Windows.Forms.CheckBox checkBoxDisableMutation;
        private System.Windows.Forms.NumericUpDown nudPercentMutation;
        private System.Windows.Forms.NumericUpDown nudConstantMutation;
        private System.Windows.Forms.NumericUpDown nudRandomMutation;
        private System.Windows.Forms.ColumnHeader columnHeaderGenotype;
        private System.Windows.Forms.Label labelCreatingGenerationStatus;
        private System.Windows.Forms.GroupBox groupBoxCrossover;
        private System.Windows.Forms.Label labelTwoPointCrossover;
        private System.Windows.Forms.Label labelSinglePointCrossover;
        private System.Windows.Forms.Label labelCrossoverChance;
        private System.Windows.Forms.NumericUpDown nudTwoPointCrossover;
        private System.Windows.Forms.NumericUpDown nudSinglePointCrossover;
        private System.Windows.Forms.NumericUpDown nudCrossoverChance;
    }
}
