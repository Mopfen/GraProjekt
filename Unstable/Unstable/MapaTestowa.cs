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
    public partial class MapaTestowa : Form
    {
        /// <summary> Umożliwia dostęp do danych zawartych w klasie Launcher.</summary>
        Launcher daneLauncher;

        public MapaTestowa(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;

            this.Text = "TerrorOfDragons - " + daneLauncher.gameVersion;

            this.poleGry.Location = new System.Drawing.Point(3, -3);

            DoubleBuffered = true;

            daneLauncher.daneGracz.obraz=gracz;
            daneLauncher.daneGracz.antyRozmycie = underGracz;
            daneLauncher.poleGry = poleGry;
            daneLauncher.daneMob[0].exists = true;
            daneLauncher.daneMob[0].antyRozmycie = underMob;
            daneLauncher.daneMob[0].obraz = mob;
            daneLauncher.daneMob[0].labelhp = labelHpMob0;
            daneLauncher.hitLog = hitLog;

            daneLauncher.daneMob[0].hp = 100;
            daneLauncher.daneMob[0].hpMax = 100;

            daneLauncher.daneStrzała[0].obraz = strzałaGracz;
            daneLauncher.daneStrzała[0].obraz.Visible = false;

            daneLauncher.rozdajStatystyki = rozdajStatystyki;

            daneLauncher.timerStatystyki = timerStatystyki;

            //daneLauncher.music.SoundLocation = "Soundtrack1.wav";
            //daneLauncher.music.PlayLooping();
        }

        private void rozdajStatystyki_Click(object sender, EventArgs e)
        {
            Statystyki formaStatystyki = new Statystyki(daneLauncher);
            formaStatystyki.ShowDialog();
        }
        private void Mapa1_KeyDown(object sender, KeyEventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.KeyDownMetoda(this, e);
        }
        private void Mapa1_KeyUp(object sender, KeyEventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.KeyUpMetoda(e);
        }
        private void timerGracz_Tick(object sender, EventArgs e)
        {
            PoruszanieSię metodaPoruszanieSię = new PoruszanieSię(daneLauncher);
            MetodyMap metodaMap = new MetodyMap(daneLauncher);

            metodaPoruszanieSię.przeszkodaNaDrodze(daneLauncher.daneGracz, daneLauncher.daneMob[0]);
            metodaMap.timerGraczMetoda();
        }
        private void timerAtakGracz_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerAtakGraczMetoda(timerGracz);
        }
        private void timerStatystyki_Tick(object sender, EventArgs e)
        {
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            labelHpMob0.Text = Convert.ToString(metodaUniwersalne.wyliczProcent(daneLauncher.daneMob[0].hp, daneLauncher.daneMob[0].hpMax)+"%");
            metodaMap.timerStatystykiMetoda(this, timerGracz, timerAtakGracz, timerMob, timerAtakMob, timerNPC, timerStatystyki, labelHpGracz, labelManaGracz, labelLvGracz, labelExpGracz);
        }

        private void timerMob_Tick(object sender, EventArgs e)
        {
            Mob metodaMob = new Mob(daneLauncher);
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            PoruszanieSię metodaPoruszanieSię = new PoruszanieSię(daneLauncher);

            metodaMob.RuchMobaDoGracza(0);
            metodaPoruszanieSię.przeszkodaNaDrodze(daneLauncher.daneMob[0], daneLauncher.daneGracz);
            metodaMap.timerMobMetoda(0);
        }

        private void timerAtakMob_Tick(object sender, EventArgs e)
        {
            Mob metodaMob = new Mob(daneLauncher);
            metodaMob.AtakMoba(timerMob, 0,1);
        }

        private void timerStrzałaGracz_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerStrzałaGraczMetoda(1,0,0,0,0);
        }
    }
}
