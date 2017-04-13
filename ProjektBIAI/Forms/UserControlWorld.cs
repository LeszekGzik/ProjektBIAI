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
    public partial class UserControlEnvironment : UserControl
    {
        World world;
        byte[] tempTableWithStats = new byte[9];
        public UserControlEnvironment()
        {
            InitializeComponent();
        }

        private void buttonCreatePopulation_Click(object sender, EventArgs e)
        {
            world = new World((int)nudSizeOfPopulation.Value, (int)nudNumberOfBattlesForCalculateFitness.Value, (byte)nudStepForFitness.Value, tempTableWithStats);
        }
    }
}
