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
using System.Reflection;
using System.Linq.Expressions;

namespace Unstable
{
    public partial class _01Parter : Form
    {
        List<PictureBox> przeszkody = new List<PictureBox>();
        List<PictureBox> alaButtons = new List<PictureBox>();
        List<Label> odpowiedzi = new List<Label>();
        bool[] koniecDialogu = new bool[20];
        bool cutScena = false;
        bool cutScenaBegin = false;

        Thread wątekCutScena;

        Launcher daneLauncher;

        public _01Parter(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;

            DoubleBuffered = true;

<<<<<<< HEAD
=======
            this.Text = "TerrorOfDragons - " + daneLauncher.gameVersion;

>>>>>>> refs/remotes/origin/Unstable1.1
            #region Test
            timerGracz.Interval = 1;

            #endregion
            #region WczytajDane
            daneLauncher.daneMapa[1].numerLokacji = 1;
            this.poleGry.Location = new System.Drawing.Point(3, -3);
            this.panelStatystyk.Location = new Point(3, 445);
            daneLauncher.daneGracz.obraz = gracz;
            daneLauncher.daneGracz.antyRozmycie = underGracz;
            daneLauncher.poleGry = poleGry;
            daneLauncher.hitLog = hitLog;

            if (daneLauncher.daneMapa[1].częśćMapyOdwiedzona[1] == false)
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
<<<<<<< HEAD

=======
            if (daneLauncher.daneMapa[1].gdzieOstatnio == 2)
            {
                daneLauncher.daneGracz.obraz.Location = new Point(700, 315);
            }
>>>>>>> refs/remotes/origin/Unstable1.1
            #endregion
            #region Przeszkody
            przeszkody.Add(beczka1);
            przeszkody.Add(beczka2);
            przeszkody.Add(beczka3);
            przeszkody.Add(beczki);
            przeszkody.Add(drzwiRightOpened);
            przeszkody.Add(ściana1);
            przeszkody.Add(ściana2);
            przeszkody.Add(ściana3);
            przeszkody.Add(stolik);

            for (int i = 12, j = 0; i <= 21; i++, j++)
            {
                if (j > 8) j = 8;
                if (daneLauncher.daneMapa[1].częśćMapyOdwiedzona[1] == false)
                {
                    daneLauncher.danePrzeszkoda[i].exists = true;
                }
                daneLauncher.danePrzeszkoda[i].obraz = przeszkody[j];
                if (daneLauncher.danePrzeszkoda[i].exists == false)
                {
                    daneLauncher.danePrzeszkoda[i].obraz.Visible = false;
                }
            }
            daneLauncher.daneMapa[1].częśćMapyOdwiedzona[1] = true;
            daneLauncher.daneMapa[1].gdzieOstatnio = 1;

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
                        przeszkody.Clear();
                        alaButtons.Clear();
                        odpowiedzi.Clear();
                        this.Close();
                        map_01Piwnica.Show();
                    }
                    if (daneLauncher.daneGracz.obraz.Bounds.IntersectsWith(wyjściePiętroPierwsze.Bounds))
                    {
                        daneLauncher.daneStrzała[0].obraz.Visible = false;
                        daneLauncher.daneStrzała[0].exists = false;
                        MapaTestowa map_01PiętroPierwsze = new MapaTestowa(daneLauncher);
                        przeszkody.Clear();
                        alaButtons.Clear();
                        odpowiedzi.Clear();
                        this.Close();
                        map_01PiętroPierwsze.Show();
                    }
                    if (daneLauncher.daneGracz.obraz.Bounds.IntersectsWith(wyjścieDziedziniec.Bounds))
                    {
                        daneLauncher.daneStrzała[0].obraz.Visible = false;
                        daneLauncher.daneStrzała[0].exists = false;
                        _01Dziedziniec map_01Dziedziniec = new _01Dziedziniec(daneLauncher);
                        przeszkody.Clear();
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
            for (int i = 12; i <= 21; i++)
            {
                metodaPoruszanieSię.przeszkodaNaDrodze(daneLauncher.daneGracz, daneLauncher.danePrzeszkoda[i]);
            }
            metodaMap.timerGraczMetoda();
        }

        private void timerAtakGracz_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerAtakGraczMetoda(timerGracz);
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
                for (int j = 0; j < 1; j++)
                {
                    for (int i = 12; i <= 21; i++)
                    {
                        metodaPoruszanieSię.przeszkodaNaDrodze(daneLauncher.daneNPC[0], daneLauncher.danePrzeszkoda[i]);
                    }
                    metodaMap.timerNPCMetoda(j);
                }
            }
        }

        private void timerStatystyki_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
<<<<<<< HEAD
            metodaMap.timerStatystykiMetoda(this, timerGracz, timerAtakGracz, timerMob, timerAtakMob, timerStatystyki, labelHpGracz, labelManaGracz, labelLvGracz, labelExpGracz);
=======
            metodaMap.timerStatystykiMetoda(this, timerGracz, timerAtakGracz, timerMob, timerAtakMob, timerNPC, timerStatystyki, labelHpGracz, labelManaGracz, labelLvGracz, labelExpGracz);
>>>>>>> refs/remotes/origin/Unstable1.1
        }

        private void timerStrzałaGracz_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerStrzałaGraczMetoda(0, 1, 12, 4, 16);
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

            string Tekst = "Co to za hałasy w piwnicy?! Kim jesteś i skąd się tu wziąłeś?! A z resztą,\nnie obchodzi mnie to. Powiedz mi tylko, czy nie uszkodziłeś moich beczek?";
            for (int i = 0; i < Tekst.Length; i++)
            {
                metodaUniwersalne.wait(0.03);
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
                Tekst = "Widzę już w Twoim spojrzeniu, że kłamiesz! Wynoś się stąd, ale już!\nZaraz... Chwila. Wieszczka mi to przepowiedziała! Powiedziała:\n\"Pewnego dnia pojawi się wśród twych beczek ten, którego\nmusisz wyprawić na wielką podróż\".";
                for (int i = 0; i < Tekst.Length; i++)
                {
                    metodaUniwersalne.wait(0.03);
                    Wątki.editInThread(this, Convert.ToString(Tekst[i]), value => labelDialogNPC.Text += value);
                }
            }
            if (daneLauncher.danoOdpowiedź3 == true)
            {
                daneLauncher.danoOdpowiedź3 = false;
                Tekst = "A niech Cię szlag parszywcu! Wynoś się stąd, ale już!\nZaraz... Chwila. Wieszczka mi to przepowiedziała! Powiedziała:\n\"Pewnego dnia pojawi się wśród twych beczek ten, którego\nmusisz wyprawić na wielką podróż\".";
                for (int i = 0; i < Tekst.Length; i++)
                {
                    metodaUniwersalne.wait(0.03);
                    Wątki.editInThread(this, Convert.ToString(Tekst[i]), value => labelDialogNPC.Text += value);
                }
            }
            metodaUniwersalne.wait(5);
            Wątki.editInThread(this, "", value => labelDialogNPC.Text = value);
            daneLauncher.danoOdpowiedź3 = false;
            Tekst = "Ona się nigdy nie myli... No chodź, rozruszasz się trochę przed wyprawą.";
            for (int i = 0; i < Tekst.Length; i++)
            {
                metodaUniwersalne.wait(0.03);
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
            daneLauncher.daneQuest[1].nazwa = "Pomoc winiarza";
            daneLauncher.daneQuest[1].exp = 5;
            daneLauncher.daneQuest[1].stan = 1;
            daneLauncher.daneQuest[1].etap = 1;
            daneLauncher.daneQuest[1].opisEtapu[1] = "Wyjdź na dziedziniec";
            cutScena = false;
        }

    }
}
