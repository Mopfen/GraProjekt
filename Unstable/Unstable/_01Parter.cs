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
using System.Reflection;
using System.Linq.Expressions;

namespace Unstable
{
    /// <summary>
    /// Odpowiada za działanie lokacji Parter (mapa1)
    /// </summary>
    public partial class _01Parter : Form
    {
        List<PictureBox> alaButtons = new List<PictureBox>();
        List<Label> odpowiedzi = new List<Label>();
        bool[] koniecDialogu = new bool[20];
        bool cutScena = false;
        bool cutScenaBegin = false;
        bool dostępNaPierwszePiętro = false;
        bool pokazSamouczekNoweZadanie = false;

        Thread wątekCutScena;

        /// <summary> 
        /// Pole umożliwia dostęp do danych zawartych w klasie Launcher.
        /// </summary>
        Launcher daneLauncher;

        public _01Parter(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;

            DoubleBuffered = true;

            this.Text = "TerrorOfDragons - " + daneLauncher.gameVersion;

            #region Test
            //timerGracz.Interval = 1;

            #endregion
            #region WczytajDane
            daneLauncher.daneMapa[1].numerLokacji = 1;
            this.poleGry.Location = new System.Drawing.Point(3, -3);
            this.panelStatystyk.Location = new Point(3, 445);
            daneLauncher.daneGracz.obraz = gracz;
            daneLauncher.daneGracz.antyRozmycie = underGracz;
            daneLauncher.poleGry = poleGry;
            daneLauncher.hitLog = hitLog;
            daneLauncher.używanaBroń = używanaBroń;

            if (daneLauncher.daneMapa[1].częśćMapyOdwiedzona[1] == false)
            {
                daneLauncher.daneNPC[0].bazowyObraz.Image = daneLauncher.PerqunStand.Image;
                daneLauncher.daneNPC[0].obraz = Perqun;
                daneLauncher.daneNPC[0].antyRozmycie = underPerqun;
                daneLauncher.daneNPC[0].exists = true;

                daneLauncher.daneMapa[1].misjaFabularnaWykonana.Add(false);
            }
            else
            {
                Perqun.Visible = false;
                Launcher.ZmiennePostaci resetuj = new Launcher.ZmiennePostaci();
                daneLauncher.daneNPC[0] = resetuj;

                if(daneLauncher.daneMapa[1].misjaFabularnaWykonana[0]==true)
                {
                    poleGry.BackgroundImage = global::Unstable.Properties.Resources._01Parter;
                    dostępNaPierwszePiętro = true;
                }
            }

            #region cutScena
            #region przypisanieDoList
            alaButtons.Add(null);
            alaButtons.Add(alaButtonOdpowiedź1);
            alaButtons.Add(alaButtonOdpowiedź2);
            alaButtons.Add(alaButtonOdpowiedź3);
            odpowiedzi.Add(null);
            odpowiedzi.Add(odpowiedź1);
            odpowiedzi.Add(odpowiedź2);
            odpowiedzi.Add(odpowiedź3);

            #endregion

            if (daneLauncher.daneNPC[0].exists == true)
            {
                cutScena = true;
            }
            if (cutScena == true)
            {
                labelDialogNPC.Text = "";
                labelDialogNPC.Visible = false;
                alaButtonOdpowiedź1.Visible = false;
                alaButtonOdpowiedź2.Visible = false;
                alaButtonOdpowiedź3.Visible = false;
                odpowiedź1.Visible = false;
                odpowiedź2.Visible = false;
                odpowiedź3.Visible = false;
                panelStatystyk.Visible = false;
                panelDialogu.Visible = true;
            }

            #endregion
            #region UstawGracza
            if (daneLauncher.daneMapa[1].gdzieOstatnio == 0)
            {
                daneLauncher.daneGracz.obraz.Location = new Point(198, 40);
            }
            if (daneLauncher.daneMapa[1].gdzieOstatnio == 2)
            {
                daneLauncher.daneGracz.obraz.Location = new Point(700, 315);
            }
            if (daneLauncher.daneMapa[1].gdzieOstatnio == 3)
            {
                daneLauncher.daneGracz.obraz.Location = new Point(110, 40);
            }
            #endregion
            #region Przeszkody
            if (daneLauncher.daneMapa[daneLauncher.numerMapy].częśćMapyOdwiedzona[daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji] == false)
            {
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, false, beczka1, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji,1));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, beczka2, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji,2));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, beczka3, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji,3));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, beczki, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji,4));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, drzwiRightOpened, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji,5));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, ściana1, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji,6));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, ściana2, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji,7));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, ściana3, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji,8));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, stolik, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji,9));
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
                        case 4: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = beczki; break;
                        case 5: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = drzwiRightOpened; break;
                        case 6: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = ściana1; break;
                        case 7: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = ściana2; break;
                        case 8: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = ściana3; break;
                        case 9: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = stolik; break;
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
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            Statystyki formaStatystyki = new Statystyki(daneLauncher);
            metodaUniwersalne.zatrzymajTimery();
            formaStatystyki.ShowDialog();
        }

        private void pokazNoweZadanie_Click(object sender, EventArgs e)
        {
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            Zadania formaZadania = new Zadania(daneLauncher);
            metodaUniwersalne.zatrzymajTimery();
            formaZadania.ShowDialog();
        }

        private void TheKeyDown(object sender, KeyEventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            if (cutScena == false)
            {
                metodaMap.KeyDownMetoda(this, e);
                if (e.KeyCode == Keys.Z)
                {
                    if (daneLauncher.daneGracz.obraz.Bounds.IntersectsWith(wyjściePiwnica.Bounds))
                    {
                        daneLauncher.daneStrzała[0].obraz.Visible = false;
                        daneLauncher.daneStrzała[0].exists = false;
                        _01Piwnica map_01Piwnica = new _01Piwnica(daneLauncher);
                        alaButtons.Clear();
                        odpowiedzi.Clear();
                        this.Close();
                        map_01Piwnica.Show();
                    }
                    if (daneLauncher.daneGracz.obraz.Bounds.IntersectsWith(wyjściePiętroPierwsze.Bounds))
                    { 
                        if (dostępNaPierwszePiętro == true)
                        {
                            daneLauncher.daneStrzała[0].obraz.Visible = false;
                            daneLauncher.daneStrzała[0].exists = false;
                            _01PiętroPierwsze map_01PiętroPierwsze = new _01PiętroPierwsze(daneLauncher);
                            alaButtons.Clear();
                            odpowiedzi.Clear();
                            this.Close();
                            map_01PiętroPierwsze.Show();
                        }
                        else
                        {
                            MetodyEkwipunek metodaEkwipunek = new MetodyEkwipunek(daneLauncher);
                            if(metodaEkwipunek.użyjFabularnegoItemu(9)==true)
                            {
                                poleGry.BackgroundImage = global::Unstable.Properties.Resources._01Parter;
                                daneLauncher.daneMapa[1].misjaFabularnaWykonana[0] = true;
                                dostępNaPierwszePiętro = true;
                            }
                        }
                        
                    }
                    if (daneLauncher.daneGracz.obraz.Bounds.IntersectsWith(wyjścieDziedziniec.Bounds))
                    {
                        daneLauncher.daneStrzała[0].obraz.Visible = false;
                        daneLauncher.daneStrzała[0].exists = false;
                        _01Dziedziniec map_01Dziedziniec = new _01Dziedziniec(daneLauncher);
                        alaButtons.Clear();
                        odpowiedzi.Clear();
                        this.Close();
                        map_01Dziedziniec.Show();
                    }
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
            NPC metodaNPC = new NPC(daneLauncher);

            if (cutScena == true)
            {
                metodaNPC.MoveToY(daneLauncher.daneGracz, 166);
            }

            metodaPoruszanieSię.przeszkodaNaDrodze(daneLauncher.daneGracz, daneLauncher.daneNPC[0]);
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

        private void timerNPC_Tick(object sender, EventArgs e)
        {
            PoruszanieSię metodaPoruszanieSię = new PoruszanieSię(daneLauncher);
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            NPC metodaNPC = new NPC(daneLauncher);

           
            if (daneLauncher.daneNPC[0].exists == true)
            {
                if (daneLauncher.daneNPC[0].dotartoDoX[1] == true)
                {
                    if (cutScenaBegin == false)
                    {
                        wątekCutScena = new Thread(wykonajCutScena1);
                        wątekCutScena.Start();
                    }
                }

                if (cutScena == true)
                {
                    metodaNPC.MoveToXX(daneLauncher.daneNPC[0], 350, 260);
                    if (daneLauncher.daneNPC[0].dotartoDoX[0] == true)
                    {
                        metodaNPC.MoveToY(daneLauncher.daneNPC[0], 166);
                    }
                }
                else
                {
                    metodaNPC.MoveToY(daneLauncher.daneNPC[0], 316);
                    metodaNPC.MoveToX(daneLauncher.daneNPC[0], 700);
                    if(daneLauncher.daneNPC[0].obraz.Bounds.IntersectsWith(wyjścieDziedziniec.Bounds))
                    {
                        daneLauncher.daneNPC[0].exists = false;
                        daneLauncher.daneNPC[0].obraz.Visible = false;
                        daneLauncher.daneNPC[0].up = daneLauncher.daneNPC[0].down = daneLauncher.daneNPC[0].left = daneLauncher.daneNPC[0].right = false;
                    }
                }

                metodaPoruszanieSię.przeszkodaNaDrodze(daneLauncher.daneNPC[0], daneLauncher.daneGracz);
                
                foreach (var indeks in daneLauncher.danePrzeszkoda.Where(x => x.numerLokacji == daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji))
                {
                    metodaPoruszanieSię.przeszkodaNaDrodze(daneLauncher.daneNPC[0], daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)]);
                }
                metodaMap.timerNPCMetoda(0);
            }
        }

        private void timerStatystyki_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerStatystykiMetoda(this, timerGracz, timerAtakGracz, timerMob, timerAtakMob, timerNPC, timerStatystyki, labelHpGracz, labelManaGracz, labelLvGracz, labelExpGracz);

            if(pokazSamouczekNoweZadanie == true & daneLauncher.samouczek == true)
            {
                pokazSamouczekNoweZadanie = false;
                Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
                metodaUniwersalne.zatrzymajTimery();

                daneLauncher.samouczekObrazDemonstracyjny.Image = global::Unstable.Properties.Resources.SamouczekNoweZadanie;
                daneLauncher.samouczekObrazKlawiszy.Image = global::Unstable.Properties.Resources.MyszSamouczekNoweZadanie;
                daneLauncher.samouczekInstrukcja = "Aby zobaczyć zaaktualizowaną listę misji, wciśnij wykrzynik w prawym dolnym rogu (lub \"Q\").";
                daneLauncher.samouczekInfo = "Gdy otrzymasz nowe zadanie lub zaaktualizujesz bierzące, pojawi się o tym informacja w postaci wykrzyknika w prawym dolnym rogu. Kliknięcie go pokaże Ci, o jakie zadanie konkretnie chodzi.";

                Samouczek formaSamouczek = new Samouczek(daneLauncher);
                formaSamouczek.ShowDialog();
            }
        }

        private void timerStrzałaGracz_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerStrzałaGraczMetoda(0, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji);
        }


        private void alaButtonOdpowiedź1_Click(object sender, EventArgs e)
        {
            daneLauncher.danoOdpowiedź1 = true;

        }

        private void alaButtonOdpowiedź2_Click(object sender, EventArgs e)
        {
            daneLauncher.danoOdpowiedź2 = true;
        }

        private void alaButtonOdpowiedź3_Click(object sender, EventArgs e)
        {
            daneLauncher.danoOdpowiedź3 = true;
        }


        private void wykonajCutScena1()
        {
            cutScenaBegin = true;
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);

            Wątki.editInThread(this, true, value => labelDialogNPC.Visible = value);

            string Tekst = "Co to za hałasy w piwnicy?! Kim jesteś i skąd się tu wziąłeś?! A z resztą, nie obchodzi mnie to. Powiedz mi tylko, czy nie uszkodziłeś moich beczek?";
            for (int i = 0; i < Tekst.Length; i++)
            {
                metodaUniwersalne.wait(0.02);
                Wątki.editInThread(this, Convert.ToString(Tekst[i]), value => labelDialogNPC.Text += value);
            }
            while(daneLauncher.danoOdpowiedź1==false & daneLauncher.danoOdpowiedź2 == false & daneLauncher.danoOdpowiedź3 == false)
            {
                Wątki.editInThread(this, "Ymm... Nie uszkodziłem.", value => odpowiedź2.Text = value);
                Wątki.editInThread(this, "Niestety, ale uszkodziłem kilka z nich.", value => odpowiedź3.Text = value);
                for (int i = 2; i <= 3; i++)
                {
                    Wątki.editInThread(this, true, value => alaButtons[i].Visible = value);
                    Wątki.editInThread(this, true, value => odpowiedzi[i].Visible = value);
                }
            }
            for (int i = 2; i <= 3; i++)
            {
                Wątki.editInThread(this, "", value => labelDialogNPC.Text = value);
                Wątki.editInThread(this, false, value => alaButtons[i].Visible = value);
                Wątki.editInThread(this, false, value => odpowiedzi[i].Visible = value);
            }
            if (daneLauncher.danoOdpowiedź2 == true)
            {
                daneLauncher.danoOdpowiedź2 = false;
                Tekst = "Widzę już w Twoim spojrzeniu, że kłamiesz! Wynoś się stąd, ale już! Zaraz... Chwila. Wieszczka mi to przepowiedziała! Powiedziała: \"Pewnego dnia pojawi się wśród twych beczek ten, którego musisz wyprawić na wielką podróż\".";
                for (int i = 0; i < Tekst.Length; i++)
                {
                    metodaUniwersalne.wait(0.02);
                    Wątki.editInThread(this, Convert.ToString(Tekst[i]), value => labelDialogNPC.Text += value);
                }
            }
            if (daneLauncher.danoOdpowiedź3 == true)
            {
                daneLauncher.danoOdpowiedź3 = false;
                Tekst = "A niech Cię szlag parszywcu! Wynoś się stąd, ale już! Zaraz... Chwila. Wieszczka mi to przepowiedziała! Powiedziała: \"Pewnego dnia pojawi się wśród twych beczek ten, którego musisz wyprawić na wielką podróż\".";
                for (int i = 0; i < Tekst.Length; i++)
                {
                    metodaUniwersalne.wait(0.02);
                    Wątki.editInThread(this, Convert.ToString(Tekst[i]), value => labelDialogNPC.Text += value);
                }
            }
            while (daneLauncher.danoOdpowiedź3 == false)
            {
                Wątki.editInThread(this, "Dalej", value => odpowiedź3.Text = value);
                Wątki.editInThread(this, true, value => alaButtons[3].Visible = value);
                Wątki.editInThread(this, true, value => odpowiedzi[3].Visible = value);
                Wątki.editInThread(this, new Point(600, 87), value => alaButtons[3].Location = value);
                Wątki.editInThread(this, new Point(626, 87), value => odpowiedzi[3].Location = value);
            }
            Wątki.editInThread(this, false, value => alaButtons[3].Visible = value);
            Wątki.editInThread(this, false, value => odpowiedzi[3].Visible = value);
            Wątki.editInThread(this, new Point(157, 87), value => alaButtons[3].Location = value);
            Wątki.editInThread(this, new Point(183, 84), value => odpowiedzi[3].Location = value);
            daneLauncher.danoOdpowiedź3 = false;
            Wątki.editInThread(this, "", value => labelDialogNPC.Text = value);
            daneLauncher.danoOdpowiedź3 = false;
            Tekst = "Ona się nigdy nie myli... No chodź, rozruszasz się trochę przed wyprawą.";
            for (int i = 0; i < Tekst.Length; i++)
            {
                metodaUniwersalne.wait(0.02);
                Wątki.editInThread(this, Convert.ToString(Tekst[i]), value => labelDialogNPC.Text += value);
            }
            Wątki.editInThread(this, "Wyjdź", value => odpowiedź1.Text = value);
            Wątki.editInThread(this, true, value => alaButtonOdpowiedź1.Visible = value);
            Wątki.editInThread(this, true, value => odpowiedź1.Visible = value);
            while(daneLauncher.danoOdpowiedź1==false) { }
            daneLauncher.danoOdpowiedź1 = false;

            Wątki.editInThread(this, false, value => panelDialogu.Visible = value);
            Wątki.editInThread(this, true, value => panelStatystyk.Visible = value);
            daneLauncher.daneGracz.down = daneLauncher.daneGracz.up = false;
            daneLauncher.daneQuest[1].nazwa = "Pomoc Winiarza";
            daneLauncher.daneQuest[1].exp = 5;
            daneLauncher.daneQuest[1].stan = 1;
            daneLauncher.daneQuest[1].etap = 1;
            daneLauncher.daneQuest[1].opisEtapu[1] = "Wyjdź na dziedziniec";
            daneLauncher.noweGlowneZadanie = true;
            cutScena = false;
            pokazSamouczekNoweZadanie = true;
        }

    }
}
