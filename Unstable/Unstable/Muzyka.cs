using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unstable
{
    class Muzyka
    {
        Launcher daneLauncher;

        public Muzyka(Launcher dane)
        {
            daneLauncher = dane;
        }

        public void SoundtrackMenu()
        {
            daneLauncher.music.URL = "SoundtrackMenu.wav";
            //daneLauncher.music.Ctlcontrols.play();
        }

        public void Soundtrack1()
        {
            daneLauncher.music.URL = "Soundtrack1.wav";
            //daneLauncher.music.Ctlcontrols.play();
        }
    }
}
