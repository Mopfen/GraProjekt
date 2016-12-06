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
    public partial class PrzedmiotyFabularne : Form
    {
        private bool[] ruchfabularnyItem = new bool[47];
        List<PictureBox> Sloty = new List<PictureBox>();

        Launcher daneLauncher;

        public PrzedmiotyFabularne(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;

            #region PrzypisanieSlotówDoTablicy
            Sloty.Add(null);
            Sloty.Add(fabularnyItem1);
            Sloty.Add(fabularnyItem2);
            Sloty.Add(fabularnyItem3);
            Sloty.Add(fabularnyItem4);
            Sloty.Add(fabularnyItem5);
            Sloty.Add(fabularnyItem6);
            Sloty.Add(fabularnyItem7);
            Sloty.Add(fabularnyItem8);
            Sloty.Add(fabularnyItem9);
            Sloty.Add(fabularnyItem10);
            Sloty.Add(fabularnyItem11);
            Sloty.Add(fabularnyItem12);
            Sloty.Add(fabularnyItem13);
            Sloty.Add(fabularnyItem14);
            Sloty.Add(fabularnyItem15);
            Sloty.Add(fabularnyItem16);

            for (int i = 1; i <= 16; i++)
            {
                daneLauncher.daneFabularnyItem[i].obraz = Sloty[i];
                if (daneLauncher.daneFabularnyItem[i].id == 9)
                {
                    daneLauncher.daneFabularnyItem[i].obraz.Image = daneLauncher.KluczNaPierwszePiętroWieżyPerquna.Image;
                }
            }

            #endregion
            daneLauncher.nazwaPrzedmiotuFabularnego = labelInfoPrzedmiotu;

            zapiszDane();
        }

        private void PrzedmiotyFabularne_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                zapiszDane();
                this.Close();
            }
        }

        private void alaButtonExit_Click(object sender, EventArgs e)
        {
            zapiszDane();
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(daneLauncher.statystykiPokazywane == false)
            {
                daneLauncher.nazwaPrzedmiotuFabularnego.Text = "Nazwa przedmiotu: ";
            }  
        }

        private void zapiszDane()
        {
            for (int i = 1; i <= 16; i++)
            {
                daneLauncher.daneFabularnyItem[i].Lokacja = Sloty[i].Location;
            }
        }

        private void pokazStatystyki(int numerSlotu)
        {
            daneLauncher.nazwaPrzedmiotuFabularnego.Text = "Nazwa przedmiotu: ";
            string nazwa = "";

            if (daneLauncher.daneFabularnyItem[numerSlotu].id == 9) nazwa = "Klucz na pierwsze piętro wieży Perquna";
            
            if (daneLauncher.daneFabularnyItem[numerSlotu].exists == true)
            {
                daneLauncher.nazwaPrzedmiotuFabularnego.Text += nazwa;
            }
            daneLauncher.statystykiPokazywane = true;
        }

        #region KursorNaPrzedmiocie
        private void fabularnyItem1_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(1);
        }

        private void fabularnyItem2_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(2);
        }

        private void fabularnyItem3_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(3);
        }

        private void fabularnyItem4_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(4);
        }

        private void fabularnyItem5_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(5);
        }

        private void fabularnyItem6_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(6);
        }

        private void fabularnyItem7_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(7);
        }

        private void fabularnyItem8_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(8);
        }

        private void fabularnyItem9_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(9);
        }

        private void fabularnyItem10_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(10);
        }

        private void fabularnyItem11_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(11);
        }

        private void fabularnyItem12_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(12);
        }

        private void fabularnyItem13_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(13);
        }

        private void fabularnyItem14_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(14);
        }

        private void fabularnyItem15_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(15);
        }

        private void fabularnyItem16_MouseHover(object sender, EventArgs e)
        {
            pokazStatystyki(16);
        }

        private void fabularnyItem_MouseLeave(object sender, EventArgs e)
        {
            daneLauncher.statystykiPokazywane = false;
        }

        #endregion
    }
}
