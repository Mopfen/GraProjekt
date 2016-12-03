﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unstable
{
    class Mob
    {
        /// <summary> Umożliwia dostęp do danych zawartych w klasie Launcher.</summary>
        Launcher daneLauncher;

        public Mob(Launcher dane)
        {
            daneLauncher = dane;
        }
        /// <summary> Metoda odpowiedzialna za ruch moba w kierunku gracza.</summary>
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
        /// <summary> Metoda odpowiedzialna za wykonywanie ataku przez Moba.</summary>
        public void AtakMoba(Timer timerMob,int numerMoba,int wartośćAtakuMin, int wartośćAtakuMax)
        {
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            Walka metodaWalka = new Walka(daneLauncher);
            if (daneLauncher.daneMob[numerMoba].exists==true)
            {
                if (daneLauncher.daneMob[numerMoba].stopMoving == 0 & daneLauncher.daneMob[numerMoba].attack == false & (daneLauncher.daneMob[numerMoba].obraz.Left - daneLauncher.daneGracz.obraz.Right >= (-16) & daneLauncher.daneMob[numerMoba].obraz.Left - daneLauncher.daneGracz.obraz.Right < 8 & daneLauncher.daneGracz.obraz.Top - daneLauncher.daneMob[numerMoba].obraz.Top >= (-64) & daneLauncher.daneGracz.obraz.Top - daneLauncher.daneMob[numerMoba].obraz.Top < daneLauncher.daneMob[numerMoba].obraz.Height))
                {
                    daneLauncher.daneMob[numerMoba].obraz.Image = daneLauncher.whiteBrownAttackingLeft.Image;
                    daneLauncher.daneMob[numerMoba].attack = true;
                }
                if (daneLauncher.daneMob[numerMoba].stopMoving == 0 & daneLauncher.daneMob[numerMoba].attack == false & (daneLauncher.daneGracz.obraz.Left - daneLauncher.daneMob[numerMoba].obraz.Right >= (-16) & daneLauncher.daneGracz.obraz.Left - daneLauncher.daneMob[numerMoba].obraz.Right < 8 & daneLauncher.daneGracz.obraz.Top - daneLauncher.daneMob[numerMoba].obraz.Top >= (-64) & daneLauncher.daneGracz.obraz.Top - daneLauncher.daneMob[numerMoba].obraz.Top < daneLauncher.daneMob[numerMoba].obraz.Height))
                {
                    daneLauncher.daneMob[numerMoba].obraz.Image = daneLauncher.whiteBrownAttackingRight.Image;
                    daneLauncher.daneMob[numerMoba].attack = true;
                    daneLauncher.daneMob[numerMoba].up = daneLauncher.daneMob[numerMoba].down = daneLauncher.daneMob[numerMoba].left = daneLauncher.daneMob[numerMoba].right = daneLauncher.daneMob[numerMoba].zmianaKierunkuUp = daneLauncher.daneMob[numerMoba].zmianaKierunkuDown = daneLauncher.daneMob[numerMoba].zmianaKierunkuLeft = daneLauncher.daneMob[numerMoba].zmianaKierunkuRight = false;
                }
                if (daneLauncher.daneMob[numerMoba].stopMoving == 0 & daneLauncher.daneMob[numerMoba].attack == true)
                {
                    metodaWalka.dmgZwarcie(daneLauncher.daneMob, numerMoba, wartośćAtakuMin, wartośćAtakuMax);
                    int dmg = metodaUniwersalne.losuj(daneLauncher.daneMob[numerMoba].siłaAtakuZwarcie[0], daneLauncher.daneMob[numerMoba].siłaAtakuZwarcie[1]);
                    int dmgK = dmg * 2;
                    if (metodaUniwersalne.losuj(1, 100) <= daneLauncher.daneMob[numerMoba].szansaKryta)
                    {
                        daneLauncher.hitLog.Text = ("Mopfen zadaje " + dmgK + " obrażeń krytycznych.\n" + daneLauncher.hitLog.Text);
                        daneLauncher.daneGracz.hp -= dmgK;
                    }
                    else
                    {
                        daneLauncher.hitLog.Text = ("Mopfen zadaje " + dmg + " obrażeń.\n" + daneLauncher.hitLog.Text);
                        daneLauncher.daneGracz.hp -= dmg;
                    }
                    daneLauncher.daneMob[numerMoba].wykonanoAtak = true;
                    daneLauncher.daneMob[numerMoba].zmianaKierunkuLeft = daneLauncher.daneMob[numerMoba].zmianaKierunkuRight = false;
                }
                if (daneLauncher.daneMob[numerMoba].wykonanoAtak == true) { timerMob.Enabled = false; daneLauncher.daneMob[numerMoba].stopMoving++; }
                if (daneLauncher.daneMob[numerMoba].stopMoving == 5)
                {
                    timerMob.Enabled = true;
                    daneLauncher.daneMob[numerMoba].wykonanoAtak = false;
                    daneLauncher.daneMob[numerMoba].stopMoving = 0;
                }
                daneLauncher.daneMob[numerMoba].attack = false;
            }
        }
    }
}
