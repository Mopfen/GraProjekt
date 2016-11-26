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
        List<PictureBox> przeszkody = new List<PictureBox>();
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

            if (daneLauncher.daneMapa[1].częśćMapyOdwiedzona[2] == false)
            {
                daneLauncher.daneNPC[0].obraz = Perqun;
                daneLauncher.daneNPC[0].antyRozmycie = underPerqun;
                daneLauncher.daneNPC[0].exists = true;

                daneLauncher.daneMob[0].obraz = kukła;
                daneLauncher.daneMob[0].obraz.Visible = true;
                daneLauncher.daneMob[0].exists = true;
                daneLauncher.daneMob[0].hp = daneLauncher.daneMob[0].hpMax = 100;
                daneLauncher.daneMob[0].labelhp = labelHpMob0;
                daneLauncher.daneMob[0].labelhp.Visible = true;
            }
            else
            {
                Perqun.Visible = false;
                Launcher.ZmiennePostaci resetuj = new Launcher.ZmiennePostaci();
                daneLauncher.daneNPC[0] = resetuj;
            }

            #region cutScena
            #region przypisanieDoList
            alaButtons.Add(alaButtonOdpowiedź1);
            alaButtons.Add(alaButtonOdpowiedź2);
            alaButtons.Add(alaButtonOdpowiedź3);
            odpowiedzi.Add(odpowiedź1);
            odpowiedzi.Add(odpowiedź2);
            odpowiedzi.Add(odpowiedź3);

            #endregion

            if (daneLauncher.daneQuest[1].etap==1)
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
            przeszkody.Add(krzak1);
            przeszkody.Add(krzak2);
            przeszkody.Add(krzak3);
            przeszkody.Add(głaz);

            for (int i = 22, j = 0; i <= 25; i++, j++)
            {
                if (j > 3) j = 2;
                if (daneLauncher.daneMapa[1].częśćMapyOdwiedzona[2] == false)
                {
                    daneLauncher.danePrzeszkoda[i].exists = true;
                }
                daneLauncher.danePrzeszkoda[i].obraz = przeszkody[j];
                if (daneLauncher.danePrzeszkoda[i].exists == false)
                {
                    daneLauncher.danePrzeszkoda[i].obraz.Visible = false;
                }
            }
            daneLauncher.daneMapa[1].częśćMapyOdwiedzona[2] = true;
            daneLauncher.daneMapa[1].gdzieOstatnio = 2;

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
                    if (daneLauncher.daneGracz.obraz.Bounds.IntersectsWith(wyjścieParter.Bounds))
                    {
                        daneLauncher.daneStrzała[0].obraz.Visible = false;
                        daneLauncher.daneStrzała[0].exists = false;
                        _01Parter map_01Parter = new _01Parter(daneLauncher);
                        przeszkody.Clear();
                        alaButtons.Clear();
                        odpowiedzi.Clear();
                        this.Close();
                        map_01Parter.Show();
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
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            NPC metodaNPC = new NPC(daneLauncher);

            if (cutScena == true)
            {
                //metodaNPC.MoveToY(daneLauncher.daneGracz, 166);
            }

            metodaUniwersalne.przeszkodaNaDrodze(daneLauncher.daneGracz, daneLauncher.daneNPC[0]);
            metodaUniwersalne.przeszkodaNaDrodze(daneLauncher.daneGracz, daneLauncher.daneMob[0]);
            for (int i = 22; i <= 25; i++)
            {
                metodaUniwersalne.przeszkodaNaDrodze(daneLauncher.daneGracz, daneLauncher.danePrzeszkoda[i]);
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
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            NPC metodaNPC = new NPC(daneLauncher);

            if (daneLauncher.daneNPC[0].exists == true)
            {
                /*if (daneLauncher.daneNPC[0].dotartoDoX[1] == true)
                {
                    if (cutScenaBegin == false)
                    {
                        //wątekCutScena = new Thread(wykonajCutScena1);
                        //wątekCutScena.Start();
                    }
                }

                metodaNPC.MoveToXX(daneLauncher.daneNPC[0], 350, 260);
                if (daneLauncher.daneNPC[0].dotartoDoX[0] == true)
                {
                    metodaNPC.MoveToY(daneLauncher.daneNPC[0], 166);
                }
                */

                metodaUniwersalne.przeszkodaNaDrodze(daneLauncher.daneNPC[0], daneLauncher.daneGracz);
                for (int j = 0; j < 1; j++)
                {
                    for (int i = 12; i <= 21; i++)
                    {
                        metodaUniwersalne.przeszkodaNaDrodze(daneLauncher.daneNPC[0], daneLauncher.danePrzeszkoda[i]);
                    }
                    metodaMap.timerNPCMetoda(j);
                }
            }
        }

        private void timerStatystyki_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);


            metodaMap.timerStatystykiMetoda(this, timerGracz, timerAtakGracz, timerMob, timerAtakMob, timerStatystyki, labelHpGracz, labelManaGracz, labelLvGracz, labelExpGracz);
            labelHpMob0.Text = Convert.ToString(metodaUniwersalne.wyliczProcent(daneLauncher.daneMob[0].hp, daneLauncher.daneMob[0].hpMax) + "%");
        }

        private void timerStrzałaGracz_Tick(object sender, EventArgs e)
        {
            MetodyMap metodaMap = new MetodyMap(daneLauncher);
            metodaMap.timerStrzałaGraczMetoda(1, 0, 0, 4, 22);
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
    }
}
