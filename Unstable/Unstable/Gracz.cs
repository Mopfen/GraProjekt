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
        /// <summary> Metoda odpowiedzialna za ruch gracza.</summary>
        public void RuchGracza()
        {
            if ((daneLauncher.daneGracz[0].up == false & daneLauncher.daneGracz[0].down == false & daneLauncher.daneGracz[0].left == false & daneLauncher.daneGracz[0].right == false)) { daneLauncher.daneGracz[0].obraz.Image = daneLauncher.whiteBrownStand.Image; } // obraz postaci, gdy się nie rusza
            if (daneLauncher.daneGracz[0].antyRozmycie.Top != daneLauncher.daneGracz[0].obraz.Top | daneLauncher.daneGracz[0].antyRozmycie.Left != daneLauncher.daneGracz[0].obraz.Left) { daneLauncher.daneGracz[0].antyRozmycie.Top = daneLauncher.daneGracz[0].obraz.Top; daneLauncher.daneGracz[0].antyRozmycie.Left = daneLauncher.daneGracz[0].obraz.Left; } // niweluje rozmycie tła podczas poruszania się postaci

            if (daneLauncher.daneGracz[0].up == true & daneLauncher.daneGracz[0].obraz.Top > daneLauncher.poleGry.Top+2 & daneLauncher.daneGracz[0].wykonanoAtak == false & daneLauncher.daneGracz[0].przeszkoda==false) { if (daneLauncher.daneGracz[0].zmianaKierunkuUp == false) { daneLauncher.daneGracz[0].obraz.Image = daneLauncher.whiteBrownMovingUp.Image; daneLauncher.daneGracz[0].zmianaKierunkuUp = true; } if (daneLauncher.daneGracz[0].left == true | daneLauncher.daneGracz[0].right == true) daneLauncher.daneGracz[0].zmianaKierunkuDown = daneLauncher.daneGracz[0].zmianaKierunkuLeft = daneLauncher.daneGracz[0].zmianaKierunkuRight = false; daneLauncher.daneGracz[0].obraz.Top -= 4; } // ruch w górę
            else
            if (daneLauncher.daneGracz[0].down == true & daneLauncher.daneGracz[0].obraz.Bottom < daneLauncher.poleGry.Bottom & daneLauncher.daneGracz[0].wykonanoAtak == false & daneLauncher.daneGracz[0].przeszkoda == false) { if (daneLauncher.daneGracz[0].zmianaKierunkuDown == false) { daneLauncher.daneGracz[0].obraz.Image = daneLauncher.whiteBrownMovingDown.Image; daneLauncher.daneGracz[0].zmianaKierunkuDown = true; } if (daneLauncher.daneGracz[0].left == true | daneLauncher.daneGracz[0].right == true) daneLauncher.daneGracz[0].zmianaKierunkuUp = daneLauncher.daneGracz[0].zmianaKierunkuLeft = daneLauncher.daneGracz[0].zmianaKierunkuRight = false; daneLauncher.daneGracz[0].obraz.Top += 4; } // ruch w dół
            else 
            if (daneLauncher.daneGracz[0].left == true & daneLauncher.daneGracz[0].obraz.Left > daneLauncher.poleGry.Left & daneLauncher.daneGracz[0].wykonanoAtak == false & daneLauncher.daneGracz[0].przeszkoda == false) { if (daneLauncher.daneGracz[0].zmianaKierunkuLeft == false) { daneLauncher.daneGracz[0].obraz.Image = daneLauncher.whiteBrownMovingLeft.Image; daneLauncher.daneGracz[0].zmianaKierunkuLeft = true; } if (daneLauncher.daneGracz[0].up == true | daneLauncher.daneGracz[0].down == true) daneLauncher.daneGracz[0].zmianaKierunkuUp = daneLauncher.daneGracz[0].zmianaKierunkuDown = daneLauncher.daneGracz[0].zmianaKierunkuRight = false; daneLauncher.daneGracz[0].obraz.Left -= 4; } // ruch w lewo
            else
            if (daneLauncher.daneGracz[0].right == true & daneLauncher.daneGracz[0].obraz.Right < daneLauncher.poleGry.Right & daneLauncher.daneGracz[0].wykonanoAtak == false & daneLauncher.daneGracz[0].przeszkoda == false) { if (daneLauncher.daneGracz[0].zmianaKierunkuRight == false) { daneLauncher.daneGracz[0].obraz.Image = daneLauncher.whiteBrownMovingRight.Image; daneLauncher.daneGracz[0].zmianaKierunkuRight = true; } if (daneLauncher.daneGracz[0].up == true | daneLauncher.daneGracz[0].down == true) daneLauncher.daneGracz[0].zmianaKierunkuUp = daneLauncher.daneGracz[0].zmianaKierunkuDown = daneLauncher.daneGracz[0].zmianaKierunkuLeft = false; daneLauncher.daneGracz[0].obraz.Left += 4; } // ruch w prawo
            daneLauncher.daneGracz[0].przeszkoda = false;
        }
        /// <summary> Metoda odpowiedzialna za wykonywanie ataku przez gracza.</summary>
        public void AtakGracza(Timer timerGracz)
        {
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            if (daneLauncher.daneGracz[0].attack == true & (daneLauncher.daneGracz[0].left == true | daneLauncher.daneGracz[0].right == true) & daneLauncher.daneGracz[0].wykonanoAtak == false)
            {
                if(daneLauncher.daneGracz[0].rodzajAtaku==true)
                {
                    if (daneLauncher.daneGracz[0].left == true) daneLauncher.daneGracz[0].obraz.Image = daneLauncher.whiteBrownAttackingLeft.Image;
                    if (daneLauncher.daneGracz[0].right == true) daneLauncher.daneGracz[0].obraz.Image = daneLauncher.whiteBrownAttackingRight.Image;
                    metodaUniwersalne.atakwCelObok(daneLauncher.daneMob, 1);
                    metodaUniwersalne.atakwCelObok(daneLauncher.danePrzeszkoda, 8);
                }
                else
                {
                    if(daneLauncher.daneStrzała[0].alive==false)
                    {
                        if (daneLauncher.daneGracz[0].left == true)
                        {
                            daneLauncher.daneGracz[0].obraz.Image = daneLauncher.whiteBrownShotingLeft.Image;
                            daneLauncher.daneStrzała[0].alive = true;
                            daneLauncher.daneStrzała[0].obraz.Image = daneLauncher.strzałaLeft.Image;
                            daneLauncher.daneStrzała[0].obraz.Left = (daneLauncher.daneGracz[0].obraz.Left - daneLauncher.daneStrzała[0].obraz.Width);
                            daneLauncher.daneStrzała[0].obraz.Top = (daneLauncher.daneGracz[0].obraz.Top + daneLauncher.daneGracz[0].obraz.Height / 2);
                        }
                        if (daneLauncher.daneGracz[0].right == true)
                        {
                            daneLauncher.daneGracz[0].obraz.Image = daneLauncher.whiteBrownShotingRight.Image;
                            daneLauncher.daneStrzała[0].alive = true;
                            daneLauncher.daneStrzała[0].obraz.Image = daneLauncher.strzałaRight.Image;
                            daneLauncher.daneStrzała[0].obraz.Left = (daneLauncher.daneGracz[0].obraz.Right);
                            daneLauncher.daneStrzała[0].obraz.Top = (daneLauncher.daneGracz[0].obraz.Top + daneLauncher.daneGracz[0].obraz.Height / 2);
                        }
                        daneLauncher.daneGracz[0].stopMoving = -5;
                    }
                }
                
                daneLauncher.daneGracz[0].zmianaKierunkuLeft=daneLauncher.daneGracz[0].zmianaKierunkuRight = false;
                daneLauncher.daneGracz[0].wykonanoAtak = true;
            }
            if (daneLauncher.daneGracz[0].wykonanoAtak == true) { timerGracz.Enabled = false; daneLauncher.daneGracz[0].stopMoving++; }
            if (daneLauncher.daneGracz[0].stopMoving == 5)
            {
                timerGracz.Enabled = true;
                daneLauncher.daneGracz[0].wykonanoAtak = false;
                daneLauncher.daneGracz[0].stopMoving = 0;
            }
            daneLauncher.daneGracz[0].attack = false;
        }

        public void StrzalaGracz(int ilośćMobow,int ilośćPrzeszkod,int indeksPierwszejŚciany,int ilośćŚcian)
        {
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            bool stop = false; // zmienna określa, kiedy strzała w coś trafi
            for (int i = indeksPierwszejŚciany; i < ilośćŚcian + indeksPierwszejŚciany; i++)
            {
                if (daneLauncher.danePrzeszkoda[i].alive == true)
                {
                    if (daneLauncher.daneStrzała[0].obraz.Bounds.IntersectsWith(daneLauncher.danePrzeszkoda[i].obraz.Bounds)) stop = true;
                }
            }       
            if (daneLauncher.daneStrzała[0].alive == true & daneLauncher.daneGracz[0].stopMoving >= 0)
            {
                daneLauncher.daneStrzała[0].obraz.Visible = true;
                metodaUniwersalne.strzałaTrafienie(daneLauncher.daneMob,ilośćMobow);
                metodaUniwersalne.strzałaTrafienie(daneLauncher.danePrzeszkoda, ilośćPrzeszkod);
                if (daneLauncher.daneStrzała[0].obraz.Image == daneLauncher.strzałaLeft.Image)
                {
                    if (daneLauncher.daneStrzała[0].obraz.Left > daneLauncher.poleGry.Left & stop==false)
                    {
                        daneLauncher.daneStrzała[0].obraz.Left -= 8;
                    }
                    else
                    {
                        daneLauncher.daneStrzała[0].alive = false;
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
                        daneLauncher.daneStrzała[0].alive = false;
                        daneLauncher.daneStrzała[0].obraz.Visible = false;
                    }
                }
            }
        }
    }
} 
