using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBIAI
{
    class Character
    {
        byte [] stats = new byte [9];
        int currentHp;
        int maxHp;     // HP - punkty zdrowia; bazowo 100 + 100 za punkt
        int hpRegen; // regeneracja HP na rundę; 5 za punkt
        int baseDmg;    // obrażenia; bazowo 10 + 20 za punkt
        int critRate;   // szansa na trafienie krytyczne; bazowo 0% + 2% za punkt
        double critDmg;  // dodatkowe obrażenia zadawane przez trafienie krytyczne; bazowo +50% +5% za punkt
        int hitRate;  // szansa na trafienie; bazowo 50% + 5% za punkt
        int dodgeRate; // szansa na uniknięcie trafienia; -5% za punkt
        int blockRate; // szansa na zablokowanie; 0% +2% za punkt
        double blockPower; // procent o jaki zmniejszone są obrażenia po udanym bloku; bazowo -50% -5% za punkt
    }
}
