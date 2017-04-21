using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjektBIAI.Forms;

namespace ProjektBIAI
{
    public partial class UserControlWorld : UserControl
    {
        private ListViewColumnSorter lvwColumnSorter;
        public MutationType currentMutationType = MutationType.RANDOM;
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
                listViewGenerations.Update();
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

        /// <summary>
        /// Aktualizacja okna z populacją
        /// </summary>
        private void UpdateListViewPopulation()
        {
            listViewPopulation.Items.Clear();
            for (int i=0; i<world.Population.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(world.Population[i].Fitness.ToString());
                lvi.SubItems.Add(previousFitness[i].ToString());
                lvi.SubItems.Add(Math.Abs(world.Population[i].Fitness - previousFitness[i]).ToString());
                string genotype = String.Empty;
                byte[] stats = world.Population[i].Stats;
                foreach (byte st in stats)
                {
                    genotype += st.ToString("X2");
                    genotype += ' ';
                }
                lvi.SubItems.Add(genotype);
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

        private void nextGeneration (int numberOfGenerations)
        {
            int mutationValue;
            switch (currentMutationType)
            {
                case MutationType.RANDOM:
                    mutationValue = (int)nudRandomMutation.Value;
                    break;
                case MutationType.CONSTANT:
                    mutationValue = (int)nudConstantMutation.Value;
                    break;
                case MutationType.PERCENT:
                    mutationValue = (int)nudPercentMutation.Value;
                    break;
                default:
                    mutationValue = 0;
                    break;
            }
            for (int i = 0; i < nudXGenerations.Value; i++)
            {
                world.BreedNewGeneration((int)nudMutationRate.Value, mutationValue, radioButtonLinearIndex.Checked, currentMutationType, labelCreatingGenerationStatus);
                world.Population = world.AllPopulations[world.AllPopulations.Count - 1];
                world.CalculateFitness(labelCreatingGenerationStatus);
                UpdateListViewGenerations();
            }
        }
        private void buttonNextGeneration_Click(object sender, EventArgs e)
        {
            nextGeneration(1);
        }

        private void buttonXGenerations_Click(object sender, EventArgs e)
        {
            nextGeneration((int)nudXGenerations.Value);
        }

        private void listViewGenerations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewGenerations.SelectedItems.Count > 0)
            { 
                int num = listViewGenerations.Items.IndexOf(listViewGenerations.SelectedItems[0]);
                nudGenerationNumber.Value = (num);
            }
        }

        private void listViewGenerations_DoubleClick(object sender, EventArgs e)
        {
            if (listViewGenerations.SelectedItems.Count > 0)
            {
                int num = listViewGenerations.Items.IndexOf(listViewGenerations.SelectedItems[0]);
                nudGenerationNumber.Value = (num);
                tabControl1.SelectedIndex = 0;
            }
        }

        private void nudGenerationNumber_ValueChanged(object sender, EventArgs e)
        {
            if (nudGenerationNumber.Value < world.AllPopulations.Count)
            {
                if (nudGenerationNumber.Value >= 0)
                {
                    world.Population = world.AllPopulations[(int)nudGenerationNumber.Value];
                    UpdateListViewPopulation();
                }
                else
                {
                    nudGenerationNumber.Value = 0;
                }
            }
            else
            {
                nudGenerationNumber.Value = world.AllPopulations.Count - 1;
            }

        }

        private void checkBoxDisableMutation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDisableMutation.Checked)
            {
                nudConstantMutation.Enabled = false;
                nudMutationRate.Enabled = false;
                nudPercentMutation.Enabled = false;
                nudRandomMutation.Enabled = false;
                radioButtonConstantMutation.Enabled = false;
                radioButtonPercentMutation.Enabled = false;
                radioButtonRandomMutation.Enabled = false;
                UpdateCurrentMutationType();
            }
            else
            {
                nudConstantMutation.Enabled = true;
                nudMutationRate.Enabled = true;
                nudPercentMutation.Enabled = true;
                nudRandomMutation.Enabled = true;
                radioButtonConstantMutation.Enabled = true;
                radioButtonPercentMutation.Enabled = true;
                radioButtonRandomMutation.Enabled = true;
                UpdateCurrentMutationType();
            }
        }

        /// <summary>
        /// metoda, która ustawia currentMutationType w zależności od stanu kontrolek
        /// </summary>
        private void UpdateCurrentMutationType()
        {
            if (checkBoxDisableMutation.Checked)
                currentMutationType = MutationType.NONE;
            else if (radioButtonConstantMutation.Checked)
                currentMutationType = MutationType.CONSTANT;
            else if (radioButtonPercentMutation.Checked)
                currentMutationType = MutationType.PERCENT;
            else if (radioButtonRandomMutation.Checked)
                currentMutationType = MutationType.RANDOM;
        }

        private void radioButtonRandomMutation_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCurrentMutationType();
        }

        private void radioButtonConstantMutation_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCurrentMutationType();
        }

        private void radioButtonPercentMutation_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCurrentMutationType();
        }
    }
}
