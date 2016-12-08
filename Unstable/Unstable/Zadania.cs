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
    /// <summary>
    /// Odpowiada za działanie panelu zadań.
    /// </summary>
    public partial class Zadania : Form
    {
        /// <summary> 
        /// Pole umożliwia dostęp do danych zawartych w klasie Launcher.
        /// </summary>
        Launcher daneLauncher;

        public Zadania(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;

            #region DodawanieMisjiDoList
            for(int i=0;i<100;i++)
            {
                bool dodaj = true;
                if (daneLauncher.daneQuest[i].stan==1 & daneLauncher.daneQuest[i].poboczna == false)
                {
                    if(listaMisjiGłównych.Items != null)
                    {
                        for (int j = 0; j < listaMisjiGłównych.Items.Count - 1; j++)
                        {
                            if(Convert.ToString(listaMisjiGłównych.Items[j]) == daneLauncher.daneQuest[i].nazwa)
                            {
                                dodaj = false;
                            }
                        }
                    }
                    if (dodaj == true)
                    {
                        listaMisjiGłównych.Items.Add(daneLauncher.daneQuest[i].nazwa);
                    }
                }
            }

            #endregion

            labelNazwa.Text = "";
            labelEtap.Text = "";
        }

        private void Zadania_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q | e.KeyCode == Keys.Escape)
            {
                Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
                metodaUniwersalne.uruchomTimery();
                this.Close();
            }
        }

        private void ZmianaArgumetówMisjeGłówne(object sender, EventArgs e)
        {
            labelNazwa.Text = "";
            labelEtap.Text = "";

            if (listaMisjiGłównych.Text=="Przeznaczenie")
            {
                labelNazwa.Text = listaMisjiGłównych.Text;
                labelEtap.Text = daneLauncher.daneQuest[0].opisEtapu[daneLauncher.daneQuest[0].etap];
            }
            if (listaMisjiGłównych.Text == "Pomoc Winiarza")
            {
                labelNazwa.Text = listaMisjiGłównych.Text;
                labelEtap.Text = daneLauncher.daneQuest[1].opisEtapu[daneLauncher.daneQuest[1].etap];
            }
            if(listaMisjiGłównych.Text == "Miasto Winczewo")
            {
                labelNazwa.Text = listaMisjiGłównych.Text;
                labelEtap.Text = daneLauncher.daneQuest[2].opisEtapu[daneLauncher.daneQuest[2].etap];
            }
        }

        private void alaButtonExit_Click(object sender, EventArgs e)
        {
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            metodaUniwersalne.uruchomTimery();
            this.Close();
        }

        private void Zadania_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                if (daneLauncher.noweGlowneZadanie == true)
                {
                    listaMisjiGłównych.Text = Convert.ToString(listaMisjiGłównych.Items[listaMisjiGłównych.Items.Count - 1]);
                    daneLauncher.noweGlowneZadanie = false;
                }
                if (daneLauncher.nowePoboczneZadanie == true)
                {
                    listaMisjiPobocznych.Text = Convert.ToString(listaMisjiPobocznych.Items[listaMisjiPobocznych.Items.Count - 1]);
                    daneLauncher.nowePoboczneZadanie = false;
                }
            }
        }
    }
}
