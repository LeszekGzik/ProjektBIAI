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
        /// dodatkowe obrażenia zadawane przez trafienie krytyczne; bazowo +50% +5% za punkt
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

            this.maxHp = (int)(100 + 100 * (points*stats[0]/sum));
            this.hpRegen = (int)(5 * (points*stats[1]/sum));
            this.baseDmg = (int)(10 + 20 * (points*stats[2]/sum));

            // dalszej części nie ogarnaim jaką miałeś koncepcję (część jest double część jest int a wszystkie są procentami), więc zostawiam Tobie
            //this.critRate = 
            //this.critDmg = 
            //this.hitRate = 
            //this.dodgeRate = 
            //this.blockRate = 
            //this.blockPower = 
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
    }
}
