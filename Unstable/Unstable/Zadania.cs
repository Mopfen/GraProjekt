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
    public partial class Zadania : Form
    {
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
                daneLauncher.timerStatystyki.Enabled = true;
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
        }

        private void alaButtonExit_Click(object sender, EventArgs e)
        {
            daneLauncher.timerStatystyki.Enabled = true;
            this.Close();
        }
    }
}
