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
    public partial class Opcje : Form
    {
        /// <summary> Umożliwia dostęp do danych zawartych w klasie Launcher.</summary>
        Launcher daneLauncher; // 

        public Opcje(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;

            labelStanMuzyka.Text = daneLauncher.opcjeMuzykaText;
            labelStanEfektyDźwiękowe.Text = daneLauncher.opcjeEfektyDźwiękoweText;
            labelStanSamouczek.Text = daneLauncher.opcjeSamouczekText;
        }

        private void labelStanMuzyka_Click(object sender, EventArgs e)
        {
            Muzyka metodaMuzyka = new Muzyka(daneLauncher);

            metodaMuzyka.SoundEffect(daneLauncher.soundInterface, "Przewijanie.wav");

            if (labelStanMuzyka.Text=="Włączona")
            {
                daneLauncher.opcjeMuzykaText = labelStanMuzyka.Text = "Wyłączona";

                daneLauncher.music.Ctlcontrols.stop();

                daneLauncher.muzykaOn = false;
            }
            else
            {
                daneLauncher.opcjeMuzykaText = labelStanMuzyka.Text = "Włączona";
                daneLauncher.muzykaOn = true;

                daneLauncher.music.Ctlcontrols.play();
            }
        }

        private void labelStanEfektyDźwiękowe_Click(object sender, EventArgs e)
        {
            Muzyka metodaMuzyka = new Muzyka(daneLauncher);

            metodaMuzyka.SoundEffect(daneLauncher.soundInterface, "Przewijanie.wav");

            if (labelStanEfektyDźwiękowe.Text == "Włączone")
            {
                daneLauncher.opcjeEfektyDźwiękoweText = labelStanEfektyDźwiękowe.Text = "Wyłączone";
                daneLauncher.efektyDźwiękoweOn = false;
            }
            else
            {
                daneLauncher.opcjeEfektyDźwiękoweText = labelStanEfektyDźwiękowe.Text = "Włączone";
                daneLauncher.efektyDźwiękoweOn = true;
            }
        }

        private void labelStanSamouczek_Click(object sender, EventArgs e)
        {
            Muzyka metodaMuzyka = new Muzyka(daneLauncher);

            metodaMuzyka.SoundEffect(daneLauncher.soundInterface, "Przewijanie.wav");

            if (labelStanSamouczek.Text == "Włączony")
            {
                daneLauncher.opcjeSamouczekText = labelStanSamouczek.Text = "Wyłączony";
                daneLauncher.samouczek = false;
            }
            else
            {
                daneLauncher.opcjeSamouczekText = labelStanSamouczek.Text = "Włączony";
                daneLauncher.samouczek = true;
            }
        }

        private void buttonWróć_Click(object sender, EventArgs e)
        {
            MenuGlowne formaMenuGlowne = new MenuGlowne(daneLauncher);

            this.Close();
            formaMenuGlowne.Show();
        }
    }
}
