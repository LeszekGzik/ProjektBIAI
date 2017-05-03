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
                world.ArchiveCurrentPopulation();
                nudGenerationNumber.Maximum = 0;
                UpdateListViewPopulation();
                UpdateAllGenerationsInfo();
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

        private string findPopulationBestGenome(List<Character> population)
        {
            int maxFitness = 0;
            Character bestChar = population[0];
            foreach (Character ch in population)
            {
                if (ch.Fitness > maxFitness)
                {
                    maxFitness = ch.Fitness;
                    bestChar = ch;
                }
            }
            return getGenotype(bestChar);
        }

        private void buttonRecalculateFitness_Click(object sender, EventArgs e)
        {
            world.UpdatePreviousFitness(previousFitness);
            world.CalculateFitness(labelRecalculateFitness);
            UpdateListViewPopulation();
            UpdateCurrentGenerationInfo();
        }

        /// <summary>
        /// Aktualizuje wszystkie wpisy na liście pokoleń. Zalecane używanie UpdateCurrentGenerationInfo() zamiast tego.
        /// </summary>
        private void UpdateAllGenerationsInfo()
        {
            listViewGenerations.Items.Clear();
            for (int i = 0; i < world.AllPopulations.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(calculatePopulationMaxFitness(world.AllPopulations[i]).ToString());
                lvi.SubItems.Add(calculatePopulationMinFitness(world.AllPopulations[i]).ToString());
                lvi.SubItems.Add(calculatePopulationAvgFitness(world.AllPopulations[i]).ToString());
                lvi.SubItems.Add(findPopulationBestGenome(world.AllPopulations[i]));
                listViewGenerations.Items.Add(lvi);
                listViewGenerations.Update();
            }
        }

        /// <summary>
        /// Aktualizuje pojedynczy wpis na liście pokoleń.
        /// </summary>
        private void UpdateCurrentGenerationInfo()
        {
            int index = world.AllPopulations.Count - 1;
            if (index >= listViewGenerations.Items.Count)
            {
                ListViewItem lvi = new ListViewItem(index.ToString());
                lvi.SubItems.Add(calculatePopulationMaxFitness(world.AllPopulations[index]).ToString());
                lvi.SubItems.Add(calculatePopulationMinFitness(world.AllPopulations[index]).ToString());
                lvi.SubItems.Add(calculatePopulationAvgFitness(world.AllPopulations[index]).ToString());
                lvi.SubItems.Add(findPopulationBestGenome(world.AllPopulations[index]));
                listViewGenerations.Items.Add(lvi);
                listViewGenerations.Update();
            }
            else
            {
                listViewGenerations.Items[index].SubItems[1].Text = calculatePopulationMaxFitness(world.AllPopulations[index]).ToString();
                listViewGenerations.Items[index].SubItems[2].Text = calculatePopulationMinFitness(world.AllPopulations[index]).ToString();
                listViewGenerations.Items[index].SubItems[3].Text = calculatePopulationAvgFitness(world.AllPopulations[index]).ToString();
                listViewGenerations.Items[index].SubItems[4].Text = findPopulationBestGenome(world.AllPopulations[index]);
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
            for (int i=0; i<world.AllPopulations[(int)nudGenerationNumber.Value].Count; i++)
            {
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(world.AllPopulations[(int)nudGenerationNumber.Value][i].Fitness.ToString());
                if (nudGenerationNumber.Value == world.AllPopulations.Count - 1)
                {
                    lvi.SubItems.Add(previousFitness[i].ToString());
                    lvi.SubItems.Add(Math.Abs(world.Population[i].Fitness - previousFitness[i]).ToString());
                }
                else
                {
                    lvi.SubItems.Add("N/A");
                    lvi.SubItems.Add("N/A");
                }
                lvi.SubItems.Add(getGenotype(world.Population[i]));
                listViewPopulation.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Wylicza genotyp osobnika, przedstawiający jego statystyki w postaci hex.
        /// </summary>
        /// <param name="ch"> osobnik, którego genotyp ma być wyliczony </param>
        /// <returns></returns>
        private string getGenotype(Character ch)
        {
            string genotype = String.Empty;
            byte[] stats = ch.Stats;
            foreach (byte st in stats)
            {
                genotype += st.ToString("X2");
                genotype += ' ';
            }
            return genotype;
        }

        private void listViewPopulation_ColumnClick(object sender, ColumnClickEventArgs e) //kliknięcie na kolumnie populacji - sortuj
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

        private void listViewPopulation_DoubleClick(object sender, EventArgs e) //dwuklik na osobniku w populacji - okienko podglądu
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
            for (int i = 0; i < numberOfGenerations; i++)
            {
                world.CurrentGenerationSelection(radioButtonLinearIndex.Checked, labelCreatingGenerationStatus);
                world.CurrentGenerationCrossover((int)nudCrossoverChance.Value, (int)nudSinglePointCrossover.Value, labelCreatingGenerationStatus);
                world.CurrentGenerationMutation((int)nudMutationRate.Value, mutationValue, currentMutationType, labelCreatingGenerationStatus);
                world.CalculateFitness(labelCreatingGenerationStatus);
                Array.Clear(previousFitness, 0, previousFitness.Length);
                world.ArchiveCurrentPopulation();
                nudGenerationNumber.Maximum = world.AllPopulations.Count - 1;
                UpdateCurrentGenerationInfo();
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
            UpdateListViewPopulation();
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

        private void nudSinglePointCrossover_ValueChanged(object sender, EventArgs e)
        {
            nudTwoPointCrossover.Value = 100 - nudSinglePointCrossover.Value;
        }

        private void nudTwoPointCrossover_ValueChanged(object sender, EventArgs e)
        {
            nudSinglePointCrossover.Value = 100 - nudTwoPointCrossover.Value;
        }

        private void buttonExportPopulation_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Binary File|*.bin";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (sfd.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)sfd.OpenFile();
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bformatter.Serialize(fs, world.Population);
                    fs.Close();
                }
            }
        }
        private void buttonImportPopulation_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Binary File|*.bin*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.Stream stream = System.IO.File.Open(ofd.FileName, System.IO.FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    if ((world == null) || (MessageBox.Show("This will destroy existing population!", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes))
                    {
                        world = new World((List<Character>)bformatter.Deserialize(stream), (int)nudNumberOfBattlesForCalculateFitness.Value, (byte)nudStepForFitness.Value, userControlCharacter1.Character.Stats);
                        previousFitness = new int[(int)nudSizeOfPopulation.Value];
                        world.CalculateFitness(labelIsPopulationCreated);
                        world.ArchiveCurrentPopulation();
                        nudGenerationNumber.Maximum = 0;
                        UpdateListViewPopulation();
                        UpdateAllGenerationsInfo();
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
            }
        }
    }
}
