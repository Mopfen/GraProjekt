﻿using System;
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
    /// Odpowiada za działanie panelu Samouczka
    /// </summary>
    public partial class Samouczek : Form
    {
        /// <summary> 
        /// Pole umożliwia dostęp do danych zawartych w klasie Launcher.
        /// </summary>
        Launcher daneLauncher;

        public Samouczek(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;

            demonstracja.Image = daneLauncher.samouczekObrazDemonstracyjny.Image;
            klawisze.Image = daneLauncher.samouczekObrazKlawiszy.Image;
            labelInstrukcja.Text = daneLauncher.samouczekInstrukcja;
            labelInfo.Text = daneLauncher.samouczekInfo;
        }

        private void buttonDalej_Click(object sender, EventArgs e)
        {
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            metodaUniwersalne.uruchomTimery();
            this.Close();
        }
    }
}
