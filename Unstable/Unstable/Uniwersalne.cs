using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Linq.Expressions;

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

        /// <summary>
        /// Metoda wyliczająca, ile procent liczby1 stanowi liczba2
        /// </summary>
        /// <param name="liczba1">Liczba1 = 100% z liczby1</param>
        /// <param name="liczba2">Liczba2 = x% z liczby1</param>
        /// <returns></returns>
        internal int wyliczProcent(int liczba1, int liczba2)
        {
            return (liczba1 * 100) / liczba2;
        }
        /// <summary>
        /// Metoda losuje liczby z danego przedziału
        /// </summary>
        /// <param name="min">Wartość minimalna do wylosowania</param>
        /// <param name="max">Wartość maksymalna do wylosowania</param>
        /// <returns></returns>
        internal int losuj(int min,int max)
        {
            Random random = new Random();
            return random.Next(min, max+1);
        }      
        /// <summary>
        /// Metoda zatrzymuje timery na mapie
        /// </summary>
        internal void zatrzymajTimery()
        {
            daneLauncher.daneGracz.up = daneLauncher.daneGracz.down = daneLauncher.daneGracz.left = daneLauncher.daneGracz.right = daneLauncher.daneGracz.zmianaKierunkuUp = daneLauncher.daneGracz.zmianaKierunkuDown = daneLauncher.daneGracz.zmianaKierunkuLeft = daneLauncher.daneGracz.zmianaKierunkuRight = false;
            daneLauncher.timerGracz.Enabled = daneLauncher.timerAtakGracz.Enabled = daneLauncher.timerMob.Enabled = daneLauncher.timerAtakMob.Enabled = daneLauncher.timerNPC.Enabled = daneLauncher.timerStatystyki.Enabled = daneLauncher.timerStrzałaGracz.Enabled = false;
        }
        /// <summary>
        /// Metoda uruchamia timery na mapie
        /// </summary>
        internal void uruchomTimery()
        {
            daneLauncher.timerGracz.Enabled = daneLauncher.timerAtakGracz.Enabled = daneLauncher.timerMob.Enabled = daneLauncher.timerAtakMob.Enabled = daneLauncher.timerNPC.Enabled = daneLauncher.timerStatystyki.Enabled = daneLauncher.timerStrzałaGracz.Enabled = true;
        }
        /// <summary>
        /// Metoda wstrzymuje wszelkie akcje w wątku na okresloną liczbę sekund
        /// </summary>
        /// <param name="seconds">Liczba sekund</param>
        internal void wait(double seconds)
        {
            double miliseconds = seconds * 1000;
            Thread.Sleep(Convert.ToInt32(miliseconds));
        }
    }
}
