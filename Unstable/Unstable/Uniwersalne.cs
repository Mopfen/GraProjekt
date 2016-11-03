using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unstable
{
    /// <summary> Zawiera uniwersalne metody, których można użyć w całym programie.</summary>
    class Uniwersalne
    {
        /// <summary> Umożliwia dostęp do danych zawartych w klasie Launcher.</summary>
        Launcher daneLauncher;

        public Uniwersalne(Launcher dane)
        {
            daneLauncher = dane;
        }
        internal int dmgZwarcieGracz() 
        {
            int dmg = 0;

            dmg += daneLauncher.siła;

            return dmg;
        }
        internal int dmgZwarcieMob(int wartośćAtaku)
        {
            return wartośćAtaku;
        }
        internal int wyliczProcent(int liczba1, int liczba2)
        {
            return (liczba1 * 100) / liczba2;
        }
        internal int losuj(int min,int max)
        {
            Random random = new Random();
            return random.Next(min, max+1);
        }
        internal bool śmierćGracza()
        {
            if (daneLauncher.hpGracz <= 0)
            {
                daneLauncher.hpGracz = 0;
                return true;
            }
            return false;
        }
        internal Tuple<bool,int> śmierćMoba()
        {
            int i = 0;
            bool zabity = false;
            Tuple<bool, int> wynik = new Tuple<bool, int>(zabity, i);
            for (i = 0; i < 9; i++)
            {
                if(daneLauncher.daneMob[i].istniejeMob==true)
                {
                    if (daneLauncher.daneMob[i].hpMob <= 0)
                    {
                        daneLauncher.daneMob[i].hpMob = 0;
                        zabity = true;
                        daneLauncher.hitLog.Text = "Mob zostaje zabity!\n" + daneLauncher.hitLog.Text;
                        if (daneLauncher.lvMob == daneLauncher.lvGracz) daneLauncher.exp+=5;
                        daneLauncher.daneMob[i].mob.Visible=false;
                        daneLauncher.daneMob[i].labelhpMob.Visible = false;
                        wynik = new Tuple<bool, int>(zabity, i);
                        return wynik;
                    }
                }
            }
            return wynik;
        }
        internal bool levelUp()
        {
            if(daneLauncher.exp>=daneLauncher.expMax)
            {
                daneLauncher.lvGracz++;
                daneLauncher.exp -= daneLauncher.expMax;
                daneLauncher.expMax += 5;
                return true;
            }
            return false;
        }
    }
}
