using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektBIAI.Forms
{
    public partial class UserControlCharacter : UserControl
    {
        Character character;
        byte points;

        public Character Character
        {
            get
            {
                return character;
            }

            set
            {
                character = value;
            }
        }

        public UserControlCharacter()
        {
            InitializeComponent();
            refreshCharacter();
        }

        public UserControlCharacter(String charName)
        {
            InitializeComponent();
            groupBoxCharacter.Text = charName;
            refreshCharacter();
        }

        public UserControlCharacter(byte[] charStats)
        {
            InitializeComponent();
            character = new Character(charStats, 100);
            labPts.Visible = false;
            nudPts.Visible = false;
            butRandomStats.Visible = false;
            nudMaxHp.Value = charStats[0];
            nudHpRegen.Value = charStats[1];
            nudBaseDmg.Value = charStats[2];
            nudCritRate.Value = charStats[3];
            nudCritDmg.Value = charStats[4];
            nudHitRate.Value = charStats[5];
            nudDodgeRate.Value = charStats[6];
            nudBlockRate.Value = charStats[7];
            nudBlockPower.Value = charStats[8];
            double[] result = character.getComputedValues();
            labMaxHpComputed.Text = result[0].ToString();
            labHpRegenComputed.Text = result[1].ToString();
            labBaseDmgComputed.Text = result[2].ToString();
            labCritRateComputed.Text = result[3].ToString();
            labCritDmgComputed.Text = result[4].ToString();
            labHitRateComputed.Text = result[5].ToString();
            labDodgeRateComputed.Text = result[6].ToString();
            labBlockRateComputed.Text = result[7].ToString();
            labBlockPowerComputed.Text = result[8].ToString();
        }
        
        private void refreshCharacter()
        {
            points = (byte)nudPts.Value;
            byte [] stats = new byte[9];
            stats[0] = (byte)nudMaxHp.Value;
            stats[1] = (byte)nudHpRegen.Value;
            stats[2] = (byte)nudBaseDmg.Value;
            stats[3] = (byte)nudCritRate.Value;
            stats[4] = (byte)nudCritDmg.Value;
            stats[5] = (byte)nudHitRate.Value;
            stats[6] = (byte)nudDodgeRate.Value;
            stats[7] = (byte)nudBlockRate.Value;
            stats[8] = (byte)nudBlockPower.Value;
            character = new Character(stats, (byte)nudPts.Value);
            double[] result = character.getComputedValues();
            labMaxHpComputed.Text = result[0].ToString();
            labHpRegenComputed.Text = result[1].ToString();
            labBaseDmgComputed.Text = result[2].ToString();
            labCritRateComputed.Text = result[3].ToString();
            labCritDmgComputed.Text = result[4].ToString();
            labHitRateComputed.Text = result[5].ToString();
            labDodgeRateComputed.Text = result[6].ToString();
            labBlockRateComputed.Text = result[7].ToString();
            labBlockPowerComputed.Text = result[8].ToString();
        }

        private void nudMaxHp_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter();
        }

        private void nudHpRegen_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter();
        }

        private void nudBaseDmg_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter();
        }

        private void nudCritRate_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter();
        }

        private void nudCritDmg_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter();
        }

        private void nudHitRate_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter();
        }

        private void nudDodgeRate_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter();
        }

        private void nudBlockRate_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter();
        }

        private void nudBlockPower_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter();
        }

        private void nudPts_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter();
        }

        private void butRandomStats_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            character = new Character(rand, (byte)nudPts.Value);
            byte[] st = new byte[9];
            character.Stats.CopyTo(st, 0);
            nudMaxHp.Value = st[0];
            nudHpRegen.Value = st[1];
            nudBaseDmg.Value = st[2];
            nudCritRate.Value = st[3];
            nudCritDmg.Value = st[4];
            nudHitRate.Value = st[5];
            nudDodgeRate.Value = st[6];
            nudBlockRate.Value = st[7];
            nudBlockPower.Value = st[8];
            double[] result = character.getComputedValues();
            labMaxHpComputed.Text = result[0].ToString();
            labHpRegenComputed.Text = result[1].ToString();
            labBaseDmgComputed.Text = result[2].ToString();
            labCritRateComputed.Text = result[3].ToString();
            labCritDmgComputed.Text = result[4].ToString();
            labHitRateComputed.Text = result[5].ToString();
            labDodgeRateComputed.Text = result[6].ToString();
            labBlockRateComputed.Text = result[7].ToString();
            labBlockPowerComputed.Text = result[8].ToString();
        }
    }
}
