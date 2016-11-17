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
    public partial class NowaGra : Form
    {
        private int włosy = 0; //
        private int skóra = 0; // zmienne odpowiadające za zmianę wyglądu gracza

        /// <summary> Umożliwia dostęp do danych zawartych w klasie Launcher.</summary>
        Launcher daneLauncher;

        public NowaGra(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;

            aktualizator.Enabled = true; 
        }

        private void NowaGra_Load(object sender, EventArgs e)
        {

        }

        private void buttonWróć_Click(object sender, EventArgs e)
        {
            MenuGlowne formaMenuGlowne = new MenuGlowne(daneLauncher);

            this.Close();                   
            formaMenuGlowne.Show();
        }

        private void gracz_Click(object sender, EventArgs e)
        {

        }
        private void buttonGoTest_Click(object sender, EventArgs e)
        {
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            metodaUniwersalne.liczStatystyki();
            MapaStartowa formaMapaStartowa = new MapaStartowa(daneLauncher);
            this.Close();
            formaMapaStartowa.Show();
        }

        private void button_KolorWłosów_Click(object sender, EventArgs e)
        {
            if (włosy > 0)
                włosy--;
            else
                włosy = 3;
        }

        private void buttonKolorWłosów__Click(object sender, EventArgs e)
        {
            if (włosy < 3)
                włosy++;
            else
                włosy = 0;
        }

        private void button_KolorSkóry_Click(object sender, EventArgs e)
        {
            if (skóra > 0)
                skóra--;
            else
                skóra = 4;
        }

        private void buttonKolorSkóry__Click(object sender, EventArgs e)
        {
            if (skóra < 4)
                skóra++;
            else
                skóra = 0;
        }

        private void aktualizator_Tick(object sender, EventArgs e)
        {
            switch (skóra)
            {
                case 0:
                    switch (włosy)
                    {
                        case 0: this.gracz.Image = daneLauncher.whiteBrownStand.Image; break;
                        case 1: this.gracz.Image = daneLauncher.whiteBlackStand.Image; break;
                        case 2: this.gracz.Image = daneLauncher.whiteBlondeStand.Image; break;
                        case 3: this.gracz.Image = daneLauncher.whiteRedStand.Image; break;
                    }
                    break;
                case 1:
                    switch (włosy)
                    {
                        case 0: this.gracz.Image = daneLauncher.blackBrownStand.Image; break;
                        case 1: this.gracz.Image = daneLauncher.blackBlackStand.Image; break;
                        case 2: this.gracz.Image = daneLauncher.blackBlondeStand.Image; break;
                        case 3: this.gracz.Image = daneLauncher.blackRedStand.Image; break;
                    }
                    break;
                case 2:
                    switch (włosy)
                    {
                        case 0: this.gracz.Image = daneLauncher.pinkBrownStand.Image; break;
                        case 1: this.gracz.Image = daneLauncher.pinkBlackStand.Image; break;
                        case 2: this.gracz.Image = daneLauncher.pinkBlondeStand.Image; break;
                        case 3: this.gracz.Image = daneLauncher.pinkRedStand.Image; break;
                    }
                    break;
                case 3:
                    switch (włosy)
                    {
                        case 0: this.gracz.Image = daneLauncher.yellowBrownStand.Image; break;
                        case 1: this.gracz.Image = daneLauncher.yellowBlackStand.Image; break;
                        case 2: this.gracz.Image = daneLauncher.yellowBlondeStand.Image; break;
                        case 3: this.gracz.Image = daneLauncher.yellowRedStand.Image; break;
                    }
                    break;
                case 4:
                    switch (włosy)
                    {
                        case 0: this.gracz.Image = daneLauncher.redBrownStand.Image; break;
                        case 1: this.gracz.Image = daneLauncher.redBlackStand.Image; break;
                        case 2: this.gracz.Image = daneLauncher.redBlondeStand.Image; break;
                        case 3: this.gracz.Image = daneLauncher.redRedStand.Image; break;
                    }
                    break;
            }
        }
    }
}
