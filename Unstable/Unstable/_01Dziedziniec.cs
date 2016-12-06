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
    public partial class _01Dziedziniec : Form
    {
        List<PictureBox> alaButtons = new List<PictureBox>();
        List<Label> odpowiedzi = new List<Label>();
        bool[] koniecDialogu = new bool[20];
        bool cutScena = false;
        bool cutScenaBegin = false;

        Thread wątekCutScena;

        Launcher daneLauncher;

        public _01Dziedziniec(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;

            DoubleBuffered = true;

            this.Text = "TerrorOfDragons - " + daneLauncher.gameVersion;

            daneLauncher.numerMapy = 1;

            #region Test
            timerGracz.Interval = 1;

            #endregion
            #region WczytajDane
            daneLauncher.daneMapa[1].numerLokacji = 2;
            this.poleGry.Location = new System.Drawing.Point(3, -3);
            this.panelStatystyk.Location = new Point(3, 445);
            daneLauncher.daneGracz.obraz = gracz;
            daneLauncher.daneGracz.antyRozmycie = underGracz;
            daneLauncher.poleGry = poleGry;
            daneLauncher.hitLog = hitLog;

            if(daneLauncher.daneQuest[2].etap<2)
            {
                daneLauncher.daneNPC[0].obraz = Perqun;
                daneLauncher.daneNPC[0].antyRozmycie = underPerqun;
                daneLauncher.daneNPC[0].exists = true;
            }
            else
            {
                Perqun.Visible = false;
                Launcher.ZmiennePostaci resetuj = new Launcher.ZmiennePostaci();
                daneLauncher.daneNPC[0] = resetuj;
            }
                

            if (daneLauncher.daneQuest[1].etap == 1 | daneLauncher.daneQuest[1].etap == 2)
            {
                daneLauncher.daneMob[0].obraz = kukła;
                daneLauncher.daneMob[0].obraz.Visible = true;
                daneLauncher.daneMob[0].exists = true;
                daneLauncher.daneMob[0].lv = 0;
                daneLauncher.daneMob[0].hp = daneLauncher.daneMob[0].hpMax = 100;
                daneLauncher.daneMob[0].labelhp = labelHpMob0;
                daneLauncher.daneMob[0].labelhp.Visible = true;
            }
            else
            {
                kukła.Visible = false;
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

            if (daneLauncher.daneQuest[1].etap==1 | daneLauncher.daneQuest[1].etap==4)
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
            if (daneLauncher.daneMapa[1].gdzieOstatnio == 1)
            {
                daneLauncher.daneGracz.obraz.Location = new Point(30, 262);
            }

            #endregion
            #region Przeszkody
            if (daneLauncher.daneMapa[daneLauncher.numerMapy].częśćMapyOdwiedzona[daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji] == false)
            {
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, krzak1, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 1));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, krzak2, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 2));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, krzak3, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 3));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, głaz, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 4));
                daneLauncher.danePrzeszkoda.Add(new Launcher.ZmienneObiektów(true, true, blokada, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji, 5));
            }
            else
            {
                #region PonownePrzypisanieObrazków
                foreach (var indeks in daneLauncher.danePrzeszkoda.Where(x => x.numerMapy == daneLauncher.numerMapy & x.numerLokacji == daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji))
                {
                    switch (daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].numerObiektu)
                    {
                        case 1: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = krzak1; break;
                        case 2: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = krzak2; break;
                        case 3: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = krzak3; break;
                        case 4: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = głaz; break;
                        case 5: daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz = blokada; break;
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
            if (cutScena == false)
            {
                metodaMap.KeyDownMetoda(this, e);
                if (e.KeyCode == Keys.Z)
                {
                    if (daneLauncher.daneGracz.obraz.Bounds.IntersectsWith(wyjścieParter.Bounds) & this.Visible == true)
                    {
                        daneLauncher.daneStrzała[0].obraz.Visible = false;
                        daneLauncher.daneStrzała[0].exists = false;
                        _01Parter map_01Parter = new _01Parter(daneLauncher);
                        alaButtons.Clear();
                        odpowiedzi.Clear();
                        this.Close();
                        map_01Parter.Show();
                    }
                }
                if (e.KeyCode == Keys.Z)
                {
                    if (daneLauncher.daneGracz.obraz.Bounds.IntersectsWith(drogowskaz.Bounds) & this.Visible==true)
                    {
                        MapaTestowa mapMapaTestowa = new MapaTestowa(daneLauncher);
                        mapMapaTestowa.Show();
                        this.Close();
                        /*
                        KoniecTestu formaKoniecTestu = new KoniecTestu(daneLauncher, this);
                        daneLauncher.daneGracz.exists = false;
                        daneLauncher.music.Ctlcontrols.stop();
                        daneLauncher.soundGracz.URL = "lvUp.wav";
                        timerGracz.Enabled = timerAtakGracz.Enabled = timerMob.Enabled = timerAtakMob.Enabled = timerNPC.Enabled = timerStatystyki.Enabled = false;
                        formaKoniecTestu.ShowDialog(); */
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
                metodaNPC.MoveToX(daneLauncher.daneGracz, 230);
                metodaNPC.MoveToY(daneLauncher.daneGracz, 262);
                if (cutScenaBegin == false)
                {
                    if (daneLauncher.daneGracz.dotartoDoX[0] == true & daneLauncher.daneQuest[1].etap == 1)
                    {
                        wątekCutScena = new Thread(wykonajCutScena1);
                        wątekCutScena.Start();
                    }
                    if (daneLauncher.daneGracz.dotartoDoX[0] == true & daneLauncher.daneQuest[1].etap == 4)
                    {
                        wątekCutScena = new Thread(wykonajCutScena3);
                        wątekCutScena.Start();
                    }
                }
                
            }

            metodaPoruszanieSię.przeszkodaNaDrodze(daneLauncher.daneGracz, daneLauncher.daneNPC[0]);
            metodaPoruszanieSię.przeszkodaNaDrodze(daneLauncher.daneGracz, daneLauncher.daneMob[0]);
            foreach (var indeks in daneLauncher.danePrzeszkoda.Where(x => x.numerLokacji == daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji))
            {
                metodaPoruszanieSię.przeszkodaNaDrodze(daneLauncher.daneGracz, daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)]);
            }
            metodaMap.timerGraczMetoda();
        }

        private void timerAtakGracz_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerAtakGraczMetoda(timerGracz, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji);
        }

        private void timerNPC_Tick(object sender, EventArgs e)
        {
            PoruszanieSię metodaPoruszanieSię = new PoruszanieSię(daneLauncher);
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            NPC metodaNPC = new NPC(daneLauncher);

            if (daneLauncher.daneNPC[0].exists == true)
            {
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
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);

            metodaMap.timerStatystykiMetoda(this, timerGracz, timerAtakGracz, timerMob, timerAtakMob, timerNPC, timerStatystyki, labelHpGracz, labelManaGracz, labelLvGracz, labelExpGracz);
            labelHpMob0.Text = Convert.ToString(metodaUniwersalne.wyliczProcent(daneLauncher.daneMob[0].hp, daneLauncher.daneMob[0].hpMax) + "%");

            if(daneLauncher.daneMob[0].exists==false & daneLauncher.daneQuest[1].etap==2)
            {
                #region PrzygotowanieDoCutSceny
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

                #endregion
                cutScena = true;
                daneLauncher.daneQuest[1].stan = 1;
                daneLauncher.daneQuest[1].etap = 3;
                daneLauncher.daneQuest[1].opisEtapu[3] = "Idź na pierwsze piętro wieży po łuk.";
                daneLauncher.noweGlowneZadanie = true;
                wątekCutScena = new Thread(wykonajCutScena2);
                wątekCutScena.Start();
            }
        }

        private void timerStrzałaGracz_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerStrzałaGraczMetoda(1, daneLauncher.numerMapy, daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji);

            if(daneLauncher.daneStrzała[0].obraz.Bounds.IntersectsWith(głaz.Bounds))
            {
                foreach(var indeks in daneLauncher.danePrzeszkoda.Where(x => x.obraz.Image == blokada.Image))
                {
                    daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].exists = false;
                    daneLauncher.danePrzeszkoda[daneLauncher.danePrzeszkoda.IndexOf(indeks)].obraz.Visible = false;
                }
                if(daneLauncher.daneQuest[1].stan == 1)
                {
                    daneLauncher.daneQuest[1].stan = 2;
                    daneLauncher.daneQuest[1].etap = 5;
                    daneLauncher.daneQuest[1].opisEtapu[5] = "Zakończono";
                    daneLauncher.daneGracz.exp += daneLauncher.daneQuest[1].exp;
                    daneLauncher.daneQuest[2].nazwa = "Miasto Winczewo";
                    daneLauncher.daneQuest[2].stan = 1;
                    daneLauncher.daneQuest[2].etap = 1;
                    daneLauncher.daneQuest[2].opisEtapu[1] = "Udaj się do miasta Winczewo";
                    daneLauncher.daneQuest[2].exp = 5;
                    daneLauncher.noweGlowneZadanie = true;
                }     
            }
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

            string Tekst = "Widzę, że znalazłeś mój stary miecz. Możesz go sobie zatrzymać.\nZobaczymy, czy potrafisz coś więcej, poza rozwalaniem moich beczek.\nRozruszaj trochę tę kukłę.";
            for (int i = 0; i < Tekst.Length; i++)
            {
                metodaUniwersalne.wait(0.02);
                Wątki.editInThread(this, Convert.ToString(Tekst[i]), value => labelDialogNPC.Text += value);
            }
            while (daneLauncher.danoOdpowiedź3 == false)
            {
                Wątki.editInThread(this, "Ruszam.", value => odpowiedź3.Text = value);
                Wątki.editInThread(this, true, value => alaButtons[3].Visible = value);
                Wątki.editInThread(this, true, value => odpowiedzi[3].Visible = value);
            }
            daneLauncher.danoOdpowiedź3 = false;
            Wątki.editInThread(this, "", value => labelDialogNPC.Text = value);
            Wątki.editInThread(this, false, value => alaButtons[3].Visible = value);
            Wątki.editInThread(this, false, value => odpowiedzi[3].Visible = value);
            Wątki.editInThread(this, false, value => panelDialogu.Visible = value);
            Wątki.editInThread(this, true, value => panelStatystyk.Visible = value);
            daneLauncher.daneGracz.up = daneLauncher.daneGracz.down = daneLauncher.daneGracz.left = daneLauncher.daneGracz.right = false;
            daneLauncher.daneQuest[1].stan = 1;
            daneLauncher.daneQuest[1].etap = 2;
            daneLauncher.daneQuest[1].opisEtapu[2] = "Zniszcz kukłę";
            daneLauncher.noweGlowneZadanie = true;
            cutScena = false;
        }

        private void wykonajCutScena2()
        {
            cutScenaBegin = true;
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);

            Wątki.editInThread(this, true, value => labelDialogNPC.Visible = value);

            string Tekst = "Mieczem władasz nienajgorzej. Hmm...\nOstatnio znalazłem stary łuk, jest na pierwszym piętrze.\nIdź po niego. Masz tutaj klucz otwierający kratę.";
            for (int i = 0; i < Tekst.Length; i++)
            {
                metodaUniwersalne.wait(0.02);
                Wątki.editInThread(this, Convert.ToString(Tekst[i]), value => labelDialogNPC.Text += value);
            }
            while (daneLauncher.danoOdpowiedź3 == false)
            {
                Wątki.editInThread(this, "Ruszam.", value => odpowiedź3.Text = value);
                Wątki.editInThread(this, true, value => alaButtons[3].Visible = value);
                Wątki.editInThread(this, true, value => odpowiedzi[3].Visible = value);
            }
            daneLauncher.danoOdpowiedź3 = false;
            Wątki.editInThread(this, "", value => labelDialogNPC.Text = value);
            Wątki.editInThread(this, false, value => alaButtons[3].Visible = value);
            Wątki.editInThread(this, false, value => odpowiedzi[3].Visible = value);
            Wątki.editInThread(this, false, value => panelDialogu.Visible = value);
            Wątki.editInThread(this, true, value => panelStatystyk.Visible = value);
            daneLauncher.daneGracz.up = daneLauncher.daneGracz.down = daneLauncher.daneGracz.left = daneLauncher.daneGracz.right = false;

            daneLauncher.daneDrop[1].exists = true;
            daneLauncher.daneDrop[1].id = 9;
            daneLauncher.daneDrop[1].fabularny = true;
            daneLauncher.daneDrop[1].obraz = daneLauncher.KluczNaPierwszePiętroWieżyPerquna;
            MetodyEkwipunek metodaEkwipunek = new MetodyEkwipunek(daneLauncher);
            metodaEkwipunek.DodajFabularnyItem();
            cutScena = false;
        }

        private void wykonajCutScena3()
        {
            cutScenaBegin = true;
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);

            Wątki.editInThread(this, true, value => labelDialogNPC.Visible = value);

            string Tekst = "Dostałeś ode mnie miecz i łuk. Wyprawiłem Cię w podróż, tak jak kazała mi wieszczka. Strzel z łuku w tamten głaz, a otworzy się przejście. Na Twoim miejscu udałbym się do miasta Winczewa. Szerokiej drogi.";
            for (int i = 0; i < Tekst.Length; i++)
            {
                metodaUniwersalne.wait(0.02);
                Wątki.editInThread(this, Convert.ToString(Tekst[i]), value => labelDialogNPC.Text += value);
            }
            while (daneLauncher.danoOdpowiedź3 == false)
            {
                Wątki.editInThread(this, "Ruszam.", value => odpowiedź3.Text = value);
                Wątki.editInThread(this, true, value => alaButtons[3].Visible = value);
                Wątki.editInThread(this, true, value => odpowiedzi[3].Visible = value);
            }
            daneLauncher.danoOdpowiedź3 = false;
            Wątki.editInThread(this, "", value => labelDialogNPC.Text = value);
            Wątki.editInThread(this, false, value => alaButtons[3].Visible = value);
            Wątki.editInThread(this, false, value => odpowiedzi[3].Visible = value);
            Wątki.editInThread(this, false, value => panelDialogu.Visible = value);
            Wątki.editInThread(this, true, value => panelStatystyk.Visible = value);
            daneLauncher.daneGracz.up = daneLauncher.daneGracz.down = daneLauncher.daneGracz.left = daneLauncher.daneGracz.right = false;
            daneLauncher.daneQuest[1].stan = 1;
            daneLauncher.daneQuest[1].etap = 5;
            daneLauncher.daneQuest[1].opisEtapu[5] = "Strzel z łuku w głaz";
            daneLauncher.noweGlowneZadanie = true;
            cutScena = false;
        }
    }
}
