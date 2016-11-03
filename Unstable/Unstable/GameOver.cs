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
    public partial class GameOver : Form
    {
        Launcher daneLauncher;
        Mapa1 daneMapa1;
        MapaStartowa daneMapaStartowa;
        public GameOver(Launcher dane, Mapa1 mapa1)
        {
            InitializeComponent();
            daneLauncher = dane;
            daneMapa1 = mapa1;
        }
        public GameOver(Launcher dane, MapaStartowa mapaStartowa)
        {
            InitializeComponent();
            daneLauncher = dane;
            daneMapaStartowa = mapaStartowa;
        }

        private void GameOver_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                daneMapa1.Close();
                daneLauncher.Show();
            }
        }
    }
}
