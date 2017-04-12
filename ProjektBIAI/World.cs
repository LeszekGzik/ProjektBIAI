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
        List<Character> population;

        void CreatePopulation(int sizeOfPopulation)
        {
            Random rnd = new Random();
            for (int i=0; i<sizeOfPopulation; i++)
            {
                population.Add(new Character(rnd));
            }
            
        }
    }
}
