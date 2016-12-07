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
    public partial class _01PiętroPierwsze : Form
    {
        List<PictureBox> przeszkody = new List<PictureBox>();

        Launcher daneLauncher;

        public _01PiętroPierwsze(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;

            DoubleBuffered = true;

            this.Text = "TerrorOfDragons - " + daneLauncher.gameVersion;

            #region Test
            timerGracz.Interval = 1;

            #endregion
            #region WczytajDane
            daneLauncher.daneMapa[1].numerLokacji = 3;
            this.poleGry.Location = new System.Drawing.Point(3, -3);
            this.panelStatystyk.Location = new Point(3, 445);
            daneLauncher.daneGracz.obraz = gracz;
            daneLauncher.daneGracz.antyRozmycie = underGracz;
            daneLauncher.poleGry = poleGry;
            daneLauncher.hitLog = hitLog;
            daneLauncher.używanaBroń = używanaBroń;

            if (daneLauncher.daneMapa[1].częśćMapyOdwiedzona[3] == false)
            {
                daneLauncher.daneMapa[1].drop[3] = true;
            }

            #region UstawGracza
            if (daneLauncher.daneMapa[1].gdzieOstatnio == 1)
            {
                daneLauncher.daneGracz.obraz.Location = new Point(198, 40);
            }

            #endregion
            #region Przeszkody
            if (daneLauncher.daneMapa[daneLauncher.numerMapy].częśćMapyOdwiedzona[daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji] == false)
            {
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, ściana1, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 1));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, ściana2, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 2));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, ściana3, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 3));
            }
            else
            {
                #region PonownePrzypisanieObrazków
                foreach (var indeks in daneLauncher.danePrzeszkoda.Where(x => x.numerMapy == daneLauncher.numerMapy & x.numerLokacji == daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji))
                {
                    switch (daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].numerObiektu)
                    {
                        case 1: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = ściana1; break;
                        case 2: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = ściana2; break;
                        case 3: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = ściana3; break;
                    }
                }

                #endregion
            }
            foreach (var indeks in daneLauncher.danePrzeszkoda.Where(x => x.numerMapy == daneLauncher.numerMapy & x.numerLokacji == daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji & x.exists == false))
            {
                daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz.Visible = false;
            }

            #endregion
            #region ZatrzymajGracza
            daneLauncher.daneGracz.up = daneLauncher.daneGracz.down = daneLauncher.daneGracz.left = daneLauncher.daneGracz.right = false;

            #endregion
            #region PrzypisanieTimerów
            daneLauncher.timerGracz = timerGracz;
            daneLauncher.timerAtakGracz = timerAtakGracz;
            daneLauncher.timerMob = timerMob;
            daneLauncher.timerAtakMob = timerAtakMob;
            daneLauncher.timerNPC = timerNPC;
            daneLauncher.timerStatystyki = timerStatystyki;
            daneLauncher.timerStrzałaGracz = timerStrzałaGracz;

            #endregion

            if (daneLauncher.daneMapa[1].drop[3]==true)
            {
                daneLauncher.daneDrop[0] = new Launcher.ZmienneEkwipunku();
                daneLauncher.daneDrop[0].exists = true;
                daneLauncher.daneDrop[0].obraz = drop0;
                daneLauncher.daneDrop[0].obraz.Visible = true;
                daneLauncher.daneDrop[0].id = 2;
                daneLauncher.daneDrop[0].łuk = true;
                daneLauncher.daneDrop[0].dmgDystans[0] = 1;
                daneLauncher.daneDrop[0].dmgDystans[1] = 6;
                daneLauncher.daneDrop[0].numerLokacji = daneLauncher.daneMapa[1].numerLokacji;
            }
            

            daneLauncher.daneStrzała[0].obraz = strzałaGracz;
            daneLauncher.daneStrzała[0].obraz.Visible = false;

            daneLauncher.rozdajStatystyki = rozdajStatystyki;
            daneLauncher.pokazNoweZadanie = pokazNoweZadanie;

            daneLauncher.daneMapa[1].częśćMapyOdwiedzona[daneLauncher.daneMapa[1].gdzieOstatnio = daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji] = true;
            daneLauncher.daneMapa[1].gdzieOstatnio = daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji;

            #endregion

        }

        private void rozdajStatystyki_Click(object sender, EventArgs e)
        {
            Statystyki formaStatystyki = new Statystyki(daneLauncher);
            formaStatystyki.ShowDialog();
        }

        private void pokazNoweZadanie_Click(object sender, EventArgs e)
        {
            Zadania formaZadania = new Zadania(daneLauncher);
            formaZadania.ShowDialog();
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
                    _01Parter map_01Parter = new _01Parter(daneLauncher);
                    this.Close();
                    map_01Parter.Show();
                }
                if(daneLauncher.daneGracz.obraz.Bounds.IntersectsWith(drop0.Bounds) & daneLauncher.samouczek == true)
                {
                    Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
                    metodaUniwersalne.zatrzymajTimery();

                    daneLauncher.samouczekObrazDemonstracyjny.Image = global::Unstable.Properties.Resources.SamouczekZmianaBroni;
                    daneLauncher.samouczekObrazKlawiszy.Image = global::Unstable.Properties.Resources.KlawiszeSamouczekZmianaBroni;
                    daneLauncher.samouczekInstrukcja = "Aby zmienić broń, której używasz, naciśnij \"X\".";
                    daneLauncher.samouczekInfo = "Możesz zmienić rodzaj aktualnie używanej broni, o ile masz jej odpowiednik w ręku.";

                    Samouczek formaSamouczek = new Samouczek(daneLauncher);
                    formaSamouczek.ShowDialog();
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
            PoruszanieSię metodaPoruszanieSię = new PoruszanieSię(daneLauncher);
            MetodyMap metodaMap = new MetodyMap(daneLauncher);

            foreach (var indeks in daneLauncher.danePrzeszkoda.Where(x => x.numerLokacji == daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji))
            {
                metodaPoruszanieSię.przeszkodaNaDrodze(daneLauncher.daneGracz, daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)]);
            }
            metodaMap.timerGraczMetoda();
        }

        private void timerAtakGracz_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerAtakGraczMetoda(daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji);
        }

        private void timerStatystyki_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerStatystykiMetoda(this, timerGracz, timerAtakGracz, timerMob, timerAtakMob, timerNPC, timerStatystyki, labelHpGracz, labelManaGracz, labelLvGracz, labelExpGracz);

            if (daneLauncher.daneDrop[0].exists == false)
            {
                daneLauncher.daneMapa[1].drop[3] = false;
            }

            #region Quest1
            if(daneLauncher.daneQuest[1].etap == 3)
            {
                for (int i = 1; i <= 46; i++)
                {
                    if (daneLauncher.danePlecakSlot[i].id == 2)
                    {
                        daneLauncher.daneQuest[1].stan = 1;
                        daneLauncher.daneQuest[1].etap = 4;
                        daneLauncher.daneQuest[1].opisEtapu[4] = "Wróć do Perquna.";
                        daneLauncher.noweGlowneZadanie = true;
                    }
                }
            }
            
            #endregion
        }

        private void timerStrzałaGracz_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerStrzałaGraczMetoda(0, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji);
        }
    }
}
