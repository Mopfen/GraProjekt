using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unstable
{
    class PoruszanieSię
    {
        Launcher daneLauncher;

        public PoruszanieSię(Launcher dane)
        {
            daneLauncher = dane;
        }

        /// <summary>
        /// Metoda odpowiedzialna za ruch postaci.
        /// </summary>
        internal void RuchPostaci(Launcher.ZmiennePostaci postać)
        {
            if (postać.up == true & postać.down != true & postać.obraz.Top > daneLauncher.poleGry.Top + 2 & postać.wykonanoAtak == false & postać.przeszkoda == false)
            {
                postać.obraz.Top -= 4; // ruch w górę
            }
            else
            {
                if (postać.down == true & postać.up != true & postać.obraz.Bottom < daneLauncher.poleGry.Bottom & postać.wykonanoAtak == false & postać.przeszkoda == false)
                {
                    postać.obraz.Top += 4; // ruch w dół
                }
                else
                {
                    if (postać.left == true & postać.right != true & postać.obraz.Left > daneLauncher.poleGry.Left & postać.wykonanoAtak == false & postać.przeszkoda == false)
                    {
                        postać.obraz.Left -= 4; // ruch w lewo
                    }
                    else
                    {
                        if (postać.right == true & postać.left != true & postać.obraz.Right < daneLauncher.poleGry.Right & postać.wykonanoAtak == false & postać.przeszkoda == false)
                        {
                            postać.obraz.Left += 4; // ruch w prawo
                        }
                    }
                }
            }
            postać.przeszkoda = false;
        }
        /// <summary>
        /// Metoda sprawdza, czy na drodze postaci znajduje się przeszkoda. Jeśli tak, nie pozwala jej iść dalej.
        /// </summary>
        /// <param name="idący">Idąca postać</param>
        /// <param name="obiekt">Istniejąca przeszkoda</param>
        internal void przeszkodaNaDrodze(Launcher.ZmiennePostaci idący, Launcher.ZmienneObiektów obiekt)
        {
            if (obiekt.exists == true)
            {
                if (idący.obraz.Bounds.IntersectsWith(obiekt.obraz.Bounds))
                {
                    idący.obraz.Location = idący.antyRozmycie.Location;
                    idący.przeszkoda = true;
                }
            }
        }
        /// <summary>
        /// Metoda sprawdza, czy na drodze postaci znajduje się przeszkoda. Jeśli tak, nie pozwala jej iść dalej.
        /// </summary>
        /// <param name="idący">Idąca postać</param>
        /// <param name="obiekt">Istniejąca przeszkoda</param>
        internal void przeszkodaNaDrodze(Launcher.ZmiennePostaci idący, Launcher.ZmiennePostaci obiekt)
        {
            if (obiekt.exists == true)
            {
                if ((idący.up | idący.down | idący.left | idący.right) & idący.obraz.Bounds.IntersectsWith(obiekt.obraz.Bounds))
                {
                    if (idący.obraz.Top <= obiekt.obraz.Bottom & idący.obraz.Top >= obiekt.obraz.Top & idący.obraz.Right >= obiekt.obraz.Left & idący.obraz.Left <= obiekt.obraz.Right)
                    {
                        idący.antyRozmycie.Top += 4;
                    }
                    if (idący.obraz.Bottom >= obiekt.obraz.Top & idący.obraz.Bottom >= obiekt.obraz.Bottom & idący.obraz.Right >= obiekt.obraz.Left & idący.obraz.Left <= obiekt.obraz.Right)
                    {
                        idący.antyRozmycie.Top -= 4;
                    }
                    if (idący.obraz.Right >= obiekt.obraz.Left & idący.obraz.Right <= obiekt.obraz.Right & idący.obraz.Bottom > obiekt.obraz.Top & idący.obraz.Top < obiekt.obraz.Bottom)
                    {
                        idący.antyRozmycie.Left -= 4;
                    }
                    if (idący.obraz.Left <= obiekt.obraz.Right & idący.obraz.Left >= obiekt.obraz.Left & idący.obraz.Bottom > obiekt.obraz.Top & idący.obraz.Top < obiekt.obraz.Bottom)
                    {
                        idący.antyRozmycie.Left += 4;
                    }

                    idący.obraz.Location = idący.antyRozmycie.Location;
                    idący.przeszkoda = true;
                }
            }
        }
    }
}
