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

        //internal bool attackUpGracz = false; //
        //internal bool attackDownGracz = false; //
        //internal bool attackLeftGracz = false; //
        //internal bool attackRightGracz = false; // zmienne odpowiadające za kierunek ataku

        //bool attack;

        //int stopMoving = 0; //Zlicza czas przetrzymania gracza podczas ataku

        #endregion

        Launcher daneLauncher;

        public Gracz(Launcher dane)
        {
            daneLauncher = dane;
        }

        public void RuchGracza()
        {

            if ((daneLauncher.up == false & daneLauncher.down == false & daneLauncher.left == false & daneLauncher.right == false)) { daneLauncher.gracz.Image = global::Unstable.Properties.Resources.StandWhiteManBrownHairBlueEyesNew1; }

            if (daneLauncher.up == true & daneLauncher.down == false & daneLauncher.gracz.Top > daneLauncher.poleGry.Top & !(daneLauncher.gracz.Bounds.IntersectsWith(daneLauncher.daneMob[0].mob.Bounds))) { if (daneLauncher.zmianaKierunkuUpGracz == false) { daneLauncher.gracz.Image = global::Unstable.Properties.Resources.MovingUpWhiteManBrownHair; daneLauncher.zmianaKierunkuUpGracz = true; }  if (daneLauncher.left == true | daneLauncher.right == true) daneLauncher.zmianaKierunkuUpGracz = false; daneLauncher.gracz.Top -= 4; }
            if (daneLauncher.down == true & daneLauncher.up == false & daneLauncher.gracz.Bottom < daneLauncher.poleGry.Bottom & !(daneLauncher.gracz.Bounds.IntersectsWith(daneLauncher.daneMob[0].mob.Bounds))) { if (daneLauncher.zmianaKierunkuDownGracz == false) { daneLauncher.gracz.Image = global::Unstable.Properties.Resources.MovingDownWhiteManBrownHair; daneLauncher.zmianaKierunkuDownGracz = true; }  if (daneLauncher.left == true | daneLauncher.right == true) daneLauncher.zmianaKierunkuDownGracz = false; daneLauncher.gracz.Top += 4; }
            if (daneLauncher.left == true & daneLauncher.right == false & daneLauncher.gracz.Left > daneLauncher.poleGry.Left & !(daneLauncher.gracz.Bounds.IntersectsWith(daneLauncher.daneMob[0].mob.Bounds))) { if (daneLauncher.zmianaKierunkuLeftGracz == false) { daneLauncher.gracz.Image = global::Unstable.Properties.Resources.MovingWhiteManBrownHairLeft; daneLauncher.zmianaKierunkuLeftGracz = true; }  if (daneLauncher.up == true | daneLauncher.down == true) daneLauncher.zmianaKierunkuLeftGracz = false; daneLauncher.gracz.Left -= 4; }
            if (daneLauncher.right == true & daneLauncher.left == false & daneLauncher.gracz.Right < daneLauncher.poleGry.Right & !(daneLauncher.gracz.Bounds.IntersectsWith(daneLauncher.daneMob[0].mob.Bounds))) { if (daneLauncher.zmianaKierunkuRightGracz == false) { daneLauncher.gracz.Image = global::Unstable.Properties.Resources.MovingWhiteManBrownHairRight; daneLauncher.zmianaKierunkuRightGracz = true; }  if (daneLauncher.up == true | daneLauncher.down == true) daneLauncher.zmianaKierunkuRightGracz = false; daneLauncher.gracz.Left += 4; }
      
            if (daneLauncher.up == true & daneLauncher.gracz.Top - daneLauncher.daneMob[0].mob.Top >= (-20) & daneLauncher.gracz.Top - daneLauncher.daneMob[0].mob.Bottom < 4 & daneLauncher.daneMob[0].mob.Left - daneLauncher.gracz.Left >= (-64) & daneLauncher.daneMob[0].mob.Left - daneLauncher.gracz.Left < daneLauncher.gracz.Width) daneLauncher.gracz.Top += 4;
            if (daneLauncher.down == true & daneLauncher.daneMob[0].mob.Top - daneLauncher.gracz.Bottom >= (-20) & daneLauncher.daneMob[0].mob.Top - daneLauncher.gracz.Bottom < 4 & daneLauncher.daneMob[0].mob.Left - daneLauncher.gracz.Left >= (-64) & daneLauncher.daneMob[0].mob.Left - daneLauncher.gracz.Left < daneLauncher.gracz.Width) daneLauncher.gracz.Top -= 4;
            if (daneLauncher.left == true & daneLauncher.gracz.Left - daneLauncher.daneMob[0].mob.Right >= (-16) & daneLauncher.gracz.Left - daneLauncher.daneMob[0].mob.Right < 0 & (daneLauncher.daneMob[0].mob.Top - daneLauncher.gracz.Top >= (-64) & daneLauncher.daneMob[0].mob.Top - daneLauncher.gracz.Top < daneLauncher.gracz.Height)) daneLauncher.gracz.Left += 3;
            if (daneLauncher.right == true & daneLauncher.daneMob[0].mob.Left - daneLauncher.gracz.Right >= (-16) & daneLauncher.daneMob[0].mob.Left - daneLauncher.gracz.Right < 0 & daneLauncher.daneMob[0].mob.Top - daneLauncher.gracz.Top >= (-64) & daneLauncher.daneMob[0].mob.Top - daneLauncher.gracz.Top < daneLauncher.gracz.Height) daneLauncher.gracz.Left -= 3;

        }
        public void AtakGracza(Timer timerGracz)
        {
            #region WarunekAtaku
            if (daneLauncher.attack == true &
                (daneLauncher.up == true | daneLauncher.down == true |
                daneLauncher.left == true | daneLauncher.right == true))
            {
                if (daneLauncher.up == true) daneLauncher.attackUpGracz = true;
                if (daneLauncher.down == true) daneLauncher.attackDownGracz = true;
                if (daneLauncher.left == true) daneLauncher.attackLeftGracz = true;
                if (daneLauncher.right == true) daneLauncher.attackRightGracz = true;
                timerGracz.Enabled = false;
                daneLauncher.stopMoving = 0;
            }
            daneLauncher.attack = false;
            daneLauncher.stopMoving++;
            if (daneLauncher.stopMoving == 10)
            {
                timerGracz.Enabled = true;
                daneLauncher.stopMoving = 0;
            }
            if (daneLauncher.stopMoving > 10) daneLauncher.stopMoving = 0;
            #endregion
            #region WykonanieAtaku
            if(timerGracz.Enabled==false)
            {
                if (daneLauncher.attackUpGracz == true)
                {
                    
                }
                if (daneLauncher.attackDownGracz == true)
                {

                }
                if (daneLauncher.attackLeftGracz == true)
                {

                }
                if (daneLauncher.attackRightGracz == true)
                {

                }
            }
            #endregion
        }
    }
}
