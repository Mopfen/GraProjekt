﻿using System;
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
        bool[] pokazSamouczek = { false, false, false };

        Launcher daneLauncher;

        public _01Piwnica(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;

            DoubleBuffered = true;

            this.Text = "TerrorOfDragons - " + daneLauncher.gameVersion;

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

            if (daneLauncher.daneMapa[1].częśćMapyOdwiedzona[0] == false)
            {
                if (daneLauncher.samouczek == true)
                {
                    pokazSamouczek[0] = true;
                }

                Muzyka metodaMuzyka = new Muzyka(daneLauncher);
                metodaMuzyka.Soundtrack("Soundtrack1.wav");

                daneLauncher.daneMapa[1].drop[0] = true;
            }

            #region UstawGracza
            if (daneLauncher.daneMapa[1].gdzieOstatnio == 1)
            {
                daneLauncher.daneGracz.obraz.Location = new Point(525, 22);
            }

            #endregion
            #region Przeszkody
            if (daneLauncher.daneMapa[daneLauncher.numerMapy].częśćMapyOdwiedzona[daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji] == false)
            {
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, false, beczka1, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 1));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, false, beczka2, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 2));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, false, beczka3, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 3));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, false, beczka4, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 4));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, false, beczka5, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 5));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, false, beczka6, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 6));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, false, beczka7, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 7));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, false, beczka8, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 8));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, beczki1, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 9));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, beczki2, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 10));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, ściana1, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 11));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, ściana2, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 12));
            }
            else
            {
                #region PonownePrzypisanieObrazków
                foreach (var indeks in daneLauncher.danePrzeszkoda.Where(x => x.numerMapy == daneLauncher.numerMapy & x.numerLokacji == daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji))
                {
                    switch (daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].numerObiektu)
                    {
                        case 1: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = beczka1; break;
                        case 2: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = beczka2; break;
                        case 3: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = beczka3; break;
                        case 4: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = beczka4; break;
                        case 5: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = beczka5; break;
                        case 6: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = beczka6; break;
                        case 7: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = beczka7; break;
                        case 8: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = beczka8; break;
                        case 9: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = beczki1; break;
                        case 10: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = beczki2; break;
                        case 11: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = ściana1; break;
                        case 12: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = ściana2; break;
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

            if (daneLauncher.daneMapa[1].drop[0] == true)
            {
                daneLauncher.daneDrop[0] = new Launcher.ZmienneEkwipunku();
                daneLauncher.daneDrop[0].exists = true;
                daneLauncher.daneDrop[0].obraz = drop0;
                daneLauncher.daneDrop[0].obraz.Visible = true;
                daneLauncher.daneDrop[0].id = 1;
                daneLauncher.daneDrop[0].miecz = true;
                daneLauncher.daneDrop[0].dmgZwarcie[0] = 3;
                daneLauncher.daneDrop[0].dmgZwarcie[1] = 5;
                daneLauncher.daneDrop[0].numerLokacji = daneLauncher.daneMapa[1].numerLokacji;
            }

            daneLauncher.daneStrzała[0].obraz = strzałaGracz;
            daneLauncher.daneStrzała[0].obraz.Visible = false;

            daneLauncher.rozdajStatystyki = rozdajStatystyki;
            daneLauncher.pokazNoweZadanie = pokazNoweZadanie;

            daneLauncher.daneMapa[1].częśćMapyOdwiedzona[daneLauncher.daneMapa[1].gdzieOstatnio = daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji] = true;
            daneLauncher.daneMapa[1].gdzieOstatnio = daneLauncher.daneMapa[1].gdzieOstatnio = daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji;

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

            foreach (var indeks in daneLauncher.danePrzeszkoda.Where(x => x.numerLokacji == daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji))
            {
                metodaPoruszanieSię.przeszkodaNaDrodze(daneLauncher.daneGracz, daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)]);
            }

            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerGraczMetoda();
        }

        private void timerAtakGracz_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerAtakGraczMetoda(timerGracz, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji);
        }

        private void timerStatystyki_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerStatystykiMetoda(this, timerGracz, timerAtakGracz, timerMob, timerAtakMob, timerNPC, timerStatystyki, labelHpGracz, labelManaGracz, labelLvGracz, labelExpGracz);

            if (daneLauncher.daneDrop[0].exists == false)
            {
                daneLauncher.daneMapa[1].drop[0] = false;
            }
            if (pokazSamouczek[0] == true)
            {
                Samouczek formaSamouczek = new Samouczek(daneLauncher);

                pokazSamouczek[0] = false;
                formaSamouczek.ShowDialog();
            }
        }

        private void timerStrzałaGracz_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerStrzałaGraczMetoda(0, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji);
        }
    }
}