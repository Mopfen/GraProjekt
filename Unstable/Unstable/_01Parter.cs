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
    public partial class _01Parter : Form
    {
        List<PictureBox> przeszkody = new List<PictureBox>();

        Launcher daneLauncher;

        public _01Parter(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;

            DoubleBuffered = true;

            #region Test
            timerGracz.Interval = 1;

            #endregion
            #region WczytajDane
            this.poleGry.Location = new System.Drawing.Point(3, -3);
            daneLauncher.daneGracz.obraz = gracz;
            daneLauncher.daneGracz.antyRozmycie = underGracz;
            daneLauncher.poleGry = poleGry;
            daneLauncher.hitLog = hitLog;

            #region Przeszkody
            przeszkody.Add(beczka1);
            przeszkody.Add(beczka2);
            przeszkody.Add(beczka3);
            przeszkody.Add(beczki);
            przeszkody.Add(ściana1);
            przeszkody.Add(ściana2);
            przeszkody.Add(ściana3);
            przeszkody.Add(stolik);

            for (int i = 12, j=0; i <= 20; i++, j++)
            {
                if (j > 7) j = 7;
                daneLauncher.danePrzeszkoda[i].exists = true;
                daneLauncher.danePrzeszkoda[i].obraz = przeszkody[j];
            }

            #endregion
            #region ZatrzymajGracza
            daneLauncher.daneGracz.up = daneLauncher.daneGracz.down = daneLauncher.daneGracz.left = daneLauncher.daneGracz.right = false;

            #endregion

            daneLauncher.daneStrzała[0].obraz = strzałaGracz;
            daneLauncher.daneStrzała[0].obraz.Visible = false;

            daneLauncher.rozdajStatystyki = rozdajStatystyki;
            daneLauncher.timerStatystyki = timerStatystyki;

            #endregion

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
            for (int i = 12; i <= 20; i++)
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
            metodaMap.timerStrzałaGraczMetoda(0, 8, 2, 10);
        }
    }
}
