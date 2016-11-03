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
        #region SzczegółyZmiennych
        
        //bool up=false; //
        //bool down=false; //
        //bool left=false; //
        //bool right=false; // zmienne odpowiadające za ruch gracza

        //bool zmianaKierunkuUpGracz = false; //
        //bool zmianaKierunkuDownGracz = false; //
        //bool zmianaKierunkuLeftGracz = false; // 
        //bool zmianaKierunkuRightGracz = false; // zmienne odpowiadające za zmianę grafiki gracza

        //bool attack;

        //int stopMoving = 0; //ALPHA

        #endregion

        Launcher daneLauncher;

        public Gracz(Launcher dane)
        {
            daneLauncher = dane;
        }

        static public Tuple <bool,bool,bool,bool> RuchGracza(bool up,bool down,bool left,bool right,
            bool zmianaKierunkuUpGracz, bool zmianaKierunkuDownGracz,
            bool zmianaKierunkuLeftGracz, bool zmianaKierunkuRightGracz,
            PictureBox gracz, PictureBox mob, Panel poleGry)
        {
            if ((up == false & down == false & left == false & right == false)) { gracz.Image = global::Unstable.Properties.Resources.StandWhiteManBrownHairBlueEyesNew1; }

            if (up == true & down == false & gracz.Top > poleGry.Top & !(gracz.Bounds.IntersectsWith(mob.Bounds))) { if (zmianaKierunkuUpGracz == false) { gracz.Image = global::Unstable.Properties.Resources.MovingUpWhiteManBrownHair; zmianaKierunkuUpGracz = true; } if (left == true | right == true) zmianaKierunkuUpGracz = false; gracz.Top -= 4; }
            if (down == true & up == false & gracz.Bottom < poleGry.Bottom & !(gracz.Bounds.IntersectsWith(mob.Bounds))) { if (zmianaKierunkuDownGracz == false) { gracz.Image = global::Unstable.Properties.Resources.MovingDownWhiteManBrownHair; zmianaKierunkuDownGracz = true; } if (left == true | right == true) zmianaKierunkuDownGracz = false; gracz.Top += 4; }
            if (left == true & right == false & gracz.Left > poleGry.Left & !(gracz.Bounds.IntersectsWith(mob.Bounds))) { if (zmianaKierunkuLeftGracz == false) { gracz.Image = global::Unstable.Properties.Resources.MovingWhiteManBrownHairLeft; zmianaKierunkuLeftGracz = true; } if (up == true | down == true) zmianaKierunkuLeftGracz = false; gracz.Left -= 4; }
            if (right == true & left == false & gracz.Right < poleGry.Right & !(gracz.Bounds.IntersectsWith(mob.Bounds))) { if (zmianaKierunkuRightGracz == false) { gracz.Image = global::Unstable.Properties.Resources.MovingWhiteManBrownHairRight; zmianaKierunkuRightGracz = true; } if (up == true | down == true) zmianaKierunkuRightGracz = false; gracz.Left += 4; }
     
            if (up == true & gracz.Top - mob.Top >= (-20) & gracz.Top - mob.Bottom < 4 & mob.Left - gracz.Left >= (-64) & mob.Left - gracz.Left < gracz.Width) gracz.Top += 4;
            if (down == true & mob.Top - gracz.Bottom >= (-20) & mob.Top - gracz.Bottom < 4 & mob.Left - gracz.Left >= (-64) & mob.Left - gracz.Left < gracz.Width) gracz.Top -= 4;
            if (left == true & gracz.Left - mob.Right >= (-16) & gracz.Left - mob.Right < 0 & (mob.Top - gracz.Top >= (-64) & mob.Top - gracz.Top < gracz.Height)) gracz.Left += 3;
            if (right == true & mob.Left - gracz.Right >= (-16) & mob.Left - gracz.Right < 0 & mob.Top - gracz.Top >= (-64) & mob.Top - gracz.Top < gracz.Height) gracz.Left -= 3;

            return new Tuple<bool, bool, bool, bool>(zmianaKierunkuUpGracz, zmianaKierunkuDownGracz, zmianaKierunkuLeftGracz, zmianaKierunkuRightGracz);
        }
        static public Tuple <bool,int> AtakGracza(bool attack,int stopMoving,Timer timerGracz)
        {
            if (attack == true)
            {
                timerGracz.Enabled = false;
                stopMoving++;
                if (stopMoving == 10)
                {
                    timerGracz.Enabled = true; 
                    attack = false;                        //ALPHA
                    stopMoving = 0;
                }
            }
            return new Tuple<bool,int>(attack,stopMoving);
        }
    }
}
