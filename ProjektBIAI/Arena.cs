using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBIAI
{
    /// <summary>
    /// Arena walki dwóch postaci
    /// </summary>
    class Arena
    {
        Character char1, char2;
        public Random rnd;

        public Arena(Character _char1, Character _char2)
        {
            char1 = _char1;
            char2 = _char2;
            rnd = new Random();
        }

        public string playBattleReport()
        {
            string result = "";
            bool end = false;
            int round = 1;

            char1.regenFull();
            char2.regenFull();

            while (!end)
            {
                result += ("-=ROUND " + round.ToString() + "=-\n");
                result += ("Character 1 " + char1.regen());
                result += ("Character 2 " + char2.regen());
                result += ("Character 1" + char1.attack(char2, rnd));
                result += ("Character 2" + char2.attack(char1, rnd));
                if (char1.isDead())
                {
                    result += "\nCharacter 1 is dead.";
                    end = true;
                }
                if (char2.isDead())
                {
                    result += "\nCharacter 2 is dead.";
                    end = true;
                }
                round++;
            }
            return result;
        }

        /// <summary>
        /// metoda rozgrywająca walkę między postaciami w arenie
        /// </summary>
        /// <returns>true jeśli wygrał char1, false jeśli char2</returns>
        public bool playBattle()
        {
            return true;
        }
    }
}