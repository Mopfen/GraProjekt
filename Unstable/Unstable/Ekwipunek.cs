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

            daneLauncher.danePlecakSlot[1].alive = true;
            daneLauncher.danePlecakSlot[2].alive = true;
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

        private void plecakSlot1_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(1);
        }
        private void plecakSlot2_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(2);
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
                bool przestawiono = false;
                for (int i = 1; i <= 46; i++)
                {
                    if (i != numerSlotu)
                    {
                        if (daneLauncher.danePlecakSlot[numerSlotu].obraz.Bounds.IntersectsWith(daneLauncher.danePlecakSlot[i].obraz.Bounds))
                        {
                            if(daneLauncher.danePlecakSlot[i].Location==new Point(311, 40))
                            {
                             
                            }


                            ruchPlecakSlot[numerSlotu] = false;
                            daneLauncher.danePlecakSlot[numerSlotu].pozycjaLeft = daneLauncher.danePlecakSlot[numerSlotu].obraz.Left = daneLauncher.danePlecakSlot[i].obraz.Left;
                            daneLauncher.danePlecakSlot[numerSlotu].pozycjaTop = daneLauncher.danePlecakSlot[numerSlotu].obraz.Top = daneLauncher.danePlecakSlot[i].obraz.Top;
                            daneLauncher.danePlecakSlot[i].pozycjaLeft = daneLauncher.danePlecakSlot[i].obraz.Left = staraLokacja.Left;
                            daneLauncher.danePlecakSlot[i].pozycjaTop = daneLauncher.danePlecakSlot[i].obraz.Top = staraLokacja.Top;
                            przestawiono = true;
                        }
                    }
                }
                if(przestawiono==false)
                {
                    ruchPlecakSlot[numerSlotu] = false;
                    daneLauncher.danePlecakSlot[numerSlotu].obraz.Left = staraLokacja.Left;
                    daneLauncher.danePlecakSlot[numerSlotu].obraz.Top = staraLokacja.Top;
                }
            }
            else
                if(daneLauncher.danePlecakSlot[numerSlotu].alive==true)
                {
                    staraLokacja.Left = daneLauncher.danePlecakSlot[numerSlotu].obraz.Left;
                    staraLokacja.Top = daneLauncher.danePlecakSlot[numerSlotu].obraz.Top;
                    ruchPlecakSlot[numerSlotu] = true;
                }
        }
        private void zapiszPozycje()
        {
            daneLauncher.danePlecakSlot[1].Lokacja = plecakSlot1.Location;
            daneLauncher.danePlecakSlot[2].Lokacja = plecakSlot2.Location;
            daneLauncher.danePlecakSlot[3].Lokacja = plecakSlot3.Location;
            daneLauncher.danePlecakSlot[4].Lokacja = plecakSlot4.Location;
            daneLauncher.danePlecakSlot[5].Lokacja = plecakSlot5.Location;
            daneLauncher.danePlecakSlot[6].Lokacja = plecakSlot6.Location;
            daneLauncher.danePlecakSlot[7].Lokacja = plecakSlot7.Location;
            daneLauncher.danePlecakSlot[8].Lokacja = plecakSlot8.Location;
            daneLauncher.danePlecakSlot[9].Lokacja = plecakSlot9.Location;
            daneLauncher.danePlecakSlot[10].Lokacja = plecakSlot10.Location;
            daneLauncher.danePlecakSlot[11].Lokacja = plecakSlot11.Location;
            daneLauncher.danePlecakSlot[12].Lokacja = plecakSlot12.Location;
            daneLauncher.danePlecakSlot[13].Lokacja = plecakSlot13.Location;
            daneLauncher.danePlecakSlot[14].Lokacja = plecakSlot14.Location;
            daneLauncher.danePlecakSlot[15].Lokacja = plecakSlot15.Location;
            daneLauncher.danePlecakSlot[16].Lokacja = plecakSlot16.Location;
            daneLauncher.danePlecakSlot[17].Lokacja = plecakSlot17.Location;
            daneLauncher.danePlecakSlot[18].Lokacja = plecakSlot18.Location;
            daneLauncher.danePlecakSlot[19].Lokacja = plecakSlot19.Location;
            daneLauncher.danePlecakSlot[20].Lokacja = plecakSlot20.Location;
            daneLauncher.danePlecakSlot[21].Lokacja = plecakSlot21.Location;
            daneLauncher.danePlecakSlot[22].Lokacja = plecakSlot22.Location;
            daneLauncher.danePlecakSlot[23].Lokacja = plecakSlot23.Location;
            daneLauncher.danePlecakSlot[24].Lokacja = plecakSlot24.Location;
            daneLauncher.danePlecakSlot[25].Lokacja = plecakSlot25.Location;
            daneLauncher.danePlecakSlot[26].Lokacja = plecakSlot26.Location;
            daneLauncher.danePlecakSlot[27].Lokacja = plecakSlot27.Location;
            daneLauncher.danePlecakSlot[28].Lokacja = plecakSlot28.Location;
            daneLauncher.danePlecakSlot[29].Lokacja = plecakSlot29.Location;
            daneLauncher.danePlecakSlot[30].Lokacja = plecakSlot30.Location;
            daneLauncher.danePlecakSlot[31].Lokacja = plecakSlot31.Location;
            daneLauncher.danePlecakSlot[32].Lokacja = plecakSlot32.Location;
            daneLauncher.danePlecakSlot[33].Lokacja = plecakSlot33.Location;
            daneLauncher.danePlecakSlot[34].Lokacja = plecakSlot34.Location;
            daneLauncher.danePlecakSlot[35].Lokacja = plecakSlot35.Location;
            daneLauncher.danePlecakSlot[36].Lokacja = plecakSlot36.Location;
            daneLauncher.danePlecakSlot[37].Lokacja = plecakSlot37.Location;
            daneLauncher.danePlecakSlot[38].Lokacja = plecakSlot38.Location;
            daneLauncher.danePlecakSlot[39].Lokacja = plecakSlot39.Location;
            daneLauncher.danePlecakSlot[40].Lokacja = plecakSlot40.Location;
            daneLauncher.danePlecakSlot[41].Lokacja = hełm.Location;
            daneLauncher.danePlecakSlot[42].Lokacja = zbroja.Location;
            daneLauncher.danePlecakSlot[43].Lokacja = spodnie.Location;
            daneLauncher.danePlecakSlot[44].Lokacja = buty.Location;
            daneLauncher.danePlecakSlot[45].Lokacja = miecz.Location;
            daneLauncher.danePlecakSlot[46].Lokacja = łuk.Location;
        }
        private void zamknijFormę()
        {
            for (int i = 1; i < 40; i++)
            {
                if (ruchPlecakSlot[i] == true)
                {
                    ruchPlecakSlot[i] = false;
                    daneLauncher.danePlecakSlot[i].Left = staraLokacja.Left;
                    daneLauncher.danePlecakSlot[i].Top = staraLokacja.Top;
                }
            }
            zapiszPozycje();
            daneLauncher.timerStatystyki.Enabled = true;
            this.Close();
        }


    }
}
