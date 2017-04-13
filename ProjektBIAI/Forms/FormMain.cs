using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektBIAI
{
    public partial class FormMain : Form
    {
        Character char1, char2;
        public FormMain()
        {
            InitializeComponent();
        }

        private void refreshCharacter1()
        {
            byte[] st = new byte[9];
            st[0] = (byte)nudMaxHp1.Value;
            st[1] = (byte)nudHpRegen1.Value;
            st[2] = (byte)nudBaseDmg1.Value;
            st[3] = (byte)nudCritRate1.Value;
            st[4] = (byte)nudCritDmg1.Value;
            st[5] = (byte)nudHitRate1.Value;
            st[6] = (byte)nudDodgeRate1.Value;
            st[7] = (byte)nudBlockRate1.Value;
            st[8] = (byte)nudBlockPower1.Value;
            char1 = new Character(st, (byte)nudPts1.Value);
            double[] result = char1.getComputedValues();
            labMaxHp1Computed.Text = result[0].ToString();
            labHpRegen1Computed.Text = result[1].ToString();
            labBaseDmg1Computed.Text = result[2].ToString();
            labCritRate1Computed.Text = result[3].ToString();
            labCritDmg1Computed.Text = result[4].ToString();
            labHitRate1Computed.Text = result[5].ToString();
            labDodgeRate1Computed.Text = result[6].ToString();
            labBlockRate1Computed.Text = result[7].ToString();
            labBlockPower1Computed.Text = result[8].ToString();
            textBoxInformations.AppendText("Changed character 1" + Environment.NewLine);
            textBoxInformations.ScrollToCaret();
        }

        private void refreshCharacter2()
        {
            byte[] st = new byte[9];
            st[0] = (byte)nudMaxHp2.Value;
            st[1] = (byte)nudHpRegen2.Value;
            st[2] = (byte)nudBaseDmg2.Value;
            st[3] = (byte)nudCritRate2.Value;
            st[4] = (byte)nudCritDmg2.Value;
            st[5] = (byte)nudHitRate2.Value;
            st[6] = (byte)nudDodgeRate2.Value;
            st[7] = (byte)nudBlockRate2.Value;
            st[8] = (byte)nudBlockPower2.Value;
            char2 = new Character(st, (byte)nudPts2.Value);
            double[] result = char2.getComputedValues();
            labMaxHp2Computed.Text = result[0].ToString();
            labHpRegen2Computed.Text = result[1].ToString();
            labBaseDmg2Computed.Text = result[2].ToString();
            labCritRate2Computed.Text = result[3].ToString();
            labCritDmg2Computed.Text = result[4].ToString();
            labHitRate2Computed.Text = result[5].ToString();
            labDodgeRate2Computed.Text = result[6].ToString();
            labBlockRate2Computed.Text = result[7].ToString();
            labBlockPower2Computed.Text = result[8].ToString();
            textBoxInformations.AppendText("Changed character 2" + Environment.NewLine);
            textBoxInformations.ScrollToCaret();
        }


        private void butStartFight_Click(object sender, EventArgs e)
        {
            Arena arena = new ProjektBIAI.Arena(char1, char2);
            textBoxResults.Text = arena.playBattleReport();
            textBoxResults.AppendText(Environment.NewLine);
            textBoxResults.ScrollToCaret();
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

        private void nudMaxHp2_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter2();
        }

        private void nudHpRegen2_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter2();
        }

        private void nudBaseDmg2_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter2();
        }

        private void nudCritRate2_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter2();
        }

        private void nudCritDmg2_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter2();
        }

        private void nudHitRate2_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter2();
        }

        private void nudDodgeRate2_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter2();
        }

        private void nudBlockRate2_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter2();
        }

        private void nudBlockPower2_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter2();
        }

        private void nudPts2_ValueChanged(object sender, EventArgs e)
        {
            refreshCharacter2();
        }

        private void butRandomStats1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            char1 = new Character(rand, (byte)nudPts1.Value);
            byte[] st = new byte[9];
            Array.Copy(char1.Stats, st, 9);
            nudMaxHp1.Value = st[0];
            nudHpRegen1.Value = st[1];
            nudBaseDmg1.Value = st[2];
            nudCritRate1.Value = st[3];
            nudCritDmg1.Value = st[4];
            nudHitRate1.Value = st[5];
            nudDodgeRate1.Value = st[6];
            nudBlockRate1.Value = st[7];
            nudBlockPower1.Value = st[8];
            double[] result = char1.getComputedValues();
            labMaxHp1Computed.Text = result[0].ToString();
            labHpRegen1Computed.Text = result[1].ToString();
            labBaseDmg1Computed.Text = result[2].ToString();
            labCritRate1Computed.Text = result[3].ToString();
            labCritDmg1Computed.Text = result[4].ToString();
            labHitRate1Computed.Text = result[5].ToString();
            labDodgeRate1Computed.Text = result[6].ToString();
            labBlockRate1Computed.Text = result[7].ToString();
            labBlockPower1Computed.Text = result[8].ToString();
            textBoxInformations.AppendText("Randomized character 1" + Environment.NewLine);
            textBoxInformations.ScrollToCaret();
        }

        private void butRandomStats2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            char2 = new Character(rand, (byte)nudPts2.Value);
            byte[] st = new byte[9];
            Array.Copy(char2.Stats, st, 9);
            nudMaxHp2.Value = st[0];
            nudHpRegen2.Value = st[1];
            nudBaseDmg2.Value = st[2];
            nudCritRate2.Value = st[3];
            nudCritDmg2.Value = st[4];
            nudHitRate2.Value = st[5];
            nudDodgeRate2.Value = st[6];
            nudBlockRate2.Value = st[7];
            nudBlockPower2.Value = st[8];            
            double[] result = char2.getComputedValues();
            labMaxHp2Computed.Text = result[0].ToString();
            labHpRegen2Computed.Text = result[1].ToString();
            labBaseDmg2Computed.Text = result[2].ToString();
            labCritRate2Computed.Text = result[3].ToString();
            labCritDmg2Computed.Text = result[4].ToString();
            labHitRate2Computed.Text = result[5].ToString();
            labDodgeRate2Computed.Text = result[6].ToString();
            labBlockRate2Computed.Text = result[7].ToString();
            labBlockPower2Computed.Text = result[8].ToString();
            textBoxInformations.AppendText("Randomized character 2" + Environment.NewLine);
            textBoxInformations.ScrollToCaret();
        }

        private void userControlWorld_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshCharacter1();
            refreshCharacter2();
        }
    }
}
