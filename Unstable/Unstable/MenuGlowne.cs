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
    public partial class MenuGlowne : Form
    {
        /// <summary> Umożliwia dostęp do danych zawartych w klasie Launcher.</summary>
        Launcher daneLauncher; // 

        public MenuGlowne(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;

            daneLauncher.music.SoundLocation = "SoundtrackMenu.wav";
            daneLauncher.music.PlayLooping();

            //aktualizator.Enabled = true;

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

        private void aktualizator_Tick(object sender, EventArgs e)
        {
            
        }

        private void MenuGlowne_Load(object sender, EventArgs e)
        {

        }
    }
}
