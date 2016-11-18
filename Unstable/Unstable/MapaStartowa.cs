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

            this.poleGry.Location = new System.Drawing.Point(3, -3);


            DoubleBuffered = true;

            timerGracz.Enabled = true;
            timerAtakGracz.Enabled = true;
            timerStatystyki.Enabled = true;
            timerMob.Enabled = true;
            timerAtakMob.Enabled = true;
            timerStrzałaGracz.Enabled = true;

            //for(int i=0;i<9;i++) daneLauncher.daneMob[i] = new Launcher();

            daneLauncher.daneGracz.obraz = gracz;
            daneLauncher.daneGracz.antyRozmycie = underGracz;
            daneLauncher.poleGry = poleGry;
            daneLauncher.hitLog = hitLog;

            daneLauncher.daneGracz.siła = 10;
            daneLauncher.daneGracz.zręczność = 20;
            daneLauncher.daneGracz.hp = daneLauncher.daneGracz.hpMax;
            daneLauncher.daneGracz.mana = daneLauncher.daneGracz.manaMax;

            daneLauncher.daneGracz.lv = daneLauncher.daneMob[0].lv = 1;

            daneLauncher.daneMob[0].hp = 100;
            daneLauncher.daneMob[0].hpMax = 100;

            daneLauncher.daneDrop[0].exists = true;
            daneLauncher.daneDrop[0].obraz = drop1;
            daneLauncher.daneDrop[0].id = 1;
            daneLauncher.daneDrop[0].miecz = true;
            daneLauncher.daneDrop[0].dmgZwarcie[0] = 1;
            daneLauncher.daneDrop[0].dmgZwarcie[1] = 3;

            daneLauncher.daneStrzała[0].obraz = strzałaGracz;
            daneLauncher.daneStrzała[0].obraz.Visible = false;

            for (int i = 0; i < 12; i++) daneLauncher.danePrzeszkoda[i].exists = true;
            daneLauncher.danePrzeszkoda[0].obraz = beczka1;
            daneLauncher.danePrzeszkoda[1].obraz = beczka2;
            daneLauncher.danePrzeszkoda[2].obraz = beczka3;
            daneLauncher.danePrzeszkoda[3].obraz = beczka4;
            daneLauncher.danePrzeszkoda[4].obraz = beczka5;
            daneLauncher.danePrzeszkoda[5].obraz = beczka6;
            daneLauncher.danePrzeszkoda[6].obraz = beczka7;
            daneLauncher.danePrzeszkoda[7].obraz = beczka8;
            daneLauncher.danePrzeszkoda[8].obraz = beczki1;
            daneLauncher.danePrzeszkoda[9].obraz = beczki2;
            daneLauncher.danePrzeszkoda[10].obraz = ściana1;
            daneLauncher.danePrzeszkoda[11].obraz = ściana2;

            daneLauncher.rozdajStatystyki = rozdajStatystyki;

            daneLauncher.timerStatystyki = timerStatystyki;

            daneLauncher.music.SoundLocation = "Soundtrack1.wav";
            daneLauncher.music.PlayLooping();

            
        }

        private void rozdajStatystyki_Click(object sender, EventArgs e)
        {
            Statystyki formaStatystyki = new Statystyki(daneLauncher);
            formaStatystyki.ShowDialog();
        }
        private void MapaStartowa_KeyDown(object sender, KeyEventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.KeyDownMetoda(this, e);
            if (e.KeyCode == Keys.Z)
            {
                if (daneLauncher.daneGracz.obraz.Bounds.IntersectsWith(wyjścieMapa1.Bounds))
                {
                    daneLauncher.daneStrzała[0].obraz.Visible = false;
                    daneLauncher.daneStrzała[0].exists = false;
                    Mapa1 mapMapa1 = new Mapa1(daneLauncher);
                    this.Close();
                    mapMapa1.Show();
                }
            }
        }
        private void MapaStartowa_KeyUp(object sender, KeyEventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.KeyUpMetoda(e);
        }
        private void timerGracz_Tick(object sender, EventArgs e)
        {
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            for(int i=0;i<12;i++)
            metodaUniwersalne.przeszkodaNaDrodze(daneLauncher.daneGracz, daneLauncher.danePrzeszkoda[i]);

            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerGraczMetoda();
        }
        private void timerAtakGracz_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerAtakGraczMetoda(timerGracz);
        }
        private void timerStatystyki_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerStatystykiMetoda(this, timerGracz, timerAtakGracz, timerMob, timerAtakMob, timerStatystyki, labelHpGracz, labelManaGracz, labelLvGracz, labelExpGracz);
        }

        private void timerStrzałaGracz_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerStrzałaGraczMetoda(0,8,2,10);
        }
    }
}