using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektBIAI
{
    /// <summary>
    /// Klasa przechowująca całą populację
    /// </summary>
    class World
    {
        /// <summary>
        /// najświeższa, aktualnie żyjąca populacja
        /// </summary>
        List<Character> population;

        /// <summary>
        /// lista wszystkich populacji
        /// </summary>
        List<List<Character>> allPopulations;

        /// <summary>
        /// ilość walk rozgrywanych z każdym przeciwnikiem przy wyznaczaniu fitness
        /// </summary>
        int numberOfBattlesForCalculateFitness;

        /// <summary>
        /// krok poziomu przeciwników przy wyznaczaniu fitness
        /// </summary>
        byte stepOfIncrementOpponentsForFitness;

        /// <summary>
        /// Tablica statystyk przeciwników dla danego świata, potrzebnych do obliczania fitness
        /// </summary>
        byte[] statsOfOpponentsForFitness;

        /// <summary>
        /// Ilość walk rozgrywanych z każdym przeciwnikiem przy wyznaczaniu fitness
        /// </summary>
        public int NumberOfBattlesForCalculateFitness
        {
            get
            {
                return numberOfBattlesForCalculateFitness;
            }

            set
            {
                numberOfBattlesForCalculateFitness = value;
            }
        }

        internal void ArchiveCurrentPopulation()
        {
            List<Character> lst = new List<Character>(population);
            AllPopulations.Add(lst);
        }

        /// <summary>
        /// Krok poziomu przeciwników przy wyznaczaniu fitness
        /// </summary>
        public byte StepOfIncrementOpponentsForFitness
        {
            get
            {
                return stepOfIncrementOpponentsForFitness;
            }

            set
            {
                stepOfIncrementOpponentsForFitness = value;
            }
        }

        /// <summary>
        /// Najświeższa, aktualnie żyjąca populacja
        /// </summary>
        public List<Character> Population
        {
            get
            {
                return population;
            }

            set
            {
                population = value;
            }
        }

        public List<List<Character>> AllPopulations
        {
            get
            {
                return allPopulations;
            }

            set
            {
                allPopulations = value;
            }
        }

        /// <summary>
        /// Zapisuje parametry Fitness do tablicy
        /// </summary>
        /// <param name="previousFitness">Tablica do której zapisane zostaną wyniki</param>
        internal void UpdatePreviousFitness(int[] previousFitness)
        {
            for (int i=0; i<population.Count; i++)
            {
                previousFitness[i] = population[i].Fitness;
            }
        }

        public World(int sizeOfPopulation, int battlesForFitness, byte stepForFitness, byte[] statsForFitness)
        {

            Random rnd = new Random();
            population = new List<Character>();
            allPopulations = new List<List<Character>>();
            statsOfOpponentsForFitness = new byte[9];
            for (int i = 0; i < sizeOfPopulation; i++)
            {
                population.Add(new Character(rnd));
            }
            numberOfBattlesForCalculateFitness = battlesForFitness;
            stepOfIncrementOpponentsForFitness = stepForFitness;
            statsForFitness.CopyTo(statsOfOpponentsForFitness, 0);
        }

        /// <summary>
        /// Oblicza współczynnik fitness dla całej populacji zapisanej na świecie
        /// </summary>
        /// <param name="calculationStatus">Etykieta z aktualnym statusem operacji</param>
        public void CalculateFitness(Label calculationStatus)
        {
            Arena arena;
            int characterIndex = 0;
            Stopwatch stopwatch = new Stopwatch();
            foreach (Character ch in population)
            {
                stopwatch.Start();
                bool end = false;
                byte opponentLevel = stepOfIncrementOpponentsForFitness;
                while (!end)
                {
                    arena = new Arena(ch, new Character(statsOfOpponentsForFitness, opponentLevel));
                    int wonBattles = 0;
                    for (int i = 0; i < numberOfBattlesForCalculateFitness; i++)
                    {
                        if (arena.playBattle())
                        {
                            wonBattles++;
                        }
                        else
                        {
                            wonBattles--;
                        }
                    }
                    if (wonBattles > 0)
                    {
                        opponentLevel += stepOfIncrementOpponentsForFitness;
                    }
                    else
                    {
                        end = true;
                    }                    
                }
                ch.Fitness = 10 * opponentLevel;
                arena = new Arena(ch, new Character(statsOfOpponentsForFitness, opponentLevel));
                for (int i=0; i<10; i++)
                {
                    if (arena.playBattle())
                    {
                        ch.Fitness++;
                    }
                }
                characterIndex++;
                calculationStatus.Text = "Calculated " + characterIndex.ToString() + "/" + population.Count.ToString();
                calculationStatus.Update();
            }
            stopwatch.Stop();
            calculationStatus.Text += " in " + stopwatch.Elapsed.TotalSeconds + " sec";
        }
    }
}
