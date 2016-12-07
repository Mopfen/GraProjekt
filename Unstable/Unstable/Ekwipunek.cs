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

            #region PrzypisanieSlotówDoTablicy
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
            Sloty.Add(PlecakSlot41);
            Sloty.Add(PlecakSlot42);
            Sloty.Add(PlecakSlot43);
            Sloty.Add(PlecakSlot44);
            Sloty.Add(PlecakSlot45);
            Sloty.Add(PlecakSlot46);

            for (int i=1;i<=46;i++)
            {
                daneLauncher.danePlecakSlot[i].obraz = Sloty[i];
                if(daneLauncher.danePlecakSlot[i].id==1)
                {
                    daneLauncher.danePlecakSlot[i].obraz.Image = daneLauncher.ZardzewiałyMiecz.Image;
                }
                if (daneLauncher.danePlecakSlot[i].id == 2)
                {
                    daneLauncher.danePlecakSlot[i].obraz.Image = daneLauncher.ZbutwiałyŁuk.Image;
                }
                if (daneLauncher.danePlecakSlot[i].id==1000)
                {
                    daneLauncher.danePlecakSlot[i].obraz.Image = daneLauncher.MieczSquadaka.Image;
                }
                if (daneLauncher.danePlecakSlot[i].id == 1001)
                {
                    daneLauncher.danePlecakSlot[i].obraz.Image = daneLauncher.ŁukSquadaka.Image;
                }
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
            daneLauncher.statystykiPrzedmiotu = labelStatystykiPrzedmiotu;
            labelStanZłota.Text = Convert.ToString(daneLauncher.daneGracz.złoto) + " złota";

            daneLauncher.daneGracz.up = daneLauncher.daneGracz.down = daneLauncher.daneGracz.left = daneLauncher.daneGracz.right = daneLauncher.daneGracz.zmianaKierunkuUp = daneLauncher.daneGracz.zmianaKierunkuDown = daneLauncher.daneGracz.zmianaKierunkuLeft = daneLauncher.daneGracz.zmianaKierunkuRight = false;

            zapiszDane();

            #region Test
            daneLauncher.danePlecakSlot[2].exists = true;
            daneLauncher.danePlecakSlot[2].id = 3;

            #endregion
        }

        private void Ekwipunek_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I | e.KeyCode == Keys.Escape)
            {
                zamknijFormę();
            }
            Komendy.MieczProgramisty metodaKomendy = new Komendy.MieczProgramisty(daneLauncher);
            metodaKomendy.WczytajKomendę(e);
        }

        private void alaButtonExit_Click(object sender, EventArgs e)
        {
            zamknijFormę();
        }

        private void timerRuch_Tick(object sender, EventArgs e)
        {
            for(int i =1;i<=46;i++)
            {
                if(ruchPlecakSlot[i]==true)
                {
                    if (antyRozmycie.Location != daneLauncher.danePlecakSlot[i].obraz.Location) { antyRozmycie.Location = daneLauncher.danePlecakSlot[i].obraz.Location; } // niweluje rozmycie tła podczas poruszania przedmiotem
                    daneLauncher.danePlecakSlot[i].obraz.BringToFront();
                    daneLauncher.danePlecakSlot[i].obraz.Left = Cursor.Position.X - 600;
                    daneLauncher.danePlecakSlot[i].obraz.Top = Cursor.Position.Y - 150;
                }
            }
            if (daneLauncher.statystykiPokazywane == false)
            {
                daneLauncher.statystykiPrzedmiotu.Text = "Statystyki przedmiotu:\n\n";
            }
            if (daneLauncher.komenda == "squadak")
            {
                Komendy.MieczProgramisty metodaKomendy = new Komendy.MieczProgramisty(daneLauncher);
                metodaKomendy.WykonajKomendę();
                zamknijFormę();
            }
        }

        private void akcjaNaSlocie(int numerSlotu)
        {
            if (ruchPlecakSlot[numerSlotu] == true)
            {
                MetodyEkwipunek metodaEkwipunek = new MetodyEkwipunek(daneLauncher);
                bool przestaw = true;
                bool przestawiono = false;
                for (int i = 1; i <= 46; i++)
                {
                    if (i != numerSlotu)
                    {
                        if (daneLauncher.danePlecakSlot[numerSlotu].obraz.Bounds.IntersectsWith(daneLauncher.danePlecakSlot[i].obraz.Bounds))
                        {
                            przestaw = metodaEkwipunek.czyPrzestawienieMożliwe(numerSlotu, i, 311, 40, staraLokacja, przestaw, daneLauncher.danePlecakSlot[numerSlotu].hełm, daneLauncher.danePlecakSlot[i].hełm);
                            przestaw = metodaEkwipunek.czyPrzestawienieMożliwe(numerSlotu, i, 311, 106, staraLokacja, przestaw, daneLauncher.danePlecakSlot[numerSlotu].zbroja, daneLauncher.danePlecakSlot[i].zbroja);
                            przestaw = metodaEkwipunek.czyPrzestawienieMożliwe(numerSlotu, i, 311, 170, staraLokacja, przestaw, daneLauncher.danePlecakSlot[numerSlotu].spodnie, daneLauncher.danePlecakSlot[i].spodnie);
                            przestaw = metodaEkwipunek.czyPrzestawienieMożliwe(numerSlotu, i, 311, 236, staraLokacja, przestaw, daneLauncher.danePlecakSlot[numerSlotu].buty, daneLauncher.danePlecakSlot[i].buty);
                            przestaw = metodaEkwipunek.czyPrzestawienieMożliwe(numerSlotu, i, 247, 170, staraLokacja, przestaw, daneLauncher.danePlecakSlot[numerSlotu].miecz, daneLauncher.danePlecakSlot[i].miecz);
                            przestaw = metodaEkwipunek.czyPrzestawienieMożliwe(numerSlotu, i, 380, 170, staraLokacja, przestaw, daneLauncher.danePlecakSlot[numerSlotu].łuk, daneLauncher.danePlecakSlot[i].łuk);

                            if (przestaw == true)
                            {
                                ruchPlecakSlot[numerSlotu] = false;
                                daneLauncher.danePlecakSlot[numerSlotu].Lokacja = daneLauncher.danePlecakSlot[numerSlotu].obraz.Location = daneLauncher.danePlecakSlot[i].obraz.Location;
                                daneLauncher.danePlecakSlot[i].Lokacja = daneLauncher.danePlecakSlot[i].obraz.Location = staraLokacja.Location;
                                przestawiono = true;
                                metodaEkwipunek.aktualizujDaneWyposażenia();
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

        private void pokazStatystyki(int numerSlotu)
        {
            daneLauncher.statystykiPrzedmiotu.Text = "Statystyki przedmiotu:\n\n";
            string nazwa="";
            string obrażenia="";

            if (daneLauncher.danePlecakSlot[numerSlotu].id == 1) nazwa = "Zardzewiały Miecz";
            if (daneLauncher.danePlecakSlot[numerSlotu].id == 2) nazwa = "Zbutwiały Łuk";
            if (daneLauncher.danePlecakSlot[numerSlotu].id == 3) nazwa = "Czerwona Mikstura(M)";
            if (daneLauncher.danePlecakSlot[numerSlotu].id == 1000) nazwa = "Miecz Squadaka";
            if (daneLauncher.danePlecakSlot[numerSlotu].id == 1001) nazwa = "Łuk Squadaka";

            if (daneLauncher.danePlecakSlot[numerSlotu].dmgZwarcie[0] != 0 & daneLauncher.danePlecakSlot[numerSlotu].dmgZwarcie[1] != 0) obrażenia = Convert.ToString(daneLauncher.danePlecakSlot[numerSlotu].dmgZwarcie[0] + "-" + daneLauncher.danePlecakSlot[numerSlotu].dmgZwarcie[1]);
            if (daneLauncher.danePlecakSlot[numerSlotu].dmgDystans[0] != 0 & daneLauncher.danePlecakSlot[numerSlotu].dmgDystans[1] != 0) obrażenia = Convert.ToString(daneLauncher.danePlecakSlot[numerSlotu].dmgDystans[0] + "-" + daneLauncher.danePlecakSlot[numerSlotu].dmgDystans[1]);

            if (daneLauncher.danePlecakSlot[numerSlotu].exists==true)
            {
                daneLauncher.statystykiPrzedmiotu.Text += nazwa+"\n";
                if (obrażenia != "") daneLauncher.statystykiPrzedmiotu.Text +="Obrażenia: " + obrażenia + "\n";
            }
            daneLauncher.statystykiPokazywane = true;
        }

        private void zapiszDane()
        {
            MetodyEkwipunek metodaEkwipunek = new MetodyEkwipunek(daneLauncher);
            for(int i=1;i<=46;i++)
            {
                daneLauncher.danePlecakSlot[i].Lokacja = Sloty[i].Location;
            }
            metodaEkwipunek.aktualizujDaneWyposażenia();
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
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            metodaUniwersalne.uruchomTimery();
            timerRuch.Enabled = false;
            Sloty.Clear();
            this.Close();
        }

        #region KlikanieNaPrzedmioty
        private void przedmiotyFabularne_Click(object sender, EventArgs e)
        {
            PrzedmiotyFabularne formaPrzedmiotyFabularne = new PrzedmiotyFabularne(daneLauncher);
            formaPrzedmiotyFabularne.ShowDialog();
        }

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

        private void plecakSlot41_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(41);
        }

        private void plecakSlot42_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(42);
        }

        private void plecakSlot43_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(43);
        }

        private void plecakSlot44_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(44);
        }

        private void plecakSlot45_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(45);
        }

        private void plecakSlot46_Click(object sender, EventArgs e)
        {
            akcjaNaSlocie(46);
        }

        private void plecakSlot1_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(1);
        }

        private void plecakSlot2_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(2);
        }

        private void plecakSlot3_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(3);
        }

        private void plecakSlot4_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(4);
        }

        private void plecakSlot5_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(5);
        }

        private void plecakSlot6_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(6);
        }

        private void plecakSlot7_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(7);
        }

        private void plecakSlot8_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(8);
        }

        private void plecakSlot9_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(9);
        }

        private void plecakSlot10_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(10);
        }

        private void plecakSlot11_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(11);
        }

        private void plecakSlot12_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(12);
        }

        private void plecakSlot13_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(13);
        }

        private void plecakSlot14_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(14);
        }

        private void plecakSlot15_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(15);
        }

        private void plecakSlot16_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(16);
        }

        private void plecakSlot17_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(17);
        }

        private void plecakSlot18_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(18);
        }

        private void plecakSlot19_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(19);
        }

        private void plecakSlot20_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(20);
        }

        private void plecakSlot21_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(21);
        }

        private void plecakSlot22_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(22);
        }

        private void plecakSlot23_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(23);
        }

        private void plecakSlot24_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(24);
        }

        private void plecakSlot25_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(25);
        }

        private void plecakSlot26_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(26);
        }

        private void plecakSlot27_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(27);
        }

        private void plecakSlot28_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(28);
        }

        private void plecakSlot29_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(29);
        }

        private void plecakSlot30_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(30);
        }

        private void plecakSlot31_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(31);
        }

        private void plecakSlot32_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(32);
        }

        private void plecakSlot33_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(33);
        }

        private void plecakSlot34_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(34);
        }

        private void plecakSlot35_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(35);
        }

        private void plecakSlot36_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(36);
        }

        private void plecakSlot37_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(37);
        }

        private void plecakSlot38_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(38);
        }

        private void plecakSlot39_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(39);
        }

        private void plecakSlot40_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(40);
        }

        private void plecakSlot41_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(41);
        }

        private void plecakSlot42_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(42);
        }

        private void plecakSlot43_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(43);
        }

        private void plecakSlot44_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(44);
        }

        private void plecakSlot45_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(45);
        }

        private void plecakSlot46_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(46);
        }

        private void plecakSlot_MouseLeave(object sender, EventArgs e)
        {
            daneLauncher.statystykiPokazywane = false;
        }

        #endregion
    }
}
