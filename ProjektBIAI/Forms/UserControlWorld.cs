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
        int[] previosFitness;
        public UserControlWorld()
        {
            InitializeComponent();
        }

        private void buttonCreatePopulation_Click(object sender, EventArgs e)
        {
            if ((world == null) || (MessageBox.Show("This will destroy existing population!", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                world = new World((int)nudSizeOfPopulation.Value, (int)nudNumberOfBattlesForCalculateFitness.Value, (byte)nudStepForFitness.Value, userControlCharacter1.Character.Stats);
                previosFitness = new int[(int)nudSizeOfPopulation.Value];                
                world.CalculateFitness(labelIsPopulationCreated);
                buttonRecalculateFitness.Enabled = true;
                UpdateListVievPopulation();
            }
            else
            {
                MessageBox.Show("Population not changed");       
            }            
        }

        private void buttonRecalculateFitness_Click(object sender, EventArgs e)
        {
            world.UpdatePreviousFitness(previosFitness);
            world.CalculateFitness(labelRecalculateFitness);
            UpdateListVievPopulation();
        }

        private void nudStepForFitness_ValueChanged(object sender, EventArgs e)
        {
            world.StepOfIncrementOpponentsForFitness = (byte)nudStepForFitness.Value;
        }

        private void nudNumberOfBattlesForCalculateFitness_ValueChanged(object sender, EventArgs e)
        {
            world.NumberOfBattlesForCalculateFitness = (int)nudNumberOfBattlesForCalculateFitness.Value;
        }

        private void UpdateListVievPopulation()
        {
            listViewPopulation.Items.Clear();
            for (int i=0; i<world.Population.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(world.Population[i].Fitness.ToString());
                lvi.SubItems.Add(previosFitness[i].ToString());
                lvi.SubItems.Add((world.Population[i].Fitness - previosFitness[i]).ToString());
                listViewPopulation.Items.Add(lvi);
            }
        }
    }
}
