﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unstable
{
    /// <summary>
    /// Przechowuje metody wykorzystywane głównie w klasie Statystyki
    /// </summary>
    class MetodyStatystyki
    {
        /// <summary> 
        /// Pole umożliwia dostęp do danych zawartych w klasie Launcher.
        /// </summary>
        Launcher daneLauncher;

        public MetodyStatystyki(Launcher dane)
        {
            daneLauncher = dane;
        }

        /// <summary>
        /// Metoda obliczająca ilość puntków życia gracza
        /// </summary>
        internal void hpMaxGracz()
        {
            daneLauncher.daneGracz.hpMax = (10 + daneLauncher.daneGracz.lv * 10 + daneLauncher.daneGracz.wytrzymałość * 5);
        }
        /// <summary>
        /// Metoda obliczająca ilość punktów many gracza
        /// </summary>
        internal void manaMaxGracz()
        {
            daneLauncher.daneGracz.manaMax = (daneLauncher.daneGracz.lv * 10 + daneLauncher.daneGracz.inteligencja * 5);
        }
        /// <summary>
        /// Metoda oblicza szansę na krytyczne uderzenie gracza
        /// </summary>
        internal void szansaKrytykGracz()
        {
            daneLauncher.daneGracz.szansaKryta = Convert.ToInt16(((daneLauncher.daneGracz.szczęście * 10) / daneLauncher.daneGracz.lv));
        }
       
        /// <summary>
        /// Metoda wykonująca operacje po osiągnięciu wyższego poziomu przez gracza
        /// </summary>
        internal void levelUp()
        {
            while (daneLauncher.daneGracz.exp >= daneLauncher.daneGracz.expMax)
            {
                Muzyka metodaMuzyka = new Muzyka(daneLauncher);
                metodaMuzyka.SoundEffect(daneLauncher.soundGracz, "lvUp.wav");
                daneLauncher.daneGracz.lv++;
                daneLauncher.daneGracz.exp -= daneLauncher.daneGracz.expMax;
                daneLauncher.daneGracz.expMax += 5;
                daneLauncher.daneGracz.statystykiDoRozdania += 4;
                liczStatystyki();
                daneLauncher.daneGracz.hp = daneLauncher.daneGracz.hpMax;
                daneLauncher.daneGracz.mana = daneLauncher.daneGracz.manaMax;
            }
        }
        /// <summary>
        /// Metoda oblicza statytyki gracza
        /// </summary>
        internal void liczStatystyki()
        {
            Walka metodaWalka = new Walka(daneLauncher);

            metodaWalka.dmgZwarcie();
            metodaWalka.dmgDystans();
            hpMaxGracz();
            manaMaxGracz();
            szansaKrytykGracz();
        }
    }
}
