using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unstable
{
    public partial class Test : Form
    {
        bool up; //
        bool down; //
        bool left; //
        bool right; // zmienne odpowiadające za ruch gracza

        bool upMob = false; //
        bool downMob = false; // 
        bool leftMob = false; //
        bool rightMob = false; // testowe zmienne poruszania się moba

        bool zmianaKierunkuUpGracz = false; //
        bool zmianaKierunkuDownGracz = false; //
        bool zmianaKierunkuLeftGracz = false; // 
        bool zmianaKierunkuRightGracz = false; // zmienne odpowiadające za zmianę grafiki gracza

        bool zmianaKierunkuUpMob = false; //
        bool zmianaKierunkuDownMob = false; //
        bool zmianaKierunkuLeftMob = false; // 
        bool zmianaKierunkuRightMob = false; // zmienne odpowiadające za zmianę grafiki moba

        bool attack;

        int staraPozycja; // zmienna określająca początkową pozyjcę moba
        short wyliczenie = 0; // zmienna pomocnicza (mob)
        bool naDole = false; // testowa zmienna sprawdzająca, czy mob dotarł do oczekiwanego punktu

        int stopMoving = 0; //ALPHA

        Launcher daneLauncher;

        public Test()
        {
            InitializeComponent();

            aktualizatorGracz.Enabled = true;
            //aktualizatorMob.Enabled = true;
            aktualizatorAtak.Enabled = true;

        }

        private void Test_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { up = true; }
            if (e.KeyCode == Keys.Down) { down = true; }
            if (e.KeyCode == Keys.Left) { left = true;}
            if (e.KeyCode == Keys.Right) { right = true;  }
            
            if (e.KeyCode == Keys.Space) attack = true;

            if(e.KeyCode==Keys.Escape)
            {
                MenuGlowne formaMenuGlowne = new MenuGlowne(daneLauncher);

                this.Close();
                formaMenuGlowne.Show();
            }
        }

        private void Test_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { up = false; zmianaKierunkuUpGracz = false; }
            if (e.KeyCode == Keys.Down) { down = false; zmianaKierunkuDownGracz = false; }
            if (e.KeyCode == Keys.Left) { left = false; zmianaKierunkuLeftGracz = false; }
            if (e.KeyCode == Keys.Right) { right = false; zmianaKierunkuRightGracz = false; }
        }

        private void Test_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void stop(bool up,bool left,bool right)
        { 
        }

        private void aktualizatorGracz_Tick(object sender, EventArgs e)
        {
            if (up == true & down == false & gracz.Top > poleGry.Top & !(gracz.Bounds.IntersectsWith(mob.Bounds))) { if (zmianaKierunkuUpGracz == false ) { this.gracz.Image = global::Unstable.Properties.Resources.MovingUpWhiteManBrownHair; zmianaKierunkuUpGracz = true; } if (left == true | right == true) zmianaKierunkuUpGracz = false; gracz.Top -= 8; }
            if (down == true & up == false & gracz.Bottom < poleGry.Bottom & !(gracz.Bounds.IntersectsWith(mob.Bounds))) { if (zmianaKierunkuDownGracz == false) {this.gracz.Image = global::Unstable.Properties.Resources.MovingDownWhiteManBrownHair; zmianaKierunkuDownGracz = true; } if (left == true | right == true) zmianaKierunkuDownGracz = false; gracz.Top += 8;  }
            if (left == true & right == false & gracz.Left > poleGry.Left & !(gracz.Bounds.IntersectsWith(mob.Bounds))) { if (zmianaKierunkuLeftGracz == false) { this.gracz.Image = global::Unstable.Properties.Resources.MovingWhiteManBrownHairLeft; zmianaKierunkuLeftGracz = true; } if (up == true | down == true) zmianaKierunkuLeftGracz = false; gracz.Left -= 8;   }
            if (right == true & left == false & gracz.Right < poleGry.Right & !(gracz.Bounds.IntersectsWith(mob.Bounds))) { if (zmianaKierunkuRightGracz == false) { this.gracz.Image = global::Unstable.Properties.Resources.MovingWhiteManBrownHairRight; zmianaKierunkuRightGracz = true; } if (up == true | down == true) zmianaKierunkuRightGracz = false; gracz.Left += 8;  }
            
            if (up==true & gracz.Top - mob.Top >= (-20) & gracz.Top - mob.Bottom < 4 & mob.Left - gracz.Left >= (-64) & mob.Left - gracz.Left < gracz.Width) gracz.Top += 4;
            if (down==true & mob.Top - gracz.Bottom >= (-20) & mob.Top - gracz.Bottom < 4 & mob.Left - gracz.Left >= (-64) & mob.Left - gracz.Left < gracz.Width) gracz.Top -= 4;
            if (left==true & mob.Left - gracz.Right >=(-16) & mob.Left - gracz.Right < 3 & mob.Top -gracz.Top>=(-64) & mob.Top-gracz.Top<gracz.Height) gracz.Left -= 3;
            if (right==true & gracz.Left-mob.Right >= (-16) & gracz.Left - mob.Right < 3 & (mob.Top - gracz.Top >= (-64) & mob.Top - gracz.Top < gracz.Height)) gracz.Left += 3;

            if ((up == false & down == false & left == false & right == false)) { this.gracz.Image = global::Unstable.Properties.Resources.StandWhiteManBrownHairBlueEyesNew1; }
        }
        private void aktualizatorMob_Tick(object sender, EventArgs e)
        {

            if (up==false & mob.Top - gracz.Top >= (-20) & mob.Top - gracz.Bottom < 4 & gracz.Left - mob.Left >= (-64) & gracz.Left - mob.Left < mob.Width) { mob.Top += 4; upMob = true; }
            if (down == false & gracz.Top - mob.Bottom >= (-20) & gracz.Top - mob.Bottom < 4 & gracz.Left - mob.Left >= (-64) & gracz.Left - mob.Left < mob.Width) { mob.Top -= 4; downMob = true; }
            if (left == false & gracz.Left - mob.Right >= (-16) & gracz.Left - mob.Right < 3 & gracz.Top - mob.Top >= (-64) & gracz.Top - mob.Top < mob.Height) { mob.Left -= 3; leftMob = true; }
            if (right == false & mob.Left - gracz.Right >= (-16) & mob.Left - gracz.Right < 3 & (gracz.Top - mob.Top >= (-64) & gracz.Top - mob.Top < mob.Height)) { mob.Left += 3; rightMob = true; }

            if (wyliczenie == 0)
            { staraPozycja = mob.Top; wyliczenie = 1; }
            if (downMob == false & mob.Top < staraPozycja + 300 & naDole == false) { if (zmianaKierunkuDownMob == false) this.mob.Image = global::Unstable.Properties.Resources.MovingDownWhiteManBrownHair; mob.Top += 8; zmianaKierunkuDownMob = true; zmianaKierunkuUpMob = false; }
            else { if (downMob == false) naDole = true; }
            if (upMob == false & mob.Top > staraPozycja & naDole == true) { if (zmianaKierunkuUpMob == false) this.mob.Image = global::Unstable.Properties.Resources.MovingUpWhiteManBrownHair; mob.Top -= 8; zmianaKierunkuUpMob = true; zmianaKierunkuDownMob = false; }
            else { if (upMob == false) naDole = false; }

            upMob = false;
            downMob = false;
            leftMob = false;
            rightMob = false;
        }

        private void aktualizatorAtak_Tick(object sender, EventArgs e)
        {
            if(attack==true)
            {
                aktualizatorGracz.Enabled = false;
                stopMoving++;
                if (stopMoving == 10)
                {
                   



                    aktualizatorGracz.Enabled = true; ;
                    attack = false;                        //ALPHA
                    stopMoving = 0;
                }
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void zbroja_Click(object sender, EventArgs e)
        {
   
        }

        
    }
}
