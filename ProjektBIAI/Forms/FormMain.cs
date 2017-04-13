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

        private void butStartFight_Click(object sender, EventArgs e)
        {
            char1 = userControlCharacter1.getChar();
            char2 = userControlCharacter2.getChar();
            Arena arena = new ProjektBIAI.Arena(char1, char2);
            textBoxResults.Text = arena.playBattleReport();
            textBoxResults.AppendText(Environment.NewLine);
            textBoxResults.ScrollToCaret();
        }

        private void userControlWorld_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
