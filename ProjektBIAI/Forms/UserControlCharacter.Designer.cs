namespace ProjektBIAI.Forms
{
    partial class UserControlCharacter
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
            this.labMaxHp = new System.Windows.Forms.Label();
            this.labHpRegen = new System.Windows.Forms.Label();
            this.nudMaxHp = new System.Windows.Forms.NumericUpDown();
            this.nudHpRegen = new System.Windows.Forms.NumericUpDown();
            this.labBaseDmg = new System.Windows.Forms.Label();
            this.labCritRate = new System.Windows.Forms.Label();
            this.nudBaseDmg = new System.Windows.Forms.NumericUpDown();
            this.nudCritRate = new System.Windows.Forms.NumericUpDown();
            this.labCritDmg = new System.Windows.Forms.Label();
            this.labHitRate = new System.Windows.Forms.Label();
            this.nudCritDmg = new System.Windows.Forms.NumericUpDown();
            this.nudHitRate = new System.Windows.Forms.NumericUpDown();
            this.labDodgeRate = new System.Windows.Forms.Label();
            this.labBlockRate = new System.Windows.Forms.Label();
            this.nudDodgeRate = new System.Windows.Forms.NumericUpDown();
            this.nudBlockRate = new System.Windows.Forms.NumericUpDown();
            this.labBlockPower = new System.Windows.Forms.Label();
            this.nudBlockPower = new System.Windows.Forms.NumericUpDown();
            this.labMaxHpComputed = new System.Windows.Forms.Label();
            this.labHpRegenComputed = new System.Windows.Forms.Label();
            this.labBaseDmgComputed = new System.Windows.Forms.Label();
            this.labCritRateComputed = new System.Windows.Forms.Label();
            this.labCritDmgComputed = new System.Windows.Forms.Label();
            this.labHitRateComputed = new System.Windows.Forms.Label();
            this.labDodgeRateComputed = new System.Windows.Forms.Label();
            this.labBlockRateComputed = new System.Windows.Forms.Label();
            this.labBlockPowerComputed = new System.Windows.Forms.Label();
            this.labPts = new System.Windows.Forms.Label();
            this.nudPts = new System.Windows.Forms.NumericUpDown();
            this.butRandomStats = new System.Windows.Forms.Button();
            this.groupBoxCharacter = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHpRegen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseDmg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritDmg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHitRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDodgeRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlockRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlockPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPts)).BeginInit();
            this.groupBoxCharacter.SuspendLayout();
            this.SuspendLayout();
            // 
            // labMaxHp
            // 
            this.labMaxHp.AutoSize = true;
            this.labMaxHp.Location = new System.Drawing.Point(7, 23);
            this.labMaxHp.Name = "labMaxHp";
            this.labMaxHp.Size = new System.Drawing.Size(45, 13);
            this.labMaxHp.TabIndex = 0;
            this.labMaxHp.Text = "Max HP";
            // 
            // labHpRegen
            // 
            this.labHpRegen.AutoSize = true;
            this.labHpRegen.Location = new System.Drawing.Point(7, 49);
            this.labHpRegen.Name = "labHpRegen";
            this.labHpRegen.Size = new System.Drawing.Size(57, 13);
            this.labHpRegen.TabIndex = 1;
            this.labHpRegen.Text = "HP Regen";
            // 
            // nudMaxHp
            // 
            this.nudMaxHp.Location = new System.Drawing.Point(78, 20);
            this.nudMaxHp.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMaxHp.Name = "nudMaxHp";
            this.nudMaxHp.Size = new System.Drawing.Size(40, 20);
            this.nudMaxHp.TabIndex = 2;
            this.nudMaxHp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMaxHp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudHpRegen
            // 
            this.nudHpRegen.Location = new System.Drawing.Point(78, 46);
            this.nudHpRegen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudHpRegen.Name = "nudHpRegen";
            this.nudHpRegen.Size = new System.Drawing.Size(40, 20);
            this.nudHpRegen.TabIndex = 3;
            this.nudHpRegen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHpRegen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labBaseDmg
            // 
            this.labBaseDmg.AutoSize = true;
            this.labBaseDmg.Location = new System.Drawing.Point(7, 75);
            this.labBaseDmg.Name = "labBaseDmg";
            this.labBaseDmg.Size = new System.Drawing.Size(54, 13);
            this.labBaseDmg.TabIndex = 4;
            this.labBaseDmg.Text = "Base dmg";
            // 
            // labCritRate
            // 
            this.labCritRate.AutoSize = true;
            this.labCritRate.Location = new System.Drawing.Point(7, 101);
            this.labCritRate.Name = "labCritRate";
            this.labCritRate.Size = new System.Drawing.Size(43, 13);
            this.labCritRate.TabIndex = 5;
            this.labCritRate.Text = "Crit rate";
            // 
            // nudBaseDmg
            // 
            this.nudBaseDmg.Location = new System.Drawing.Point(78, 72);
            this.nudBaseDmg.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBaseDmg.Name = "nudBaseDmg";
            this.nudBaseDmg.Size = new System.Drawing.Size(40, 20);
            this.nudBaseDmg.TabIndex = 6;
            this.nudBaseDmg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudBaseDmg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCritRate
            // 
            this.nudCritRate.Location = new System.Drawing.Point(78, 98);
            this.nudCritRate.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudCritRate.Name = "nudCritRate";
            this.nudCritRate.Size = new System.Drawing.Size(40, 20);
            this.nudCritRate.TabIndex = 7;
            this.nudCritRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCritRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labCritDmg
            // 
            this.labCritDmg.AutoSize = true;
            this.labCritDmg.Location = new System.Drawing.Point(7, 127);
            this.labCritDmg.Name = "labCritDmg";
            this.labCritDmg.Size = new System.Drawing.Size(45, 13);
            this.labCritDmg.TabIndex = 8;
            this.labCritDmg.Text = "Crit dmg";
            // 
            // labHitRate
            // 
            this.labHitRate.AutoSize = true;
            this.labHitRate.Location = new System.Drawing.Point(7, 153);
            this.labHitRate.Name = "labHitRate";
            this.labHitRate.Size = new System.Drawing.Size(41, 13);
            this.labHitRate.TabIndex = 9;
            this.labHitRate.Text = "Hit rate";
            // 
            // nudCritDmg
            // 
            this.nudCritDmg.Location = new System.Drawing.Point(78, 124);
            this.nudCritDmg.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudCritDmg.Name = "nudCritDmg";
            this.nudCritDmg.Size = new System.Drawing.Size(40, 20);
            this.nudCritDmg.TabIndex = 10;
            this.nudCritDmg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCritDmg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudHitRate
            // 
            this.nudHitRate.Location = new System.Drawing.Point(78, 150);
            this.nudHitRate.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudHitRate.Name = "nudHitRate";
            this.nudHitRate.Size = new System.Drawing.Size(40, 20);
            this.nudHitRate.TabIndex = 11;
            this.nudHitRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHitRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labDodgeRate
            // 
            this.labDodgeRate.AutoSize = true;
            this.labDodgeRate.Location = new System.Drawing.Point(7, 179);
            this.labDodgeRate.Name = "labDodgeRate";
            this.labDodgeRate.Size = new System.Drawing.Size(60, 13);
            this.labDodgeRate.TabIndex = 12;
            this.labDodgeRate.Text = "Dodge rate";
            // 
            // labBlockRate
            // 
            this.labBlockRate.AutoSize = true;
            this.labBlockRate.Location = new System.Drawing.Point(7, 205);
            this.labBlockRate.Name = "labBlockRate";
            this.labBlockRate.Size = new System.Drawing.Size(55, 13);
            this.labBlockRate.TabIndex = 13;
            this.labBlockRate.Text = "Block rate";
            // 
            // nudDodgeRate
            // 
            this.nudDodgeRate.Location = new System.Drawing.Point(78, 176);
            this.nudDodgeRate.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudDodgeRate.Name = "nudDodgeRate";
            this.nudDodgeRate.Size = new System.Drawing.Size(40, 20);
            this.nudDodgeRate.TabIndex = 14;
            this.nudDodgeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDodgeRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudBlockRate
            // 
            this.nudBlockRate.Location = new System.Drawing.Point(78, 202);
            this.nudBlockRate.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlockRate.Name = "nudBlockRate";
            this.nudBlockRate.Size = new System.Drawing.Size(40, 20);
            this.nudBlockRate.TabIndex = 15;
            this.nudBlockRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudBlockRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labBlockPower
            // 
            this.labBlockPower.AutoSize = true;
            this.labBlockPower.Location = new System.Drawing.Point(7, 231);
            this.labBlockPower.Name = "labBlockPower";
            this.labBlockPower.Size = new System.Drawing.Size(67, 13);
            this.labBlockPower.TabIndex = 16;
            this.labBlockPower.Text = "Block Power";
            // 
            // nudBlockPower
            // 
            this.nudBlockPower.Location = new System.Drawing.Point(78, 228);
            this.nudBlockPower.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlockPower.Name = "nudBlockPower";
            this.nudBlockPower.Size = new System.Drawing.Size(40, 20);
            this.nudBlockPower.TabIndex = 17;
            this.nudBlockPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudBlockPower.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labMaxHpComputed
            // 
            this.labMaxHpComputed.AutoSize = true;
            this.labMaxHpComputed.Location = new System.Drawing.Point(124, 23);
            this.labMaxHpComputed.Name = "labMaxHpComputed";
            this.labMaxHpComputed.Size = new System.Drawing.Size(13, 13);
            this.labMaxHpComputed.TabIndex = 18;
            this.labMaxHpComputed.Text = "0";
            // 
            // labHpRegenComputed
            // 
            this.labHpRegenComputed.AutoSize = true;
            this.labHpRegenComputed.Location = new System.Drawing.Point(124, 49);
            this.labHpRegenComputed.Name = "labHpRegenComputed";
            this.labHpRegenComputed.Size = new System.Drawing.Size(13, 13);
            this.labHpRegenComputed.TabIndex = 19;
            this.labHpRegenComputed.Text = "0";
            // 
            // labBaseDmgComputed
            // 
            this.labBaseDmgComputed.AutoSize = true;
            this.labBaseDmgComputed.Location = new System.Drawing.Point(124, 75);
            this.labBaseDmgComputed.Name = "labBaseDmgComputed";
            this.labBaseDmgComputed.Size = new System.Drawing.Size(13, 13);
            this.labBaseDmgComputed.TabIndex = 20;
            this.labBaseDmgComputed.Text = "0";
            // 
            // labCritRateComputed
            // 
            this.labCritRateComputed.AutoSize = true;
            this.labCritRateComputed.Location = new System.Drawing.Point(124, 101);
            this.labCritRateComputed.Name = "labCritRateComputed";
            this.labCritRateComputed.Size = new System.Drawing.Size(13, 13);
            this.labCritRateComputed.TabIndex = 21;
            this.labCritRateComputed.Text = "0";
            // 
            // labCritDmgComputed
            // 
            this.labCritDmgComputed.AutoSize = true;
            this.labCritDmgComputed.Location = new System.Drawing.Point(124, 127);
            this.labCritDmgComputed.Name = "labCritDmgComputed";
            this.labCritDmgComputed.Size = new System.Drawing.Size(13, 13);
            this.labCritDmgComputed.TabIndex = 22;
            this.labCritDmgComputed.Text = "0";
            // 
            // labHitRateComputed
            // 
            this.labHitRateComputed.AutoSize = true;
            this.labHitRateComputed.Location = new System.Drawing.Point(124, 153);
            this.labHitRateComputed.Name = "labHitRateComputed";
            this.labHitRateComputed.Size = new System.Drawing.Size(13, 13);
            this.labHitRateComputed.TabIndex = 23;
            this.labHitRateComputed.Text = "0";
            // 
            // labDodgeRateComputed
            // 
            this.labDodgeRateComputed.AutoSize = true;
            this.labDodgeRateComputed.Location = new System.Drawing.Point(124, 179);
            this.labDodgeRateComputed.Name = "labDodgeRateComputed";
            this.labDodgeRateComputed.Size = new System.Drawing.Size(13, 13);
            this.labDodgeRateComputed.TabIndex = 24;
            this.labDodgeRateComputed.Text = "0";
            // 
            // labBlockRateComputed
            // 
            this.labBlockRateComputed.AutoSize = true;
            this.labBlockRateComputed.Location = new System.Drawing.Point(124, 205);
            this.labBlockRateComputed.Name = "labBlockRateComputed";
            this.labBlockRateComputed.Size = new System.Drawing.Size(13, 13);
            this.labBlockRateComputed.TabIndex = 25;
            this.labBlockRateComputed.Text = "0";
            // 
            // labBlockPowerComputed
            // 
            this.labBlockPowerComputed.AutoSize = true;
            this.labBlockPowerComputed.Location = new System.Drawing.Point(124, 231);
            this.labBlockPowerComputed.Name = "labBlockPowerComputed";
            this.labBlockPowerComputed.Size = new System.Drawing.Size(13, 13);
            this.labBlockPowerComputed.TabIndex = 26;
            this.labBlockPowerComputed.Text = "0";
            // 
            // labPts
            // 
            this.labPts.AutoSize = true;
            this.labPts.Location = new System.Drawing.Point(7, 257);
            this.labPts.Name = "labPts";
            this.labPts.Size = new System.Drawing.Size(36, 13);
            this.labPts.TabIndex = 27;
            this.labPts.Text = "Points";
            // 
            // nudPts
            // 
            this.nudPts.Location = new System.Drawing.Point(78, 254);
            this.nudPts.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudPts.Name = "nudPts";
            this.nudPts.Size = new System.Drawing.Size(40, 20);
            this.nudPts.TabIndex = 28;
            this.nudPts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPts.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // butRandomStats
            // 
            this.butRandomStats.Location = new System.Drawing.Point(10, 275);
            this.butRandomStats.Name = "butRandomStats";
            this.butRandomStats.Size = new System.Drawing.Size(141, 23);
            this.butRandomStats.TabIndex = 29;
            this.butRandomStats.Text = "Random Stats";
            this.butRandomStats.UseVisualStyleBackColor = true;
            // 
            // groupBoxCharacter
            // 
            this.groupBoxCharacter.Controls.Add(this.butRandomStats);
            this.groupBoxCharacter.Controls.Add(this.nudPts);
            this.groupBoxCharacter.Controls.Add(this.labPts);
            this.groupBoxCharacter.Controls.Add(this.labBlockPowerComputed);
            this.groupBoxCharacter.Controls.Add(this.labBlockRateComputed);
            this.groupBoxCharacter.Controls.Add(this.labDodgeRateComputed);
            this.groupBoxCharacter.Controls.Add(this.labHitRateComputed);
            this.groupBoxCharacter.Controls.Add(this.labCritDmgComputed);
            this.groupBoxCharacter.Controls.Add(this.labCritRateComputed);
            this.groupBoxCharacter.Controls.Add(this.labBaseDmgComputed);
            this.groupBoxCharacter.Controls.Add(this.labHpRegenComputed);
            this.groupBoxCharacter.Controls.Add(this.labMaxHpComputed);
            this.groupBoxCharacter.Controls.Add(this.nudBlockPower);
            this.groupBoxCharacter.Controls.Add(this.labBlockPower);
            this.groupBoxCharacter.Controls.Add(this.nudBlockRate);
            this.groupBoxCharacter.Controls.Add(this.nudDodgeRate);
            this.groupBoxCharacter.Controls.Add(this.labBlockRate);
            this.groupBoxCharacter.Controls.Add(this.labDodgeRate);
            this.groupBoxCharacter.Controls.Add(this.nudHitRate);
            this.groupBoxCharacter.Controls.Add(this.nudCritDmg);
            this.groupBoxCharacter.Controls.Add(this.labHitRate);
            this.groupBoxCharacter.Controls.Add(this.labCritDmg);
            this.groupBoxCharacter.Controls.Add(this.nudCritRate);
            this.groupBoxCharacter.Controls.Add(this.nudBaseDmg);
            this.groupBoxCharacter.Controls.Add(this.labCritRate);
            this.groupBoxCharacter.Controls.Add(this.labBaseDmg);
            this.groupBoxCharacter.Controls.Add(this.nudHpRegen);
            this.groupBoxCharacter.Controls.Add(this.nudMaxHp);
            this.groupBoxCharacter.Controls.Add(this.labHpRegen);
            this.groupBoxCharacter.Controls.Add(this.labMaxHp);
            this.groupBoxCharacter.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCharacter.Name = "groupBoxCharacter";
            this.groupBoxCharacter.Size = new System.Drawing.Size(157, 304);
            this.groupBoxCharacter.TabIndex = 1;
            this.groupBoxCharacter.TabStop = false;
            this.groupBoxCharacter.Text = "Character 1";
            // 
            // UserControlCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxCharacter);
            this.Name = "UserControlCharacter";
            this.Size = new System.Drawing.Size(164, 310);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHpRegen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseDmg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritDmg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHitRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDodgeRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlockRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlockPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPts)).EndInit();
            this.groupBoxCharacter.ResumeLayout(false);
            this.groupBoxCharacter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labMaxHp;
        private System.Windows.Forms.Label labHpRegen;
        private System.Windows.Forms.NumericUpDown nudMaxHp;
        private System.Windows.Forms.NumericUpDown nudHpRegen;
        private System.Windows.Forms.Label labBaseDmg;
        private System.Windows.Forms.Label labCritRate;
        private System.Windows.Forms.NumericUpDown nudBaseDmg;
        private System.Windows.Forms.NumericUpDown nudCritRate;
        private System.Windows.Forms.Label labCritDmg;
        private System.Windows.Forms.Label labHitRate;
        private System.Windows.Forms.NumericUpDown nudCritDmg;
        private System.Windows.Forms.NumericUpDown nudHitRate;
        private System.Windows.Forms.Label labDodgeRate;
        private System.Windows.Forms.Label labBlockRate;
        private System.Windows.Forms.NumericUpDown nudDodgeRate;
        private System.Windows.Forms.NumericUpDown nudBlockRate;
        private System.Windows.Forms.Label labBlockPower;
        private System.Windows.Forms.NumericUpDown nudBlockPower;
        private System.Windows.Forms.Label labMaxHpComputed;
        private System.Windows.Forms.Label labHpRegenComputed;
        private System.Windows.Forms.Label labBaseDmgComputed;
        private System.Windows.Forms.Label labCritRateComputed;
        private System.Windows.Forms.Label labCritDmgComputed;
        private System.Windows.Forms.Label labHitRateComputed;
        private System.Windows.Forms.Label labDodgeRateComputed;
        private System.Windows.Forms.Label labBlockRateComputed;
        private System.Windows.Forms.Label labBlockPowerComputed;
        private System.Windows.Forms.Label labPts;
        private System.Windows.Forms.NumericUpDown nudPts;
        private System.Windows.Forms.Button butRandomStats;
        private System.Windows.Forms.GroupBox groupBoxCharacter;
    }
}
