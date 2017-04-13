using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektBIAI
{
    public partial class UserControlWorld : UserControl
    {
        World world;
        byte[] tempTableWithStats = new byte[9];
        public UserControlWorld()
        {
            InitializeComponent();
        }

        private void buttonCreatePopulation_Click(object sender, EventArgs e)
        {
            tempTableWithStats.CopyTo(userControlCharacter1.stats,0);
            world = new World((int)nudSizeOfPopulation.Value, (int)nudNumberOfBattlesForCalculateFitness.Value, (byte)nudStepForFitness.Value, tempTableWithStats);
        }
    }
}
