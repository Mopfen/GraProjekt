using System;
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
        public void RuchMobaDoGracza()
        {
            for (int i = 0; i < 9; i++)
            {
                if (daneLauncher.daneMob[i].istniejeMob == true)
                {
                    //if ((daneLauncher.daneMob[i].upMob == false & daneLauncher.daneMob[i].downMob == false & daneLauncher.daneMob[i].leftMob == false & daneLauncher.daneMob[i].rightMob == false)) { daneLauncher.daneMob[i].mob.Image = daneLauncher.whiteBrownStand.Image; } // wygląd postaci, gdy się nie rusza

                    daneLauncher.daneMob[i].upMob = daneLauncher.daneMob[i].downMob = daneLauncher.daneMob[i].leftMob = daneLauncher.daneMob[i].rightMob = false;

                    if (daneLauncher.daneMob[i].mob.Top > daneLauncher.gracz.Top & daneLauncher.daneMob[i].wykonanoAtakMob == false) { daneLauncher.daneMob[i].upMob = true; }
                    if (daneLauncher.daneMob[i].mob.Bottom < daneLauncher.gracz.Bottom & daneLauncher.daneMob[i].wykonanoAtakMob == false) { daneLauncher.daneMob[i].downMob = true; }
                    if (daneLauncher.daneMob[i].mob.Left > daneLauncher.gracz.Right + 4 & daneLauncher.daneMob[i].wykonanoAtakMob == false) { daneLauncher.daneMob[i].leftMob = true; }
                    if (daneLauncher.daneMob[i].mob.Right < daneLauncher.gracz.Left - 4 & daneLauncher.daneMob[i].wykonanoAtakMob == false) { daneLauncher.daneMob[i].rightMob = true; }

                    if (((daneLauncher.daneMob[i].mob.Top > daneLauncher.gracz.Top & daneLauncher.daneMob[i].mob.Top <= daneLauncher.gracz.Bottom + 8) | (daneLauncher.daneMob[i].mob.Bottom < daneLauncher.gracz.Bottom & daneLauncher.daneMob[i].mob.Bottom >= daneLauncher.gracz.Top - 8)) & daneLauncher.daneMob[i].mob.Left <= daneLauncher.gracz.Right + 4 & daneLauncher.daneMob[i].mob.Right >= daneLauncher.gracz.Left - 4 & daneLauncher.daneMob[i].wykonanoAtakMob == false)
                    {
                        daneLauncher.daneMob[i].upMob = daneLauncher.daneMob[i].downMob = false;
                        if (!(daneLauncher.gracz.Left < (daneLauncher.poleGry.Left + 70)))
                        {
                            daneLauncher.daneMob[i].leftMob = true;
                        }
                        else daneLauncher.daneMob[i].rightMob = true;
                    }


                    if (daneLauncher.daneMob[i].underMob.Top != daneLauncher.daneMob[i].mob.Top | daneLauncher.daneMob[i].underMob.Left != daneLauncher.daneMob[i].mob.Left) { daneLauncher.daneMob[i].underMob.Top = daneLauncher.daneMob[i].mob.Top; daneLauncher.daneMob[i].underMob.Left = daneLauncher.daneMob[i].mob.Left; } // niweluje rozmycie tła podczas poruszania się postaci
                    if (daneLauncher.daneMob[i].labelhpMob.Bottom != daneLauncher.daneMob[i].mob.Top | daneLauncher.daneMob[i].labelhpMob.Left != daneLauncher.daneMob[i].mob.Left + 8) { daneLauncher.daneMob[i].labelhpMob.Top = daneLauncher.daneMob[i].mob.Top - daneLauncher.daneMob[i].labelhpMob.Height; daneLauncher.daneMob[i].labelhpMob.Left = daneLauncher.daneMob[i].mob.Left + 8; }

                    if (daneLauncher.daneMob[i].upMob == true & daneLauncher.daneMob[i].mob.Top > daneLauncher.poleGry.Top & !(daneLauncher.daneMob[i].mob.Bounds.IntersectsWith(daneLauncher.gracz.Bounds))) { if (daneLauncher.daneMob[i].zmianaKierunkuUpMob == false) { daneLauncher.daneMob[i].mob.Image = daneLauncher.whiteBrownMovingUp.Image; daneLauncher.daneMob[i].zmianaKierunkuUpMob = true; } daneLauncher.daneMob[i].zmianaKierunkuDownMob = daneLauncher.daneMob[i].zmianaKierunkuLeftMob = daneLauncher.daneMob[i].zmianaKierunkuRightMob = false; daneLauncher.daneMob[i].mob.Top -= 4; } else // ruch w górę
                    if (daneLauncher.daneMob[i].downMob == true & daneLauncher.daneMob[i].mob.Bottom < daneLauncher.poleGry.Bottom & !(daneLauncher.daneMob[i].mob.Bounds.IntersectsWith(daneLauncher.gracz.Bounds))) { if (daneLauncher.daneMob[i].zmianaKierunkuDownMob == false) { daneLauncher.daneMob[i].mob.Image = daneLauncher.whiteBrownMovingDown.Image; daneLauncher.daneMob[i].zmianaKierunkuDownGracz = true; } daneLauncher.daneMob[i].zmianaKierunkuUpMob = daneLauncher.daneMob[i].zmianaKierunkuLeftMob = daneLauncher.daneMob[i].zmianaKierunkuRightMob = false; daneLauncher.daneMob[i].mob.Top += 4; } else // ruch w dół
                    if (daneLauncher.daneMob[i].leftMob == true & daneLauncher.daneMob[i].mob.Left > daneLauncher.poleGry.Left & !(daneLauncher.daneMob[i].mob.Bounds.IntersectsWith(daneLauncher.gracz.Bounds))) { if (daneLauncher.daneMob[i].zmianaKierunkuLeftMob == false) { daneLauncher.daneMob[i].mob.Image = daneLauncher.whiteBrownMovingLeft.Image; daneLauncher.daneMob[i].zmianaKierunkuLeftMob = true; } daneLauncher.daneMob[i].zmianaKierunkuUpMob = daneLauncher.daneMob[i].zmianaKierunkuDownMob = daneLauncher.daneMob[i].zmianaKierunkuRightMob = false; daneLauncher.daneMob[i].mob.Left -= 4; } else // ruch w lewo
                    if (daneLauncher.daneMob[i].rightMob == true & daneLauncher.daneMob[i].mob.Right < daneLauncher.poleGry.Right & !(daneLauncher.daneMob[i].mob.Bounds.IntersectsWith(daneLauncher.gracz.Bounds))) { if (daneLauncher.daneMob[i].zmianaKierunkuRightMob == false) { daneLauncher.daneMob[i].mob.Image = daneLauncher.whiteBrownMovingRight.Image; daneLauncher.daneMob[i].zmianaKierunkuRightMob = true; } daneLauncher.daneMob[i].zmianaKierunkuUpMob = daneLauncher.daneMob[i].zmianaKierunkuDownMob = daneLauncher.daneMob[i].zmianaKierunkuLeftMob = false; daneLauncher.daneMob[i].mob.Left += 4; } // ruch w prawo

                    //if (daneLauncher.daneMob[i].left == true | daneLauncher.daneMob[i].right == true) { daneLauncher.daneMob[i].zmianaKierunkuUpMob = false; daneLauncher.daneMob[i].zmianaKierunkuDownMob = false; }
                    //if (daneLauncher.daneMob[i].up == true | daneLauncher.daneMob[i].down == true) { daneLauncher.daneMob[i].zmianaKierunkuLeftMob = false; daneLauncher.daneMob[i].zmianaKierunkuRightMob = false; }

                    //if ((daneLauncher.daneMob[i].upMob == true | daneLauncher.daneMob[i].downMob == true) & daneLauncher.daneMob[i].leftMob == true) { if (daneLauncher.daneMob[i].zmianaKierunkuLeftSkosMob == false) daneLauncher.daneMob[i].mob.Image = daneLauncher.whiteBrownMovingLeft.Image; daneLauncher.daneMob[i].zmianaKierunkuLeftSkosMob = true; } else daneLauncher.daneMob[i].zmianaKierunkuLeftSkosMob = false; // ruch na lewy skos
                    //if ((daneLauncher.daneMob[i].upMob == true | daneLauncher.daneMob[i].downMob == true) & daneLauncher.daneMob[i].rightMob == true) { if (daneLauncher.daneMob[i].zmianaKierunkuRightSkosMob == false) daneLauncher.daneMob[i].mob.Image = daneLauncher.whiteBrownMovingRight.Image; daneLauncher.daneMob[i].zmianaKierunkuRightSkosMob = true; } else daneLauncher.daneMob[i].zmianaKierunkuRightSkosMob = false; // ruch na prawy skos

                    //if (daneLauncher.daneMob[i].mob.Top - daneLauncher.gracz.Top >= (-20) & daneLauncher.daneMob[i].mob.Top - daneLauncher.gracz.Bottom < 0 & daneLauncher.gracz.Left - daneLauncher.daneMob[i].mob.Left >= (-64) & daneLauncher.gracz.Left - daneLauncher.daneMob[i].mob.Left < daneLauncher.daneMob[i].mob.Width) { daneLauncher.daneMob[i].mob.Top += 2; daneLauncher.daneMob[i].upMob = false; }
                    //if (daneLauncher.gracz.Top - daneLauncher.daneMob[i].mob.Bottom >= (-20) & daneLauncher.gracz.Top - daneLauncher.daneMob[i].mob.Bottom < 0 & daneLauncher.gracz.Left - daneLauncher.daneMob[i].mob.Left >= (-64) & daneLauncher.gracz.Left - daneLauncher.daneMob[i].mob.Left < daneLauncher.daneMob[i].mob.Width) { daneLauncher.daneMob[i].mob.Top -= 2; daneLauncher.daneMob[i].downMob = false; }
                    //if (daneLauncher.daneMob[i].mob.Left - daneLauncher.gracz.Right >= (-16) & daneLauncher.daneMob[i].mob.Left - daneLauncher.gracz.Right < 0 & daneLauncher.gracz.Top - daneLauncher.daneMob[i].mob.Top >= (-64) & daneLauncher.gracz.Top - daneLauncher.daneMob[i].mob.Top < daneLauncher.daneMob[i].mob.Height) { daneLauncher.daneMob[i].mob.Left += 2; daneLauncher.daneMob[i].rightMob = false; }
                    //if (daneLauncher.gracz.Left - daneLauncher.daneMob[i].mob.Right >= (-16) & daneLauncher.gracz.Left - daneLauncher.daneMob[i].mob.Right < 0 & daneLauncher.gracz.Top - daneLauncher.daneMob[i].mob.Top >= (-64) & daneLauncher.gracz.Top - daneLauncher.daneMob[i].mob.Top < daneLauncher.daneMob[i].mob.Height) { daneLauncher.daneMob[i].mob.Left -= 2; daneLauncher.daneMob[i].leftMob = false; }
                }
            }
        }
        /// <summary> Metoda odpowiedzialna za wykonywanie ataku przez Moba.</summary>
        public void AtakMoba(Timer timerMob,int numerMoba,int wartośćAtaku)
        {
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            if(daneLauncher.daneMob[numerMoba].istniejeMob==true)
            {
                if (daneLauncher.daneMob[numerMoba].stopMovingMob == 0 & daneLauncher.daneMob[numerMoba].attackMob == false & (daneLauncher.daneMob[numerMoba].mob.Left - daneLauncher.gracz.Right >= (-16) & daneLauncher.daneMob[numerMoba].mob.Left - daneLauncher.gracz.Right < 8 & daneLauncher.gracz.Top - daneLauncher.daneMob[numerMoba].mob.Top >= (-64) & daneLauncher.gracz.Top - daneLauncher.daneMob[numerMoba].mob.Top < daneLauncher.daneMob[numerMoba].mob.Height))
                {
                    daneLauncher.daneMob[numerMoba].mob.Image = daneLauncher.whiteBrownAttackingLeft.Image;
                    daneLauncher.daneMob[numerMoba].attackMob = true;
                }
                if (daneLauncher.daneMob[numerMoba].stopMovingMob == 0 & daneLauncher.daneMob[numerMoba].attackMob == false & (daneLauncher.gracz.Left - daneLauncher.daneMob[numerMoba].mob.Right >= (-16) & daneLauncher.gracz.Left - daneLauncher.daneMob[numerMoba].mob.Right < 8 & daneLauncher.gracz.Top - daneLauncher.daneMob[numerMoba].mob.Top >= (-64) & daneLauncher.gracz.Top - daneLauncher.daneMob[numerMoba].mob.Top < daneLauncher.daneMob[numerMoba].mob.Height))
                {
                    daneLauncher.daneMob[numerMoba].mob.Image = daneLauncher.whiteBrownAttackingRight.Image;
                    daneLauncher.daneMob[numerMoba].attackMob = true;
                    daneLauncher.daneMob[numerMoba].upMob = daneLauncher.daneMob[numerMoba].downMob = daneLauncher.daneMob[numerMoba].leftMob = daneLauncher.daneMob[numerMoba].rightMob = daneLauncher.daneMob[numerMoba].zmianaKierunkuUpMob = daneLauncher.daneMob[numerMoba].zmianaKierunkuDownMob = daneLauncher.daneMob[numerMoba].zmianaKierunkuLeftMob = daneLauncher.daneMob[numerMoba].zmianaKierunkuRightMob = false;
                }
                if (daneLauncher.daneMob[numerMoba].stopMovingMob == 0 & daneLauncher.daneMob[numerMoba].attackMob == true)
                {
                    daneLauncher.hpGracz -= metodaUniwersalne.dmgZwarcieMob(wartośćAtaku);
                    daneLauncher.hitLog.Text = ("Mob zadaje " + metodaUniwersalne.dmgZwarcieMob(wartośćAtaku) + " obrażeń.\n" + daneLauncher.hitLog.Text);
                    daneLauncher.daneMob[numerMoba].wykonanoAtakMob = true;
                    daneLauncher.daneMob[numerMoba].zmianaKierunkuLeftMob = daneLauncher.daneMob[numerMoba].zmianaKierunkuRightMob = false;
                }
                if (daneLauncher.daneMob[numerMoba].wykonanoAtakMob == true) { timerMob.Enabled = false; daneLauncher.daneMob[numerMoba].stopMovingMob++; }
                if (daneLauncher.daneMob[numerMoba].stopMovingMob == 5)
                {
                    timerMob.Enabled = true;
                    daneLauncher.daneMob[numerMoba].wykonanoAtakMob = false;
                    daneLauncher.daneMob[numerMoba].stopMovingMob = 0;
                }
                daneLauncher.daneMob[numerMoba].attackMob = false;
            }
        }
    }
}
