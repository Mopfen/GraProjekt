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
    /// <summary>
    /// Odpowiada za działanie menu głównego
    /// </summary>
    public partial class MenuGlowne : Form
    {
        /// <summary> 
        /// Pole umożliwia dostęp do danych zawartych w klasie Launcher.
        /// </summary>
        Launcher daneLauncher;

        public MenuGlowne(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;

            this.Text = "TerrorOfDragons - " + daneLauncher.gameVersion;
            wersjaGry.Text += daneLauncher.gameVersion;

            if (daneLauncher.muzykaMenu==false)
            {
                Muzyka metodaMuzyka = new Muzyka(daneLauncher);
                metodaMuzyka.Soundtrack("SoundtrackMenu.wav");

                daneLauncher.muzykaMenu = true;
            }
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            NowaGra formaNowaGra = new NowaGra(daneLauncher);

            this.Close();
            formaNowaGra.Show();
        }

        private void buttonWczytajGrę_Click(object sender, EventArgs e)
        {
            WczytajGrę formaWczytajGrę = new WczytajGrę(daneLauncher);

            this.Close();
            formaWczytajGrę.Show();
        }

        private void buttonWyjście_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOpcjeGry_Click(object sender, EventArgs e)
        {
            Opcje formaOpcje = new Opcje(daneLauncher);

            this.Close();
            formaOpcje.Show();
        }

    }
}
