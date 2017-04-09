using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBIAI
{
    class Arena
    {
        public Character char1, char2;

        public Arena(Character _char1, Character _char2)
        {
            char1 = _char1;
            char2 = _char2;
        }

        public string playBattleReport()
        {
            string result = "";
            bool end = false;
            int round = 1;
            while (!end)
            {
                result += ("-=ROUND " + round.ToString() + "=-\n");
                result += "Character 1 ";
                result += char1.regen();
                result += "Character 2 ";
                result += char2.regen();
                result += char1.attack(char2);
                result += char2.attack(char1);
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