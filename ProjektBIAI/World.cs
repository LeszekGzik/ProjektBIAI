using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBIAI
{
    /// <summary>
    /// Klasa przechowująca całą populację
    /// </summary>
    class World
    {
        /// <summary>
        /// Najświeższa, aktualnie żyjąca populacja
        /// </summary>
        List<Character> population;

        /// <summary>
        /// Ilość walk rozgrywanych z każdym przeciwnikiem przy wyznaczaniu fitness
        /// </summary>
        int numberOfBattlesForCalculateFitness;

        /// <summary>
        /// Krok poziomu przeciwników przy wyznaczaniu fitness
        /// </summary>
        byte stepOfIncrementOpponentsForFitness;

        /// <summary>
        /// Tablica statystyk przeciwników dla danego świata, potrzebnych do obliczania fitness
        /// </summary>
        byte[] statsOfOpponentsForFitness = new byte[9];

        public World(int sizeOfPopulation, int battlesForFitness, byte stepForFitness, byte[] statsForFitness)
        {
            Random rnd = new Random();
            population = new List<Character>();
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
        public void CalculateFitness()
        {
            Arena arena;
            foreach (Character ch in population)
            {
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
            }
        }
    }
}
