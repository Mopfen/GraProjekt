using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unstable
{
    /// <summary>
    /// Zawiera metody odpowiadające za poruszanie się postaci.
    /// </summary>
    class PoruszanieSię
    {
        /// <summary> 
        /// Pole umożliwia dostęp do danych zawartych w klasie Launcher.
        /// </summary>
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

        /// <summary>
        /// (W fazie testów) Metoda odpowiedzialna za ruch moba w kierunku gracza.
        /// </summary>
        public void RuchMobaDoGracza(int numerMoba)
        {
            if (daneLauncher.daneMob[numerMoba].exists == true)
            {
                daneLauncher.daneMob[numerMoba].up = daneLauncher.daneMob[numerMoba].down = daneLauncher.daneMob[numerMoba].left = daneLauncher.daneMob[numerMoba].right = false;

                if (daneLauncher.daneMob[numerMoba].obraz.Top > daneLauncher.daneGracz.obraz.Top & daneLauncher.daneMob[numerMoba].wykonanoAtak == false) { daneLauncher.daneMob[numerMoba].up = true; }
                if (daneLauncher.daneMob[numerMoba].obraz.Bottom < daneLauncher.daneGracz.obraz.Bottom & daneLauncher.daneMob[numerMoba].wykonanoAtak == false) { daneLauncher.daneMob[numerMoba].down = true; }
                if (daneLauncher.daneMob[numerMoba].obraz.Left > daneLauncher.daneGracz.obraz.Right + 4 & daneLauncher.daneMob[numerMoba].wykonanoAtak == false) { daneLauncher.daneMob[numerMoba].left = true; }
                if (daneLauncher.daneMob[numerMoba].obraz.Right < daneLauncher.daneGracz.obraz.Left - 4 & daneLauncher.daneMob[numerMoba].wykonanoAtak == false) { daneLauncher.daneMob[numerMoba].right = true; }

                if (((daneLauncher.daneMob[numerMoba].obraz.Top > daneLauncher.daneGracz.obraz.Top & daneLauncher.daneMob[numerMoba].obraz.Top <= daneLauncher.daneGracz.obraz.Bottom + 8) | (daneLauncher.daneMob[numerMoba].obraz.Bottom < daneLauncher.daneGracz.obraz.Bottom & daneLauncher.daneMob[numerMoba].obraz.Bottom >= daneLauncher.daneGracz.obraz.Top - 8)) & daneLauncher.daneMob[numerMoba].obraz.Left <= daneLauncher.daneGracz.obraz.Right + 4 & daneLauncher.daneMob[numerMoba].obraz.Right >= daneLauncher.daneGracz.obraz.Left - 4 & daneLauncher.daneMob[numerMoba].wykonanoAtak == false)
                {
                    daneLauncher.daneMob[numerMoba].up = daneLauncher.daneMob[numerMoba].down = false;
                    if (!(daneLauncher.daneGracz.obraz.Left < (daneLauncher.poleGry.Left + 70)))
                    {
                        daneLauncher.daneMob[numerMoba].left = true;
                    }
                    else daneLauncher.daneMob[numerMoba].right = true;
                }


                if (daneLauncher.daneMob[numerMoba].antyRozmycie.Top != daneLauncher.daneMob[numerMoba].obraz.Top | daneLauncher.daneMob[numerMoba].antyRozmycie.Left != daneLauncher.daneMob[numerMoba].obraz.Left) { daneLauncher.daneMob[numerMoba].antyRozmycie.Top = daneLauncher.daneMob[numerMoba].obraz.Top; daneLauncher.daneMob[numerMoba].antyRozmycie.Left = daneLauncher.daneMob[numerMoba].obraz.Left; } // niweluje rozmycie tła podczas poruszania się postaci
                if (daneLauncher.daneMob[numerMoba].labelhp.Bottom != daneLauncher.daneMob[numerMoba].obraz.Top | daneLauncher.daneMob[numerMoba].labelhp.Left != daneLauncher.daneMob[numerMoba].obraz.Left + 8) { daneLauncher.daneMob[numerMoba].labelhp.Top = daneLauncher.daneMob[numerMoba].obraz.Top - daneLauncher.daneMob[numerMoba].labelhp.Height; daneLauncher.daneMob[numerMoba].labelhp.Left = daneLauncher.daneMob[numerMoba].obraz.Left + 8; } // przesuwa wskaźnik punktów życia za mobem
            }
        }
    }
}
