using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Unstable
{
    public partial class _01Piwnica : Form
    {
        List<PictureBox> przeszkody = new List<PictureBox>();

        Launcher daneLauncher;

        public _01Piwnica(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;

            DoubleBuffered = true;

            daneLauncher.numerMapy = 1;

            #region Test
            timerGracz.Interval = 1;

            #endregion
            #region WczytajDaneMapy
            daneLauncher.daneMapa[1].numerLokacji = 0;
            this.poleGry.Location = new System.Drawing.Point(3, -3);
            daneLauncher.daneGracz.obraz = gracz;
            daneLauncher.daneGracz.antyRozmycie = underGracz;
            daneLauncher.poleGry = poleGry;
            daneLauncher.hitLog = hitLog;

            daneLauncher.daneDrop[0].exists = true;
            daneLauncher.daneDrop[0].obraz = drop1;
            daneLauncher.daneDrop[0].id = 1;
            daneLauncher.daneDrop[0].miecz = true;
            daneLauncher.daneDrop[0].dmgZwarcie[0] = 3;
            daneLauncher.daneDrop[0].dmgZwarcie[1] = 5;
            daneLauncher.daneDrop[0].numerLokacji = daneLauncher.daneMapa[1].numerLokacji;

            daneLauncher.daneStrzała[0].obraz = strzałaGracz;
            daneLauncher.daneStrzała[0].obraz.Visible = false;

            #region UstawGracza
            if (daneLauncher.daneMapa[1].gdzieOstatnio == 1)
            {
                daneLauncher.daneGracz.obraz.Location = new Point(525, 22);
            }

            #endregion
            #region Przeszkody
            przeszkody.Add(beczka1);
            przeszkody.Add(beczka2);
            przeszkody.Add(beczka3);
            przeszkody.Add(beczka4);
            przeszkody.Add(beczka5);
            przeszkody.Add(beczka6);
            przeszkody.Add(beczka7);
            przeszkody.Add(beczka8);
            przeszkody.Add(beczki1);
            przeszkody.Add(beczki2);
            przeszkody.Add(ściana1);
            przeszkody.Add(ściana2);

            for (int i = 0; i <= 11; i++)
            {
                if(daneLauncher.daneMapa[1].częśćMapyOdwiedzona[0]==false)
                {
                    Muzyka metodaMuzyka = new Muzyka(daneLauncher);
                    daneLauncher.danePrzeszkoda[i].exists = true;
                    daneLauncher.wątekMuzyka = new Thread(metodaMuzyka.Soundtrack1);
                    daneLauncher.wątekMuzyka.Start();
                }
                daneLauncher.danePrzeszkoda[i].obraz = przeszkody[i];
                if(daneLauncher.danePrzeszkoda[i].exists==false)
                {
                    daneLauncher.danePrzeszkoda[i].obraz.Visible = false;
                }                
            }
            daneLauncher.daneMapa[1].częśćMapyOdwiedzona[0] = true;
            daneLauncher.daneMapa[1].gdzieOstatnio = 0;

            #endregion
            #region ZatrzymajGracza
            daneLauncher.daneGracz.up = daneLauncher.daneGracz.down = daneLauncher.daneGracz.left = daneLauncher.daneGracz.right = false;

            #endregion

            daneLauncher.rozdajStatystyki = rozdajStatystyki;
            daneLauncher.timerStatystyki = timerStatystyki;

            #endregion
        }

        private void rozdajStatystyki_Click(object sender, EventArgs e)
        {
            Statystyki formaStatystyki = new Statystyki(daneLauncher);
            formaStatystyki.ShowDialog();
        }

        private void TheKeyDown(object sender, KeyEventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.KeyDownMetoda(this, e);
            if (e.KeyCode == Keys.Z)
            {
                if (daneLauncher.daneGracz.obraz.Bounds.IntersectsWith(wyjścieParter.Bounds))
                {
                    daneLauncher.daneStrzała[0].obraz.Visible = false;
                    daneLauncher.daneStrzała[0].exists = false;
                    //MapaTestowa mapMapaTestowa = new MapaTestowa(daneLauncher);
                    _01Parter map_01Parter = new _01Parter(daneLauncher);
                    przeszkody.Clear();
                    this.Close();
                    //mapMapaTestowa.Show();
                    map_01Parter.Show();
                }
            }
        }

        private void TheKeyUp(object sender, KeyEventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.KeyUpMetoda(e);
        }

        private void timerGracz_Tick(object sender, EventArgs e)
        {
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            for(int i=0;i<=11;i++)
            {
                metodaUniwersalne.przeszkodaNaDrodze(daneLauncher.daneGracz, daneLauncher.danePrzeszkoda[i]);
            }
            
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
            metodaMap.timerStrzałaGraczMetoda(0,8,0,2,10);
        }
    }
}