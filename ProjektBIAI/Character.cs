using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBIAI
{
    class Character
    {
        byte [] stats = new byte [9]; // stosunek statystyk z wartościami 0-255
        int currentHp; // aktualna wartość HP, ustawiana na początku walki i zmniejszana w jej trakcie

        int maxHp;     // HP - punkty zdrowia; bazowo 100 + 100 za punkt
        int hpRegen; // regeneracja HP na rundę; 5 za punkt
        int baseDmg;    // obrażenia; bazowo 10 + 20 za punkt
        int critRate;   // szansa na trafienie krytyczne; bazowo 0% + 2% za punkt
        double critDmg;  // dodatkowe obrażenia zadawane przez trafienie krytyczne; bazowo +50% +5% za punkt
        int hitRate;  // szansa na trafienie; bazowo 50% + 5% za punkt
        int dodgeRate; // szansa na uniknięcie trafienia; -5% za punkt
        int blockRate; // szansa na zablokowanie; 0% +2% za punkt
        double blockPower; // procent o jaki zmniejszone są obrażenia po udanym bloku; bazowo -50% -5% za punkt

        /// <summary>
        /// Konstruktor domyślny, tworzy postać z równomiernie rozłożonymi statystykami, łącznie zawierającą 100 pkt
        /// </summary>
        Character()
        {
            computeValues(new byte[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 100);
        }

        /// <summary>
        /// Tworzy postać z równomiernie rozłożonymi statystykami, suma punktów podana w parametrze
        /// </summary>
        /// <param name="pts">Łączna liczba punktów do rozdysponowania</param>
        Character(int pts)
        {
            computeValues(new byte[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 }, pts);
        }

        /// <summary>
        /// Tworzy postać na podstawie podanych parametrów
        /// </summary>
        /// <param name="sta">Tablica 9 wartości 0-255 ze stosunkiem statystyk</param>
        /// <param name="pts">Łączna liczba punktów do rozdysponowania</param>
        Character (byte[]sta, int pts)
        {
            computeValues(sta, pts);
        }

        /// <summary>
        /// Oblicza wartości punktowe parametrów postaci na postawie tablicy ze statystykami i sumy punktów do rozdysponowania
        /// </summary>
        /// <param name="stats">Tablica 9 wartości 0-255 ze stosunkiem statystyk</param>
        /// <param name="points">Łączna liczba punktów do rozdysponowania</param>
        void computeValues(byte[] stats, int points)
        {
            int sum = 0; // suma wszystkich statystyk
            foreach (byte value in stats)
            {
                sum += value;
            }

            this.maxHp = 100 + 100 * (stats[0]/sum);
            this.hpRegen = 5 * (stats[1]/sum);
            this.baseDmg = 10 + 20 * (stats[2]/sum);

            // dalszej części nie ogarnaim jaką miałeś koncepcję (część jest double część jest int a wszystkie są procentami), więc zostawiam Tobie
            //this.critRate = 
            //this.critDmg = 
            //this.hitRate = 
            //this.dodgeRate = 
            //this.blockRate = 
            //this.blockPower = 
        }
    }
}
