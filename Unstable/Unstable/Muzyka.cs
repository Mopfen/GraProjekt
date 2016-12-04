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

        public void Soundtrack(string nazwa)
        {
            if(daneLauncher.muzykaOn==true)
            {
                daneLauncher.music.URL = nazwa;
            }
        }

        public void SoundEffect(AxWMPLib.AxWindowsMediaPlayer soundEffect, string nazwa)
        {
            if (daneLauncher.efektyDźwiękoweOn == true)
            {
                soundEffect.Ctlcontrols.stop();
                soundEffect.URL = nazwa;
                soundEffect.Ctlcontrols.play();
            }
        }

    }
}
