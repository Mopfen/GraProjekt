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
            daneLauncher.przeszkodaGracz = false;
            for (int i = 0; i < 9; i++)
            {
                if (daneLauncher.daneMob[i].istniejeMob == true)
                {
                    //if ((daneLauncher.gracz.Bounds.IntersectsWith(daneLauncher.daneMob[i].mob.Bounds))) daneLauncher.przeszkodaGracz = true;

                    //if ((daneLauncher.up == true) & (daneLauncher.gracz.Bounds.IntersectsWith(daneLauncher.daneMob[i].mob.Bounds))) daneLauncher.up = false;
                    //if ((daneLauncher.down == true) & (daneLauncher.gracz.Bounds.IntersectsWith(daneLauncher.daneMob[i].mob.Bounds))) daneLauncher.down = false;
                    //if ((daneLauncher.left == true) & (daneLauncher.gracz.Bounds.IntersectsWith(daneLauncher.daneMob[i].mob.Bounds))) daneLauncher.left = false;
                    //if ((daneLauncher.right == true) & (daneLauncher.gracz.Bounds.IntersectsWith(daneLauncher.daneMob[i].mob.Bounds))) daneLauncher.right = false;

                    if (daneLauncher.up == true & daneLauncher.gracz.Top - daneLauncher.daneMob[i].mob.Top >= (60) & daneLauncher.gracz.Top - daneLauncher.daneMob[i].mob.Bottom < 4 & (daneLauncher.daneMob[i].mob.Left - daneLauncher.gracz.Left >= (-64) & daneLauncher.daneMob[i].mob.Left - daneLauncher.gracz.Left < daneLauncher.gracz.Width)) { daneLauncher.gracz.Top += 4; daneLauncher.przeszkodaGracz = true; } //
                    if (daneLauncher.down == true & daneLauncher.daneMob[i].mob.Bottom - daneLauncher.gracz.Bottom >= (60) & daneLauncher.daneMob[i].mob.Top - daneLauncher.gracz.Bottom < 4 & (daneLauncher.daneMob[i].mob.Left - daneLauncher.gracz.Left >= (-64) & daneLauncher.daneMob[i].mob.Left - daneLauncher.gracz.Left < daneLauncher.gracz.Width)) { daneLauncher.gracz.Top -= 4; daneLauncher.przeszkodaGracz = true; } // 
                    if (daneLauncher.left== true & daneLauncher.gracz.Left - daneLauncher.daneMob[i].mob.Left >= (60) & daneLauncher.gracz.Left - daneLauncher.daneMob[i].mob.Right < 0 & (daneLauncher.daneMob[i].mob.Top - daneLauncher.gracz.Top >= (-64) & daneLauncher.daneMob[i].mob.Top - daneLauncher.gracz.Top < daneLauncher.gracz.Height)) { daneLauncher.gracz.Left += 2; daneLauncher.przeszkodaGracz = true; } //
                    if (daneLauncher.right == true & daneLauncher.daneMob[i].mob.Left - daneLauncher.gracz.Left >= (-60) & daneLauncher.daneMob[i].mob.Left - daneLauncher.gracz.Right < 0 & (daneLauncher.daneMob[i].mob.Top - daneLauncher.gracz.Top >= (-64) & daneLauncher.daneMob[i].mob.Top - daneLauncher.gracz.Top < daneLauncher.gracz.Height)) { daneLauncher.gracz.Left -= 2; daneLauncher.przeszkodaGracz = true; } // zapobieganie nachodzeniu na inny obiekt
                }
            }
            if ((daneLauncher.up == false & daneLauncher.down == false & daneLauncher.left == false & daneLauncher.right == false)) { daneLauncher.gracz.Image = daneLauncher.whiteBrownStand.Image; } // wygląd postaci, gdy się nie rusza
            if (daneLauncher.underGracz.Top != daneLauncher.gracz.Top | daneLauncher.underGracz.Left != daneLauncher.gracz.Left) { daneLauncher.underGracz.Top = daneLauncher.gracz.Top; daneLauncher.underGracz.Left = daneLauncher.gracz.Left; } // niweluje rozmycie tła podczas poruszania się postaci

            if (daneLauncher.up == true & daneLauncher.gracz.Top > daneLauncher.poleGry.Top & daneLauncher.wykonanoAtakGracz == false & daneLauncher.przeszkodaGracz==false) { if (daneLauncher.zmianaKierunkuUpGracz == false) { daneLauncher.gracz.Image = daneLauncher.whiteBrownMovingUp.Image; daneLauncher.zmianaKierunkuUpGracz = true; } if (daneLauncher.left == true | daneLauncher.right == true) daneLauncher.zmianaKierunkuDownGracz = daneLauncher.zmianaKierunkuLeftGracz = daneLauncher.zmianaKierunkuRightGracz = false; daneLauncher.gracz.Top -= 4; } // ruch w górę
            else
            if (daneLauncher.down == true & daneLauncher.gracz.Bottom < daneLauncher.poleGry.Bottom & daneLauncher.wykonanoAtakGracz == false & daneLauncher.przeszkodaGracz == false) { if (daneLauncher.zmianaKierunkuDownGracz == false) { daneLauncher.gracz.Image = daneLauncher.whiteBrownMovingDown.Image; daneLauncher.zmianaKierunkuDownGracz = true; } if (daneLauncher.left == true | daneLauncher.right == true) daneLauncher.zmianaKierunkuUpGracz = daneLauncher.zmianaKierunkuLeftGracz = daneLauncher.zmianaKierunkuRightGracz = false; daneLauncher.gracz.Top += 4; } // ruch w dół
            else 
            if (daneLauncher.left == true & daneLauncher.gracz.Left > daneLauncher.poleGry.Left & daneLauncher.wykonanoAtakGracz == false & daneLauncher.przeszkodaGracz == false) { if (daneLauncher.zmianaKierunkuLeftGracz == false) { daneLauncher.gracz.Image = daneLauncher.whiteBrownMovingLeft.Image; daneLauncher.zmianaKierunkuLeftGracz = true; } if (daneLauncher.up == true | daneLauncher.down == true) daneLauncher.zmianaKierunkuUpGracz = daneLauncher.zmianaKierunkuDownGracz = daneLauncher.zmianaKierunkuRightGracz = false; daneLauncher.gracz.Left -= 4; } // ruch w lewo
            else
            if (daneLauncher.right == true & daneLauncher.gracz.Right < daneLauncher.poleGry.Right & daneLauncher.wykonanoAtakGracz == false & daneLauncher.przeszkodaGracz == false) { if (daneLauncher.zmianaKierunkuRightGracz == false) { daneLauncher.gracz.Image = daneLauncher.whiteBrownMovingRight.Image; daneLauncher.zmianaKierunkuRightGracz = true; } if (daneLauncher.up == true | daneLauncher.down == true) daneLauncher.zmianaKierunkuUpGracz = daneLauncher.zmianaKierunkuDownGracz = daneLauncher.zmianaKierunkuLeftGracz = false; daneLauncher.gracz.Left += 4; } // ruch w prawo

            //if ((daneLauncher.up == true | daneLauncher.down == true) & daneLauncher.left == true) { if (daneLauncher.zmianaKierunkuLeftSkosGracz == false) daneLauncher.gracz.Image = daneLauncher.whiteBrownMovingLeft.Image; daneLauncher.zmianaKierunkuLeftSkosGracz = true; } else daneLauncher.zmianaKierunkuLeftSkosGracz = false; // ruch na lewy skos
            //if ((daneLauncher.up == true | daneLauncher.down == true) & daneLauncher.right == true) { if (daneLauncher.zmianaKierunkuRightSkosGracz == false) daneLauncher.gracz.Image = daneLauncher.whiteBrownMovingRight.Image; daneLauncher.zmianaKierunkuRightSkosGracz = true; } else daneLauncher.zmianaKierunkuRightSkosGracz = false; // ruch na prawy skos
        }
        /// <summary> Metoda odpowiedzialna za wykonywanie ataku przez gracza.</summary>
        public void AtakGracza(Timer timerGracz)
        {
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            if (daneLauncher.attackGracz == true & (daneLauncher.left == true | daneLauncher.right == true) & daneLauncher.stopMovingGracz == 0)
            {
                if (daneLauncher.left == true) daneLauncher.gracz.Image = daneLauncher.whiteBrownAttackingLeft.Image;
                if (daneLauncher.right == true) daneLauncher.gracz.Image = daneLauncher.whiteBrownAttackingRight.Image;
                for (int i = 0; i < 9; i++)
                {
                    if (daneLauncher.daneMob[i].istniejeMob == true)
                    {
                        if ((daneLauncher.left == true & (daneLauncher.gracz.Left - daneLauncher.daneMob[i].mob.Left >= (60) & daneLauncher.gracz.Left - daneLauncher.daneMob[i].mob.Right < 8 & (daneLauncher.daneMob[i].mob.Top - daneLauncher.gracz.Top >= (-64) & daneLauncher.daneMob[i].mob.Top - daneLauncher.gracz.Top < daneLauncher.gracz.Height)) |
                         (daneLauncher.right==true & (daneLauncher.daneMob[i].mob.Left - daneLauncher.gracz.Left >= (-60) & daneLauncher.daneMob[i].mob.Left - daneLauncher.gracz.Right < 8 & (daneLauncher.daneMob[i].mob.Top - daneLauncher.gracz.Top >= (-64) & daneLauncher.daneMob[i].mob.Top - daneLauncher.gracz.Top < daneLauncher.gracz.Height)))))
                        {
                            daneLauncher.siłaAtakuGracz = metodaUniwersalne.dmgZwarcieGracz();
                            daneLauncher.daneMob[i].hpMob -= daneLauncher.siłaAtakuGracz;
                            daneLauncher.hitLog.Text = ("Mopfen zadaje "+ daneLauncher.siłaAtakuGracz+" obrażeń.\n" + daneLauncher.hitLog.Text);
                        }
                    }
                }
                daneLauncher.zmianaKierunkuLeftGracz=daneLauncher.zmianaKierunkuRightGracz = false;
                daneLauncher.wykonanoAtakGracz = true;
            }
            if (daneLauncher.wykonanoAtakGracz == true) { timerGracz.Enabled = false; daneLauncher.stopMovingGracz++; }
            if (daneLauncher.stopMovingGracz == 5)
            {
                timerGracz.Enabled = true;
                daneLauncher.wykonanoAtakGracz = false;
                daneLauncher.stopMovingGracz = 0;
            }
            daneLauncher.attackGracz = false;
        }
    }
} 
