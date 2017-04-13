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
        Character char1;
        public UserControlCharacter()
        {
            InitializeComponent();
        }

        private void refreshCharacter1()
        {
            byte[] st = new byte[9];
            st[0] = (byte)nudMaxHp.Value;
            st[1] = (byte)nudHpRegen.Value;
            st[2] = (byte)nudBaseDmg.Value;
            st[3] = (byte)nudCritRate.Value;
            st[4] = (byte)nudCritDmg.Value;
            st[5] = (byte)nudHitRate.Value;
            st[6] = (byte)nudDodgeRate.Value;
            st[7] = (byte)nudBlockRate.Value;
            st[8] = (byte)nudBlockPower.Value;
            char1 = new Character(st, (byte)nudPts.Value);
            double[] result = char1.getComputedValues();
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

        private void nudMaxHp1_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter1();
        }

        private void nudHpRegen1_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter1();
        }

        private void nudBaseDmg1_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter1();
        }

        private void nudCritRate1_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter1();
        }

        private void nudCritDmg1_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter1();
        }

        private void nudHitRate1_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter1();
        }

        private void nudDodgeRate1_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter1();
        }

        private void nudBlockRate1_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter1();
        }

        private void nudBlockPower1_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter1();
        }

        private void nudPts1_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter1();
        }
    }
}
