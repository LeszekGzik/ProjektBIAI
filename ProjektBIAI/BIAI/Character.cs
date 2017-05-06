using System;

namespace ProjektBIAI
{
    /// <summary>
    /// Pojedyncza postać
    /// </summary>
    public class Character
    {
        /// <summary>
        /// Wartość współczynnika fitness
        /// </summary>
        int fitness;

        /// <summary>
        /// stosunek statystyk z wartościami 0-255
        /// </summary>
        byte[] stats; 

        /// <summary>
        /// aktualna wartość HP, ustawiana na początku walki i zmniejszana w jej trakcie
        /// </summary>
        int currentHp;

        /// <summary>
        /// STAT [0]
        /// HP - punkty zdrowia; bazowo 100 + 100 za punkt
        /// </summary>
        int maxHp;

        /// <summary>
        /// STAT [1]
        /// regeneracja HP na rundę; 5 za punkt
        /// </summary>
        int hpRegen;

        /// <summary>
        /// STAT [2]
        /// obrażenia; bazowo 10 + 20 za punkt
        /// </summary>
        int baseDmg;

        /// <summary>
        /// STAT [3]
        /// szansa na trafienie krytyczne; bazowo 0% + 2% za punkt
        /// </summary>
        int critRate;

        /// <summary>
        /// STAT [4]
        /// mnożnik obrażeń zadawanych przez trafienie krytyczne; bazowo +50% +5% za punkt
        /// </summary>
        double critDmg;

        /// <summary>
        /// STAT [5]
        /// szansa na trafienie; bazowo 50% + 5% za punkt
        /// </summary>
        int hitRate;

        /// <summary>
        /// STAT [6]
        /// szansa na uniknięcie trafienia; -5% za punkt
        /// </summary>
        int dodgeRate;

        /// <summary>
        /// STAT [7]
        /// szansa na zablokowanie; 0% +2% za punkt
        /// </summary>
        int blockRate;

        /// <summary>
        /// STAT [8]
        /// procent o jaki zmniejszone są obrażenia po udanym bloku; bazowo -50% -5% za punkt
        /// </summary>
        double blockPower;

        /// <summary>
        /// Stosunek statystyk z wartościami 0-255
        /// [0] = maxHp;
        /// [1] = hpRegen;
        /// [2] = baseDmg;
        /// [3] = critRate;
        /// [4] = critDmg;
        /// [5] = hitRate;
        /// [6] = dodgeRate;
        /// [7] = blockRate;
        /// [8] = blockPower;
        /// </summary>
        public byte[] Stats
        {
            get
            {
                return stats;
            }

            set
            {
                stats = value;
            }
        }

        /// <summary>
        /// Wartość współczynnika fitness
        /// </summary>
        public int Fitness
        {
            get
            {
                return fitness;
            }

            set
            {
                fitness = value;
            }
        }

        /// <summary>
        /// Konstruktor domyślny, tworzy postać z równomiernie rozłożonymi statystykami, suma punktów do rozdysponowania == 100
        /// </summary>
        public Character()
        {
            stats = new byte[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            ComputeValues(100);
        }      

        /// <summary>
        /// Tworzy postać z równomiernie rozłożonymi statystykami, suma punktów podana w parametrze
        /// </summary>
        /// <param name="pts">Łączna liczba punktów do rozdysponowania</param>
        public Character(byte pts)
        {
            stats = new byte[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            ComputeValues(pts);
        }

        /// <summary>
        /// Tworzy postać z losowo rozłożonymi statystykami, suma punktów do rozdysponowania == 100
        /// </summary>
        /// <param name="rnd">Generator liczb pseudolosowych</param>
        public Character(Random rnd)
        {
            stats = new byte[9];
            rnd.NextBytes(stats);
            ComputeValues(100);
        }

        /// <summary>
        /// Tworzy postać z losowo rozłożonymi statystykami, suma punktów podana w parametrze
        /// </summary>
        /// <param name="rnd">Generator liczb pseudolosowych</param>
        /// <param name="pts">Ilość punktów do rozdysponowania</param>
        public Character(Random rnd, byte pts)
        {
            stats = new byte[9];
            rnd.NextBytes(stats);
            ComputeValues(pts);
        }

        /// <summary>
        /// Tworzy postać na podstawie podanych parametrów
        /// </summary>
        /// <param name="sta">Tablica 9 wartości 0-255 ze stosunkiem statystyk</param>
        /// <param name="pts">Łączna liczba punktów do rozdysponowania</param>
        public Character (byte[]sta, byte pts)
        {
            stats = new byte[9];
            sta.CopyTo(stats, 0);
            ComputeValues(pts);
        }

        /// <summary>
        /// Oblicza wartości punktowe parametrów postaci na postawie tablicy ze statystykami i sumy punktów do rozdysponowania
        /// </summary>
        /// <param name="points">Łączna liczba punktów do rozdysponowania</param>
        void ComputeValues(byte points)
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
            this.critDmg = (1.5 + 0.05 * (points * stats[4] / sum));     //trzeba by coś zrobić z balansem tutaj
            this.hitRate = (int)(50 + 5 * (points * stats[5] / sum));
            this.dodgeRate = (int)(5 * (points * stats[6] / sum));
            this.blockRate = (int)(2 * (points * stats[7] / sum));
            this.blockPower = (0.5 - 0.05 * (points * stats[8] / sum));  //trzeba by coś zrobić z balansem tutaj
        }

        /// <summary>
        /// Zwraca tablicę zawierającą obliczone wartości statystyk
        /// </summary>
        /// <returns>
        ///    ret[0] = maxHp;
        ///    ret[1] = hpRegen;
        ///    ret[2] = baseDmg;
        ///    ret[3] = critRate;
        ///    ret[4] = critDmg;
        ///    ret[5] = hitRate;
        ///    ret[6] = dodgeRate;
        ///    ret[7] = blockRate;
        ///    ret[8] = blockPower;
        /// </returns>
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

        /// <summary>
        /// Ustawia postaci maksymalne HP
        /// </summary>
        public void regenFull()
        {
            this.currentHp = this.maxHp;
        }

        internal void TwoPointCrossover(Character character, Random rnd)
        {
            byte temp;
            int[] crossingPoint = new int[2];
            crossingPoint[0] = rnd.Next(1, 9);
            crossingPoint[1] = rnd.Next(1, 9);
            while (crossingPoint[0] == crossingPoint[1])
            {
                crossingPoint[1] = rnd.Next(1, 9);
            }
            Array.Sort(crossingPoint);
            for (int i=crossingPoint[0]; i<crossingPoint[1]; i++)
            {
                temp = stats[i];
                stats[i] = character.stats[i];
                character.stats[i] = temp;
            }

        }

        internal void SinglePointCrossover(Character character, Random rnd)
        {
            byte temp;
            int crossingPoint = rnd.Next(1, 9);
            for (int i = 0; i<crossingPoint; i++)
            {
                temp = stats[i];
                stats[i] = character.stats[i];
                character.stats[i] = temp;
            }
        }

        /// <summary>
        /// Zwiększa HP postaci o współczynnik hpRegen
        /// </summary>
        /// <returns>String z informacją o przywróconym HP</returns>
        public string regen()
        {
            currentHp += hpRegen;
            if (currentHp > maxHp)
                currentHp = maxHp;
            return "restored to " + currentHp + " HP" + Environment.NewLine;
        }

        /// <summary>
        /// Zaatakuj przeciwnika podanego w parametrze
        /// </summary>
        /// <param name="enemy">Przeciwnik do zaatakowania</param>
        /// <param name="rnd">Generator liczb pseudolosowych</param>
        /// <returns>String z informacją o walce</returns>
        public string attack(Character enemy, Random rnd)
        {
            string result = "";
            int dmg;

            if (rnd.Next(0, 100) < (this.hitRate - enemy.dodgeRate))     //czy trafił?
            {
                if (rnd.Next(0, 100) < this.critRate)                    //czy krytyk?
                {
                    result += "'s attack hit critically! ";
                    if (rnd.Next(0, 100) < enemy.blockRate)            //czy krytyk został zablokowany?
                    {
                        dmg = this.baseDmg;
                        enemy.currentHp -= dmg;
                        result += ("Target blocked and took only " + dmg.ToString() + " damage.\n");
                    }
                    else
                    {
                        dmg = (int)(this.baseDmg * this.critDmg);
                        enemy.currentHp -= dmg;
                        result += ("Target took " + dmg.ToString() + " damage.\n");
                    }
                }
                else if (rnd.Next(0, 100) < enemy.blockRate)            //czy atak został zablokowany?
                {
                    result += "'s attack hit. Target blocked ";
                    dmg = (int)(this.baseDmg * enemy.blockPower);
                    enemy.currentHp -= dmg;
                    if (enemy.blockPower < 0)
                        result += ("and absorbed " + (-dmg).ToString() + " damage.\n");
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
