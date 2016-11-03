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
    public partial class MapaStartowa : Form
    {
        Launcher daneLauncher;

        public MapaStartowa(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;

            //DoubleBuffered = true;

            timerGracz.Enabled = true;
            timerAtakGracz.Enabled = true;
            timerStatystyki.Enabled = true;
            timerMob.Enabled = true;
            timerAtakMob.Enabled = true;

            //for(int i=0;i<9;i++) daneLauncher.daneMob[i] = new Launcher();

            daneLauncher.gracz = gracz;
            daneLauncher.underGracz = underGracz;
            daneLauncher.poleGry = poleGry;
            daneLauncher.hitLog = hitLog;

            daneLauncher.hpGracz = 100;
            daneLauncher.hpGraczMax = 100;

            daneLauncher.daneMob[0].hpMob = 100;
            daneLauncher.daneMob[0].hpMobMax = 100;

            daneLauncher.music.SoundLocation = "Soundtrack1.wav";
            daneLauncher.music.PlayLooping();
        }

        private void MapaStartowa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { daneLauncher.up = true; }
            if (e.KeyCode == Keys.Down) { daneLauncher.down = true; }
            if (e.KeyCode == Keys.Left) { daneLauncher.left = true; }
            if (e.KeyCode == Keys.Right) { daneLauncher.right = true; }
            if (e.KeyCode == Keys.Space) daneLauncher.attackGracz = true;
            if (e.KeyCode == Keys.Escape)
            {
                MenuGlowne formaMenuGlowne = new MenuGlowne(daneLauncher);

                this.Close();
                formaMenuGlowne.Show();
            }
            if (e.KeyCode == Keys.Z)
            {
                if(daneLauncher.gracz.Bounds.IntersectsWith(wyjścieMapa1.Bounds))
                {
                    Mapa1 mapMapa1 = new Mapa1(daneLauncher);
                    this.Close();
                    mapMapa1.Show();
                }
            }
            if(e.KeyCode==Keys.C)
            {
                Statystyki formaStatystyki = new Statystyki(daneLauncher);
                formaStatystyki.ShowDialog();
            }
        }
        private void MapaStartowa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { daneLauncher.up = false; daneLauncher.zmianaKierunkuUpGracz = false; }
            if (e.KeyCode == Keys.Down) { daneLauncher.down = false; daneLauncher.zmianaKierunkuDownGracz = false; }
            if (e.KeyCode == Keys.Left) { daneLauncher.left = false; daneLauncher.zmianaKierunkuLeftGracz = false; }
            if (e.KeyCode == Keys.Right) { daneLauncher.right = false; daneLauncher.zmianaKierunkuRightGracz = false; }
        }
        private void timerGracz_Tick(object sender, EventArgs e)
        {
            Gracz metodaGracz = new Gracz(daneLauncher);
            metodaGracz.RuchGracza();
        }
        private void timerAtakGracz_Tick(object sender, EventArgs e)
        {
            Gracz metodaGracz = new Unstable.Gracz(daneLauncher);
            metodaGracz.AtakGracza(timerGracz);
        }

        private void timerStatystyki_Tick(object sender, EventArgs e)
        {
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            GameOver formaGameOver = new GameOver(daneLauncher, this);
            labelHpGracz.Text = Convert.ToString("HP: " + daneLauncher.hpGracz + "/" + daneLauncher.hpGraczMax);

            Tuple<bool, int> czyMobZabity = metodaUniwersalne.śmierćMoba();
            if (czyMobZabity.Item1 == true)
            {
                daneLauncher.daneMob[czyMobZabity.Item2].istniejeMob = false;
            }
            if (metodaUniwersalne.śmierćGracza() == true)
            {
                daneLauncher.music.SoundLocation = "GameOver.wav";
                daneLauncher.music.Play();
                formaGameOver.Show();
                timerGracz.Enabled = timerAtakGracz.Enabled = timerMob.Enabled = timerAtakMob.Enabled = timerStatystyki.Enabled = false;
            }
        }

        
    }
}