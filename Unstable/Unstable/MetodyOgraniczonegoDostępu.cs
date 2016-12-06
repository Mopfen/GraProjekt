using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unstable
{
    public partial class MetodyOgraniczonegoDostępu: Form
    {
        Launcher daneLauncher;

        protected MetodyOgraniczonegoDostępu() { }

        protected void WczytajDaneOdNowa(Launcher dane)
        {
            daneLauncher = dane;

            daneLauncher.daneGracz = new Launcher.ZmiennePostaci();
            daneLauncher.daneBonusyGracz = new Launcher.ZmienneBonusów();

            for (int i = 0; i <= 99; i++)
            {
                if (i < 2)
                {
                    daneLauncher.daneStrzała[i] = new Launcher.ZmienneObiektów();
                }
                if (i < 5)
                {
                    daneLauncher.daneMob[i] = new Launcher.ZmiennePostaci();

                    daneLauncher.daneNPC[i] = new Launcher.ZmiennePostaci();

                    daneLauncher.daneBonusyMob[i] = new Launcher.ZmienneBonusów();

                    daneLauncher.daneDrop[i] = new Launcher.ZmienneEkwipunku();
                }
                if (i < 17)
                {
                    daneLauncher.daneFabularnyItem[i] = new Launcher.ZmienneEkwipunku();
                }
                if (i < 47)
                {
                    daneLauncher.danePlecakSlot[i] = new Launcher.ZmienneEkwipunku();
                }

                daneLauncher.daneQuest[i] = new Launcher.ZmienneMisji();
                daneLauncher.daneMapa[i] = new Launcher.ZmienneMap();

                for (int j = 0; j <= 19; j++)
                {
                    if (i < 5 & j < 10)
                    {
                        daneLauncher.daneNPC[i].dotartoDoX[j] = false;
                        daneLauncher.daneNPC[i].dotartoDoY[j] = false;
                    }
                    daneLauncher.daneMapa[i].częśćMapyOdwiedzona[j] = false;
                    daneLauncher.daneMapa[i].drop[j] = false;
                }
            }
            daneLauncher.daneGracz.exists = true;
            daneLauncher.daneQuest[0].nazwa = "Przeznaczenie";
            daneLauncher.daneQuest[0].stan = 1;
            daneLauncher.daneQuest[0].etap = 1;
            daneLauncher.daneQuest[0].exp = 100;
            daneLauncher.daneQuest[0].opisEtapu[1] = "Znajdź odpowiedź.";
        }
    }
}
