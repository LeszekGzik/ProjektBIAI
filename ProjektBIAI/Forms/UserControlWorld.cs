using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjektBIAI.Forms;

namespace ProjektBIAI
{
    public partial class UserControlWorld : UserControl
    {
        private ListViewColumnSorter lvwColumnSorter;
        World world;
        int[] previousFitness;
        public UserControlWorld()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.listViewPopulation.ListViewItemSorter = lvwColumnSorter;
        }

        private void buttonCreatePopulation_Click(object sender, EventArgs e)
        {
            if ((world == null) || (MessageBox.Show("This will destroy existing population!", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                world = new World((int)nudSizeOfPopulation.Value, (int)nudNumberOfBattlesForCalculateFitness.Value, (byte)nudStepForFitness.Value, userControlCharacter1.Character.Stats);
                previousFitness = new int[(int)nudSizeOfPopulation.Value];                
                world.CalculateFitness(labelIsPopulationCreated);
                UpdateListViewPopulation();
                world.ArchiveCurrentPopulation();
                UpdateListViewGenerations();
                listViewGenerations.Items[0].Selected = true;
                buttonRecalculateFitness.Enabled = true;
                buttonNextGeneration.Enabled = true;
                buttonXGenerations.Enabled = true;
                nudXGenerations.Enabled = true;
            }
            else
            {
                MessageBox.Show("Population not changed");       
            }            
        }

        private int calculatePopulationAvgFitness(List<Character> population)
        {
            int avg = 0;
            foreach (Character ch in population)
            {
                avg += ch.Fitness;
            }
            return (int)(avg/population.Count);
        }

        private int calculatePopulationMinFitness(List<Character> population)
        {
            int minFitness = calculatePopulationMaxFitness(population);
            foreach (Character ch in population)
            {
                if (ch.Fitness < minFitness)
                    minFitness = ch.Fitness;
            }
            return minFitness;
        }

        private int calculatePopulationMaxFitness(List<Character> population)
        {
            int maxFitness = 0;
            foreach (Character ch in population)
            {
                if (ch.Fitness > maxFitness)
                    maxFitness = ch.Fitness;
            }
            return maxFitness;
        }

        private void buttonRecalculateFitness_Click(object sender, EventArgs e)
        {
            world.UpdatePreviousFitness(previousFitness);
            world.CalculateFitness(labelRecalculateFitness);
            UpdateListViewPopulation();
            UpdateListViewGenerations();
        }

        private void UpdateListViewGenerations()
        {
            listViewGenerations.Items.Clear();
            for (int i = 0; i < world.AllPopulations.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(calculatePopulationMaxFitness(world.AllPopulations[i]).ToString());
                lvi.SubItems.Add(calculatePopulationMinFitness(world.AllPopulations[i]).ToString());
                lvi.SubItems.Add(calculatePopulationAvgFitness(world.AllPopulations[i]).ToString());
                listViewGenerations.Items.Add(lvi);
            }
        }

        private void nudStepForFitness_ValueChanged(object sender, EventArgs e)
        {
            world.StepOfIncrementOpponentsForFitness = (byte)nudStepForFitness.Value;
        }

        private void nudNumberOfBattlesForCalculateFitness_ValueChanged(object sender, EventArgs e)
        {
            world.NumberOfBattlesForCalculateFitness = (int)nudNumberOfBattlesForCalculateFitness.Value;
        }

        private void UpdateListViewPopulation()
        {
            listViewPopulation.Items.Clear();
            for (int i=0; i<world.Population.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(world.Population[i].Fitness.ToString());
                lvi.SubItems.Add(previousFitness[i].ToString());
                lvi.SubItems.Add(Math.Abs(world.Population[i].Fitness - previousFitness[i]).ToString());
                listViewPopulation.Items.Add(lvi);
            }
        }

        private void listViewPopulation_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listViewPopulation.Sort();
        }

        private void listViewPopulation_DoubleClick(object sender, EventArgs e)
        {
            int clickedID = int.Parse(((ListView)sender).SelectedItems[0].Text);
            byte[] stats = new byte[9];
            world.Population[clickedID].Stats.CopyTo(stats,0);
            UserControlCharacter clickedCharacter = new UserControlCharacter(stats);
            clickedCharacter.Dock = DockStyle.Fill;
            Form window = new Form();
            window.Controls.Add(clickedCharacter);
            window.Size = new System.Drawing.Size(180, 320);
            window.Show();
        }

        private void buttonNextGeneration_Click(object sender, EventArgs e)
        {
            world.BreedNewGeneration((int)nudMutationRate.Value, (int)nudMaxMutationValue.Value);
            world.Population = world.AllPopulations[world.AllPopulations.Count - 1];
            world.CalculateFitness(labelRecalculateFitness);
            UpdateListViewGenerations();
        }

        private void buttonXGenerations_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<nudXGenerations.Value; i++)
            {
                world.BreedNewGeneration((int)nudMutationRate.Value, (int)nudMaxMutationValue.Value);
                world.Population = world.AllPopulations[world.AllPopulations.Count - 1];
                world.CalculateFitness(labelRecalculateFitness);
                UpdateListViewGenerations();
            }
        }

        private void listViewGenerations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewGenerations.SelectedItems.Count > 0)
            { 
                int num = listViewGenerations.Items.IndexOf(listViewGenerations.SelectedItems[0]);
                world.Population = world.AllPopulations[num];
                UpdateListViewPopulation();
                labelGenerationNumber.Text = ("Generation #" + num);
            }
        }

        private void listViewGenerations_DoubleClick(object sender, EventArgs e)
        {
            if (listViewGenerations.SelectedItems.Count > 0)
            {
                int num = listViewGenerations.Items.IndexOf(listViewGenerations.SelectedItems[0]);
                world.Population = world.AllPopulations[num];
                UpdateListViewPopulation();
                labelGenerationNumber.Text = ("Generation #" + num);
                tabControl1.SelectedIndex = 0;
            }
        }
    }
}
