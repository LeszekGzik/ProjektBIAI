using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBIAI
{
    class Character
    {
        /// <summary>
        /// stosunek statystyk z wartościami 0-255
        /// </summary>
        byte[] stats = new byte [9]; 

        /// <summary>
        /// aktualna wartość HP, ustawiana na początku walki i zmniejszana w jej trakcie
        /// </summary>
        int currentHp;

        /// <summary>
        /// HP - punkty zdrowia; bazowo 100 + 100 za punkt
        /// </summary>
        int maxHp;

        /// <summary>
        /// regeneracja HP na rundę; 5 za punkt
        /// </summary>
        int hpRegen;

        /// <summary>
        /// obrażenia; bazowo 10 + 20 za punkt
        /// </summary>
        int baseDmg;

        /// <summary>
        /// szansa na trafienie krytyczne; bazowo 0% + 2% za punkt
        /// </summary>
        int critRate;

        /// <summary>
        /// mnożnik obrażeń zadawanych przez trafienie krytyczne; bazowo +50% +5% za punkt
        /// </summary>
        double critDmg;

        /// <summary>
        /// szansa na trafienie; bazowo 50% + 5% za punkt
        /// </summary>
        int hitRate;

        /// <summary>
        /// szansa na uniknięcie trafienia; -5% za punkt
        /// </summary>
        int dodgeRate;

        /// <summary>
        /// szansa na zablokowanie; 0% +2% za punkt
        /// </summary>
        int blockRate;

        /// <summary>
        /// procent o jaki zmniejszone są obrażenia po udanym bloku; bazowo -50% -5% za punkt
        /// </summary>
        double blockPower;

        /// <summary>
        /// Konstruktor domyślny, tworzy postać z równomiernie rozłożonymi statystykami, łącznie zawierającą 100 pkt
        /// </summary>
        public Character()
        {
            computeValues(new byte[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 100);
        }

        /// <summary>
        /// Tworzy postać z równomiernie rozłożonymi statystykami, suma punktów podana w parametrze
        /// </summary>
        /// <param name="pts">Łączna liczba punktów do rozdysponowania</param>
        public Character(byte pts)
        {
            computeValues(new byte[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 }, pts);
        }

        /// <summary>
        /// Tworzy postać na podstawie podanych parametrów
        /// </summary>
        /// <param name="sta">Tablica 9 wartości 0-255 ze stosunkiem statystyk</param>
        /// <param name="pts">Łączna liczba punktów do rozdysponowania</param>
        public Character (byte[]sta, byte pts)
        {
            computeValues(sta, pts);
        }

        /// <summary>
        /// Oblicza wartości punktowe parametrów postaci na postawie tablicy ze statystykami i sumy punktów do rozdysponowania
        /// </summary>
        /// <param name="stats">Tablica 9 wartości 0-255 ze stosunkiem statystyk</param>
        /// <param name="points">Łączna liczba punktów do rozdysponowania</param>
        void computeValues(byte[] stats, byte points)
        {
            double sum = 0; // suma wszystkich statystyk, double aby wymusić dzielenie rzeczywiste
            foreach (byte value in stats)
            {
                sum += value;
            }

            this.maxHp = (int)(100 + 100 * (points*stats[0] / sum));
            this.hpRegen = (int)(5 * (points*stats[1] / sum));
            this.baseDmg = (int)(10 + 20 * (points*stats[2] / sum));
            this.critRate = (int)(2 * (points * stats[3] / sum));
            this.critDmg = (1.5 + 0.05 * (points * stats[4] / sum));
            this.hitRate = (int)(50 + 5 * (points * stats[5] / sum));
            this.dodgeRate = (int)(5 * (points * stats[6] / sum));
            this.blockRate = (int)(2 * (points * stats[7] / sum));
            this.blockPower = (0.5 - 0.05 * (points * stats[8] / sum));
        }

        public double[] getComputedValues()
        {
            double[] ret = new double[9];
            ret[0] = maxHp;
            ret[1] = hpRegen;
            ret[2] = baseDmg;
            ret[3] = critRate;
            ret[4] = critDmg;
            ret[5] = hitRate;
            ret[6] = dodgeRate;
            ret[7] = blockRate;
            ret[8] = blockPower;
            return ret;
        }

        public void regenFull()
        {
            this.currentHp = this.maxHp;
        }

        public string regen()
        {
            currentHp += hpRegen;
            if (currentHp > maxHp)
                currentHp = maxHp;
            return "restored to " + currentHp + " HP" + Environment.NewLine;
        }

        public string attack(Character enemy, Random rnd)
        {
            string result = "";
            int dmg;

            if (rnd.Next(0, 100) < (this.hitRate - enemy.dodgeRate))     //czy trafił?
            {
                if (rnd.Next(0, 100) < this.critRate)                    //czy krytyk?
                {
                    result += "'s attack hit critically! ";
                    dmg = (int)(this.baseDmg * this.critDmg);
                    enemy.currentHp -= dmg;
                    result += ("Target took " + dmg.ToString() + " damage.\n");
                }
                else if (rnd.Next(0, 100) < enemy.blockRate)            //czy atak został zablokowany?
                {
                    result += "'s attack hit. Target blocked ";
                    dmg = (int)(this.baseDmg * enemy.blockPower);
                    enemy.currentHp -= dmg;
                    if (enemy.blockPower < 0)
                        result += ("and absorbed " + dmg.ToString() + " damage.\n");
                    else
                        result += ("and took only " + dmg.ToString() + " damage.\n");
                }
                else
                {
                    result += "'s attack hit. ";
                    dmg = this.baseDmg;
                    enemy.currentHp -= dmg;
                    result += ("Target took " + dmg.ToString() + " damage.\n");
                }
            }
            else
                result += "'s attack missed.\n";

            return result;
        }

        public bool isDead()
        {
            return (this.currentHp <= 0);
        }
    }
}
