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
    public partial class Ekwipunek : Form
    {
        private bool[] ruchPlecakSlot = new bool[47];
        List<PictureBox> Sloty = new List<PictureBox>();
   
        Launcher daneLauncher;
        public Ekwipunek(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;

            #region przypisanieSlotówDoTablicy
            Sloty.Add(staraLokacja);
            Sloty.Add(plecakSlot1);
            Sloty.Add(plecakSlot2);
            Sloty.Add(plecakSlot3);
            Sloty.Add(plecakSlot4);
            Sloty.Add(plecakSlot5);
            Sloty.Add(plecakSlot6);
            Sloty.Add(plecakSlot7);
            Sloty.Add(plecakSlot8);
            Sloty.Add(plecakSlot9);
            Sloty.Add(plecakSlot10);
            Sloty.Add(plecakSlot11);
            Sloty.Add(plecakSlot12);
            Sloty.Add(plecakSlot13);
            Sloty.Add(plecakSlot14);
            Sloty.Add(plecakSlot15);
            Sloty.Add(plecakSlot16);
            Sloty.Add(plecakSlot17);
            Sloty.Add(plecakSlot18);
            Sloty.Add(plecakSlot19);
            Sloty.Add(plecakSlot20);
            Sloty.Add(plecakSlot21);
            Sloty.Add(plecakSlot22);
            Sloty.Add(plecakSlot23);
            Sloty.Add(plecakSlot24);
            Sloty.Add(plecakSlot25);
            Sloty.Add(plecakSlot26);
            Sloty.Add(plecakSlot27);
            Sloty.Add(plecakSlot28);
            Sloty.Add(plecakSlot29);
            Sloty.Add(plecakSlot30);
            Sloty.Add(plecakSlot31);
            Sloty.Add(plecakSlot32);
            Sloty.Add(plecakSlot33);
            Sloty.Add(plecakSlot34);
            Sloty.Add(plecakSlot35);
            Sloty.Add(plecakSlot36);
            Sloty.Add(plecakSlot37);
            Sloty.Add(plecakSlot38);
            Sloty.Add(plecakSlot39);
            Sloty.Add(plecakSlot40);
            Sloty.Add(hełm);
            Sloty.Add(zbroja);
            Sloty.Add(spodnie);
            Sloty.Add(buty);
            Sloty.Add(miecz);
            Sloty.Add(łuk);

            for (int i=1;i<=46;i++)
            {
                daneLauncher.danePlecakSlot[i].obraz = Sloty[i];
            }

            if(daneLauncher.danePlecakSlot[1].Lokacja != new Point(0, 0))
            {
                for(int i=0;i<=46;i++)
                {
                    Sloty[i].Location = daneLauncher.danePlecakSlot[i].Lokacja;
                }
            }
            #endregion
            for (int i=1;i<=46;i++)
            {
                ruchPlecakSlot[i] = false;
            }

            daneLauncher.danePlecakSlot[1].exists = true;
            daneLauncher.danePlecakSlot[2].exists = true;

            daneLauncher.danePlecakSlot[1].miecz = true;
            daneLauncher.danePlecakSlot[1].dmgZwarcie[0] = 1;
            daneLauncher.danePlecakSlot[1].dmgZwarcie[1] = 3;
        }

        private void Statystyki_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I | e.KeyCode == Keys.Escape)
            {
                zamknijFormę();
            }
        }

        private void alaButtonExit_Click(object sender, EventArgs e)
        {
            zamknijFormę();
        }

        private void timerRuch_Tick(object sender, EventArgs e)
        {
            for(int i =1;i<41;i++)
            {
                if(ruchPlecakSlot[i]==true)
                {
                    daneLauncher.danePlecakSlot[i].obraz.BringToFront();
                    daneLauncher.danePlecakSlot[i].obraz.Left = Cursor.Position.X - 590;
                    daneLauncher.danePlecakSlot[i].obraz.Top = Cursor.Position.Y - 140;
                }
            }
        }

        private void akcjaNaSlocie(int numerSlotu)
        {
            if (ruchPlecakSlot[numerSlotu] == true)
            {
                bool przestaw = true;
                bool przestawiono = false;
                for (int i = 1; i <= 46; i++)
                {
                    if (i != numerSlotu)
                    {
                        if (daneLauncher.danePlecakSlot[numerSlotu].obraz.Left<daneLauncher.danePlecakSlot[i].obraz.Right & daneLauncher.danePlecakSlot[numerSlotu].obraz.Left> daneLauncher.danePlecakSlot[i].obraz.Left & daneLauncher.danePlecakSlot[numerSlotu].obraz.Top < daneLauncher.danePlecakSlot[i].obraz.Bottom & daneLauncher.danePlecakSlot[numerSlotu].obraz.Top > daneLauncher.danePlecakSlot[i].obraz.Top)
                        {
                            przestaw = czyPrzestawienieMożliwe(numerSlotu, i, 311, 40, staraLokacja, przestaw, daneLauncher.danePlecakSlot[numerSlotu].hełm, daneLauncher.danePlecakSlot[i].hełm);
                            przestaw = czyPrzestawienieMożliwe(numerSlotu, i, 311, 106, staraLokacja, przestaw, daneLauncher.danePlecakSlot[numerSlotu].zbroja, daneLauncher.danePlecakSlot[i].zbroja);
                            przestaw = czyPrzestawienieMożliwe(numerSlotu, i, 311, 170, staraLokacja, przestaw, daneLauncher.danePlecakSlot[numerSlotu].spodnie, daneLauncher.danePlecakSlot[i].spodnie);
                            przestaw = czyPrzestawienieMożliwe(numerSlotu, i, 311, 236, staraLokacja, przestaw, daneLauncher.danePlecakSlot[numerSlotu].buty, daneLauncher.danePlecakSlot[i].buty);
                            przestaw = czyPrzestawienieMożliwe(numerSlotu, i, 247, 170, staraLokacja, przestaw, daneLauncher.danePlecakSlot[numerSlotu].miecz, daneLauncher.danePlecakSlot[i].miecz);
                            przestaw = czyPrzestawienieMożliwe(numerSlotu, i, 380, 170, staraLokacja, przestaw, daneLauncher.danePlecakSlot[numerSlotu].łuk, daneLauncher.danePlecakSlot[i].łuk);

                            if (przestaw == true)
                            {
                                ruchPlecakSlot[numerSlotu] = false;
                                daneLauncher.danePlecakSlot[numerSlotu].pozycjaLeft = daneLauncher.danePlecakSlot[numerSlotu].obraz.Left = daneLauncher.danePlecakSlot[i].obraz.Left;
                                daneLauncher.danePlecakSlot[numerSlotu].pozycjaTop = daneLauncher.danePlecakSlot[numerSlotu].obraz.Top = daneLauncher.danePlecakSlot[i].obraz.Top;
                                daneLauncher.danePlecakSlot[i].pozycjaLeft = daneLauncher.danePlecakSlot[i].obraz.Left = staraLokacja.Left;
                                daneLauncher.danePlecakSlot[i].pozycjaTop = daneLauncher.danePlecakSlot[i].obraz.Top = staraLokacja.Top;
                                przestawiono = true;
                                aktualizujDaneWyposażenia();
                            }
                        }
                    }
                }
                if (przestawiono == false)
                {
                    ruchPlecakSlot[numerSlotu] = false;
                    daneLauncher.danePlecakSlot[numerSlotu].obraz.Left = staraLokacja.Left;
                    daneLauncher.danePlecakSlot[numerSlotu].obraz.Top = staraLokacja.Top;
                }
            }
            else
            {
                if (daneLauncher.danePlecakSlot[numerSlotu].exists == true)
                {
                    staraLokacja.Left = daneLauncher.danePlecakSlot[numerSlotu].obraz.Left;
                    staraLokacja.Top = daneLauncher.danePlecakSlot[numerSlotu].obraz.Top;
                    ruchPlecakSlot[numerSlotu] = true;
                }
            }
        }

        private bool czyPrzestawienieMożliwe(int numerSlotu, int i, int LocationX, int LocationY, PictureBox staraLokacja, bool przestaw, bool elementWyposażenia1, bool elementWyposażenia2)
        {
            if (przestaw == true & daneLauncher.danePlecakSlot[i].obraz.Location == new Point(LocationX, LocationY))
            {
                if (elementWyposażenia1 == false)
                {
                    return false;
                }
            }
            if (przestaw == true & staraLokacja.Location == new Point(LocationX, LocationY))
            {
                if (elementWyposażenia2 == false & daneLauncher.danePlecakSlot[i].exists==true)
                {
                    return false;
                }
            }
            if (przestaw==false)
            {
                return false;
            }
            return true;
        }

        private void aktualizujDaneWyposażenia()
        {
            for(int i=1;i<=46;i++)
            {
                if(daneLauncher.danePlecakSlot[i].obraz.Location == new Point(311,40) & daneLauncher.danePlecakSlot[i].exists == true)
                {
                    // statystyki hełmu
                }
                if (daneLauncher.danePlecakSlot[i].obraz.Location == new Point(311, 106) & daneLauncher.danePlecakSlot[i].exists == true)
                {
                    // statystyki zbroji
                }
                if (daneLauncher.danePlecakSlot[i].obraz.Location == new Point(311, 170) & daneLauncher.danePlecakSlot[i].exists == true)
                {
                    // statystyki spodni
                }
                if (daneLauncher.danePlecakSlot[i].obraz.Location == new Point(311, 236) & daneLauncher.danePlecakSlot[i].exists == true)
                {
                    // statystyki butów
                }
                if (daneLauncher.danePlecakSlot[i].obraz.Location == new Point(247, 170))
                {
                    if(daneLauncher.danePlecakSlot[i].exists==true)
                    {
                        daneLauncher.daneBonusyGracz.dmgZwarcie[0] = daneLauncher.danePlecakSlot[i].dmgZwarcie[0];
                        daneLauncher.daneBonusyGracz.dmgZwarcie[1] = daneLauncher.danePlecakSlot[i].dmgZwarcie[1];

                        daneLauncher.daneGracz.posiadaMiecz = true;
                    }
                    else
                    {
                        daneLauncher.daneBonusyGracz.dmgZwarcie[0] = 0;
                        daneLauncher.daneBonusyGracz.dmgZwarcie[1] = 0;

                        daneLauncher.daneGracz.posiadaMiecz = false;
                    }
                    
                }
                if (daneLauncher.danePlecakSlot[i].obraz.Location == new Point(380, 170) & daneLauncher.danePlecakSlot[i].exists==true)
                {

                    // statystyki łuku

                    daneLauncher.daneGracz.posiadaŁuk = true;
                }
            }
        }

        private void zapiszDane()
        {
            for(int i=1;i<=46;i++)
            {
                daneLauncher.danePlecakSlot[i].Lokacja = Sloty[i].Location;
            }
            aktualizujDaneWyposażenia();
        }

        private void zamknijFormę()
        {
            for (int i = 1; i < 40; i++)
            {
                if (ruchPlecakSlot[i] == true)
                {
                    ruchPlecakSlot[i] = false;
                    daneLauncher.danePlecakSlot[i].obraz.Left = staraLokacja.Left;
                    daneLauncher.danePlecakSlot[i].obraz.Top = staraLokacja.Top;
                }
            }
            zapiszDane();
            daneLauncher.timerStatystyki.Enabled = true;
            this.Close();
        }

        #region KlikanieNaPrzedmioty
        private void plecakSlot1_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(1);
        }

        private void plecakSlot2_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(2);
        }

        private void plecakSlot3_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(3);
        }

        private void plecakSlot4_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(4);
        }

        private void plecakSlot5_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(5);
        }

        private void plecakSlot6_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(6);
        }

        private void plecakSlot7_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(7);
        }

        private void plecakSlot8_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(8);
        }

        private void plecakSlot9_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(9);
        }

        private void plecakSlot10_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(10);
        }

        private void plecakSlot11_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(11);
        }

        private void plecakSlot12_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(12);
        }

        private void plecakSlot13_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(13);
        }

        private void plecakSlot14_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(14);
        }

        private void plecakSlot15_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(15);
        }

        private void plecakSlot16_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(16);
        }

        private void plecakSlot17_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(17);
        }

        private void plecakSlot18_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(18);
        }

        private void plecakSlot19_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(19);
        }

        private void plecakSlot20_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(20);
        }

        private void plecakSlot21_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(21);
        }

        private void plecakSlot22_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(22);
        }

        private void plecakSlot23_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(23);
        }

        private void plecakSlot24_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(24);
        }

        private void plecakSlot25_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(25);
        }

        private void plecakSlot26_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(26);
        }

        private void plecakSlot27_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(27);
        }

        private void plecakSlot28_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(28);
        }

        private void plecakSlot29_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(29);
        }

        private void plecakSlot30_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(30);
        }

        private void plecakSlot31_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(31);
        }

        private void plecakSlot32_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(32);
        }

        private void plecakSlot33_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(33);
        }

        private void plecakSlot34_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(34);
        }

        private void plecakSlot35_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(35);
        }

        private void plecakSlot36_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(36);
        }

        private void plecakSlot37_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(37);
        }

        private void plecakSlot38_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(38);
        }

        private void plecakSlot39_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(39);
        }

        private void plecakSlot40_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(40);
        }
        #endregion
    }
}
