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
    public partial class Mapa1 : Form
    {
        #region zmienne

        bool upMob = false; //
        bool downMob = false; // 
        bool leftMob = false; //
        bool rightMob = false; // testowe zmienne poruszania się moba

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
        #endregion
        bool x = false;

        public Mapa1(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;
            
            timerGracz.Enabled = true;
            timerAtakGracz.Enabled = true;

            daneLauncher.daneMob[0] = new Launcher();

            daneLauncher.gracz=gracz;
            daneLauncher.poleGry = poleGry;
            daneLauncher.daneMob[0].mob = mob;
        }

        private void Mapa1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X) { x = true; }
            if (e.KeyCode == Keys.Up) { daneLauncher.up = true; }
            if (e.KeyCode == Keys.Down) { daneLauncher.down = true; }
            if (e.KeyCode == Keys.Left) { daneLauncher.left = true; }
            if (e.KeyCode == Keys.Right) { daneLauncher.right = true; }
            if (e.KeyCode == Keys.Space) daneLauncher.attack = true;
            if (e.KeyCode == Keys.Escape)
            {
                MenuGlowne formaMenuGlowne = new MenuGlowne(daneLauncher);

                this.Close();
                formaMenuGlowne.Show();
            }
        }
        private void Mapa1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { daneLauncher.up = false; daneLauncher.zmianaKierunkuUpGracz = false; }
            if (e.KeyCode == Keys.Down) { daneLauncher.down = false; daneLauncher.zmianaKierunkuDownGracz = false; }
            if (e.KeyCode == Keys.Left) { daneLauncher.left = false; daneLauncher.zmianaKierunkuLeftGracz = false; }
            if (e.KeyCode == Keys.Right) { daneLauncher.right = false; daneLauncher.zmianaKierunkuRightGracz = false; }
        }
        private void timerGracz_Tick(object sender, EventArgs e)
        {
            Gracz metodaGracz = new Unstable.Gracz(daneLauncher);
            metodaGracz.RuchGracza();

            if(x==true)
            {
                //for (int i = 0; i < 9; i++) daneLauncher.daneMob[i].mob = gracz;
            }
        }
        private void timerAtakGracz_Tick(object sender, EventArgs e)
        {
            Gracz metodaGracz = new Unstable.Gracz(daneLauncher);
            metodaGracz.AtakGracza(timerGracz);
        }
    }
}
