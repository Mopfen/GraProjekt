using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unstable
{
    /// <summary>
    /// Przechowuje metody używane do odtwarzania muzyki i efektów dźwiękowych
    /// </summary>
    class Muzyka
    {
        /// <summary> 
        /// Pole umożliwia dostęp do danych zawartych w klasie Launcher.
        /// </summary>
        Launcher daneLauncher;

        public Muzyka(Launcher dane)
        {
            daneLauncher = dane;
        }

        /// <summary>
        /// Metoda odtwarza muzykę
        /// </summary>
        /// <param name="nazwa">Nazwa utworu</param>
        internal void Soundtrack(string nazwa)
        {
            if(daneLauncher.muzykaOn==true)
            {
                daneLauncher.music.URL = nazwa;
            }
        }

        /// <summary>
        /// Metoda odtwarza efekty dźwiękowe
        /// </summary>
        /// <param name="soundEffect">Player, który ma odtworzyć dany efekt dźwiękowy</param>
        /// <param name="nazwa">Nazwa efektu dźwiękowego</param>
        internal void SoundEffect(AxWMPLib.AxWindowsMediaPlayer soundEffect, string nazwa)
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
