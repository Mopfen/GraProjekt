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
        private int włosy = 0;
        private int skóra = 0;

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
            Mapa1 formaMapa1 = new Mapa1(daneLauncher);

            this.Close();
            formaMapa1.Show();
        }

        private void button_KolorWłosów_Click(object sender, EventArgs e)
        {
            if (włosy > 0)
                włosy--;
            else
                włosy = 4;
        }

        private void buttonKolorWłosów__Click(object sender, EventArgs e)
        {
            if (włosy < 4)
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
                        case 0: this.gracz.Image = global::Unstable.Properties.Resources.StandWhiteManBrownHairBlueEyes; break;
                        case 1: this.gracz.Image = global::Unstable.Properties.Resources.StandWhiteManBlackHairBlueEyes; break;
                    }
                    break;
                case 1:
                    switch (włosy)
                    {
                        case 0: this.gracz.Image = global::Unstable.Properties.Resources.StandBlackManBrownHairBlueEyes; break;
                        case 1: this.gracz.Image = global::Unstable.Properties.Resources.StandBlackManBlackHairBlueEyes; break;
                    }
                    break;
                case 2:
                    switch (włosy)
                    {
                        case 0: this.gracz.Image = global::Unstable.Properties.Resources.StandPinkManBrownHairBlueEyes; break;
                        case 1: this.gracz.Image = global::Unstable.Properties.Resources.StandPinkManBlackHairBlueEyes; break;
                    }
                    break;
                case 3:
                    switch (włosy)
                    {
                        case 0: this.gracz.Image = global::Unstable.Properties.Resources.StandYellowManBrownHairBlueEyes; break;
                        case 1: this.gracz.Image = global::Unstable.Properties.Resources.StandYellowManBlackHairBlueEyes; break;
                    }
                    break;
                case 4:
                    switch (włosy)
                    {
                        case 0: this.gracz.Image = global::Unstable.Properties.Resources.StandRedManBrownHairBlueEyes; break;
                        case 1: this.gracz.Image = global::Unstable.Properties.Resources.StandRedManBlackHairBlueEyes; break;
                    }
                    break;
            }
        }

        
    }
}
