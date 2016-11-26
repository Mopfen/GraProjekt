using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unstable
{
    class Gracz
    {
        /// <summary> Umożliwia dostęp do danych zawartych w klasie Launcher.</summary>
        Launcher daneLauncher;

        public Gracz(Launcher dane)
        {
            daneLauncher = dane;
        }

        /// <summary> Metoda odpowiedzialna za wykonywanie ataku przez gracza.</summary>
        public void AtakGracza(Timer timerGracz)
        {
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            if (daneLauncher.daneGracz.attack == true & (daneLauncher.daneGracz.left == true | daneLauncher.daneGracz.right == true) & daneLauncher.daneGracz.wykonanoAtak == false)
            {
                if(daneLauncher.daneGracz.rodzajAtaku==true & daneLauncher.daneGracz.posiadaMiecz==true)
                {
                    if (daneLauncher.daneGracz.left == true) daneLauncher.daneGracz.obraz.Image = daneLauncher.whiteBrownAttackingLeft.Image;
                    if (daneLauncher.daneGracz.right == true) daneLauncher.daneGracz.obraz.Image = daneLauncher.whiteBrownAttackingRight.Image;
                    metodaUniwersalne.atakwCelObok(daneLauncher.daneMob, 5);

                    #region metodaUniwersalne.atakwCelObok(daneLauncher.danePrzeszkoda,...)
                    if (daneLauncher.daneMapa[1].gdzieOstatnio == 0) metodaUniwersalne.atakwCelObok(daneLauncher.danePrzeszkoda,0, 8);
                    if (daneLauncher.daneMapa[1].gdzieOstatnio == 1) metodaUniwersalne.atakwCelObok(daneLauncher.danePrzeszkoda, 12, 12);

                    #endregion
                }
                if(daneLauncher.daneGracz.rodzajAtaku==false & daneLauncher.daneGracz.posiadaŁuk==true)
                {
                    if(daneLauncher.daneStrzała[0].exists==false)
                    {
                        if (daneLauncher.daneGracz.left == true)
                        {
                            daneLauncher.daneGracz.obraz.Image = daneLauncher.whiteBrownShotingLeft.Image;
                            daneLauncher.daneStrzała[0].exists = true;
                            daneLauncher.daneStrzała[0].obraz.Image = daneLauncher.strzałaLeft.Image;
                            daneLauncher.daneStrzała[0].obraz.Left = (daneLauncher.daneGracz.obraz.Left - daneLauncher.daneStrzała[0].obraz.Width);
                            daneLauncher.daneStrzała[0].obraz.Top = (daneLauncher.daneGracz.obraz.Top + daneLauncher.daneGracz.obraz.Height / 2);
                        }
                        if (daneLauncher.daneGracz.right == true)
                        {
                            daneLauncher.daneGracz.obraz.Image = daneLauncher.whiteBrownShotingRight.Image;
                            daneLauncher.daneStrzała[0].exists = true;
                            daneLauncher.daneStrzała[0].obraz.Image = daneLauncher.strzałaRight.Image;
                            daneLauncher.daneStrzała[0].obraz.Left = (daneLauncher.daneGracz.obraz.Right);
                            daneLauncher.daneStrzała[0].obraz.Top = (daneLauncher.daneGracz.obraz.Top + daneLauncher.daneGracz.obraz.Height / 2);
                        }
                        daneLauncher.daneGracz.stopMoving = -5;
                    }
                }
                
                daneLauncher.daneGracz.zmianaKierunkuLeft=daneLauncher.daneGracz.zmianaKierunkuRight = false;
                daneLauncher.daneGracz.wykonanoAtak = true;
            }
            if (daneLauncher.daneGracz.wykonanoAtak == true) { timerGracz.Enabled = false; daneLauncher.daneGracz.stopMoving++; }
            if (daneLauncher.daneGracz.stopMoving == 5)
            {
                timerGracz.Enabled = true;
                daneLauncher.daneGracz.wykonanoAtak = false;
                daneLauncher.daneGracz.stopMoving = 0;
            }
            daneLauncher.daneGracz.attack = false;
        }

        public void StrzalaGracz(int ilośćMobow, int ilośćPrzeszkod, int indeksPierwszejPrzeszkody, int ilośćŚcian, int indeksPierwszejŚciany)
        {
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            bool stop = false; // zmienna określa, kiedy strzała w coś trafi
            for (int i = indeksPierwszejŚciany; i < ilośćŚcian + indeksPierwszejŚciany; i++)
            {
                if (daneLauncher.danePrzeszkoda[i].exists == true)
                {
                    if (daneLauncher.daneStrzała[0].obraz.Bounds.IntersectsWith(daneLauncher.danePrzeszkoda[i].obraz.Bounds)) stop = true;
                }
            }       
            if (daneLauncher.daneStrzała[0].exists == true & daneLauncher.daneGracz.stopMoving >= 0)
            {
                daneLauncher.daneStrzała[0].obraz.Visible = true;
                metodaUniwersalne.strzałaTrafienie(daneLauncher.daneMob,ilośćMobow);
                metodaUniwersalne.strzałaTrafienie(daneLauncher.danePrzeszkoda, indeksPierwszejPrzeszkody, ilośćPrzeszkod);
                if (daneLauncher.daneStrzała[0].obraz.Image == daneLauncher.strzałaLeft.Image)
                {
                    if (daneLauncher.daneStrzała[0].obraz.Left > daneLauncher.poleGry.Left & stop==false)
                    {
                        daneLauncher.daneStrzała[0].obraz.Left -= 8;
                    }
                    else
                    {
                        daneLauncher.daneStrzała[0].exists = false;
                        daneLauncher.daneStrzała[0].obraz.Visible = false;
                    }
                }
                if (daneLauncher.daneStrzała[0].obraz.Image == daneLauncher.strzałaRight.Image)
                {
                    if (daneLauncher.daneStrzała[0].obraz.Right < daneLauncher.poleGry.Right & stop==false)
                    {
                        daneLauncher.daneStrzała[0].obraz.Left += 8;
                    }
                    else
                    {
                        daneLauncher.daneStrzała[0].exists = false;
                        daneLauncher.daneStrzała[0].obraz.Visible = false;
                    }
                }
            }
        }
    }
} 
